using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public class Backtracking
    {

        public int[,] _datenTesten { get; set; }


        public bool LoeseFeld()
        {
            Coordinate freiesFeld = new Coordinate();

            if (IstFeldVoll())
                return true;
            freiesFeld = naechstesFreiesFeld();

            for (int i = 1; i < 10; i++)
            {
                _datenTesten[freiesFeld.x, freiesFeld.y] = i;


                if (IstGueltigesFeld())
                {
                    if (LoeseFeld())
                    {
                        return true;

                    }

                }

            }
            _datenTesten[freiesFeld.x, freiesFeld.y] = -1;
            return false;


        }

        private bool IstGueltigesFeld()
        {
            int zahl;
            bool[] vorhanden = new bool[9];



            //ZEILEN
            for (int y = 0; y < 9; y++)
            {
                for (int i = 0; i < 9; i++)
                    vorhanden[i] = false;

                for (int x = 0; x < 9; x++)
                {
                    zahl = _datenTesten[x, y];
                    if (zahl != -1)
                    {
                        if (vorhanden[zahl - 1])
                        {
                            return false;
                        }
                        else
                            vorhanden[zahl - 1] = true;

                    }
                }
            }

            //SPALTEN
            for (int x = 0; x < 9; x++)
            {
                for (int i = 0; i < 9; i++)
                    vorhanden[i] = false;

                for (int y = 0; y < 9; y++)
                {

                    zahl = _datenTesten[x, y];
                    if (zahl != -1)
                    {
                        if (vorhanden[zahl - 1] == true)
                        {
                            return false;
                        }
                        else
                        {
                            vorhanden[zahl - 1] = true;
                        }
                    }
                }
            }



            for (int ys = 0; ys < 3; ys++)
            {
                for (int xs = 0; xs < 3; xs++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        vorhanden[i] = false;
                    }


                    for (int y = (ys * 3); y < (ys * 3) + 3; y++)
                    {
                        for (int x = (xs * 3); x < (xs * 3) + 3; x++)
                        {
                            zahl = _datenTesten[x, y];

                            if (zahl != -1)
                            {


                                if (vorhanden[zahl - 1])
                                {
                                    return false;
                                }
                                else
                                {
                                    vorhanden[zahl - 1] = true;
                                }
                            }
                        }
                    }
                }
            }



            return true;



        }


        private Coordinate naechstesFreiesFeld()
        {
            Coordinate coord = new Coordinate();
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (_datenTesten[x, y] == -1)
                    {
                        coord.x = x;
                        coord.y = y;
                        return coord;
                    }
                }
            }
            return coord;
        }


        private bool IstFeldVoll()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (_datenTesten[x, y] == -1)
                    {
                        return false;
                    }
                }
            }


            return true;

        }



    }
}
