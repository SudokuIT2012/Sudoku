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
    public partial class _ucSudokuFeldGross : UserControl
    {

        #region Globale Variablen
        private bool _isInitialize;
        private Color _gueltigeEingabe;
        private Color _leereEingabe;
        private Color _ungueltigeEingabe;
        private string _loesung;
        private _ucZahlenAuswahl _zahlenAuswahl;
        private _frmHauptmenue _hauptmenue;


        #endregion Globale Variablen

        #region Constructor
        public _ucSudokuFeldGross()
        {
            InitializeComponent();
            _gueltigeEingabe = Color.LightGreen;
            _ungueltigeEingabe = Color.LightPink;
            _leereEingabe = Color.White;

        }
        #endregion Constructor

        #region Properties

        public string Loesung
        {
            get { return _loesung; }
            set { _loesung = value; }
        }

        public override string Text
        {
            set
            {
                _isInitialize = true;

                _txtZahl.Text = value;
                _lblZahl.Text = value;

                _isInitialize = false;

            }
            get { return _txtZahl.Text; }
        }

        public bool FreieEingabe
        {
            set { _txtZahl.Visible = value; }
            get { return _txtZahl.Visible; }
        }

        public bool FarbenSetzen { get; set; }

        public Enums.Farbzuweisung GueltigeEingabe
        {
            set
            {

                if (!FarbenSetzen)
                    return;

                if (value == Enums.Farbzuweisung.Gueltig)
                    _txtZahl.BackColor = _gueltigeEingabe;

                if (value == Enums.Farbzuweisung.Ungueltig)
                    _txtZahl.BackColor = _ungueltigeEingabe;

                if (value == Enums.Farbzuweisung.Leer)
                    _txtZahl.BackColor = _leereEingabe;

            }


        }

        public _frmHauptmenue Hauptmenue { set { _hauptmenue = value; } }
        public _ucZahlenAuswahl ZahlenAuswahl { set { _zahlenAuswahl = value; } }

        #endregion Properties

        #region Events
        private void _txtZahl_TextChanged(object sender, EventArgs e)
        {
            if (_isInitialize)
                return;


            int dummy;
            if (_txtZahl.Text != string.Empty && (_txtZahl.Text.Length > 1 || (!int.TryParse(_txtZahl.Text, out dummy))))
            {
                FehlermeldungAnzeigen("Autsch!", "Bitte gib nur einzelne Ziffern ein. Das Feld wurde wieder geleert.", false);
                _txtZahl.Text = string.Empty;
            }

            GueltigeEingabe = Enums.Farbzuweisung.Leer;

            if (Parent is _ucSudokuGross)
            {
                _ucSudokuGross feld = (_ucSudokuGross)Parent;
                feld.PruefenObSudokuFertig();
            }

        }

        public Enums.Farbzuweisung AufFehlerPruefen
        {
            get
            {
                if (FreieEingabe && _txtZahl.Text == string.Empty)
                    return Enums.Farbzuweisung.Leer;

                if (FreieEingabe && _txtZahl.Text != _loesung)
                {
                    GueltigeEingabe = Enums.Farbzuweisung.Ungueltig;
                    return Enums.Farbzuweisung.Ungueltig;
                }
                else
                    GueltigeEingabe = Enums.Farbzuweisung.Gueltig;
                return Enums.Farbzuweisung.Gueltig;
            }

        }

        private void _txtZahl_Click(object sender, EventArgs e)
        {
            if (_zahlenAuswahl == null)
                return;

            _zahlenAuswahl.Visible = true;
            _zahlenAuswahl.FeldGross = this;
            _hauptmenue.UserControlsEnableDisable(false);
        }

        #endregion Events


        private void FehlermeldungAnzeigen(string textOben, string textMitte, bool neinAnzeigen)
        {

            _hauptmenue.MeldungZeigen(textOben, textMitte, neinAnzeigen);
        }



    }
}
