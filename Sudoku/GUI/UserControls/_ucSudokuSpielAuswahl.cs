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


    public partial class _ucSudokuSpielAuswahl : UserControl
    {
        #region Globale Variablen

        private int _aktuelleSeitenZahl = 1;
        private int _datensatzAnzahl;
        private int _seitenAnzahl;
        private _frmHauptmenue _hauptmenue;
        private ToolTip _tooltip;

        #endregion Globale Variablen



        public _ucSudokuSpielAuswahl()
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
            _tooltip.SetToolTip(_cmdZurueck, "Wenn du eine Seite zurück möchtest, klick hier.");
            _tooltip.SetToolTip(_cmdWeiter, "Wenn du eine Seite weiter möchtest, klick hier.");
        }


        public DataSet Sudokus { get; set; }

        public void VerfuegbareSudokusAnzeigen()
        {

            SeitenAnzahlAktualisieren();


            for (int i = -1; i < 3; i++)
            {
                if (((_aktuelleSeitenZahl * 4 - 3) + i) >= _datensatzAnzahl)
                    continue;


                //Neues Sudoku erstellen
                _ucSudokuKlein sudokuKlein = new _ucSudokuKlein();

                //Neuem Sudoku Daten übergeben, die angezeigt werden sollen
                sudokuKlein.Daten = Sudokus.Tables[0].Rows[(_aktuelleSeitenZahl * 4 - 3) + i][1].ToString();

                //Neuem Sudoku ID übergeben, damit das Sudoku identifizierbar ist
                sudokuKlein.ID = new Guid(Sudokus.Tables[0].Rows[(_aktuelleSeitenZahl * 4 - 3) + i][0].ToString());

                //Diesem und allen enthaltenen Controls ein Event anhängen
                sudokuKlein.Click += new EventHandler(AusgewaehltesSudokuLaden);
                foreach (Control ctrl in sudokuKlein.Controls)
                    foreach (Control ctrl2 in ctrl.Controls)
                        ctrl2.Click += new EventHandler(AusgewaehltesSudokuLaden);



                //Neues Sudoku der Oberfläche hinzufügen
                _flpAuswahl.Controls.Add(sudokuKlein);
            }



        }

        private void SeitenAnzahlAktualisieren()
        {
            double rest;
            if (Sudokus == null)
                return;
            _datensatzAnzahl = Sudokus.Tables[0].Rows.Count;

            _seitenAnzahl = _datensatzAnzahl / 4;
            rest = _datensatzAnzahl % 4;
            if (rest > 0)
            {
                _seitenAnzahl = _seitenAnzahl + 1;
            }

            _lblSeite.Text = _aktuelleSeitenZahl + " / " + _seitenAnzahl;
        }

        public _frmHauptmenue Hauptmenue { set { _hauptmenue = value; } }

        public void AusgewaehltesSudokuLaden(object sender, EventArgs e)
        {
            Guid id = Guid.Empty;
            if (sender is Label)
                id = ((_ucSudokuKlein)((_ucSudokuFeldKlein)((Label)sender).Parent).Parent).ID;

            if (sender is _ucSudokuKlein)
                id = ((_ucSudokuKlein)sender).ID;


            Visible = false;

            _hauptmenue.ID = id;
            _hauptmenue.SpielLaden();

        }



        private void AuswahlLeeren()
        {

            // Schmutz
            int anzahlControls = _flpAuswahl.Controls.Count;


            for (int i = 0; i < anzahlControls; i++)
            {
                _flpAuswahl.Controls.RemoveAt(anzahlControls - 1 - i);
            }


        }

        private void _cmdZurueck_Click(object sender, EventArgs e)
        {
            if (_aktuelleSeitenZahl == 1)
                return;
            if (_aktuelleSeitenZahl == 2)
            {
                _cmdZurueck.Image = Image.FromFile("pfeilLinksDeaktiviert.png");
                _cmdZurueck.Enabled = false;
            }
            if (_aktuelleSeitenZahl <= _seitenAnzahl)
            {
                _cmdWeiter.Image = Image.FromFile("pfeilRechts.png");
                _cmdWeiter.Enabled = true;
            }

            AuswahlLeeren();
            _aktuelleSeitenZahl = _aktuelleSeitenZahl - 1;
            VerfuegbareSudokusAnzeigen();
        }

        private void _cmdWeiter_Click(object sender, EventArgs e)
        {
            if (_aktuelleSeitenZahl == _seitenAnzahl)
                return;
            if (_aktuelleSeitenZahl == _seitenAnzahl - 1)
            {
                _cmdWeiter.Image = Image.FromFile("pfeilRechtsDeaktiviert.png");
                _cmdWeiter.Enabled = false;
            }
            if (_aktuelleSeitenZahl >= 1)
            {
                _cmdZurueck.Enabled = true;
                _cmdZurueck.Image = Image.FromFile("pfeilLinks.png");
            }

            AuswahlLeeren();
            _aktuelleSeitenZahl = _aktuelleSeitenZahl + 1;
            VerfuegbareSudokusAnzeigen();
        }

    }
}
