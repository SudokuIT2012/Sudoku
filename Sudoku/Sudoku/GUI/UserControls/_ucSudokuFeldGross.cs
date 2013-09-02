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

                _txtMerken1.Visible = false;
                _txtMerken2.Visible = false;
                _txtMerken3.Visible = false;

                _isInitialize = false;

            }
            get { return _txtZahl.Text; }
        }

        public bool FehlerZeigen { get; set; }
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


                switch (value)
                {
                    case Enums.Farbzuweisung.Gueltig:
                        _txtZahl.BackColor = _gueltigeEingabe;
                        break;
                    case Enums.Farbzuweisung.Ungueltig:
                        _txtZahl.BackColor = _ungueltigeEingabe;
                        break;
                    case Enums.Farbzuweisung.Leer:
                        _txtZahl.BackColor = _leereEingabe;
                        break;
                }



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

            if (!FehlerZeigen)
                return;

            int dummy;
            if (_txtZahl.Text != string.Empty && (_txtZahl.Text.Length > 1 || (!int.TryParse(_txtZahl.Text, out dummy))))
            {
                FehlermeldungAnzeigen("Autsch!", "Bitte gib nur einzelne Ziffern ein. Das Feld wurde wieder geleert.", false);
                _txtZahl.Text = string.Empty;
            }

            GueltigeEingabe = Enums.Farbzuweisung.Leer;

            _txtMerken1.Visible = false;
            _txtMerken2.Visible = false;
            _txtMerken3.Visible = false;

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


        public void PruefenObSudokuFertig()
        {
            if (!(Parent is _ucSudokuGross))
                return;

            ((_ucSudokuGross)Parent).PruefenObSudokuFertig();
        }

        private void _txtZahl_MouseEnter(object sender, EventArgs e)
        {



            if (_txtZahl.Text != string.Empty || !(Parent is _ucSudokuGross))
            {
                return;
            }


            MerkenEinblenden();


            _txtMerken1.Visible = true;

        }

        private void MerkenEinblenden()
        {

            if (!(Parent is _ucSudokuGross))
                return;

            ((_ucSudokuGross)Parent).AktuellesFeld = this;
            if (_txtMerken1.Text != string.Empty)
                _txtMerken2.Visible = true;

            if (_txtMerken2.Text != string.Empty)
                _txtMerken3.Visible = true;



        }


        public void ResetMerken()
        {
            FarbenZuruecksetzen();
            if (_txtMerken1.Text == "")
                _txtMerken1.Visible = false;

            if (_txtMerken2.Text == "")
                _txtMerken2.Visible = false;

            if (_txtMerken3.Text == "")
                _txtMerken3.Visible = false;

        }

        private void _lblZahl_MouseEnter(object sender, EventArgs e)
        {
            ((_ucSudokuGross)Parent).AktuellesFeld = this;


        }

        private void _txtMerken1_DoubleClick(object sender, EventArgs e)
        {
            if (_zahlenAuswahl == null)
                return;

            _zahlenAuswahl.Visible = true;
            _zahlenAuswahl.TXTMerken = _txtMerken1;
            _hauptmenue.UserControlsEnableDisable(false);
        }

        private void _txtMerken2_DoubleClick(object sender, EventArgs e)
        {
            if (_zahlenAuswahl == null)
                return;

            _zahlenAuswahl.Visible = true;
            _zahlenAuswahl.TXTMerken = _txtMerken2;
            _hauptmenue.UserControlsEnableDisable(false);
        }

        private void _txtMerken3_DoubleClick(object sender, EventArgs e)
        {
            if (_zahlenAuswahl == null)
                return;

            _zahlenAuswahl.Visible = true;
            _zahlenAuswahl.TXTMerken = _txtMerken3;
            _hauptmenue.UserControlsEnableDisable(false);
        }

        private void _txtMerken1_MouseEnter(object sender, EventArgs e)
        {
            FarbenZuruecksetzen();
            _txtMerken1.BackColor = Color.LightGray;
        }

        private void FarbenZuruecksetzen()
        {

            _txtMerken1.BackColor = Color.White;
            _txtMerken2.BackColor = Color.White;
            _txtMerken3.BackColor = Color.White;
            _txtZahl.BackColor = Color.White;
        }

        private void _txtZahl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_txtZahl.BackColor == _ungueltigeEingabe || _txtZahl.BackColor == _gueltigeEingabe)
            {
                return;
            }
            FarbenZuruecksetzen();
            _txtZahl.BackColor = Color.LightGray;
        }

        private void _txtMerken2_MouseEnter(object sender, EventArgs e)
        {
            FarbenZuruecksetzen();
            _txtMerken2.BackColor = Color.LightGray;
        }

        private void _txtMerken3_MouseEnter(object sender, EventArgs e)
        {
            FarbenZuruecksetzen();
            _txtMerken3.BackColor = Color.LightGray;
        }

        private void _txtZahl_MouseLeave(object sender, EventArgs e)
        {
            if (_txtZahl.BackColor == _ungueltigeEingabe || _txtZahl.BackColor == _gueltigeEingabe)
            {
                return;
            }
            _txtZahl.BackColor = Color.White;
        }
    }
}
