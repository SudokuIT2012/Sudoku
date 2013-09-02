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
        private int[,] _datenTesten = new int[9, 9];
        private _ucSudokuFeldGross _aktuellesFeld;

        #endregion Globale Variablen


        public _ucSudokuGross()
        {
            InitializeComponent();

            ToolTipInitialisieren();
        }

        public _ucSudokuFeldGross AktuellesFeld
        {
            set
            {
                if (_aktuellesFeld == null)
                {
                    _aktuellesFeld = value;
                }
                _aktuellesFeld.ResetMerken();
                _aktuellesFeld = value;
            }
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
            foreach (DataRow row in Sudokus.Tables[Schwierigkeitsgrad].Rows)
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
                    feldGross.FehlerZeigen = true;
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

        public string Schwierigkeitsgrad { get; set; }

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

        private void LoesungLaden()
        {

            _loesung = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    _loesung = _loesung + _datenTesten[j, i];
                }
            }
            _loesung = _loesung.Replace("-1", "x");
        }

        private bool IstGueltigesFeld()
        {
            int zahl;
            bool[] vorhanden = new bool[9];



            //ZEILEN
            for (int y = 0; y < 9; y++)
            {
                for (int i = 0; i < 9; i++)
                    vorhanden[i] = false;

                for (int x = 0; x < 9; x++)
                {
                    zahl = _datenTesten[x, y];
                    if (zahl != -1)
                    {
                        if (vorhanden[zahl - 1])
                        {
                            return false;
                        }
                        else
                            vorhanden[zahl - 1] = true;

                    }
                }
            }

            //SPALTEN
            for (int x = 0; x < 9; x++)
            {
                for (int i = 0; i < 9; i++)
                    vorhanden[i] = false;

                for (int y = 0; y < 9; y++)
                {

                    zahl = _datenTesten[x, y];
                    if (zahl != -1)
                    {
                        if (vorhanden[zahl - 1] == true)
                        {
                            return false;
                        }
                        else
                        {
                            vorhanden[zahl - 1] = true;
                        }
                    }
                }
            }



            for (int ys = 0; ys < 3; ys++)
            {
                for (int xs = 0; xs < 3; xs++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        vorhanden[i] = false;
                    }


                    for (int y = (ys * 3); y < (ys * 3) + 3; y++)
                    {
                        for (int x = (xs * 3); x < (xs * 3) + 3; x++)
                        {
                            zahl = _datenTesten[x, y];

                            if (zahl != -1)
                            {


                                if (vorhanden[zahl - 1])
                                {
                                    return false;
                                }
                                else
                                {
                                    vorhanden[zahl - 1] = true;
                                }
                            }
                        }
                    }
                }
            }



            return true;



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
                    _hauptmenue.MeldungZeigen("Autsch!", "Leider sind noch nicht alle Zahlen richtig.",false);
            }

        }


        public void SudokuAutomatischGenerieren(int schwierigkeitsgrad)
        {
            AutomatischGenerieren = true;

            FelderLeeren();

            Random rnd = new Random();

            do
            {

                _uc00.Text = rnd.Next(1, 9).ToString();
                _uc20.Text = rnd.Next(1, 9).ToString();
                _uc40.Text = rnd.Next(1, 9).ToString();
                _uc60.Text = rnd.Next(1, 9).ToString();
                _uc80.Text = rnd.Next(1, 9).ToString();

                _uc23.Text = rnd.Next(1, 9).ToString();

                _uc53.Text = rnd.Next(1, 9).ToString();

                _uc71.Text = rnd.Next(1, 9).ToString();

                ArrayFuellen();

            } while (!IstGueltigesFeld());


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (_datenTesten[i, j] == 0)
                    {
                        _datenTesten[i, j] = -1;
                    }
                }
            }

            Backtracking backtracking = new Backtracking();
            backtracking._datenTesten = _datenTesten;
            backtracking.LoeseFeld();
            LoesungLaden();
            DatenInOberflaecheSchreiben();

            //Zufällige Felder entfernen
            for (int i = 0; i < schwierigkeitsgrad; i++)
            {
                int x = rnd.Next(0, 8);
                int y = rnd.Next(0, 8);


                foreach (Control ctrl in Controls)
                {


                    if (ctrl.Tag == null)
                        continue;


                    int yCtrl = int.Parse(ctrl.Name.Substring(3, 1));
                    int xCtrl = int.Parse(ctrl.Name.Substring(4, 1));

                    if (y == yCtrl && x == xCtrl && ctrl.Text == string.Empty)
                    {
                        i = i - 1;
                        continue;

                    }

                    if (y == yCtrl && x == xCtrl)
                    {
                        ctrl.Text = "";

                    }


                }

            }

            foreach (Control ctrl in Controls)
            {


                if (ctrl.Tag == null)
                    continue;
                if (ctrl.Text != string.Empty)
                {
                    ((_ucSudokuFeldGross)ctrl).FreieEingabe = false;
                    ((_ucSudokuFeldGross)ctrl).FarbenSetzen = false;
                    ((_ucSudokuFeldGross)ctrl).GueltigeEingabe = Enums.Farbzuweisung.Leer;
                }
                else
                {
                    ((_ucSudokuFeldGross)ctrl).FreieEingabe = true;
                    ((_ucSudokuFeldGross)ctrl).FarbenSetzen = true;
                    ((_ucSudokuFeldGross)ctrl).GueltigeEingabe = Enums.Farbzuweisung.Leer;
                }



            }


            foreach (Control ctrl in Controls)
            {

                if (!(ctrl is _ucSudokuFeldGross))
                    continue;

                _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;


                for (int i = 0; i < 81; i++)
                {


                    if (feldGross.Tag.ToString() == i.ToString())
                    {



                        feldGross.Loesung = _loesung.Substring(i, 1);



                    }
                }
            }


            AutomatischGenerieren = false;
        }


        private void ArrayFuellen()
        {
            #region Daten ins Array laden

            int nullWert = -1;
            _datenTesten[0, 0] = int.TryParse(_uc00.Text, out nullWert) ? int.Parse(_uc00.Text) : -1;
            _datenTesten[0, 1] = int.TryParse(_uc01.Text, out nullWert) ? int.Parse(_uc01.Text) : -1;
            _datenTesten[0, 2] = int.TryParse(_uc02.Text, out nullWert) ? int.Parse(_uc02.Text) : -1;
            _datenTesten[0, 3] = int.TryParse(_uc03.Text, out nullWert) ? int.Parse(_uc03.Text) : -1;
            _datenTesten[0, 4] = int.TryParse(_uc04.Text, out nullWert) ? int.Parse(_uc04.Text) : -1;
            _datenTesten[0, 5] = int.TryParse(_uc05.Text, out nullWert) ? int.Parse(_uc05.Text) : -1;
            _datenTesten[0, 6] = int.TryParse(_uc06.Text, out nullWert) ? int.Parse(_uc06.Text) : -1;
            _datenTesten[0, 7] = int.TryParse(_uc07.Text, out nullWert) ? int.Parse(_uc07.Text) : -1;
            _datenTesten[0, 8] = int.TryParse(_uc08.Text, out nullWert) ? int.Parse(_uc08.Text) : -1;

            _datenTesten[1, 0] = int.TryParse(_uc10.Text, out nullWert) ? int.Parse(_uc10.Text) : -1;
            _datenTesten[1, 1] = int.TryParse(_uc11.Text, out nullWert) ? int.Parse(_uc11.Text) : -1;
            _datenTesten[1, 2] = int.TryParse(_uc12.Text, out nullWert) ? int.Parse(_uc12.Text) : -1;
            _datenTesten[1, 3] = int.TryParse(_uc13.Text, out nullWert) ? int.Parse(_uc13.Text) : -1;
            _datenTesten[1, 4] = int.TryParse(_uc14.Text, out nullWert) ? int.Parse(_uc14.Text) : -1;
            _datenTesten[1, 5] = int.TryParse(_uc15.Text, out nullWert) ? int.Parse(_uc15.Text) : -1;
            _datenTesten[1, 6] = int.TryParse(_uc16.Text, out nullWert) ? int.Parse(_uc16.Text) : -1;
            _datenTesten[1, 7] = int.TryParse(_uc17.Text, out nullWert) ? int.Parse(_uc17.Text) : -1;
            _datenTesten[1, 8] = int.TryParse(_uc18.Text, out nullWert) ? int.Parse(_uc18.Text) : -1;

            _datenTesten[2, 0] = int.TryParse(_uc20.Text, out nullWert) ? int.Parse(_uc20.Text) : -1;
            _datenTesten[2, 1] = int.TryParse(_uc21.Text, out nullWert) ? int.Parse(_uc21.Text) : -1;
            _datenTesten[2, 2] = int.TryParse(_uc22.Text, out nullWert) ? int.Parse(_uc22.Text) : -1;
            _datenTesten[2, 3] = int.TryParse(_uc23.Text, out nullWert) ? int.Parse(_uc23.Text) : -1;
            _datenTesten[2, 4] = int.TryParse(_uc24.Text, out nullWert) ? int.Parse(_uc24.Text) : -1;
            _datenTesten[2, 5] = int.TryParse(_uc25.Text, out nullWert) ? int.Parse(_uc25.Text) : -1; ;
            _datenTesten[2, 6] = int.TryParse(_uc26.Text, out nullWert) ? int.Parse(_uc26.Text) : -1; ;
            _datenTesten[2, 7] = int.TryParse(_uc27.Text, out nullWert) ? int.Parse(_uc27.Text) : -1; ;
            _datenTesten[2, 8] = int.TryParse(_uc28.Text, out nullWert) ? int.Parse(_uc28.Text) : -1; ;

            _datenTesten[3, 0] = int.TryParse(_uc30.Text, out nullWert) ? int.Parse(_uc30.Text) : -1; ;
            _datenTesten[3, 1] = int.TryParse(_uc31.Text, out nullWert) ? int.Parse(_uc31.Text) : -1; ;
            _datenTesten[3, 2] = int.TryParse(_uc32.Text, out nullWert) ? int.Parse(_uc32.Text) : -1; ;
            _datenTesten[3, 3] = int.TryParse(_uc33.Text, out nullWert) ? int.Parse(_uc33.Text) : -1; ;
            _datenTesten[3, 4] = int.TryParse(_uc34.Text, out nullWert) ? int.Parse(_uc34.Text) : -1; ;
            _datenTesten[3, 5] = int.TryParse(_uc35.Text, out nullWert) ? int.Parse(_uc35.Text) : -1; ;
            _datenTesten[3, 6] = int.TryParse(_uc36.Text, out nullWert) ? int.Parse(_uc36.Text) : -1; ;
            _datenTesten[3, 7] = int.TryParse(_uc37.Text, out nullWert) ? int.Parse(_uc37.Text) : -1; ;
            _datenTesten[3, 8] = int.TryParse(_uc38.Text, out nullWert) ? int.Parse(_uc38.Text) : -1; ;

            _datenTesten[4, 0] = int.TryParse(_uc40.Text, out nullWert) ? int.Parse(_uc40.Text) : -1; ;
            _datenTesten[4, 1] = int.TryParse(_uc41.Text, out nullWert) ? int.Parse(_uc41.Text) : -1; ;
            _datenTesten[4, 2] = int.TryParse(_uc42.Text, out nullWert) ? int.Parse(_uc42.Text) : -1; ;
            _datenTesten[4, 3] = int.TryParse(_uc43.Text, out nullWert) ? int.Parse(_uc43.Text) : -1; ;
            _datenTesten[4, 4] = int.TryParse(_uc44.Text, out nullWert) ? int.Parse(_uc44.Text) : -1; ;
            _datenTesten[4, 5] = int.TryParse(_uc45.Text, out nullWert) ? int.Parse(_uc45.Text) : -1; ;
            _datenTesten[4, 6] = int.TryParse(_uc46.Text, out nullWert) ? int.Parse(_uc46.Text) : -1; ;
            _datenTesten[4, 7] = int.TryParse(_uc47.Text, out nullWert) ? int.Parse(_uc47.Text) : -1; ;
            _datenTesten[4, 8] = int.TryParse(_uc48.Text, out nullWert) ? int.Parse(_uc48.Text) : -1; ;

            _datenTesten[5, 0] = int.TryParse(_uc50.Text, out nullWert) ? int.Parse(_uc50.Text) : -1; ;
            _datenTesten[5, 1] = int.TryParse(_uc51.Text, out nullWert) ? int.Parse(_uc51.Text) : -1; ;
            _datenTesten[5, 2] = int.TryParse(_uc52.Text, out nullWert) ? int.Parse(_uc52.Text) : -1; ;
            _datenTesten[5, 3] = int.TryParse(_uc53.Text, out nullWert) ? int.Parse(_uc53.Text) : -1; ;
            _datenTesten[5, 4] = int.TryParse(_uc54.Text, out nullWert) ? int.Parse(_uc54.Text) : -1; ;
            _datenTesten[5, 5] = int.TryParse(_uc55.Text, out nullWert) ? int.Parse(_uc55.Text) : -1; ;
            _datenTesten[5, 6] = int.TryParse(_uc56.Text, out nullWert) ? int.Parse(_uc56.Text) : -1; ;
            _datenTesten[5, 7] = int.TryParse(_uc57.Text, out nullWert) ? int.Parse(_uc57.Text) : -1; ;
            _datenTesten[5, 8] = int.TryParse(_uc58.Text, out nullWert) ? int.Parse(_uc58.Text) : -1; ;

            _datenTesten[6, 0] = int.TryParse(_uc60.Text, out nullWert) ? int.Parse(_uc60.Text) : -1; ;
            _datenTesten[6, 1] = int.TryParse(_uc61.Text, out nullWert) ? int.Parse(_uc61.Text) : -1; ;
            _datenTesten[6, 2] = int.TryParse(_uc62.Text, out nullWert) ? int.Parse(_uc62.Text) : -1; ;
            _datenTesten[6, 3] = int.TryParse(_uc63.Text, out nullWert) ? int.Parse(_uc63.Text) : -1; ;
            _datenTesten[6, 4] = int.TryParse(_uc64.Text, out nullWert) ? int.Parse(_uc64.Text) : -1; ;
            _datenTesten[6, 5] = int.TryParse(_uc65.Text, out nullWert) ? int.Parse(_uc65.Text) : -1; ;
            _datenTesten[6, 6] = int.TryParse(_uc66.Text, out nullWert) ? int.Parse(_uc66.Text) : -1; ;
            _datenTesten[6, 7] = int.TryParse(_uc67.Text, out nullWert) ? int.Parse(_uc67.Text) : -1; ;
            _datenTesten[6, 8] = int.TryParse(_uc68.Text, out nullWert) ? int.Parse(_uc68.Text) : -1; ;

            _datenTesten[7, 0] = int.TryParse(_uc70.Text, out nullWert) ? int.Parse(_uc70.Text) : -1; ;
            _datenTesten[7, 1] = int.TryParse(_uc71.Text, out nullWert) ? int.Parse(_uc71.Text) : -1; ;
            _datenTesten[7, 2] = int.TryParse(_uc72.Text, out nullWert) ? int.Parse(_uc72.Text) : -1; ;
            _datenTesten[7, 3] = int.TryParse(_uc73.Text, out nullWert) ? int.Parse(_uc73.Text) : -1; ;
            _datenTesten[7, 4] = int.TryParse(_uc74.Text, out nullWert) ? int.Parse(_uc74.Text) : -1; ;
            _datenTesten[7, 5] = int.TryParse(_uc75.Text, out nullWert) ? int.Parse(_uc75.Text) : -1; ;
            _datenTesten[7, 6] = int.TryParse(_uc76.Text, out nullWert) ? int.Parse(_uc76.Text) : -1; ;
            _datenTesten[7, 7] = int.TryParse(_uc77.Text, out nullWert) ? int.Parse(_uc77.Text) : -1; ;
            _datenTesten[7, 8] = int.TryParse(_uc78.Text, out nullWert) ? int.Parse(_uc78.Text) : -1; ;

            _datenTesten[8, 0] = int.TryParse(_uc80.Text, out nullWert) ? int.Parse(_uc80.Text) : -1; ;
            _datenTesten[8, 1] = int.TryParse(_uc81.Text, out nullWert) ? int.Parse(_uc81.Text) : -1; ;
            _datenTesten[8, 2] = int.TryParse(_uc82.Text, out nullWert) ? int.Parse(_uc82.Text) : -1; ;
            _datenTesten[8, 3] = int.TryParse(_uc83.Text, out nullWert) ? int.Parse(_uc83.Text) : -1; ;
            _datenTesten[8, 4] = int.TryParse(_uc84.Text, out nullWert) ? int.Parse(_uc84.Text) : -1; ;
            _datenTesten[8, 5] = int.TryParse(_uc85.Text, out nullWert) ? int.Parse(_uc85.Text) : -1; ;
            _datenTesten[8, 6] = int.TryParse(_uc86.Text, out nullWert) ? int.Parse(_uc86.Text) : -1; ;
            _datenTesten[8, 7] = int.TryParse(_uc87.Text, out nullWert) ? int.Parse(_uc87.Text) : -1; ;
            _datenTesten[8, 8] = int.TryParse(_uc88.Text, out nullWert) ? int.Parse(_uc88.Text) : -1; ;
            #endregion Daten ins Array laden
        }

        public void FelderLeeren()
        {

            foreach (Control ctrl in Controls)
            {

                if (ctrl.Tag == null)
                    continue;

                ctrl.Text = "";

            }


        }

        private void DatenInOberflaecheSchreiben()
        {
            #region Daten in Oberfläche laden

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl.Tag == null)
                            continue;

                        int y = int.Parse(ctrl.Name.Substring(3, 1));
                        int x = int.Parse(ctrl.Name.Substring(4, 1));

                        if (x == i && y == j)
                            ctrl.Text = _datenTesten[i, j].ToString();


                    }

                }
            }


            #endregion Daten in Oberfläche laden
        }


        protected bool AutomatischGenerieren { get; set; }
    }
}
