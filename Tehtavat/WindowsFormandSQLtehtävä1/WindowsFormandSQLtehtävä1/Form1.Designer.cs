namespace WindowsFormandSQLtehtävä1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Itse = new System.Windows.Forms.Button();
            this.DataBase = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Poistu = new System.Windows.Forms.Button();
            this.IDdelete = new System.Windows.Forms.TextBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // Itse
            // 
            this.Itse.Location = new System.Drawing.Point(569, 101);
            this.Itse.Name = "Itse";
            this.Itse.Size = new System.Drawing.Size(141, 23);
            this.Itse.TabIndex = 0;
            this.Itse.Text = "itse Elokuvat";
            this.Itse.UseVisualStyleBackColor = true;
            this.Itse.Click += new System.EventHandler(this.Itse_Click_1);
            // 
            // DataBase
            // 
            this.DataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nimi});
            this.DataBase.Location = new System.Drawing.Point(323, 90);
            this.DataBase.Name = "DataBase";
            this.DataBase.Size = new System.Drawing.Size(240, 150);
            this.DataBase.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nimi
            // 
            this.Nimi.HeaderText = "Nimi";
            this.Nimi.Name = "Nimi";
            this.Nimi.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 327);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Syota nimi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Poistu
            // 
            this.Poistu.Location = new System.Drawing.Point(733, 101);
            this.Poistu.Name = "Poistu";
            this.Poistu.Size = new System.Drawing.Size(75, 23);
            this.Poistu.TabIndex = 6;
            this.Poistu.Text = "IDPois";
            this.Poistu.UseVisualStyleBackColor = true;
            this.Poistu.Click += new System.EventHandler(this.Poistu_Click);
            // 
            // IDdelete
            // 
            this.IDdelete.Location = new System.Drawing.Point(733, 130);
            this.IDdelete.Name = "IDdelete";
            this.IDdelete.Size = new System.Drawing.Size(100, 20);
            this.IDdelete.TabIndex = 7;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(51, 363);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 8;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ryhmä1",
            "Ryhmä2",
            "Ryhmä3"});
            this.comboBox1.Location = new System.Drawing.Point(442, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.IDdelete);
            this.Controls.Add(this.Poistu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.Itse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Itse;
        private System.Windows.Forms.DataGridView DataBase;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nimi;
        private System.Windows.Forms.Button Poistu;
        private System.Windows.Forms.TextBox IDdelete;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

