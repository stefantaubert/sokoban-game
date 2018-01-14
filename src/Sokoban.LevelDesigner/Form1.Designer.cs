namespace LevelDesigner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LevelCollectionName = new System.Windows.Forms.TextBox();
            this.einfügen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zielfeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kisteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pauleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HinzufügenButton = new System.Windows.Forms.Button();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.PrüfenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Beschreibung = new System.Windows.Forms.TextBox();
            this.SpeichernButton = new System.Windows.Forms.Button();
            this.ÖffnenButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.InfoButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.einfügen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Levelcollection Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level Name:";
            // 
            // LevelCollectionName
            // 
            this.LevelCollectionName.Location = new System.Drawing.Point(15, 25);
            this.LevelCollectionName.Name = "LevelCollectionName";
            this.LevelCollectionName.Size = new System.Drawing.Size(164, 20);
            this.LevelCollectionName.TabIndex = 2;
            this.LevelCollectionName.Text = "Meine Collection";
            this.LevelCollectionName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // einfügen
            // 
            this.einfügen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wandToolStripMenuItem,
            this.pauleToolStripMenuItem,
            this.kisteToolStripMenuItem,
            this.freiToolStripMenuItem,
            this.zielfeldToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.einfügen.Name = "einfügen";
            this.einfügen.Size = new System.Drawing.Size(119, 136);
            // 
            // wandToolStripMenuItem
            // 
            this.wandToolStripMenuItem.Name = "wandToolStripMenuItem";
            this.wandToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wandToolStripMenuItem.Text = "Wand";
            this.wandToolStripMenuItem.Click += new System.EventHandler(this.wandToolStripMenuItem_Click);
            // 
            // pauleToolStripMenuItem
            // 
            this.pauleToolStripMenuItem.Name = "pauleToolStripMenuItem";
            this.pauleToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pauleToolStripMenuItem.Text = "Paule";
            this.pauleToolStripMenuItem.Click += new System.EventHandler(this.pauleToolStripMenuItem_Click);
            // 
            // kisteToolStripMenuItem
            // 
            this.kisteToolStripMenuItem.Name = "kisteToolStripMenuItem";
            this.kisteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.kisteToolStripMenuItem.Text = "Kiste";
            this.kisteToolStripMenuItem.Click += new System.EventHandler(this.kisteToolStripMenuItem_Click);
            // 
            // freiToolStripMenuItem
            // 
            this.freiToolStripMenuItem.Name = "freiToolStripMenuItem";
            this.freiToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.freiToolStripMenuItem.Text = "Frei";
            this.freiToolStripMenuItem.Click += new System.EventHandler(this.freiToolStripMenuItem_Click);
            // 
            // zielfeldToolStripMenuItem
            // 
            this.zielfeldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.kisteToolStripMenuItem1,
            this.pauleToolStripMenuItem1});
            this.zielfeldToolStripMenuItem.Name = "zielfeldToolStripMenuItem";
            this.zielfeldToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zielfeldToolStripMenuItem.Text = "Zielfeld";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // kisteToolStripMenuItem1
            // 
            this.kisteToolStripMenuItem1.Name = "kisteToolStripMenuItem1";
            this.kisteToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.kisteToolStripMenuItem1.Text = "Kiste";
            this.kisteToolStripMenuItem1.Click += new System.EventHandler(this.kisteToolStripMenuItem1_Click);
            // 
            // pauleToolStripMenuItem1
            // 
            this.pauleToolStripMenuItem1.Name = "pauleToolStripMenuItem1";
            this.pauleToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.pauleToolStripMenuItem1.Text = "Paule";
            this.pauleToolStripMenuItem1.Click += new System.EventHandler(this.pauleToolStripMenuItem1_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // HinzufügenButton
            // 
            this.HinzufügenButton.Location = new System.Drawing.Point(196, 61);
            this.HinzufügenButton.Name = "HinzufügenButton";
            this.HinzufügenButton.Size = new System.Drawing.Size(117, 25);
            this.HinzufügenButton.TabIndex = 5;
            this.HinzufügenButton.Text = "Hinzufügen/Löschen";
            this.HinzufügenButton.UseVisualStyleBackColor = true;
            this.HinzufügenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Items.AddRange(new object[] {
            "Level 1"});
            this.LevelComboBox.Location = new System.Drawing.Point(15, 64);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(164, 21);
            this.LevelComboBox.TabIndex = 6;
            this.LevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelComboBox_SelectedIndexChanged);
            this.LevelComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelComboBox_KeyDown);
            // 
            // PrüfenButton
            // 
            this.PrüfenButton.Location = new System.Drawing.Point(567, 61);
            this.PrüfenButton.Name = "PrüfenButton";
            this.PrüfenButton.Size = new System.Drawing.Size(109, 24);
            this.PrüfenButton.TabIndex = 9;
            this.PrüfenButton.Text = "Level prüfen";
            this.PrüfenButton.UseVisualStyleBackColor = true;
            this.PrüfenButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Copyright:";
            // 
            // Copyright
            // 
            this.Copyright.Location = new System.Drawing.Point(9, 32);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(145, 20);
            this.Copyright.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Beschreibung:";
            // 
            // Beschreibung
            // 
            this.Beschreibung.Location = new System.Drawing.Point(9, 71);
            this.Beschreibung.Multiline = true;
            this.Beschreibung.Name = "Beschreibung";
            this.Beschreibung.Size = new System.Drawing.Size(145, 100);
            this.Beschreibung.TabIndex = 13;
            // 
            // SpeichernButton
            // 
            this.SpeichernButton.Location = new System.Drawing.Point(196, 23);
            this.SpeichernButton.Name = "SpeichernButton";
            this.SpeichernButton.Size = new System.Drawing.Size(117, 23);
            this.SpeichernButton.TabIndex = 14;
            this.SpeichernButton.Text = "Speichern";
            this.SpeichernButton.UseVisualStyleBackColor = true;
            this.SpeichernButton.Click += new System.EventHandler(this.SpeichernButton_Click);
            // 
            // ÖffnenButton
            // 
            this.ÖffnenButton.Location = new System.Drawing.Point(567, 23);
            this.ÖffnenButton.Name = "ÖffnenButton";
            this.ÖffnenButton.Size = new System.Drawing.Size(109, 23);
            this.ÖffnenButton.TabIndex = 15;
            this.ÖffnenButton.Text = "Öffnen";
            this.ÖffnenButton.UseVisualStyleBackColor = true;
            this.ÖffnenButton.Click += new System.EventHandler(this.ÖffnenButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Höhe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Breite:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Copyright);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Beschreibung);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 181);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meine Collection";
            // 
            // ChancelButton
            // 
            this.ChancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ChancelButton.Location = new System.Drawing.Point(21, 546);
            this.ChancelButton.Name = "ChancelButton";
            this.ChancelButton.Size = new System.Drawing.Size(145, 23);
            this.ChancelButton.TabIndex = 23;
            this.ChancelButton.Text = "Beenden";
            this.ChancelButton.UseVisualStyleBackColor = true;
            this.ChancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 101);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Level";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(8, 71);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(22, 517);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(145, 23);
            this.InfoButton.TabIndex = 25;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LevelDesigner.Properties.Resources.leveldesigner;
            this.pictureBox2.Location = new System.Drawing.Point(319, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LevelDesigner.Properties.Resources.nowisys2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 431);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::LevelDesigner.Properties.Resources.schachbrett_2;
            this.panel1.ContextMenuStrip = this.einfügen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 480);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(196, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 480);
            this.panel2.TabIndex = 27;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Level-Datei|*.xml|Alle Datein|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ChancelButton;
            this.ClientSize = new System.Drawing.Size(688, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChancelButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ÖffnenButton);
            this.Controls.Add(this.SpeichernButton);
            this.Controls.Add(this.LevelComboBox);
            this.Controls.Add(this.PrüfenButton);
            this.Controls.Add(this.HinzufügenButton);
            this.Controls.Add(this.LevelCollectionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(696, 630);
            this.Name = "Form1";
            this.Text = "Level Designer Sokoban";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.einfügen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LevelCollectionName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HinzufügenButton;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.ContextMenuStrip einfügen;
        private System.Windows.Forms.ToolStripMenuItem wandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zielfeldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kisteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pauleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.Button PrüfenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Copyright;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Beschreibung;
        private System.Windows.Forms.Button SpeichernButton;
        private System.Windows.Forms.Button ÖffnenButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

