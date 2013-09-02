using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku.GUI
{
    public partial class _ucSudokuFeldKlein : UserControl
    {
        public _ucSudokuFeldKlein()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return _lblZahl.Text;
            }

            set
            {
                _lblZahl.Text = value;
                if (value == "x")
                {
                    _lblZahl.BackColor = Color.White;
                    _lblZahl.Text = " ";
                }
            }
        }


    }
}
