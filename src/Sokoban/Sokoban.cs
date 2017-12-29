using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sokoban.Properties;
using System.Diagnostics;
namespace XmlTest
{
    public partial class Sokoban : Form
    {
        public Spieldaten daten;
        SpielenForm game;

        public Sokoban()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            openFileDialog1.InitialDirectory = Application.StartupPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    comboBox1.Items.Clear();
                    daten = new Spieldaten(openFileDialog1.FileName);
                    for (int i = 0; i < daten.Spielfelder.Length; i++)
                    {
                        comboBox1.Items.Add(daten.Spielfelder[i].Name);
                    }
                    CopyrightLabel.Text = daten.Copyright.TrimStart();
                    BeschreibungLabel.Text = daten.Beschreibung.TrimStart();
                    label2.Show();
                    label3.Show();
                    comboBox1.SelectedIndex = 0;
                    if (comboBox2.SelectedIndex == -1)
                    {
                        comboBox2.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Datei hat ungültiges Format!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Spielfeld spielfeld = daten.Spielfelder[comboIndex1];
                game = new SpielenForm(spielfeld, comboIndex2);
                if (game.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        comboBox1.SelectedIndex++;
                        button1_Click(button1, e);
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Das Level konnte nicht gestartet werden!", "Fehler");
            }
        }

        public int comboIndex1
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }
        public int comboIndex2
        {
            get { return comboBox2.SelectedIndex; }
            set { comboBox2.SelectedIndex = value; }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboIndex1 = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboIndex2 = comboBox2.SelectedIndex;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string text = "Entwicklung: Stefan Taubert im Rahmen eines zweiwöchigen Betriebspraktikums.";
            text += "\r\nBetreuung: Nowisys IT-Service GmbH.\r\n\n";
            text += "Bedienung: Bewegung mit Pfeiltasten, Neustart mit Leertaste.";
            MessageBox.Show(text, "Info", MessageBoxButtons.OK);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "http://www.nowisys.de/");
        }
    }
}

