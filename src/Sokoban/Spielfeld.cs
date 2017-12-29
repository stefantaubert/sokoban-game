using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace XmlTest
{
    public class Spielfeld
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int xMax;
        public int XMax
        {
            get { return xMax; }
            set { xMax = value; }
        }

        private int yMax;
        public int YMax
        {
            get { return yMax; }
            set { yMax = value; }
        }

        private int anzahlZüge;
        public int AnzahlZüge
        {
            get { return anzahlZüge; }
            set { anzahlZüge = value; }
        }

        private Figur[,] figuren;
        public Figur[,] Figuren
        {
            get { return figuren; }
            set { figuren = value; }
        }

        private Figur[,] ausgangsstellung;
        public Figur[,] Ausgangsstellung
        {
            get { return ausgangsstellung; }
            set { ausgangsstellung = value; }
        }

        int paul_X;
        int paul_Y;

        public void LadeAusgangsstellung()
        {
            for (int y = 0; y < YMax; y++)
            {
                for (int x = 0; x < XMax; x++)
                {
                    figuren[x, y] = ausgangsstellung[x, y];
                }
            }            
        }


        private void GetPaulPosition()
        {
            for (int y = 0; y < YMax; y++)
            {
                for (int x = 0; x < XMax; x++)
                {
                    if (Figuren[x, y] == Figur.Paule || Figuren[x, y] == Figur.ZielfeldPaule)
                    {
                        paul_X = x;
                        paul_Y = y;
                        break;
                    }
                }
            }
        }

        private void SetPosition(string richtung)
        {
            GetPaulPosition();

            Figur hindernis, paule, hindernis2 = new Figur();
            Figur f = Figur.Frei, l = Figur.Leer, k = Figur.Kiste, p = Figur.Paule, pz = Figur.ZielfeldPaule, kz = Figur.ZielfeldKiste, z = Figur.ZielfeldFrei, m = Figur.Mauer;


            int yPos, xPos, yPosDanach, xPosDanach, yPosDanach2, xPosDanach2;
            Figur figurAlt, figurNeu, figurNachNeu = new Figur();

            xPos = paul_X;
            yPos = paul_Y;

            paule = Figuren[xPos, yPos];

            // finde das nächste und übernächste Feld
            GetFelder(richtung, yPos, xPos, out yPosDanach, out xPosDanach, out yPosDanach2, out xPosDanach2);

            hindernis = figuren[xPosDanach, yPosDanach];
            if (xPosDanach2 > 0 && yPosDanach2 > 0 && xPosDanach2 < XMax && yPosDanach2 < YMax)
            {
                hindernis2 = figuren[xPosDanach2, yPosDanach2];
            }
            else
            {
                hindernis2 = hindernis;
            }

            // paule + frei/leer
            if (paule == p && (hindernis == f || hindernis == l))
            {
                figurAlt = hindernis;
                figurNeu = paule;
                figurNachNeu = hindernis2;
            }

            // paule + hindernis + frei/leer            
            else if (paule == p && hindernis == k && (hindernis2 == l || hindernis2 == f))
            {
                figurAlt = hindernis2;
                figurNeu = p;
                figurNachNeu = k;
            }
            else if (paule == p && hindernis == z && (hindernis2 == l || hindernis2 == f))
            {
                figurAlt = hindernis2;
                figurNeu = pz;
                figurNachNeu = f;
            }
            else if (paule == p && hindernis == kz && (hindernis2 == l || hindernis2 == f))
            {
                figurAlt = hindernis2;
                figurNeu = pz;
                figurNachNeu = k;
            }

            // paule + hindernis + hindernis
            else if (paule == p && hindernis == k && hindernis2 == z)
            {
                figurAlt = f;
                figurNeu = p;
                figurNachNeu = kz;
            }
            else if (paule == p && hindernis == kz && hindernis2 == z)
            {
                figurAlt = f;
                figurNeu = pz;
                figurNachNeu = kz;
            }
            else if (paule == p && hindernis == z && hindernis2 == k)
            {
                figurAlt = f;
                figurNeu = pz;
                figurNachNeu = k;
            }
            else if (paule == p && hindernis == z && hindernis2 == kz)
            {
                figurAlt = f;
                figurNeu = pz;
                figurNachNeu = kz;
            }
            else if (paule == p && hindernis == f && hindernis2 == k)
            {
                figurAlt = f;
                figurNeu = p;
                figurNachNeu = k;
            }
            else if (paule == p && hindernis == f && hindernis2 == kz)
            {
                figurAlt = f;
                figurNeu = p;
                figurNachNeu = kz;
            }
            else if (paule == p && hindernis == f && hindernis2 == z)
            {
                figurAlt = f;
                figurNeu = p;
                figurNachNeu = z;
            }
            else if (paule == p && hindernis == f && hindernis2 == m)
            {
                figurAlt = f;
                figurNeu = p;
                figurNachNeu = m;
            }
            else if (paule == p && hindernis == z && hindernis2 == m)
            {
                figurAlt = f;
                figurNeu = pz;
                figurNachNeu = m;
            }

            else if (paule == p && hindernis == z && hindernis2 == z)
            {
                figurAlt = f;
                figurNeu = pz;
                figurNachNeu = z;
            }
            // zielfeld paule + frei/leer
            else if (paule == pz && (hindernis == f || hindernis == l) && (hindernis2 == f || hindernis2 == l))
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = hindernis2;
            }

            // zielfeld paule + hindernis + frei/leer            
            else if (paule == pz && hindernis == k && (hindernis2 == l || hindernis2 == f))
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = k;
            }
            else if (paule == pz && hindernis == z && (hindernis2 == l || hindernis2 == f))
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = f;
            }
            else if (paule == pz && hindernis == kz && (hindernis2 == l || hindernis2 == f))
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = k;
            }

            // zielfeld paule + hindernis + hindernis
            else if (paule == pz && hindernis == k && hindernis2 == z)
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = kz;
            }
            else if (paule == pz && hindernis == kz && hindernis2 == z)
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = kz;
            }
            else if (paule == pz && hindernis == z && hindernis2 == k)
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = k;
            }
            else if (paule == pz && hindernis == z && hindernis2 == kz)
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = kz;
            }
            else if (paule == pz && hindernis == f && hindernis2 == k)
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = k;
            }
            else if (paule == pz && hindernis == f && hindernis2 == kz)
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = kz;
            }
            else if (paule == pz && hindernis == m && hindernis2 == m)
            {
                figurAlt = pz;
                figurNeu = m;
                figurNachNeu = m;
            }
            else if (paule == pz && hindernis == f && hindernis2 == z)
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = z;
            }
            else if (paule == pz && hindernis == f && hindernis2 == m)
            {
                figurAlt = z;
                figurNeu = p;
                figurNachNeu = m;
            }
            else if (paule == pz && hindernis == z && hindernis2 == m)
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = m;
            }
            else if (paule == pz && hindernis == z && hindernis2 == z)
            {
                figurAlt = z;
                figurNeu = pz;
                figurNachNeu = z;
            }

            else
            {
                if (paule == pz)
                    figurAlt = pz;
                else
                    figurAlt = p;

                figurNeu = hindernis;
                figurNachNeu = hindernis2;
            }

            Figuren[xPos, yPos] = figurAlt;
            Figuren[xPosDanach, yPosDanach] = figurNeu;

            if (figurNachNeu != Figur.Mauer && yPosDanach2 > 0 && xPosDanach2 > 0)
            {
                Figuren[xPosDanach2, yPosDanach2] = figurNachNeu;
            }
            if (figurAlt == paule || figurAlt == pz)   {}
            else
            {
                AnzahlZüge++;
                PrüfeGewinn();
            }

        }

        private static void GetFelder(string richtung, int yPos, int xPos, out int yPosDanach, out int xPosDanach, out int yPosDanach2, out int xPosDanach2)
        {
            if (richtung == "oben")
            {
                xPosDanach = xPos;
                yPosDanach = yPos;
                yPosDanach--;

                xPosDanach2 = xPos;
                yPosDanach2 = yPosDanach;
                yPosDanach2--;
            }
            else if (richtung == "unten")
            {
                xPosDanach = xPos;
                yPosDanach = yPos;
                yPosDanach++;

                xPosDanach2 = xPos;
                yPosDanach2 = yPosDanach;
                yPosDanach2++;
            }
            else if (richtung == "rechts")
            {
                xPosDanach = xPos;
                xPosDanach++;
                yPosDanach = yPos;

                xPosDanach2 = xPosDanach;
                xPosDanach2++;
                yPosDanach2 = yPos;
            }
            else if (richtung == "links")
            {
                xPosDanach = xPos;
                xPosDanach--;
                yPosDanach = yPos;

                xPosDanach2 = xPosDanach;
                xPosDanach2--;
                yPosDanach2 = yPos;
            }
            else
            {
                xPosDanach = 0;
                yPosDanach = 0;

                xPosDanach2 = 0;
                yPosDanach2 = 0;
            }
        }
        public bool gewonnen = false;
        private void PrüfeGewinn()
        {
            int anzahlKisten = 0;
            for (int x = 0; x < XMax; x++)
            {
                for (int y = 0; y < YMax; y++)
                {
                    if (Figuren[x, y] == Figur.Kiste)
                    {
                        anzahlKisten++;
                    }
                }
            }
            if (anzahlKisten != 0)
            {
                gewonnen = false;
            }
            else
            {
                gewonnen = true;
            }
        }

        public void Oben()
        {
            SetPosition("oben");
        }
        public void Unten()
        {
            SetPosition("unten");
        }
        public void Rechts()
        {
            SetPosition("rechts");
        }
        public void Links()
        {
            SetPosition("links");
        }
    }
}
