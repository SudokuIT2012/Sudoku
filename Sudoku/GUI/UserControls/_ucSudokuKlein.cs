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
            int a=0;
            for (int i = 0; i < 85; i++)
            {
                if (Controls[i] is _ucSudokuFeldKlein)
                {
                    _ucSudokuFeldKlein feld = (_ucSudokuFeldKlein)Controls[i];

                    //den Daten-String von hinten nach vorne durchgehen, da die Controls von hinten nach vorn gefunden werden
                    feld.Text = _daten.Substring(80 - a, 1);

                    a = a + 1;
                }
            }
        }




    }
}
