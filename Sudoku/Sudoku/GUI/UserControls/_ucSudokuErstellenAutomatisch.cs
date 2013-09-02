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
    public partial class _ucSudokuErstellenAutomatisch : UserControl
    {
        public _ucSudokuErstellenAutomatisch()
        {
            InitializeComponent();
        }

        public _ucSudokuErstellen UCSudokuErstellen { get; set; }
        public _frmHauptmenue Hauptmenue { get; set; }


        private void _cmdLeicht_Click(object sender, EventArgs e)
        {
            Visible = false;
            Hauptmenue.UserControlsEnableDisable(true);
        }

        private void _cmdMittel_Click(object sender, EventArgs e)
        {
            Visible = false;
            Hauptmenue.UserControlsEnableDisable(true);
        }

        private void _cmdSchwer_Click(object sender, EventArgs e)
        {
            Visible = false;
            Hauptmenue.UserControlsEnableDisable(true);
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

        private void _cmdAbbrechen_Click(object sender, EventArgs e)
        {
            Hauptmenue.UserControlsEnableDisable(true);
            Visible = false;
        }


    }
}
