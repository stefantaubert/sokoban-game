using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace XmlTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sokoban());
            //Spieldaten daten = new Spieldaten("values.xml");
            //Spielfeld feld1 = daten.Spielfelder[0];
        }
    }
}
