using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sereflikochisar
{
    public partial class kategoriEkleSil : Form
    {
        public kategoriEkleSil()
        {
            InitializeComponent();
        }
        Helper hlp = new Helper();
        stokBL firmakategoriekle = new stokBL();

        private void kategoriEkleSil_Load(object sender, EventArgs e)
        {

            cmbKategori.DataSource = hlp.GetDataTable("select kategoriID,kategoriAd from tblKategori", null);
            cmbKategori.DisplayMember = "kategoriAd";
            cmbKategori.ValueMember = "kategoriID";


            cmbFirma.DataSource = hlp.GetDataTable("select firmaID, firmaAd from tblFirma", null);
            cmbFirma.DisplayMember = "firmaAd";
            cmbFirma.ValueMember = "firmaID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kategori eklenecek. Emin misiniz?", "Kategori Ekleme", MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {
                kategoriModel kategori = new kategoriModel { kategoriAd = txtkategori.Text };
                if (firmakategoriekle.KategoriEkle(kategori))
                {
                    MessageBox.Show("Yeni Kategori Eklendi");
                }

                else
                {
                    MessageBox.Show("Hata");
                }

            }
            else
            {
                MessageBox.Show("İşlem Sonuçlanmadı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Firma eklenecek. Emin misiniz?", "Firma Ekleme", MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {
                firmaModel firma = new firmaModel { firmaAd = txtFirma.Text };
                if (firmakategoriekle.FirmaEkle(firma))
                {
                    MessageBox.Show("Yeni Kategori Eklendi");
                }

                else
                {
                    MessageBox.Show("Hata");
                }

            }
            else
            {
                MessageBox.Show("İşlem Sonuçlanmadı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kategori silinecek. Dikkat Eğer bu kategoriyi silerseniz o kategoride kayıtlı tüm stok silinecektir. Emin misiniz?", "Kategori Ekleme", MessageBoxButtons.YesNo);
            if (cvp == DialogResult.Yes)
            {
                stokBL sil = new stokBL();
                int id = Convert.ToInt32(cmbKategori.SelectedValue);
                if (sil.KategoriSil(id)>0)
                {
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cvp = MessageBox.Show("Firma silinecek. Dikkat Eğer bu firmayı silerseniz o kategoride kayıtlı tüm stok silinecektir. Emin misiniz?", "Kategori Ekleme", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    stokBL sil = new stokBL();
                    int id = Convert.ToInt32(cmbFirma.SelectedValue);
                    if (sil.FirmaSil(id) > 0)
                    {
                        MessageBox.Show("Silme İşlemi Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
         
        }

        private void kategoriEkleSil_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Dispose();
        }
    }
}
