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
        private DataSet _sudokus;
        private string _nameTabelle;

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
            _tooltip.SetToolTip(_cmdZurueckDeaktiviert, "Wenn du eine Seite zurück möchtest, klick hier.");
            _tooltip.SetToolTip(_cmdWeiter, "Wenn du eine Seite weiter möchtest, klick hier.");
        }


        public DataSet Sudokus
        {
            get { return _sudokus; }
            set
            {
                _sudokus = value;
                _nameTabelle = "LeichteSudokus";
                SeitenAnzahlAktualisieren();
                if (_seitenAnzahl == 1)
                {
                    _cmdWeiterDeaktiviert.Visible = true;
                    _cmdWeiterDeaktiviert.Enabled = false;

                    _cmdWeiter.Visible = false;
                    _cmdWeiter.Enabled = false;
                }
            }
        }

        public void VerfuegbareSudokusAnzeigen()
        {


            if (_cmdLeichteSudokus.Checked)
                _nameTabelle = "LeichteSudokus";
            if (_cmdMittlereSudokus.Checked)
                _nameTabelle = "MittelSudokus";
            if (_cmdSchwereSudokus.Checked)
                _nameTabelle = "SchwerSudokus";

            SeitenAnzahlAktualisieren();
            _ucSudokuKlein1.Visible = true;
            _ucSudokuKlein2.Visible = true;
            _ucSudokuKlein3.Visible = true;
            _ucSudokuKlein4.Visible = true;



            if (((_aktuelleSeitenZahl * 4 - 3) - 1) >= _datensatzAnzahl)
            {
                _ucSudokuKlein1.Visible = false;
                return;
            }




            //Neuem Sudoku Daten übergeben, die angezeigt werden sollen
            _ucSudokuKlein1.Daten = Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3) - 1][1].ToString();

            //Neuem Sudoku ID übergeben, damit das Sudoku identifizierbar ist
            _ucSudokuKlein1.ID = new Guid(Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3) - 1][0].ToString());


            if (((_aktuelleSeitenZahl * 4 - 3)) >= _datensatzAnzahl)
            {
                _ucSudokuKlein2.Visible = false;
                _ucSudokuKlein3.Visible = false;
                _ucSudokuKlein4.Visible = false;
                return;
            }

            //Neuem Sudoku Daten übergeben, die angezeigt werden sollen
            _ucSudokuKlein2.Daten = Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3)][1].ToString();

            //Neuem Sudoku ID übergeben, damit das Sudoku identifizierbar ist
            _ucSudokuKlein2.ID = new Guid(Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3)][0].ToString());



            if (((_aktuelleSeitenZahl * 4 - 3) + 1) >= _datensatzAnzahl)
            {
                _ucSudokuKlein3.Visible = false;
                _ucSudokuKlein4.Visible = false;
                return;
            }



            //Neuem Sudoku Daten übergeben, die angezeigt werden sollen
            _ucSudokuKlein3.Daten = Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3) + 1][1].ToString();

            //Neuem Sudoku ID übergeben, damit das Sudoku identifizierbar ist
            _ucSudokuKlein3.ID = new Guid(Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3) + 1][0].ToString());




            if (((_aktuelleSeitenZahl * 4 - 3) + 2) >= _datensatzAnzahl)
            {
                _ucSudokuKlein4.Visible = false;
                return;
            }




            //Neuem Sudoku Daten übergeben, die angezeigt werden sollen
            _ucSudokuKlein4.Daten = Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3) + 2][1].ToString();

            //Neuem Sudoku ID übergeben, damit das Sudoku identifizierbar ist
            _ucSudokuKlein4.ID = new Guid(Sudokus.Tables[_nameTabelle].Rows[(_aktuelleSeitenZahl * 4 - 3) + 2][0].ToString());



        }

        private void SeitenAnzahlAktualisieren()
        {
            double rest;
            if (Sudokus == null)
                return;

            _datensatzAnzahl = Sudokus.Tables[_nameTabelle].Rows.Count;

            _seitenAnzahl = _datensatzAnzahl / 4;
            rest = _datensatzAnzahl % 4;
            if (rest > 0)
            {
                _seitenAnzahl = _seitenAnzahl + 1;
            }

            _lblSeite.Text = _aktuelleSeitenZahl + " / " + _seitenAnzahl;
        }

        public _frmHauptmenue Hauptmenue { set { _hauptmenue = value; } }

        public void AusgewaehltesSudokuLaden(Guid id)
        {

            Visible = false;

            _hauptmenue.ID = id;
            _hauptmenue.Schwierigkeitsgrad = _nameTabelle;
            _hauptmenue.SpielLaden();

        }




        private void _cmdZurueck_Click(object sender, EventArgs e)
        {
            if (_aktuelleSeitenZahl == 1)
                return;
            if (_aktuelleSeitenZahl == 2)
            {
                _cmdZurueckDeaktiviert.Visible = true;
                _cmdZurueckDeaktiviert.Enabled = false;
                _cmdZurueck.Visible = false;
                _cmdZurueck.Enabled = false;
            }
            if (_aktuelleSeitenZahl <= _seitenAnzahl)
            {
                _cmdWeiter.Visible = true;
                _cmdWeiter.Enabled = true;
                _cmdWeiterDeaktiviert.Visible = false;
                _cmdWeiterDeaktiviert.Enabled = false;
            }

            _aktuelleSeitenZahl = _aktuelleSeitenZahl - 1;
            VerfuegbareSudokusAnzeigen();
        }



        private void _cmdWeiter_Click(object sender, EventArgs e)
        {
            if (_aktuelleSeitenZahl == _seitenAnzahl)
                return;
            if (_aktuelleSeitenZahl == _seitenAnzahl - 1)
            {
                _cmdWeiterDeaktiviert.Visible = true;
                _cmdWeiterDeaktiviert.Enabled = false;

                _cmdWeiter.Visible = false;
                _cmdWeiter.Enabled = false;
            }

            if (_aktuelleSeitenZahl >= 1)
            {
                _cmdZurueck.Enabled = true;
                _cmdZurueck.Visible = true;
                _cmdZurueckDeaktiviert.Enabled = true;
                _cmdZurueckDeaktiviert.Visible = false;

            }

            _aktuelleSeitenZahl = _aktuelleSeitenZahl + 1;
            VerfuegbareSudokusAnzeigen();
        }



        public void SeitenAnzahlZuruecksetzen()
        {

            _cmdWeiter.Visible = true;
            _cmdWeiter.Enabled = true;
            _cmdWeiterDeaktiviert.Visible = false;
            _cmdWeiterDeaktiviert.Enabled = false;


            _cmdZurueckDeaktiviert.Visible = true;
            _cmdZurueckDeaktiviert.Enabled = false;

            _cmdZurueck.Visible = false;
            _cmdZurueck.Enabled = false;



            _aktuelleSeitenZahl = 1;
        }

        private void _cmdLeichteSudokus_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxenDeaktivieren();
            SeitenAnzahlZuruecksetzen();
            _cmdLeichteSudokus.Checked = true;
            VerfuegbareSudokusAnzeigen();
        }

        private void _cmdMittlereSudokus_CheckedChanged(object sender, EventArgs e)
        {

            CheckboxenDeaktivieren();
            SeitenAnzahlZuruecksetzen();
            _cmdMittlereSudokus.Checked = true;
            VerfuegbareSudokusAnzeigen();
        }

        private void _cmdSchwereSudokus_CheckedChanged(object sender, EventArgs e)
        {


            CheckboxenDeaktivieren();
            SeitenAnzahlZuruecksetzen();
            _cmdSchwereSudokus.Checked = true;
            VerfuegbareSudokusAnzeigen();
        }
        private void CheckboxenDeaktivieren()
        {
            _cmdMittlereSudokus.Checked = false;
            _cmdLeichteSudokus.Checked = false;
            _cmdSchwereSudokus.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int schwierigkeitsgrad = 4;


            if (_cmdLeichteSudokus.Checked)
                schwierigkeitsgrad = 4;
            if (_cmdMittlereSudokus.Checked)
                schwierigkeitsgrad = 8;
            if (_cmdSchwereSudokus.Checked)
                schwierigkeitsgrad = 12;

            _hauptmenue.SudokuAutomatischGenerieren(schwierigkeitsgrad);
        }






    }
}
