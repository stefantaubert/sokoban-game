using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace XmlTest
{
    public class Spieldaten
    {
        private string file;
        public string File
        {
            get { return file; }
            set { file = value; }
        }

        private string titel;
        private string beschreibung;
        private string copyright;
        private int levelAnzahl;
        private Spielfeld[] spielfelder;
        public Spielfeld[] Spielfelder
        {
            get { return spielfelder; }
            set { spielfelder = value; }
        }
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public string Beschreibung
        {
            get { return beschreibung; }
            set { beschreibung = value; }
        }
        private int maxX;
        public int maximumX
        {
            get { return maxX; }
            set { maxX = value; }
        }
        private int maxY;
        public int maximumY
        {
            get { return maxY; }
            set { maxY = value; }
        }
        public string Copyright
        {
            get { return copyright; }
            set { copyright = value; }
        }

        public Spieldaten()
        {
            file = string.Empty;
        }

        public Spieldaten(string file)
        {
            this.file = file;
            Load();
        }

        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SokobanLevels));
            FileStream fileStream = new FileStream(file, FileMode.Open);
            SokobanLevels sokobanLevels = (SokobanLevels)serializer.Deserialize(fileStream);

            titel = sokobanLevels.Title;
            beschreibung = sokobanLevels.Description;
            copyright = sokobanLevels.LevelCollection.Copyright;
            levelAnzahl = sokobanLevels.LevelCollection.Level.Length;
            Beschreibung = beschreibung;
            Copyright = copyright;

            spielfelder = new Spielfeld[levelAnzahl];
            for (int i = 0; i < levelAnzahl; i++)
            {
                Level level = sokobanLevels.LevelCollection.Level[i];
                spielfelder[i] = new Spielfeld();
                Spielfeld spielfeld = spielfelder[i];

                spielfeld.Name = level.Id;
                spielfeld.XMax = level.Width;
                spielfeld.YMax = level.Height;
                maximumX = spielfeld.XMax;
                maximumY = spielfeld.YMax;
                spielfeld.Figuren = new Figur[spielfeld.XMax, spielfeld.YMax];
                spielfeld.Ausgangsstellung = new Figur[spielfeld.XMax, spielfeld.YMax];

                for (int y = 0; y < spielfeld.YMax; y++)
                {
                    for (int x = 0; x < spielfeld.XMax; x++)
                    {
                        Figur figur;
                        if (x < level.L[y].Length)
                        {
                            string zeichen = level.L[y].Substring(x, 1);
                            switch (zeichen)
                            {
                                case "#":
                                    figur = Figur.Mauer;
                                    break;
                                case "@":
                                    figur = Figur.Paule;
                                    break;
                                case " ":
                                    if (x < level.L[y].IndexOf("#"))
                                    {
                                        figur = Figur.Leer;
                                    }
                                    else
                                    {
                                        figur = Figur.Frei;
                                    }
                                    break;
                                case "+":
                                    figur = Figur.ZielfeldPaule;
                                    break;
                                case "$":
                                    figur = Figur.Kiste;
                                    break;
                                case "*":
                                    figur = Figur.ZielfeldKiste;
                                    break;
                                case ".":
                                    figur = Figur.ZielfeldFrei;
                                    break;
                                default:
                                    figur = Figur.Leer;
                                    break;
                            }
                        }
                        else
                        {
                            figur = Figur.Leer;
                        }
                        spielfeld.Figuren[x, y] = figur;
                        spielfeld.Ausgangsstellung[x, y] = figur;
                    }
                }
            }
        }

        public void Save()
        {
            SokobanLevels sokobanLevels = new SokobanLevels();
            sokobanLevels.Title = titel;
            sokobanLevels.Description = beschreibung;
            sokobanLevels.LevelCollection = new LevelCollection();
            sokobanLevels.LevelCollection.Copyright = copyright;
            sokobanLevels.LevelCollection.Level = new Level[spielfelder.Length];

            for (int i = 0; i < spielfelder.Length; i++)
            {
                sokobanLevels.LevelCollection.Level[i] = new Level();
                Level level = sokobanLevels.LevelCollection.Level[i];
                Spielfeld spielfeld = new Spielfeld();
                spielfeld = spielfelder[i];

                level.Height = spielfeld.YMax;
                level.Width = spielfeld.XMax;
                level.Id = spielfeld.Name;
                level.L = new string[spielfeld.YMax];
                for (int y = 0; y < spielfeld.YMax; y++)
                {
                    level.L[y] = "";
                    for (int x = 0; x < spielfeld.XMax; x++)
                    {
                        string zeichen;
                        switch (spielfeld.Figuren[x, y])
                        {
                            case Figur.Paule:
                                zeichen = "@";
                                break;
                            case Figur.Kiste:
                                zeichen = "$";
                                break;
                            case Figur.Frei:
                                zeichen = " ";
                                break;
                            case Figur.Leer:
                                zeichen = " ";
                                break;
                            case Figur.Mauer:
                                zeichen = "#";
                                break;
                            case Figur.ZielfeldFrei:
                                zeichen = ".";
                                break;
                            case Figur.ZielfeldKiste:
                                zeichen = "*";
                                break;
                            case Figur.ZielfeldPaule:
                                zeichen = "+";
                                break;
                            default:
                                zeichen = "";
                                break;
                        }
                        level.L[y] += zeichen;
                    }
                }
            }
            XmlSerializer serializer = new XmlSerializer(typeof(SokobanLevels));
            FileStream fileStream = new FileStream(file, FileMode.Create);
            serializer.Serialize(fileStream, sokobanLevels);
        }

    }
}
