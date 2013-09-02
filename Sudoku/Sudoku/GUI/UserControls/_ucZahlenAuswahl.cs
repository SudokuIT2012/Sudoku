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


    public partial class _ucZahlenAuswahl : UserControl
    {
        private _frmHauptmenue _hauptmenue;
        private ToolTip _tooltip;
        private TextBox _txtMerken;

        public _ucZahlenAuswahl()
        {
            InitializeComponent();
            ToolTipInitialisieren();
        }

        private void ToolTipInitialisieren()
        {

            _tooltip = new ToolTip();
            _tooltip.ShowAlways = true;
            _tooltip.IsBalloon = true;

            _tooltip.SetToolTip(_cmdZurueck, "Wenn du dir doch keine Zahl aussuchen möchtest, klick hier.");
            _tooltip.SetToolTip(_cmdLeer, "Wenn du die Zahl löschen möchtest, klick hier.");
        }


        public _ucSudokuFeldGross FeldGross { get; set; }
        #region Properties

        public string Zahl { get; set; }
        public _frmHauptmenue Hauptmenue { set { _hauptmenue = value; } }
        #endregion Properties

        #region Events

        private void AuswahlGetroffen(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Zahl = button.Text;

            if (_txtMerken != null)
            {
                _txtMerken.Text = Zahl;
                Visible = false;
                _txtMerken = null;
                _hauptmenue.UserControlsEnableDisable(true);
                return;
            }

            FeldGross.Text = Zahl;
            FeldGross.GueltigeEingabe = Enums.Farbzuweisung.Leer;
            FeldGross.PruefenObSudokuFertig();
            Visible = false;
            _hauptmenue.UserControlsEnableDisable(true);

        }
        #endregion Events

        private void _cmdZurueck_Click(object sender, EventArgs e)
        {
            Zahl = string.Empty;
            Visible = false;
            _hauptmenue.UserControlsEnableDisable(true);
        }

        private void _cmdLeer_Click(object sender, EventArgs e)
        {
            Zahl = string.Empty;

            if (_txtMerken != null)
            {
                _txtMerken.Text = string.Empty;
                Visible = false;
                _txtMerken = null;
                _hauptmenue.UserControlsEnableDisable(true);
                return;
            }

            FeldGross.Text = string.Empty;
            FeldGross.GueltigeEingabe = Enums.Farbzuweisung.Leer;
            Visible = false;
            _hauptmenue.UserControlsEnableDisable(true);
        }

        public Color HintergrundSetzen
        {
            set
            {
                foreach (Control ctrl in Controls)
                {
                    ctrl.BackColor = value;
                }
            }
        }

        public TextBox TXTMerken
        {
            set { _txtMerken = value; }
        }
    }
}
