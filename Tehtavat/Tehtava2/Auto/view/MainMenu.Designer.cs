namespace Autokauppa.view
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittarilukema = new System.Windows.Forms.TextBox();
            this.hinta = new System.Windows.Forms.TextBox();
            this.moottorintilavuus = new System.Windows.Forms.TextBox();
            this.MerkkiANDmaali = new System.Windows.Forms.ComboBox();
            this.Rekisteröintipäivämäärä = new System.Windows.Forms.DateTimePicker();
            this.Poista = new System.Windows.Forms.Button();
            this.Uusi = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.mittarilukema1 = new System.Windows.Forms.Label();
            this.Hinta1 = new System.Windows.Forms.Label();
            this.moottorintilavuus1 = new System.Windows.Forms.Label();
            this.Merkki = new System.Windows.Forms.Button();
            this.MerkkiBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Seurava = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EdellinenButton = new System.Windows.Forms.Button();
            this.Talenna = new System.Windows.Forms.Button();
            this.PolltoaieBox = new System.Windows.Forms.ComboBox();
            this.VariBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaToolStripMenuItem
            // 
            this.testaaToolStripMenuItem.Name = "testaaToolStripMenuItem";
            this.testaaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.testaaToolStripMenuItem.Text = "Testaa";
            this.testaaToolStripMenuItem.Click += new System.EventHandler(this.testaaToolStripMenuItem_Click);
            // 
            // mittarilukema
            // 
            this.mittarilukema.Location = new System.Drawing.Point(137, 108);
            this.mittarilukema.Name = "mittarilukema";
            this.mittarilukema.Size = new System.Drawing.Size(100, 20);
            this.mittarilukema.TabIndex = 1;
            // 
            // hinta
            // 
            this.hinta.Location = new System.Drawing.Point(137, 180);
            this.hinta.Name = "hinta";
            this.hinta.Size = new System.Drawing.Size(100, 20);
            this.hinta.TabIndex = 2;
            // 
            // moottorintilavuus
            // 
            this.moottorintilavuus.Location = new System.Drawing.Point(137, 145);
            this.moottorintilavuus.Name = "moottorintilavuus";
            this.moottorintilavuus.Size = new System.Drawing.Size(100, 20);
            this.moottorintilavuus.TabIndex = 3;
            // 
            // MerkkiANDmaali
            // 
            this.MerkkiANDmaali.FormattingEnabled = true;
            this.MerkkiANDmaali.Location = new System.Drawing.Point(136, 29);
            this.MerkkiANDmaali.Name = "MerkkiANDmaali";
            this.MerkkiANDmaali.Size = new System.Drawing.Size(121, 21);
            this.MerkkiANDmaali.TabIndex = 4;
            this.MerkkiANDmaali.SelectedIndexChanged += new System.EventHandler(this.MerkkiANDmaali_SelectedIndexChanged);
            // 
            // Rekisteröintipäivämäärä
            // 
            this.Rekisteröintipäivämäärä.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Rekisteröintipäivämäärä.Location = new System.Drawing.Point(260, 179);
            this.Rekisteröintipäivämäärä.Name = "Rekisteröintipäivämäärä";
            this.Rekisteröintipäivämäärä.Size = new System.Drawing.Size(200, 20);
            this.Rekisteröintipäivämäärä.TabIndex = 5;
            this.Rekisteröintipäivämäärä.Value = new System.DateTime(2020, 11, 28, 0, 0, 0, 0);
            // 
            // Poista
            // 
            this.Poista.Location = new System.Drawing.Point(424, 366);
            this.Poista.Name = "Poista";
            this.Poista.Size = new System.Drawing.Size(75, 23);
            this.Poista.TabIndex = 7;
            this.Poista.Text = "Poista";
            this.Poista.UseVisualStyleBackColor = true;
            this.Poista.Click += new System.EventHandler(this.Poista_Click);
            // 
            // Uusi
            // 
            this.Uusi.Enabled = false;
            this.Uusi.Location = new System.Drawing.Point(0, 366);
            this.Uusi.Name = "Uusi";
            this.Uusi.Size = new System.Drawing.Size(75, 23);
            this.Uusi.TabIndex = 8;
            this.Uusi.Text = "Uusi tietue";
            this.Uusi.UseVisualStyleBackColor = true;
            this.Uusi.Click += new System.EventHandler(this.Uusi_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(0, 322);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(96, 23);
            this.test.TabIndex = 10;
            this.test.Text = "Admin Button";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // mittarilukema1
            // 
            this.mittarilukema1.AutoSize = true;
            this.mittarilukema1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mittarilukema1.Location = new System.Drawing.Point(22, 112);
            this.mittarilukema1.Name = "mittarilukema1";
            this.mittarilukema1.Size = new System.Drawing.Size(96, 18);
            this.mittarilukema1.TabIndex = 11;
            this.mittarilukema1.Text = "Mittarilukema";
            // 
            // Hinta1
            // 
            this.Hinta1.AutoSize = true;
            this.Hinta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hinta1.Location = new System.Drawing.Point(76, 179);
            this.Hinta1.Name = "Hinta1";
            this.Hinta1.Size = new System.Drawing.Size(42, 18);
            this.Hinta1.TabIndex = 12;
            this.Hinta1.Text = "Hinta";
            // 
            // moottorintilavuus1
            // 
            this.moottorintilavuus1.AutoSize = true;
            this.moottorintilavuus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moottorintilavuus1.Location = new System.Drawing.Point(-3, 147);
            this.moottorintilavuus1.Name = "moottorintilavuus1";
            this.moottorintilavuus1.Size = new System.Drawing.Size(121, 18);
            this.moottorintilavuus1.TabIndex = 13;
            this.moottorintilavuus1.Text = "Moottorintilavuus";
            // 
            // Merkki
            // 
            this.Merkki.Location = new System.Drawing.Point(272, 30);
            this.Merkki.Name = "Merkki";
            this.Merkki.Size = new System.Drawing.Size(88, 23);
            this.Merkki.TabIndex = 14;
            this.Merkki.Text = "Ladata Merkki";
            this.Merkki.UseVisualStyleBackColor = true;
            this.Merkki.Click += new System.EventHandler(this.Merkki_Click);
            // 
            // MerkkiBox
            // 
            this.MerkkiBox.FormattingEnabled = true;
            this.MerkkiBox.Location = new System.Drawing.Point(366, 30);
            this.MerkkiBox.Name = "MerkkiBox";
            this.MerkkiBox.Size = new System.Drawing.Size(121, 21);
            this.MerkkiBox.TabIndex = 15;
            this.MerkkiBox.SelectedIndexChanged += new System.EventHandler(this.MerkkiBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "vari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Polttoaine";
            // 
            // Seurava
            // 
            this.Seurava.Enabled = false;
            this.Seurava.Location = new System.Drawing.Point(80, 215);
            this.Seurava.Name = "Seurava";
            this.Seurava.Size = new System.Drawing.Size(75, 23);
            this.Seurava.TabIndex = 20;
            this.Seurava.Text = "Seurava";
            this.Seurava.UseVisualStyleBackColor = true;
            this.Seurava.Click += new System.EventHandler(this.Seurava_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Malli";
            // 
            // EdellinenButton
            // 
            this.EdellinenButton.Enabled = false;
            this.EdellinenButton.Location = new System.Drawing.Point(284, 215);
            this.EdellinenButton.Name = "EdellinenButton";
            this.EdellinenButton.Size = new System.Drawing.Size(75, 23);
            this.EdellinenButton.TabIndex = 22;
            this.EdellinenButton.Text = "Edellinen";
            this.EdellinenButton.UseVisualStyleBackColor = true;
            this.EdellinenButton.Click += new System.EventHandler(this.EdellinenButton_Click);
            // 
            // Talenna
            // 
            this.Talenna.Enabled = false;
            this.Talenna.Location = new System.Drawing.Point(182, 215);
            this.Talenna.Name = "Talenna";
            this.Talenna.Size = new System.Drawing.Size(75, 23);
            this.Talenna.TabIndex = 23;
            this.Talenna.Text = "Talenna";
            this.Talenna.UseVisualStyleBackColor = true;
            this.Talenna.Click += new System.EventHandler(this.Talenna_Click);
            // 
            // PolltoaieBox
            // 
            this.PolltoaieBox.FormattingEnabled = true;
            this.PolltoaieBox.Items.AddRange(new object[] {
            "Bensiini",
            "Diesel",
            "Hybridi",
            "SÀhkö",
            "Kaasu"});
            this.PolltoaieBox.Location = new System.Drawing.Point(137, 82);
            this.PolltoaieBox.Name = "PolltoaieBox";
            this.PolltoaieBox.Size = new System.Drawing.Size(100, 21);
            this.PolltoaieBox.TabIndex = 24;
            // 
            // VariBox
            // 
            this.VariBox.FormattingEnabled = true;
            this.VariBox.Items.AddRange(new object[] {
            "Valkoinen",
            "Titaanivalkoinen",
            "Norsunluu",
            "Sinkkivalkoinen",
            "Hopea",
            "Harmaa",
            "Musta",
            "Laventeli",
            "Ruiskaunokin sininen",
            "Asuuri",
            "Sininen",
            "Ultramariini",
            "Ftalosyaniini",
            "Laivastonsininen",
            "Indigo",
            "Asuuri X11",
            "Syaani",
            "Turkoosi",
            "Teal",
            "Akvamariini",
            "Smaragdinvihre?",
            "Vihre?",
            "Limenvihre?",
            "Beige",
            "Isabella",
            "Keltainen",
            "Khaki",
            "Ecru",
            "Oliivinvihre?",
            "Kulta",
            "Meripihka",
            "Oranssi",
            "Intialainen kulta",
            "Okra",
            "Sienna",
            "Ruskea",
            "Seepia",
            "Terrakotta",
            "Ruoste",
            "Karmiini",
            "Punamulta",
            "van Dyck",
            "Roosa",
            "Koralli",
            "Tulenpunainen",
            "Punainen",
            "Sinooberi",
            "Kastanja",
            "Bordeaux",
            "Kirsikanpunainen",
            "Karmosiini",
            "Lila",
            "Violetti",
            "Fuksia",
            "Purppura"});
            this.VariBox.Location = new System.Drawing.Point(137, 56);
            this.VariBox.Name = "VariBox";
            this.VariBox.Size = new System.Drawing.Size(100, 21);
            this.VariBox.TabIndex = 25;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 401);
            this.Controls.Add(this.VariBox);
            this.Controls.Add(this.PolltoaieBox);
            this.Controls.Add(this.Talenna);
            this.Controls.Add(this.EdellinenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seurava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MerkkiBox);
            this.Controls.Add(this.Merkki);
            this.Controls.Add(this.moottorintilavuus1);
            this.Controls.Add(this.Hinta1);
            this.Controls.Add(this.mittarilukema1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Uusi);
            this.Controls.Add(this.Poista);
            this.Controls.Add(this.Rekisteröintipäivämäärä);
            this.Controls.Add(this.MerkkiANDmaali);
            this.Controls.Add(this.moottorintilavuus);
            this.Controls.Add(this.hinta);
            this.Controls.Add(this.mittarilukema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaToolStripMenuItem;
        private System.Windows.Forms.TextBox mittarilukema;
        private System.Windows.Forms.TextBox hinta;
        private System.Windows.Forms.TextBox moottorintilavuus;
        private System.Windows.Forms.ComboBox MerkkiANDmaali;
        private System.Windows.Forms.DateTimePicker Rekisteröintipäivämäärä;
        private System.Windows.Forms.Button Poista;
        private System.Windows.Forms.Button Uusi;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Label mittarilukema1;
        private System.Windows.Forms.Label Hinta1;
        private System.Windows.Forms.Label moottorintilavuus1;
        private System.Windows.Forms.ComboBox MerkkiBox;
        public System.Windows.Forms.Button Merkki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Seurava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EdellinenButton;
        private System.Windows.Forms.Button Talenna;
        private System.Windows.Forms.ComboBox PolltoaieBox;
        private System.Windows.Forms.ComboBox VariBox;
    }
}