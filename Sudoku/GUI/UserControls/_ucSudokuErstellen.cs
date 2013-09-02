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
    public partial class _ucSudokuErstellen : UserControl
    {
        private string _daten;
        private string _loesung;
        private string[,] _datenTesten = new string[9, 9];
        private _frmHauptmenue _hauptmenue;
        private _ucZahlenAuswahl _zahlenAuswahl;

        public _ucSudokuErstellen()
        {

            InitializeComponent();
            foreach (Control ctrlPanel in Controls)
            {
                if (!(ctrlPanel is Panel))
                    continue;

                foreach (Control ctrl in ctrlPanel.Controls)
                {
                    if (!(ctrl is _ucSudokuFeldGross))
                        continue;

                    _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;
                    feldGross.Controls["_txtZahl"].TextChanged += new EventHandler(_ucSudokuErstellen_TextChanged);
                    feldGross.Hauptmenue = _hauptmenue;
                    feldGross.ZahlenAuswahl = _zahlenAuswahl;

                }


            }


        }


        public void DatenAusOberflaecheLaden()
        {
            _daten = string.Empty;
            for (int i = 0; i < 82; i++)
            {
                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl.Tag == null)
                        continue;

                    if (ctrl.Tag.ToString() == i.ToString())
                    {
                        if (ctrl.Text == string.Empty)
                            _daten = _daten + "x";
                        else
                            _daten = _daten + ctrl.Text;
                    }
                }
            }

        }


        public _frmHauptmenue Hauptmenue
        {
            set
            {
                _hauptmenue = value;
                foreach (Control ctrlPanel in Controls)
                {
                    if (!(ctrlPanel is Panel))
                        continue;

                    foreach (Control ctrl in ctrlPanel.Controls)
                    {
                        if (!(ctrl is _ucSudokuFeldGross))
                            continue;

                        _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;
                        feldGross.Hauptmenue = _hauptmenue;
                    }


                }




            }
        }
        public _ucZahlenAuswahl Zahlenauswahl
        {
            set
            {
                _zahlenAuswahl = value;
                foreach (Control ctrlPanel in Controls)
                {
                    if (!(ctrlPanel is Panel))
                        continue;

                    foreach (Control ctrl in ctrlPanel.Controls)
                    {
                        if (!(ctrl is _ucSudokuFeldGross))
                            continue;

                        _ucSudokuFeldGross feldGross = (_ucSudokuFeldGross)ctrl;
                        feldGross.ZahlenAuswahl = _zahlenAuswahl;
                    }


                }




            }
        }

        private void _cmdSpeichern_Click(object sender, EventArgs e)
        {
            DatenAusOberflaecheLaden();

            //TODO Lösung implementieren
            _loesung = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

            _hauptmenue.SpielErstellen(_daten, _loesung, Guid.NewGuid());
            MeldungAnzeigen("Sudoku wurde gespeichert", "Möchtest du es jetzt spielen?", true);

        }
        private void _ucSudokuErstellen_TextChanged(object sender, EventArgs e)
        {
            DatenTesten(((Control)sender).Parent.Name, ((Control)sender).Text, sender);
        }

        public void DatenTesten(string controlName, string wert, object sender)
        {


            int x = int.Parse(controlName.Substring(3, 1));
            int y = int.Parse(controlName.Substring(4, 1));


            #region Daten ins Array laden
            _datenTesten[0, 0] = _uc00.Text;
            _datenTesten[0, 1] = _uc01.Text;
            _datenTesten[0, 2] = _uc02.Text;
            _datenTesten[0, 3] = _uc03.Text;
            _datenTesten[0, 4] = _uc04.Text;
            _datenTesten[0, 5] = _uc05.Text;
            _datenTesten[0, 6] = _uc06.Text;
            _datenTesten[0, 7] = _uc07.Text;
            _datenTesten[0, 8] = _uc08.Text;

            _datenTesten[1, 0] = _uc10.Text;
            _datenTesten[1, 1] = _uc11.Text;
            _datenTesten[1, 2] = _uc12.Text;
            _datenTesten[1, 3] = _uc13.Text;
            _datenTesten[1, 4] = _uc14.Text;
            _datenTesten[1, 5] = _uc15.Text;
            _datenTesten[1, 6] = _uc16.Text;
            _datenTesten[1, 7] = _uc17.Text;
            _datenTesten[1, 8] = _uc18.Text;

            _datenTesten[2, 0] = _uc20.Text;
            _datenTesten[2, 1] = _uc21.Text;
            _datenTesten[2, 2] = _uc22.Text;
            _datenTesten[2, 3] = _uc23.Text;
            _datenTesten[2, 4] = _uc24.Text;
            _datenTesten[2, 5] = _uc25.Text;
            _datenTesten[2, 6] = _uc26.Text;
            _datenTesten[2, 7] = _uc27.Text;
            _datenTesten[2, 8] = _uc28.Text;

            _datenTesten[3, 0] = _uc30.Text;
            _datenTesten[3, 1] = _uc31.Text;
            _datenTesten[3, 2] = _uc32.Text;
            _datenTesten[3, 3] = _uc33.Text;
            _datenTesten[3, 4] = _uc34.Text;
            _datenTesten[3, 5] = _uc35.Text;
            _datenTesten[3, 6] = _uc36.Text;
            _datenTesten[3, 7] = _uc37.Text;
            _datenTesten[3, 8] = _uc38.Text;

            _datenTesten[4, 0] = _uc40.Text;
            _datenTesten[4, 1] = _uc41.Text;
            _datenTesten[4, 2] = _uc42.Text;
            _datenTesten[4, 3] = _uc43.Text;
            _datenTesten[4, 4] = _uc44.Text;
            _datenTesten[4, 5] = _uc45.Text;
            _datenTesten[4, 6] = _uc46.Text;
            _datenTesten[4, 7] = _uc47.Text;
            _datenTesten[4, 8] = _uc48.Text;

            _datenTesten[5, 0] = _uc50.Text;
            _datenTesten[5, 1] = _uc51.Text;
            _datenTesten[5, 2] = _uc52.Text;
            _datenTesten[5, 3] = _uc53.Text;
            _datenTesten[5, 4] = _uc54.Text;
            _datenTesten[5, 5] = _uc55.Text;
            _datenTesten[5, 6] = _uc56.Text;
            _datenTesten[5, 7] = _uc57.Text;
            _datenTesten[5, 8] = _uc58.Text;

            _datenTesten[6, 0] = _uc60.Text;
            _datenTesten[6, 1] = _uc61.Text;
            _datenTesten[6, 2] = _uc62.Text;
            _datenTesten[6, 3] = _uc63.Text;
            _datenTesten[6, 4] = _uc64.Text;
            _datenTesten[6, 5] = _uc65.Text;
            _datenTesten[6, 6] = _uc66.Text;
            _datenTesten[6, 7] = _uc67.Text;
            _datenTesten[6, 8] = _uc68.Text;

            _datenTesten[7, 0] = _uc70.Text;
            _datenTesten[7, 1] = _uc71.Text;
            _datenTesten[7, 2] = _uc72.Text;
            _datenTesten[7, 3] = _uc73.Text;
            _datenTesten[7, 4] = _uc74.Text;
            _datenTesten[7, 5] = _uc75.Text;
            _datenTesten[7, 6] = _uc76.Text;
            _datenTesten[7, 7] = _uc77.Text;
            _datenTesten[7, 8] = _uc78.Text;

            _datenTesten[8, 0] = _uc80.Text;
            _datenTesten[8, 1] = _uc81.Text;
            _datenTesten[8, 2] = _uc82.Text;
            _datenTesten[8, 3] = _uc83.Text;
            _datenTesten[8, 4] = _uc84.Text;
            _datenTesten[8, 5] = _uc85.Text;
            _datenTesten[8, 6] = _uc86.Text;
            _datenTesten[8, 7] = _uc87.Text;
            _datenTesten[8, 8] = _uc88.Text;
            #endregion Daten ins Array laden

            //Horizontal prüfen
            for (int i = 0; i < 9; i++)
            {
                if (wert != string.Empty && i != y && _datenTesten[x, i] == wert)
                {
                    MeldungAnzeigen("Autsch!", "Diese Zahl gibt es in dieser Reihe schon. Die Zahl wird wieder entfernt", false);
                    ((TextBox)sender).Text = "";
                }
            }

            //Vertikal prüfen
            for (int i = 0; i < 9; i++)
            {
                if (wert != string.Empty && i != x && _datenTesten[i, y] == wert)
                {
                    MeldungAnzeigen("Autsch!", "Diese Zahl gibt es in dieser Spalte schon. Die Zahl wird wieder entfernt", false);
                    ((TextBox)sender).Text = "";
                }
            }

            //3-er Kästen prüfen
            int xDreierKasten = (x / 3) * 3;
            int yDreierKasten = (y / 3) * 3;

            for (int i = xDreierKasten; i < xDreierKasten + 3; i++)
            {
                for (int j = yDreierKasten; j < yDreierKasten + 3; j++)
                {
                    if (wert != string.Empty && i != x && j != y && _datenTesten[i, j] == wert)
                    {
                        MeldungAnzeigen("Autsch!", "Diese Zahl gibt es im 3er Kasten schon. Die Zahl wird wieder entfernt", false);
                        ((TextBox)sender).Text = "";


                    }
                }
            }

        }

        private void MeldungAnzeigen(string textOben, string textMitte, bool neinAnzeigen)
        {

            _hauptmenue.MeldungZeigen(textOben, textMitte, neinAnzeigen);
        }

    }
}
