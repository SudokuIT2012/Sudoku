using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sudoku.GUI.UserControls;

namespace Sudoku.GUI
{
    public partial class _ucSudokuKlein : UserControl
    {
        #region Globale Variablen
        private string _daten;

        #endregion Globale Variablen

        #region Constructor
        public _ucSudokuKlein()
        {
            InitializeComponent();
        }
        #endregion Constructor


        public string Daten
        {
            set
            {
                _daten = value;
                DatenAnzeigen();
            }
        }

        public Guid ID { get; set; }

        private void DatenAnzeigen()
        {
            int a = 0;


            foreach (Control ctrl in Controls)
            {
                if (!(ctrl is Label))
                    continue;

                if (ctrl.Tag == "LEER")
                {
                    continue;
                }

                Label lbl = (Label)ctrl;

                lbl.Text = _daten.Substring(80 - a, 1) == "x" ? "" : _daten.Substring(80 - a, 1);

                if (_daten.Substring(80 - a, 1) == "x")
                {
                    lbl.BackColor = Color.White;
                }
                else
                {
                    lbl.ResetBackColor();
                }

                a = a + 1;
            }

        }



        private void SudokuLaden(object sender, EventArgs e)
        {
            ((_ucSudokuSpielAuswahl)Parent.Parent).AusgewaehltesSudokuLaden(ID);
        }




    }
}
