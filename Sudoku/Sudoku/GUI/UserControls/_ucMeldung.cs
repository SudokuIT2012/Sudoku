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
    public partial class _ucMeldung : UserControl
    {
        private bool _neinAnzeigen;
        private _frmHauptmenue _hauptmenue;
        private ToolTip _tooltip;


        public _ucMeldung()
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
            _tooltip.SetToolTip(_picMeldungNein, "Wenn du dein Sudoku jetzt nicht spielen möchtest, klick hier.");
            _tooltip.SetToolTip(_picMeldungOk, "Wenn du dein Sudoku jetzt spielen möchtest, klick hier.");
        }


        public void MeldungAnzeigen(string meldungOben, string meldungUnten, bool neinAnzeigen)
        {
            _lblMeldungOben.Text = meldungOben;
            _lblMeldungUnten.Text = meldungUnten;
            _neinAnzeigen = neinAnzeigen;
            _picMeldungNein.Visible = neinAnzeigen;

        }

        public _frmHauptmenue Hauptmenue { set { _hauptmenue = value; } }

        private void _picMeldungOk_Click(object sender, EventArgs e)
        {


            _hauptmenue.ReaktionJa(_neinAnzeigen);

            _hauptmenue.UserControlsEnableDisable(true);
            Visible = false;
        }

        private void _picMeldungNein_Click(object sender, EventArgs e)
        {


            _hauptmenue.ReaktionNein();
            _hauptmenue.UserControlsEnableDisable(true);
            Visible = false;

        }
    }
}
