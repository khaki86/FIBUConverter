namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.execute_btn = new System.Windows.Forms.Button();
            this.inputfile_btn = new System.Windows.Forms.Button();
            this.outfile_btn = new System.Windows.Forms.Button();
            this.infile_text = new System.Windows.Forms.TextBox();
            this.outfile_text = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_mandant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AutoUpgradeEnabled = false;
            this.openFileDialog1.Filter = "TXT-Dateien|*.txt|CSV-Dateien|*.csv";
            this.openFileDialog1.Title = "Quelldatei";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.AutoUpgradeEnabled = false;
            this.openFileDialog2.Filter = "TXT-Dateien|*.txt|CSV-Dateien|*.csv";
            this.openFileDialog2.Title = "Zieldatei";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // execute_btn
            // 
            this.execute_btn.Enabled = false;
            this.execute_btn.Location = new System.Drawing.Point(12, 143);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(75, 23);
            this.execute_btn.TabIndex = 6;
            this.execute_btn.Text = "Start";
            this.execute_btn.UseVisualStyleBackColor = true;
            this.execute_btn.Click += new System.EventHandler(this.execute_btn_Click);
            // 
            // inputfile_btn
            // 
            this.inputfile_btn.Location = new System.Drawing.Point(197, 70);
            this.inputfile_btn.Name = "inputfile_btn";
            this.inputfile_btn.Size = new System.Drawing.Size(75, 23);
            this.inputfile_btn.TabIndex = 3;
            this.inputfile_btn.Text = "Quell-Datei";
            this.inputfile_btn.UseVisualStyleBackColor = true;
            this.inputfile_btn.Click += new System.EventHandler(this.infile_btn_Click);
            // 
            // outfile_btn
            // 
            this.outfile_btn.Location = new System.Drawing.Point(197, 99);
            this.outfile_btn.Name = "outfile_btn";
            this.outfile_btn.Size = new System.Drawing.Size(75, 23);
            this.outfile_btn.TabIndex = 5;
            this.outfile_btn.Text = "Ziel-Datei";
            this.outfile_btn.UseVisualStyleBackColor = true;
            this.outfile_btn.Visible = false;
            this.outfile_btn.Click += new System.EventHandler(this.outfile_btn_Click);
            // 
            // infile_text
            // 
            this.infile_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.infile_text.Location = new System.Drawing.Point(12, 72);
            this.infile_text.Name = "infile_text";
            this.infile_text.Size = new System.Drawing.Size(179, 20);
            this.infile_text.TabIndex = 2;
            this.infile_text.TextChanged += new System.EventHandler(this.infile_text_TextChanged);
            // 
            // outfile_text
            // 
            this.outfile_text.Location = new System.Drawing.Point(12, 101);
            this.outfile_text.Name = "outfile_text";
            this.outfile_text.Size = new System.Drawing.Size(179, 20);
            this.outfile_text.TabIndex = 4;
            this.outfile_text.Visible = false;
            this.outfile_text.TextChanged += new System.EventHandler(this.outfile_text_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(196, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "erfolgreich";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "benutzerdef. Datum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2016, 8, 23, 14, 58, 5, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox_mandant
            // 
            this.comboBox_mandant.FormattingEnabled = true;
            this.comboBox_mandant.Items.AddRange(new object[] {
            "Consult",
            "PanStreet",
            "Enseidon"});
            this.comboBox_mandant.Location = new System.Drawing.Point(196, 31);
            this.comboBox_mandant.Name = "comboBox_mandant";
            this.comboBox_mandant.Size = new System.Drawing.Size(74, 21);
            this.comboBox_mandant.TabIndex = 7;
            this.comboBox_mandant.ValueMember = "Consult";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mandant";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_mandant);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.outfile_text);
            this.Controls.Add(this.infile_text);
            this.Controls.Add(this.outfile_btn);
            this.Controls.Add(this.inputfile_btn);
            this.Controls.Add(this.execute_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FIBUConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.Button inputfile_btn;
        private System.Windows.Forms.Button outfile_btn;
        private System.Windows.Forms.TextBox infile_text;
        private System.Windows.Forms.TextBox outfile_text;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_mandant;
        private System.Windows.Forms.Label label2;
    }
}

