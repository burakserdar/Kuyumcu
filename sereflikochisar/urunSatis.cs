using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sereflikochisar
{
    public partial class urunSatis : Form
    {
        string hata;
        public urunSatis()
        {
            InitializeComponent();
        }
        SatisBL sb = new SatisBL();

        urunEkle frm = (urunEkle)Application.OpenForms["urunEkle"];
        MainMenu frm2 = (MainMenu)Application.OpenForms["MainMenu"];
        
            

        private void urunSatis_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtbarkod;
            lblAyar.Visible = false;
            lblAyar2.Visible = false;
            lblGram.Visible = false;
            lblGram2.Visible = false;
            lblFirma.Visible = false;
            lblFirma2.Visible = false;
            lblKategori.Visible = false;
            lblKategori2.Visible = false;
            lblMilyem.Visible = false;
            lblMilyem2.Visible = false;
            label1.Visible = false;
            btnSatis.Visible = false;
            txtSatisFiyat.Visible = false;


            veriCekAsync();

           
            
       

          

        }
        private async  void veriCekAsync()
        {
            this.Cursor = Cursors.WaitCursor;
         // await  Task.Delay(5000);
            
            try
            {
                altinkaynak.DataServiceSoapClient altin = new altinkaynak.DataServiceSoapClient();
                altinkaynak.AuthHeader yetki = new altinkaynak.AuthHeader();
                yetki.Username = "AltinkaynakWebServis";
                yetki.Password = "AltinkaynakWebServis";
                string veri =(await altin.GetGoldAsync(yetki)).GetGoldResult;


                XmlReader reader = XmlReader.Create(new StringReader(veri));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(veri);


                XmlNode node = doc.DocumentElement.SelectSingleNode("Kur[Kod = \"B_T\"]");
                var aliss = decimal.Parse(node["Alis"].InnerText);
                var satiss = decimal.Parse(node["Satis"].InnerText);
                var aciklama = node["Aciklama"].InnerText;

                label7.Text = aciklama;
                label10.Text = aliss.ToString("#.##");  //dispatch thread bak...
                label11.Text = satiss.ToString("#.##");


            }
            catch (Exception)
            {

                MessageBox.Show("Alış-Satış Fiyat Verileri Çekilemedi!! İnternet bağlantınızı kontrol ediniz ulen!! :)");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void btnSatis_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Satış yapılacak. Emin misiniz?", "Satış Onayı", MessageBoxButtons.YesNo);

            try
            {
                if (cvp == DialogResult.Yes)
                {
                    DateTimePicker tarihcikis = new DateTimePicker();
                    string barkod = txtbarkod.Text;
                    stokModel s = new stokModel { cikistarih = tarihcikis.Value.Date, satisfiyat = int.Parse(txtSatisFiyat.Text), barkod = barkod };

                    if (sb.SatisYap(s))
                    {
                        MessageBox.Show("Satış Yapıldı");
                    }
                }
            }
            catch (Exception ex)
            {
                hata = ex.Message;
                MessageBox.Show(hata);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string barkod = txtbarkod.Text;
                stokModel sm = sb.satisBilgiGetir(barkod);
                lblAyar.Text = sm.ayarID.ToString();
                lblKategori.Text = sm.kategoriAd;
                lblFirma.Text = sm.firmaAd;
                lblMilyem.Text = sm.milyem.ToString();
                lblGram.Text = sm.gram.ToString();



                double a = Convert.ToDouble(sm.milyem);
                double b = 0.912;
                double c = double.Parse(label11.Text, System.Globalization.CultureInfo.InvariantCulture);
                double d = Convert.ToDouble(sm.gram);
                txtTutar.Text = ((a / b) * c * d).ToString("#");

                lblAyar.Visible = true;
                lblAyar2.Visible = true;
                lblGram.Visible = true;
                lblGram2.Visible = true;
                lblFirma.Visible = true;
                lblFirma2.Visible = true;
                lblKategori.Visible = true;
                lblKategori2.Visible = true;
                lblMilyem.Visible = true;
                lblMilyem2.Visible = true;
                label1.Visible = true;
                btnSatis.Visible = true;
                txtSatisFiyat.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Barkod veritabanında bulunamadı!");
            }


        }

        private void txtbarkod_TextChanged(object sender, EventArgs e)
        {
            if (txtbarkod.TextLength == 6)
            {
                btnGet.PerformClick();
            }
        }
    }
}
