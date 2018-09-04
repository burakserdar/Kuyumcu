namespace sereflikochisar
{
    partial class AnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenu));
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnStokSor = new System.Windows.Forms.Button();
            this.btnSatisSor = new System.Windows.Forms.Button();
            this.btnUrunSat = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(145, 425);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(148, 78);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnStokSor
            // 
            this.btnStokSor.Location = new System.Drawing.Point(507, 425);
            this.btnStokSor.Name = "btnStokSor";
            this.btnStokSor.Size = new System.Drawing.Size(148, 78);
            this.btnStokSor.TabIndex = 1;
            this.btnStokSor.Text = "Stok Sorgula";
            this.btnStokSor.UseVisualStyleBackColor = true;
            this.btnStokSor.Click += new System.EventHandler(this.btnStokSor_Click);
            // 
            // btnSatisSor
            // 
            this.btnSatisSor.Location = new System.Drawing.Point(866, 425);
            this.btnSatisSor.Name = "btnSatisSor";
            this.btnSatisSor.Size = new System.Drawing.Size(148, 78);
            this.btnSatisSor.TabIndex = 2;
            this.btnSatisSor.Text = "Satış Sorgula";
            this.btnSatisSor.UseVisualStyleBackColor = true;
            this.btnSatisSor.Click += new System.EventHandler(this.btnSatisSor_Click);
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.Location = new System.Drawing.Point(145, 522);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(148, 78);
            this.btnUrunSat.TabIndex = 3;
            this.btnUrunSat.Text = "Ürün Satışı";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(507, 522);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(148, 78);
            this.btnUrunGuncelle.TabIndex = 4;
            this.btnUrunGuncelle.Text = "Ürün Güncelle-Sil";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(866, 522);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(148, 78);
            this.btnKategoriEkle.TabIndex = 5;
            this.btnKategoriEkle.Text = "Kategori Ekle-Sil";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "ŞerefliKoçhisar Kuyumculuk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 360);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunSat);
            this.Controls.Add(this.btnSatisSor);
            this.Controls.Add(this.btnStokSor);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaMenu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnStokSor;
        private System.Windows.Forms.Button btnSatisSor;
        private System.Windows.Forms.Button btnUrunSat;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}