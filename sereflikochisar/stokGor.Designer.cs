namespace sereflikochisar
{
    partial class stokGor
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
            this.datagridStok = new System.Windows.Forms.DataGridView();
            this.ayarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milyem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStok)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridStok
            // 
            this.datagridStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ayarID,
            this.kategoriID,
            this.gram,
            this.milyem,
            this.firmaID,
            this.giristarih,
            this.barkod});
            this.datagridStok.Location = new System.Drawing.Point(5, -2);
            this.datagridStok.Margin = new System.Windows.Forms.Padding(4);
            this.datagridStok.Name = "datagridStok";
            this.datagridStok.Size = new System.Drawing.Size(1029, 342);
            this.datagridStok.TabIndex = 0;
            // 
            // ayarID
            // 
            this.ayarID.DataPropertyName = "ayarID";
            this.ayarID.HeaderText = "Altın Ayarı";
            this.ayarID.Name = "ayarID";
            // 
            // kategoriID
            // 
            this.kategoriID.DataPropertyName = "kategoriAd";
            this.kategoriID.HeaderText = "Kategorisi";
            this.kategoriID.Name = "kategoriID";
            // 
            // gram
            // 
            this.gram.DataPropertyName = "gram";
            this.gram.HeaderText = "Gramı";
            this.gram.Name = "gram";
            // 
            // milyem
            // 
            this.milyem.DataPropertyName = "milyem";
            this.milyem.HeaderText = "Milyem";
            this.milyem.Name = "milyem";
            // 
            // firmaID
            // 
            this.firmaID.DataPropertyName = "firmaAd";
            this.firmaID.HeaderText = "Firması";
            this.firmaID.Name = "firmaID";
            // 
            // giristarih
            // 
            this.giristarih.DataPropertyName = "giristarih";
            this.giristarih.HeaderText = "Giris Tarihi";
            this.giristarih.Name = "giristarih";
            // 
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 488);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Firma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ayar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 511);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 511);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Toplam Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Toplam Gram";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Hepsi"});
            this.comboBox3.Location = new System.Drawing.Point(189, 490);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 24);
            this.comboBox3.TabIndex = 32;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hepsi"});
            this.comboBox2.Location = new System.Drawing.Point(189, 456);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hepsi",
            "8",
            "10",
            "14",
            "22"});
            this.comboBox1.Location = new System.Drawing.Point(189, 418);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(496, 386);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 386);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // stokGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datagridStok);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "stokGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stokGor";
            this.Load += new System.EventHandler(this.stokGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gram;
        private System.Windows.Forms.DataGridViewTextBoxColumn milyem;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}