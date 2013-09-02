using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sudoku.GUI;
using Sudoku.GUI.UserControls;

namespace Sudoku
{
    public partial class _frmHauptmenue : Form
    {

        #region Globale Variablen

        private DataSet _sudokus;
        private _ucSudokuSpielAuswahl _spielAuswahl;
        private ToolTip _tooltip;

        #endregion Globale Variablen

        #region Constructor
        public _frmHauptmenue()
        {
            InitializeComponent();

            _sudokus = new DataSet();
            _sudokus.ReadXml(Application.StartupPath + "\\spiele.xml");

            _spielAuswahl = _ucSudokuSpielAuswahl1;

            _ucMeldung1.Hauptmenue = this;
            _ucSudokuErstellen1.Hauptmenue = this;
            _ucSudokuErstellen1.Zahlenauswahl = _ucZahlenAuswahl1;
            _ucSudokuSpielAuswahl1.Hauptmenue = this;
            _ucSpiel.Hauptmenue = this;
            _ucSpiel.ZahlenAuswahl = _ucZahlenAuswahl1;
            _ucZahlenAuswahl1.Hauptmenue = this;
            _ucSudokuErstellenAutomatisch1.UCSudokuErstellen = _ucSudokuErstellen1;
            _ucSudokuErstellenAutomatisch1.Hauptmenue = this;

            _spielAuswahl.Sudokus = _sudokus;
            _spielAuswahl.VerfuegbareSudokusAnzeigen();
            ToolTipInitialisieren();
            MeldungZeigen("Hallo ich bin Leonie", "Ich gebe dir ein paar Tipps. Du bist im Hauptmenü.", false);

        }
        #endregion Constructor
        private void ToolTipInitialisieren()
        {

            _tooltip = new ToolTip();
            _tooltip.ShowAlways = true;
            _tooltip.IsBalloon = true;

            _tooltip.UseFading = true;
            _tooltip.SetToolTip(_picSchliessen, "Wenn du nichtmehr spielen möchtest, klick hier.");
            _tooltip.SetToolTip(_lblFarbe1, "Wenn du die Farbe ändern möchtest, klick hier.");
            _tooltip.SetToolTip(_lblFarbe2, "Wenn du die Farbe ändern möchtest, klick hier.");
            _tooltip.SetToolTip(_lblFarbe3, "Wenn du die Farbe ändern möchtest, klick hier.");
            _tooltip.SetToolTip(_lblFarbe4, "Wenn du die Farbe ändern möchtest, klick hier.");
            _tooltip.SetToolTip(_lblFarbe5, "Wenn du die Farbe ändern möchtest, klick hier.");
            _tooltip.SetToolTip(_lblFarbe6, "Wenn du die Farbe ändern möchtest, klick hier.");
            _tooltip.SetToolTip(_picGiraffe, "Das ist Leonie. Sie gibt dir ein paar Tipps für das Spiel.");
        }


        private void _picSchliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _lblNeuesSpiel_Click(object sender, EventArgs e)
        {
            _ucSudokuSpielAuswahl1.Visible = true;
            _ucSpiel.Visible = false;
            _ucSudokuErstellen1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _ucSudokuSpielAuswahl1.Visible = false;
            _ucSpiel.Visible = false;
            _ucSudokuErstellen1.FelderLeeren();
            _ucSudokuErstellen1.Visible = true;

        }

        public Guid ID { get; set; }

        public void SpielLaden()
        {
            _ucSpiel.Visible = true;
            _ucSpiel.Sudokus = _sudokus;
            _ucSpiel.ID = ID;
            _ucSpiel.Schwierigkeitsgrad = Schwierigkeitsgrad;
            _ucSpiel.SpieldatenLaden();
            _ucSpiel.DatenAnzeigen();

        }

        public string Schwierigkeitsgrad { get; set; }

        #region Fenster verschieben
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCAPTION = 0x02;

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
            else
            {
                base.WndProc(ref m);
            }


        }
        #endregion Fenster verschieben



        private void _lblFarbe1_Click(object sender, EventArgs e)
        {
            BackColor = Color.PeachPuff;
            _ucZahlenAuswahl1.HintergrundSetzen = Color.PeachPuff;
            _ucSudokuErstellenAutomatisch1.HintergrundSetzen = Color.PeachPuff;
        }

        private void _lblFarbe2_Click(object sender, EventArgs e)
        {

            BackColor = Color.Plum;
            _ucZahlenAuswahl1.HintergrundSetzen = Color.Plum;
            _ucSudokuErstellenAutomatisch1.HintergrundSetzen = Color.Plum;
        }

        private void _lblFarbe3_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightCoral;
            _ucZahlenAuswahl1.HintergrundSetzen = Color.LightCoral;
            _ucSudokuErstellenAutomatisch1.HintergrundSetzen = Color.LightCoral;
        }

        private void _lblFarbe4_Click(object sender, EventArgs e)
        {

            BackColor = Color.SeaGreen;
            _ucZahlenAuswahl1.HintergrundSetzen = Color.SeaGreen;
            _ucSudokuErstellenAutomatisch1.HintergrundSetzen = Color.SeaGreen;
        }

        private void _lblFarbe5_Click(object sender, EventArgs e)
        {

            BackColor = Color.Gold;
            _ucZahlenAuswahl1.HintergrundSetzen = Color.Gold;
            _ucSudokuErstellenAutomatisch1.HintergrundSetzen = Color.Gold;
        }

        private void _lblFarbe6_Click(object sender, EventArgs e)
        {

            BackColor = Color.LightSkyBlue;
            _ucZahlenAuswahl1.HintergrundSetzen = Color.LightSkyBlue;
            _ucSudokuErstellenAutomatisch1.HintergrundSetzen = Color.LightSkyBlue;
        }

        public void SpielErstellen(string daten, string loesung, Guid id, string schwierigkeitsgrad)
        {
            _sudokus.Tables[schwierigkeitsgrad].Rows.Add(id, daten, loesung);
            ID = id;
            Speichern();
        }

        public bool PruefenObSudokuVorhanden(string loesung)
        {

            foreach (DataTable table in _sudokus.Tables)
            {
                foreach (DataRow row in table.Rows)
                {

                    if (row["LoesungCode"].ToString() == loesung)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void Speichern()
        {
            _sudokus.WriteXml(Application.StartupPath + "\\spiele.xml");
        }

        //private void _picMeldungOk_Click(object sender, EventArgs e)
        //{

        //    if (_picMeldungNein.Visible)
        //    {
        //        _ucSudokuErstellen1.Visible = false;
        //        SpielLaden();
        //    }

        //    _ucSudokuErstellen1.Enabled = true;
        //    _ucSudokuSpielAuswahl1.Enabled = true;
        //    _ucSpiel.Enabled = true;

        //}


        public void MeldungZeigen(string textOben, string textUnten, bool neinAnzeigen)
        {
            _ucMeldung1.Visible = true;
            _ucMeldung1.MeldungAnzeigen(textOben, textUnten, neinAnzeigen);


            UserControlsEnableDisable(false);

        }

        public void UserControlsEnableDisable(bool value)
        {
            _ucSudokuErstellen1.Enabled = value;
            _ucSudokuSpielAuswahl1.Enabled = value;
            _ucSpiel.Enabled = value;
            _cmdAnleitung.Enabled = value;
            _cmdSudokuErstellen.Enabled = value;
            _cmdSudokuSpielen.Enabled = value;
            _cmdHauptmenue.Enabled = value;
        }

        public void ReaktionNein()
        {
            _ucSudokuSpielAuswahl1.Visible = true;
            _ucSpiel.Visible = false;
            _ucSudokuErstellen1.Visible = false;


        }

        public void ReaktionJa(bool istNeinSichtbar)
        {
            if (istNeinSichtbar)
            {
                _ucSudokuErstellen1.Visible = false;
                SpielLaden();
            }

            _ucSudokuErstellen1.Enabled = true;
            _ucSudokuSpielAuswahl1.Enabled = true;
            _ucSpiel.Enabled = true;
        }

        private void _ucSudokuSpielAuswahl1_VisibleChanged(object sender, EventArgs e)
        {

            _ucSudokuSpielAuswahl1.SeitenAnzahlZuruecksetzen();
            _ucSudokuSpielAuswahl1.VerfuegbareSudokusAnzeigen();
        }

        private void _cmdSudokuSpielen_Click(object sender, EventArgs e)
        {
            _ucSudokuSpielAuswahl1.Visible = true;
            _ucSpiel.Visible = false;
            _ucSudokuErstellen1.Visible = false;
            _cmdSudokuSpielen.Visible = false;
            _cmdSudokuErstellen.Visible = false;
            _cmdAnleitung.Visible = false;
            _cmdHauptmenue.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ucSudokuSpielAuswahl1.Visible = false;
            _ucSpiel.Visible = false;
            _ucSudokuErstellen1.FelderLeeren();
            _ucSudokuErstellen1.Visible = true;
            _cmdSudokuSpielen.Visible = false;
            _cmdSudokuErstellen.Visible = false;
            _cmdAnleitung.Visible = false;
            _cmdHauptmenue.Visible = true;

        }

        private void _cmdHauptmenue_Click(object sender, EventArgs e)
        {
            _ucSudokuSpielAuswahl1.Visible = false;
            _ucSpiel.Visible = false;
            _ucSudokuErstellen1.FelderLeeren();
            _ucSudokuErstellen1.Visible = false;
            _cmdSudokuSpielen.Visible = true;
            _cmdSudokuErstellen.Visible = true;
            _cmdAnleitung.Visible = true;
            _cmdHauptmenue.Visible = false;
        }


        public void SudokuAutomatischGenerieren(int schwierigkeitsgrad)
        {
            _ucSpiel.SudokuAutomatischGenerieren(schwierigkeitsgrad);
            _ucSpiel.Visible = true;
            _ucSudokuSpielAuswahl1.Visible = false;

        }
    }
}
