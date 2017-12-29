using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sokoban.Properties;

namespace XmlTest
{
    public partial class SpielenForm : Form
    {
        Spielfeld spielfeld;
        PictureBox[,] bilder;
        const int abstandLinks = 32;
        const int abstandOben = 32;
        const int feldgrößeX = 32;
        const int feldgrößeY = 32;
        private int männel;

        public SpielenForm(Spielfeld spielfeld, int männel)
        {
            InitializeComponent();

            spielfeld.LadeAusgangsstellung();
            this.spielfeld = spielfeld;
            this.männel = männel;
            spielfeld.AnzahlZüge = 0;
        }

        private void SpielenForm_Load(object sender, EventArgs e)
        {
            ZeigeSpielfeld();
            string zugAnzahl = spielfeld.AnzahlZüge.ToString();
            label3.Text = zugAnzahl;
        }

        public void UpdateFelder()
        {
            for (int x = 0; x < spielfeld.XMax; x++)
            {
                for (int y = 0; y < spielfeld.YMax; y++)
                {
                    switch (spielfeld.Figuren[x, y])
                    {
                        case Figur.Mauer:
                            bilder[x, y].Image = Resources.Wand;
                            break;
                        case Figur.Paule:
                            if (männel == 0)
                            {
                                bilder[x, y].Image = Resources.Hamster;
                                if (taste == "l")
                                {
                                    bilder[x, y].Image = Resources.Hamster;
                                }
                                else if (taste == "r")
                                {
                                    bilder[x, y].Image = Resources.Hamster;
                                    bilder[x, y].Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                                }
                            }
                            else if (männel == 1)
                            {
                                bilder[x, y].Image = Resources.Paule_neu;
                            }
                            else
                            {
                                bilder[x, y].Image = Resources.Sumo;
                            }
                            break;
                        case Figur.Frei:
                            bilder[x, y].Image = Resources.Weiss;
                            break;
                        case Figur.Kiste:
                            bilder[x, y].Image = Resources.Kiste;
                            break;
                        case Figur.ZielfeldPaule:
                            if (männel == 0)
                            {
                                bilder[x, y].Image = Resources.HamsterZielfeld;
                                if (taste == "l")
                                {
                                    bilder[x, y].Image = Resources.HamsterZielfeld;
                                }
                                else if (taste == "r")
                                {
                                    bilder[x, y].Image = Resources.HamsterZielfeld;
                                    bilder[x, y].Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                                }
                            }
                            else if (männel == 1)
                            {
                                bilder[x, y].Image = Resources.PauleZielfeld;
                            }
                            else
                            {
                                bilder[x, y].Image = Resources.SumoZielfeld;
                            }
                            break;
                        case Figur.ZielfeldKiste:
                            bilder[x, y].Image = Resources.KisteZielfeld;
                            break;
                        case Figur.ZielfeldFrei:
                            bilder[x, y].Image = Resources.Ziel;
                            break;
                        default:
                            bilder[x, y].Image = Resources.Grau;
                            break;
                    }
                }
            }
        }

        public void ZeigeSpielfeld()
        {
            bilder = new PictureBox[spielfeld.XMax, spielfeld.YMax];
            for (int x = 0; x < spielfeld.XMax; x++)
            {
                for (int y = 0; y < spielfeld.YMax; y++)
                {
                    Point lage = new Point(abstandLinks + feldgrößeX * x, abstandOben + feldgrößeY * y);
                    bilder[x, y] = new PictureBox();
                    bilder[x, y].Location = lage;
                    bilder[x, y].Height = feldgrößeX;
                    bilder[x, y].Width = feldgrößeY;
                    this.Controls.Add(bilder[x, y]);
                    LevelLabel.Text = spielfeld.Name;
                    Width = feldgrößeX * spielfeld.XMax + 2 * abstandLinks + 3;
                    Height = feldgrößeY * spielfeld.YMax + 3 * abstandOben;
                }
            }
            UpdateFelder();
        }
        string taste = "";
        private void SpielenForm_KeyDown(object sender, KeyEventArgs e)
        {
            string zugAnzahl;

            switch (e.KeyData)
            {
                case Keys.Up:
                    spielfeld.Oben();
                    zugAnzahl = spielfeld.AnzahlZüge.ToString();
                    label3.Text = zugAnzahl;
                    break;
                case Keys.Down:
                    spielfeld.Unten();
                    zugAnzahl = spielfeld.AnzahlZüge.ToString();
                    label3.Text = zugAnzahl;
                    break;
                case Keys.Left:
                    spielfeld.Links();
                    zugAnzahl = spielfeld.AnzahlZüge.ToString();
                    label3.Text = zugAnzahl;
                    taste = "l";
                    break;
                case Keys.Right:
                    spielfeld.Rechts();
                    zugAnzahl = spielfeld.AnzahlZüge.ToString();
                    label3.Text = zugAnzahl;
                    taste = "r";
                    break;
                case Keys.Space:
                    label4_Click(label4, e);
                    break;
                case Keys.ControlKey:
                    label4_Click(label4, e);
                    break;
                default:
                    break;
            }
            UpdateFelder();
            if (spielfeld.gewonnen)
            {
                MessageBox.Show("Sie haben gewonnen!", "Gewonnen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void Reset()
        {
            spielfeld.AnzahlZüge = 0;
            spielfeld.LadeAusgangsstellung();
            UpdateFelder();
            label3.Text = spielfeld.AnzahlZüge.ToString();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SpielenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
