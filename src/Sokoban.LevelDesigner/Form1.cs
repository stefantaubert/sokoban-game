using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sokoban;
using LevelDesigner.Properties;
using XmlTest;
using System.Diagnostics;

namespace LevelDesigner
{
    public partial class Form1 : Form
    {
        KoordinatenPicBox[,] pictureBox = new KoordinatenPicBox[15, 15];
        Figur[, ,] figuren = new Figur[50, 15, 15];
        Size[] größe = new Size[50];
        int selectedLevel = 0;
        int widhtField = 0;
        int heightField = 0;
        const int rastergröße = 32;
        const int picBoxgröße = 32;
        int mausX = 0, mausY = 0;
        int X;
        int Y;
        string prüfung = "";
        private string dateiName = @"C:\Dokumente und Einstellungen\ewilhelm\Desktop\Meine Collection.xml";
        Spielfeld spielfeld;
        public Spieldaten daten;


        #region ToolStrip
        private void wandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.Wand;
            figuren[selectedLevel, X, Y] = Figur.Mauer;
        }
        private void pauleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.Paule_neu;
            figuren[selectedLevel, X, Y] = Figur.Paule;
        }

        private void kisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.Kiste;
            figuren[selectedLevel, X, Y] = Figur.Kiste;
        }

        private void freiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.Weiss;
            figuren[selectedLevel, X, Y] = Figur.Frei;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.Ziel;
            figuren[selectedLevel, X, Y] = Figur.ZielfeldFrei;
        }

        private void kisteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.KisteZielfeld;
            figuren[selectedLevel, X, Y] = Figur.ZielfeldKiste;
        }

        private void pauleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = Resources.PauleZielfeld;
            figuren[selectedLevel, X, Y] = Figur.ZielfeldPaule;
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox[X, Y].Image = null;
            pictureBox[X, Y].BackColor = Color.Transparent;
            figuren[selectedLevel, X, Y] = Figur.Leer; ;
        }
        #endregion

        void click(object sender, MouseEventArgs e)
        {
            if (sender is KoordinatenPicBox)
            {
                KoordinatenPicBox box = (KoordinatenPicBox)sender;

                mausX = MousePosition.X;
                mausY = MousePosition.Y;

                einfügen.Show(mausX, mausY);
                //selectedPictureBox = (KoordinatenPicBox)sender;
                X = box.x;
                Y = box.y;
            }
        }

        public Form1()
        {
            InitializeComponent();
            LevelComboBox.SelectedIndex = 0;
            widhtField = Convert.ToInt16(numericUpDown2.Value);
            heightField = Convert.ToInt16(numericUpDown1.Value);
            openFileDialog1.InitialDirectory = Application.StartupPath;
            ChangeSize();
            numericUpDown2.Value = 15;
            numericUpDown1.Value = 15;
        }

        private void PaintImages()
        {
            for (int i = 0; i < widhtField; i++)
            {
                for (int j = 0; j < heightField; j++)
                {
                    pictureBox[i, j] = new KoordinatenPicBox(i, j);
                    pictureBox[i, j].Width = picBoxgröße;
                    pictureBox[i, j].Height = picBoxgröße;
                    pictureBox[i, j].MouseDown += click;
                    pictureBox[i, j].Location = new Point(i * picBoxgröße, j * picBoxgröße);
                    pictureBox[i, j].BackColor = Color.Transparent;
                    panel1.Controls.Add(pictureBox[i, j]);
                }
            }
        }

        private void UpdateImages()
        {
            for (int x = 0; x < widhtField; x++)
            {
                for (int y = 0; y < heightField; y++)
                {
                    switch (figuren[selectedLevel, x, y])
                    {
                        case Figur.Paule:
                            pictureBox[x, y].Image = Resources.Paule_neu;
                            break;
                        case Figur.Kiste:
                            pictureBox[x, y].Image = Resources.Kiste;
                            break;
                        case Figur.Frei:
                            pictureBox[x, y].Image = Resources.Weiss;
                            break;
                        case Figur.Mauer:
                            pictureBox[x, y].Image = Resources.Wand;
                            break;
                        case Figur.ZielfeldFrei:
                            pictureBox[x, y].Image = Resources.Ziel;
                            break;
                        case Figur.ZielfeldKiste:
                            pictureBox[x, y].Image = Resources.KisteZielfeld;
                            break;
                        case Figur.ZielfeldPaule:
                            pictureBox[x, y].Image = Resources.PauleZielfeld;
                            break;
                        default:
                            pictureBox[x, y].Image = null;
                            pictureBox[x, y].BackColor = Color.Transparent;
                            break;

                    }
                    pictureBox[x, y].Width = picBoxgröße;
                    pictureBox[x, y].Height = picBoxgröße;
                }

            }
        }

        public void UpdateFelder()
        {
            spielfeld = new Spielfeld();
            try
            {
                spielfeld = daten.Spielfelder[LevelComboBox.SelectedIndex];
            }
            catch (Exception ex)
            {
                daten.Spielfelder[LevelComboBox.SelectedIndex] = new Spielfeld();
                spielfeld = daten.Spielfelder[LevelComboBox.SelectedIndex];
            }


            BilderNullen();
            for (int x = 0; x < spielfeld.XMax; x++)
            {
                for (int y = 0; y < spielfeld.YMax; y++)
                {
                    switch (spielfeld.Figuren[x, y])
                    {
                        case Figur.Mauer:
                            pictureBox[x, y].Image = Resources.Wand;
                            break;
                        case Figur.Paule:
                            pictureBox[x, y].Image = Resources.Paule_neu;
                            break;
                        case Figur.Frei:
                            pictureBox[x, y].Image = Resources.Weiss;
                            break;
                        case Figur.Kiste:
                            pictureBox[x, y].Image = Resources.Kiste;
                            break;
                        case Figur.ZielfeldPaule:
                            pictureBox[x, y].Image = Resources.PauleZielfeld;
                            break;
                        case Figur.ZielfeldKiste:
                            pictureBox[x, y].Image = Resources.KisteZielfeld;
                            break;
                        case Figur.ZielfeldFrei:
                            pictureBox[x, y].Image = Resources.Ziel;
                            break;
                        default:
                            pictureBox[x, y].Image = Resources.Grau;
                            break;
                    }
                }
            }
        }

        private void BilderNullen()
        {
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    pictureBox[x, y].Image = null;
                    pictureBox[x, y].BackColor = Color.Transparent;
                }
            }
        }

        private void fehlerprüfung()
        {
            int kistenAnzahl = 0;
            int zielfeldAnzahl = 0;
            int pauleAnzahl = 0;
            string fehlermeldung = "";


            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (figuren[selectedLevel, i, j] == Figur.Kiste)
                    {
                        kistenAnzahl++;
                    }
                    if (figuren[selectedLevel, i, j] == Figur.ZielfeldFrei)
                    {
                        zielfeldAnzahl++;
                    }
                    if (figuren[selectedLevel, i, j] == Figur.ZielfeldKiste)
                    {
                        zielfeldAnzahl++;
                        kistenAnzahl++;
                    }
                    if (figuren[selectedLevel, i, j] == Figur.ZielfeldPaule)
                    {
                        zielfeldAnzahl++;
                        pauleAnzahl++;
                    }
                    if (figuren[selectedLevel, i, j] == Figur.Paule)
                    {
                        pauleAnzahl++;
                    }
                }
            }

            // Kistenprüfung
            if (kistenAnzahl > zielfeldAnzahl)
            {
                fehlermeldung += "Zu viele Kisten: " + (kistenAnzahl - zielfeldAnzahl) + "\r\n";
            }
            else if (kistenAnzahl == 0)
            {
                fehlermeldung += "Keine Kisten!" + "\r\n";
            }
            else
            {
                fehlermeldung += "Kistenprüfung bestanden." + "\r\n";
            }

            // Zielfeldprüfung
            if (kistenAnzahl < zielfeldAnzahl)
            {
                fehlermeldung += "Zu viele Zielfeldeer: " + (zielfeldAnzahl - kistenAnzahl) + "\r\n";
            }
            else if (zielfeldAnzahl == 0)
            {
                fehlermeldung += "Keine Zielfelder!" + "\r\n";
            }
            else
            {
                fehlermeldung += "Zielfeldprüfung bestanden." + "\r\n";
            }

            // Paulprüfung
            if (pauleAnzahl > 1)
            {
                fehlermeldung += "Zu viele Pauls: " + (pauleAnzahl - 1);
            }
            else if (pauleAnzahl == 0)
            {
                fehlermeldung += "Kein Paul!";
            }
            else
            {
                fehlermeldung += "Paulprüfung bestanden.";
            }

            if (fehlermeldung != ("Kistenprüfung bestanden." + "\r\n" + "Zielfeldprüfung bestanden." + "\r\n" + "Paulprüfung bestanden."))
            {
                prüfung = fehlermeldung;
            }
            else
            {
                prüfung = "Alle Felder sind OK";
            }

        }

        private void UpdateFiguren()
        {

            for (int i = 0; i < LevelComboBox.Items.Count; i++)
            {
                spielfeld.XMax = daten.Spielfelder[i].XMax;
                spielfeld.YMax = daten.Spielfelder[i].YMax;
                for (int x = 0; x < spielfeld.XMax; x++)
                {
                    for (int y = 0; y < spielfeld.YMax; y++)
                    {
                        figuren[i, x, y] = daten.Spielfelder[i].Figuren[x, y];
                    }
                }
            }
        }

        private void ChangeSize()
        {
            try
            {
                if (größe[selectedLevel] == null)
                {
                    größe[selectedLevel] = new Size();
                }
                heightField = Convert.ToInt16(numericUpDown1.Value);
                widhtField = Convert.ToInt16(numericUpDown2.Value);

                if (heightField <= 15 && heightField >= 1 && (widhtField <= 15 && widhtField >= 1))
                {
                    größe[selectedLevel].Width = widhtField * rastergröße;
                    größe[selectedLevel].Height = heightField * rastergröße;
                    panel1.Size = größe[selectedLevel];
                }
                else
                {
                    MessageBox.Show("Der Wert ist ungültig.");
                    numericUpDown1.Value = 15;
                    numericUpDown2.Value = 15;
                }
            }
            catch
            {
                MessageBox.Show("Der Wert besitzt ein illegales Zeichen!");
                numericUpDown1.Value = heightField;
                numericUpDown2.Value = widhtField;
            }

        }
        bool geöffnetesFile = false;
        private void ÖffnenButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bitte beachten Sie, dass alle nicht gespeicherten Daten verloren gehen! Wollen Sie fortfahren?", "Achtung", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    LevelComboBox.Items.Clear();
                    daten = new Spieldaten(openFileDialog1.FileName);
                    for (int i = 0; i < daten.Spielfelder.Length; i++)
                    {
                        LevelComboBox.Items.Add(daten.Spielfelder[i].Name);
                    }
                    Copyright.Text = daten.Copyright.TrimStart();
                    Beschreibung.Text = daten.Beschreibung.TrimStart();
                    LevelComboBox.SelectedIndex = 0;
                    dateiName = openFileDialog1.FileName;
                    numericUpDown1.Value = daten.Spielfelder[0].YMax;
                    numericUpDown2.Value = daten.Spielfelder[0].XMax;
                    UpdateFiguren();
                    HinzufügenButton.Hide();
                    geöffnetesFile = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (LevelCollectionName.Text != "")
            {
                LevelComboBox.Show();
                HinzufügenButton.Show();
                label2.Show();
                UpdateImages();
            }
            else
            {
                LevelComboBox.Hide();
                HinzufügenButton.Hide();
                label2.Hide();
            }
            if (LevelCollectionName.TextLength < 15)
            {
                groupBox1.Text = LevelCollectionName.Text;
            }
            else
            {
                groupBox1.Text = LevelCollectionName.Text.Substring(0, 15) + "...";

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fehlerprüfung();
            MessageBox.Show(prüfung, "Prüfung");
        }

        private void SpeichernButton_Click(object sender, EventArgs e)
        {
            fehlerprüfung();
            if (prüfung == "Alle Felder sind OK" && LevelCollectionName.Text != "" && LevelComboBox.Items.Count > 0)
            {
                saveFileDialog1.FileName = LevelCollectionName.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {                   
                    Spieldaten spieldaten = new Spieldaten();
                    spieldaten.Beschreibung = Beschreibung.Text;
                    spieldaten.Copyright = Copyright.Text;
                    spieldaten.File = saveFileDialog1.FileName;
                    spieldaten.Titel = LevelCollectionName.Text;
                    spieldaten.Spielfelder = new Spielfeld[LevelComboBox.Items.Count];
                    Level level = new Level();
                    for (int i = 0; i < LevelComboBox.Items.Count; i++)
                    {
                        level.Width = größe[i].Width / rastergröße;
                        level.Height = größe[i].Height / rastergröße;

                        Spielfeld spielfeld = new Spielfeld();
                        spieldaten.Spielfelder[i] = new Spielfeld();
                        spielfeld = spieldaten.Spielfelder[i];
                        spielfeld.Name = LevelComboBox.Items[i].ToString();
                        spielfeld.XMax = level.Width;
                        spielfeld.YMax = level.Height;
                        spielfeld.Figuren = new Figur[spielfeld.XMax, spielfeld.YMax];
                        for (int x = 0; x < spielfeld.XMax; x++)
                        {
                            for (int y = 0; y < spielfeld.YMax; y++)
                            {
                                spielfeld.Figuren[x, y] = new Figur();
                                spielfeld.Figuren[x, y] = figuren[i, x, y];
                            }
                        }
                    }
                    spieldaten.Save();
                }
            }
            else
            {
                MessageBox.Show("Nicht alle Daten sind OK!");
            }
        }

        private bool PrüfeCombobox()
        {
            int wert = 0;
            for (int i = 0; i < LevelComboBox.Items.Count; i++)
            {
                if (Convert.ToString(LevelComboBox.Items[i]) == LevelComboBox.Text)
                {
                    wert = 1;
                    break;
                }
            }
            if (wert == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LevelComboBox.Text != "")
            {
                if (PrüfeCombobox())
                {
                    LevelComboBox.Items.Add(LevelComboBox.Text);
                }
                else
                {
                    if (LevelComboBox.Items.Count >= 2)
                    {
                        LevelComboBox.Items.Remove(LevelComboBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Es muss mindestens 1 Level geben!");
                    }
                }
                LevelComboBox.SelectedIndex = LevelComboBox.Items.Count - 1;
                UpdateImages();
            }
            if (LevelComboBox.Items.Count > 1)
            {
                UpdateImages();
                ChangeSize();
            }

        }

        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLevel = LevelComboBox.SelectedIndex;
            if (openFileDialog1.FileName != "")
            {
                UpdateFelder();
                numericUpDown1.Value = daten.Spielfelder[selectedLevel].YMax;
                numericUpDown2.Value = daten.Spielfelder[selectedLevel].XMax;
            }
            else
            {
                UpdateImages();
                panel1.Size = größe[selectedLevel];
            }
        }

        private void Länge_TextChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void Breite_TextChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "http://www.nowisys.de/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PaintImages();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = "Entwicklung: Stefan Taubert im Rahmen eines zweiwöchigen Betriebspraktikums.";
            text += "\r\nBetreuung: Nowisys IT-Service GmbH.\r\n\n";
            text += "Bedienung: Mausclick auf Quadrat -> Figur auswählen.\r\n";
            text += "Speichern: Es wird vorher geprüft ob die Levelcollection den Anforderungen entspricht.\r\n";
            text += "Laden: Es wird eine Levelcollection geladen, bei der aber kein Level hinzugefügt werden kann.\r\n";
            text += "Bei Unklarheiten: Prüfbutton drücken.\r\n";
            MessageBox.Show(text, "Info", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void LevelComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && geöffnetesFile == false)
            {
                button1_Click(HinzufügenButton, e);
            }
        }

    }
}
