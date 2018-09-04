using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sereflikochisar
{
    public partial class urunEkle : Form
    {
        public urunEkle()
        {
            InitializeComponent();
        }
        Helper hlp = new Helper();
        SatisBL satis = new SatisBL();
        string barkodyazisi;

        private void urunEkle_Load(object sender, EventArgs e)
        {


            cmbAyar.Text = "seçiniz";

            cmbKategori.DataSource = hlp.GetDataTable("select kategoriID,kategoriAd from tblKategori", null);
            cmbKategori.DisplayMember = "kategoriAd";
            cmbKategori.ValueMember = "kategoriID";


            cmbFirma.DataSource = hlp.GetDataTable("select firmaID, firmaAd from tblFirma", null);
            cmbFirma.DisplayMember = "firmaAd";
            cmbFirma.ValueMember = "firmaID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cvp = MessageBox.Show("Ürün Eklenecek. Emin misiniz?", "Ürün Ekleme", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    DateTimePicker datetimepicker1 = new DateTimePicker();
                    stokModel stok = new stokModel { ayarID = Convert.ToInt32(cmbAyar.Text), kategoriID = Convert.ToInt32(cmbKategori.SelectedValue), gram = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture), milyem = decimal.Parse(textBox2.Text, CultureInfo.InvariantCulture), giristarih = datetimepicker1.Value.Date, firmaID = Convert.ToInt32(cmbFirma.SelectedValue) };
                    stokBL stk = new stokBL();
                    if (stk.urunEkle(stok))
                    {
                        int urunid = stk.IDno(null);
                        string barkodno = String.Format("{0:D6}", urunid);
                        stokModel s = new stokModel { barkod = barkodno, urunID = urunid };
                        satis.BarkodEkle(s);
                        label7.Text = barkodno;
                        barkodyazisi = string.Concat(urunid, cmbKategori.Text);
                        Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                        pictureBox1.Image = barcode.Draw(label7.Text, 30);
                        pictureBox1.Size = pictureBox1.Image.Size;
                        #region digerbarkod
                        //Guid.NewGuid7
                        //ZXing.BarcodeWriter barcode2 = new ZXing.BarcodeWriter();
                        //barcode2.Format = ZXing.BarcodeFormat.CODE_128;
                        //pictureBox1.Image = barcode2.Write(label7.Text);

                        //pictureBox1.Image = Resize_Picture(pictureBox1.Image, (int)(pictureBox1.Image.Width * 0.7f), 0);

                        //var setting = new Spire.Barcode.BarcodeSettings();
                        //setting.Type = Spire.Barcode.BarCodeType.Code128;
                        //setting.Data = label7.Text;
                        //setting.AutoResize = false;
                        ////setting.ImageHeight = 8;
                        //setting.ShowTopText = false;
                        //setting.Unit = GraphicsUnit.Millimeter;
                        //setting.X = 15;
                        //Spire.Barcode.BarCodeGenerator barcode3 = new Spire.Barcode.BarCodeGenerator(setting);
                        //pictureBox1.Image = barcode3.GenerateImage(); 
                        #endregion
                        PrintDocument print = new PrintDocument();
                        var paperSize = new PaperSize("USER", 80, 20);
                        paperSize.RawKind = (int)PaperKind.Custom;
                        //print.PrinterSettings.DefaultPageSettings.PaperSize = paperSize;
                        //print.PrinterSettings.DefaultPageSettings.Margins = new Margins(7, 0, 0, 0);
                        print.PrintPage += Print_PrintPage;
                        print.Print();
                        MessageBox.Show("Ekleme İşlemi Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }

                #region EskiKod
                string yazi = cmbKategori.Text;
                yazi = yazi.ToLower();
                yazi = yazi.Replace('ö', 'o');
                yazi = yazi.Replace('ç', 'c');
                yazi = yazi.Replace('ü', 'u');
                yazi = yazi.Replace('ğ', 'g');
                yazi = yazi.Replace('ş', 's');
                yazi = yazi.Replace('ı', 'i');
                yazi = yazi.Replace(' ', '_');
                #endregion
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }

        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.PageUnit = GraphicsUnit.Millimeter;


                e.Graphics.DrawImage(pictureBox1.Image, 3, 0, 14, 5);
                //e.Graphics.DrawImageUnscaled(pictureBox1.Image, 11, 0);

                e.Graphics.DrawString(barkodyazisi, new Font("Arial", 7), Brushes.Black, new PointF(20, 0));
                e.Graphics.DrawString(textBox1.Text, new Font("Arial", 7), Brushes.Black, new PointF(20, 3));
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }


        }

        #region eskikod2
        public static Bitmap Resize_Picture(Image bmp, int FinalWidth, int FinalHeight) 
        
        {
            System.Drawing.Bitmap NewBMP;
            System.Drawing.Graphics graphicTemp;

            int iWidth;
            int iHeight;
            if ((FinalHeight == 0) && (FinalWidth != 0))
            {
                iWidth = FinalWidth;
                iHeight = (bmp.Size.Height * iWidth / bmp.Size.Width);
            }
            else if ((FinalHeight != 0) && (FinalWidth == 0))
            {
                iHeight = FinalHeight;
                iWidth = (bmp.Size.Width * iHeight / bmp.Size.Height);
            }
            else
            {
                iWidth = FinalWidth;
                iHeight = FinalHeight;
            }

            NewBMP = new System.Drawing.Bitmap(iWidth, iHeight);
            graphicTemp = System.Drawing.Graphics.FromImage(NewBMP);
            graphicTemp.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            graphicTemp.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphicTemp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphicTemp.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphicTemp.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            graphicTemp.DrawImage(bmp, 0, 0, iWidth, iHeight);
            graphicTemp.Dispose();
            //System.Drawing.Imaging.EncoderParameters encoderParams = new System.Drawing.Imaging.EncoderParameters();
            //System.Drawing.Imaging.EncoderParameter encoderParam = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, ImageQuality);
            //encoderParams.Param[0] = encoderParam;
            //System.Drawing.Imaging.ImageCodecInfo[] arrayICI = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();
            //for (int fwd = 0; fwd <= arrayICI.Length - 1; fwd++)
            //{
            //    if (arrayICI[fwd].FormatDescription.Equals("JPEG"))
            //    {
            //        NewBMP.Save(Des, arrayICI[fwd], encoderParams);
            //    }
            //}

            //NewBMP.Dispose();
            //bmp.Dispose();
            return NewBMP;
        }
        #endregion
        private void button3_Click(object sender, EventArgs e)
        {
            urunSatis sat = new urunSatis();
            sat.Show();

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            //string sayi = txtsayi.Text;
            //txtsayi.Text = String.Format("{0:D6}", int.Parse(sayi));
            // txtsayi.Text = sayi.PadLeft(6, '0');
        }
    }
}
