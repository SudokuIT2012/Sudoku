using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku.GUI.UserControls
{
    public partial class _ucSudokuGross : UserControl
    {

        #region Globale Variablen


        private string _daten;
        private string _loesung;
        private _frmHauptmenue _hauptmenue;
        private _ucZahlenAuswahl _zahlenAuswahl;
        private ToolTip _tooltip;

        #endregion Globale Variablen


        public _ucSudokuGross()
        {
            InitializeComponent();

            ToolTipInitialisieren();
        }

        private void ToolTipInitialisieren()
        {

            _tooltip = new ToolTip();
            _tooltip.ShowAlways = true;
            _tooltip.IsBalloon = true;

            _tooltip.UseFading = true;
            _tooltip.SetToolTip(_cmdSpeichern, "Wenn du dein Sudoku testen möchtest, klick hier.");
            _tooltip.SetToolTip(_cmdTipp, "Wenn du Tipp haben möchtest, klick hier.");
        }


        public DataSet Sudokus { get; set; }
        public Guid ID { get; set; }


        public void SpieldatenLaden()
        {
            foreach (DataRow row in Sudokus.Tables[0].Rows)
            {
                if (row[0].ToString().ToUpper() != ID.ToString().ToUpper())
                    continue;

                _daten = row[1].ToString();
                _loesung = row[2].ToString();

            }
        }

        public _frmHauptmenue Hauptmenue
        {
            set
            {

                _hauptmenue = value;


                foreach (Control ctrl in Controls)
                {
                    if (!(ctrl is _ucSudokuFeldGross))
                        continue;

                    _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;
                    feldGross.Hauptmenue = _hauptmenue;
                }

            }
        }

        public _ucZahlenAuswahl ZahlenAuswahl
        {
            set
            {

                _zahlenAuswahl = value;


                foreach (Control ctrl in Controls)
                {
                    if (!(ctrl is _ucSudokuFeldGross))
                        continue;

                    _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;
                    feldGross.ZahlenAuswahl = _zahlenAuswahl;
                }

            }
        }

        public void DatenAnzeigen()
        {
            foreach (Control ctrl in Controls)
            {

                if (!(ctrl is _ucSudokuFeldGross))
                    continue;

                _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;


                for (int i = 0; i < 81; i++)
                {


                    if (feldGross.Tag.ToString() == i.ToString())
                    {

                        feldGross.Text = _daten.Substring(i, 1);

                        if (_daten.Substring(i, 1) == "x")
                        {
                            feldGross.FarbenSetzen = true;
                            feldGross.FreieEingabe = true;
                            feldGross.Text = string.Empty;
                            feldGross.Loesung = _loesung.Substring(i, 1);
                            feldGross.GueltigeEingabe = Enums.Farbzuweisung.Leer;
                        }
                        else
                            feldGross.FreieEingabe = false;


                    }
                }
            }




        }

        private void _cmdSpeichern_Click(object sender, EventArgs e)
        {
            AufFehlerPruefen();
        }

        private bool AufFehlerPruefen()
        {
            List<int> liste = new List<int>();

            foreach (Control ctrl in Controls)
            {
                if (!(ctrl is _ucSudokuFeldGross))
                    continue;

                _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;

                if (feldGross.AufFehlerPruefen == Enums.Farbzuweisung.Ungueltig)
                    liste.Add(int.Parse(feldGross.Tag.ToString()));

            }

            return liste.Count > 0 ? true : false;

        }

        private void _cmdZuruecksetzen_Click(object sender, EventArgs e)
        {
           
        }

        private void _cmdTipp_Click(object sender, EventArgs e)
        {
            List<int> freieFelder = new List<int>();
            foreach (Control ctrl in Controls)
            {

                if (!(ctrl is _ucSudokuFeldGross))
                    continue;
                _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;

                if (feldGross.FreieEingabe && feldGross.Text == string.Empty)
                {
                    freieFelder.Add(int.Parse(feldGross.Tag.ToString()));
                }

            }
            if (freieFelder.Count == 0)
                return;

            Random rnd = new Random();
            int zahl = rnd.Next(0, freieFelder.Count);

            foreach (Control ctrl in Controls)
            {
                if (!(ctrl is _ucSudokuFeldGross))
                    continue;

                _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;

                if (feldGross.Tag.ToString() == freieFelder[zahl].ToString())
                {
                    feldGross.Text = _loesung.Substring(int.Parse(feldGross.Tag.ToString()), 1);
                    feldGross.GueltigeEingabe = Enums.Farbzuweisung.Gueltig;
                    PruefenObSudokuFertig();
                }


            }


        }


        public void PruefenObSudokuFertig()
        {
            bool freiesFeld = false;
            foreach (Control ctrl in Controls)
            {
                if (!(ctrl is _ucSudokuFeldGross))
                    continue;

                _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;

                if (feldGross.Text == string.Empty)
                    freiesFeld = true;


            }
            if (!freiesFeld)
            {

                if (!AufFehlerPruefen())
                    _hauptmenue.MeldungZeigen("Super!", "Du hast das Sudoku gelöst", false);
                if (AufFehlerPruefen())
                    _hauptmenue.MeldungZeigen("bäääh!", "Mega bitter -.-", false);
            }

        }
    }
}
