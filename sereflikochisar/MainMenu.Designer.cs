namespace sereflikochisar
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
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokDurumunuGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılanÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışıYapılanÜrünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünGüncelleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokİşlemleriToolStripMenuItem,
            this.satılanÜrünlerToolStripMenuItem,
            this.kategoriEkleSilToolStripMenuItem,
            this.ürünGüncelleSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1325, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünEkleToolStripMenuItem,
            this.stokDurumunuGörToolStripMenuItem});
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.stokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri";
            // 
            // yeniÜrünEkleToolStripMenuItem
            // 
            this.yeniÜrünEkleToolStripMenuItem.Name = "yeniÜrünEkleToolStripMenuItem";
            this.yeniÜrünEkleToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.yeniÜrünEkleToolStripMenuItem.Text = "Yeni Ürün Ekle";
            this.yeniÜrünEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünEkleToolStripMenuItem_Click);
            // 
            // stokDurumunuGörToolStripMenuItem
            // 
            this.stokDurumunuGörToolStripMenuItem.Name = "stokDurumunuGörToolStripMenuItem";
            this.stokDurumunuGörToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.stokDurumunuGörToolStripMenuItem.Text = "Stok Durumunu Gör";
            this.stokDurumunuGörToolStripMenuItem.Click += new System.EventHandler(this.stokDurumunuGörToolStripMenuItem_Click);
            // 
            // satılanÜrünlerToolStripMenuItem
            // 
            this.satılanÜrünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışıYapılanÜrünlerToolStripMenuItem});
            this.satılanÜrünlerToolStripMenuItem.Name = "satılanÜrünlerToolStripMenuItem";
            this.satılanÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.satılanÜrünlerToolStripMenuItem.Text = "Satılan Ürünler";
            // 
            // satışıYapılanÜrünlerToolStripMenuItem
            // 
            this.satışıYapılanÜrünlerToolStripMenuItem.Name = "satışıYapılanÜrünlerToolStripMenuItem";
            this.satışıYapılanÜrünlerToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.satışıYapılanÜrünlerToolStripMenuItem.Text = "Satışı Yapılan Ürünler";
            this.satışıYapılanÜrünlerToolStripMenuItem.Click += new System.EventHandler(this.satışıYapılanÜrünlerToolStripMenuItem_Click);
            // 
            // kategoriEkleSilToolStripMenuItem
            // 
            this.kategoriEkleSilToolStripMenuItem.Name = "kategoriEkleSilToolStripMenuItem";
            this.kategoriEkleSilToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.kategoriEkleSilToolStripMenuItem.Text = "Kategori Ekle-Sil";
            this.kategoriEkleSilToolStripMenuItem.Click += new System.EventHandler(this.kategoriEkleSilToolStripMenuItem_Click);
            // 
            // ürünGüncelleSilToolStripMenuItem
            // 
            this.ürünGüncelleSilToolStripMenuItem.Name = "ürünGüncelleSilToolStripMenuItem";
            this.ürünGüncelleSilToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.ürünGüncelleSilToolStripMenuItem.Text = "Ürün Güncelle-Sil";
            this.ürünGüncelleSilToolStripMenuItem.Click += new System.EventHandler(this.ürünGüncelleSilToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 663);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokDurumunuGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılanÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışıYapılanÜrünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünGüncelleSilToolStripMenuItem;
    }
}