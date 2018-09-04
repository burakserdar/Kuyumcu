using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sereflikochisar
{
    public partial class UrunGuncelleSil : Form
    {
        Helper hlp = new Helper();
        SatisBL satis = new SatisBL();
        stokModel sm = new stokModel();
        public UrunGuncelleSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                sm = satis.satisBilgiGetir(txtBarkod.Text);

                cmbAyar.SelectedItem = sm.ayarID.ToString();


                cmbKategori.DataSource = hlp.GetDataTable("select kategoriID,kategoriAd from tblKategori", null);
                cmbKategori.DisplayMember = "kategoriAd";
                cmbKategori.ValueMember = "kategoriID";
                cmbKategori.SelectedValue = sm.kategoriID;




                cmbFirma.DataSource = hlp.GetDataTable("select firmaID, firmaAd from tblFirma", null);
                cmbFirma.DisplayMember = "firmaAd";
                cmbFirma.ValueMember = "firmaID";
                cmbFirma.SelectedValue = sm.firmaID;

                string gram = sm.gram.ToString();
                string milyem = sm.milyem.ToString();


                gram = gram.Replace(',', '.');
                milyem = milyem.Replace(',', '.');
                txtGram.Text = gram;
                txtMilyem.Text = milyem;
                //cmbKategori.SelectedValue = sm.kategoriID;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }


        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Ürün Güncellenecek. Emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {



                stokModel s = new stokModel { barkod = txtBarkod.Text, ayarID = Convert.ToInt32(cmbAyar.SelectedItem), kategoriID = Convert.ToInt32(cmbKategori.SelectedValue), firmaID = Convert.ToInt32(cmbFirma.SelectedValue), gram = decimal.Parse(txtGram.Text), milyem = decimal.Parse(txtMilyem.Text) };

                if (satis.UrunGuncelle(s))
                {
                    MessageBox.Show("Güncelleme Yapıldı");
                }




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Ürüne ait tüm bilgiler silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {
                try
                {

                    if (satis.UrunSil(txtBarkod.Text) > 0)
                    {
                        MessageBox.Show("Ürün Silindi");
                    }
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show(hata);
                }


            }

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    decimal a = decimal.Parse(textBox1.Text);
        //    textBox2.Text = a.ToString();

        //   //decimal a= 0,925;
        //   // textBox1.Text = a.ToString();

        //   // textBox2.Text = milyem.Replace(',', '.');
        //   // txtGram.Text = gram;

        //}
    }
}
