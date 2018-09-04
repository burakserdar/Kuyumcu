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
    public partial class stokGor : Form
    {

        DataTable dt = null;
        stokBL stok = new stokBL();
        SatisBL satis = new SatisBL();
        public stokGor()
        {
            InitializeComponent();
        }

        Helper hlp = new Helper();
        private void stokGor_Load(object sender, EventArgs e)
        {

            datagridStok.AutoGenerateColumns = false;
            dt = stok.stokGetir();
            datagridStok.DataSource = dt;

            comboBox1.Text = "Hepsi";

            comboBox2.DataSource = satis.comboGetir("select kategoriID,kategoriAd from tblKategori", comboBox2);
            comboBox2.DisplayMember = "kategoriAd";
            comboBox2.ValueMember = "kategoriID";




            comboBox3.DataSource = satis.comboGetir("select firmaID,firmaAd from tblFirma", comboBox3);
            comboBox3.DisplayMember = "firmaAd";
            comboBox3.ValueMember = "firmaID";
            label5.Text = dt.Compute("sum(gram)", "").ToString();
            label7.Text = dt.Compute("count(ayarID)", "").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParametreModel param = new ParametreModel { tarih1 = dateTimePicker1.Value.Date, tarih2 = dateTimePicker2.Value.Date, payar = comboBox1.SelectedItem.ToString(), pkategori = comboBox2.SelectedValue.ToString(), pfirma = comboBox3.SelectedValue.ToString() };


            string sorgu = @"Select tblStok.barkod, tblStok.giristarih, tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih 
from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  
inner join tblFirma on tblFirma.firmaID=tblStok.firmaID 
where  cikistarih is null and  (giristarih between @tarih1 AND  @tarih2)";
            if (comboBox1.SelectedIndex !=0)
            {
                sorgu += " and tblStok.ayarID=@p1"; // and'den önce bosluk koymazsam önceki sorgu stringinden sonra hemen bitişiginden baslıyor ve hata veriyor. O yüzden bosluk var.
            }
            if (comboBox2.SelectedIndex != 0)
            {
                sorgu += " and tblStok.kategoriID=@p2";
            }
            if (comboBox3.SelectedIndex != 0)
            {
                sorgu += " and tblStok.firmaID=@p3";
            }
            dt = satis.Listele(sorgu, param);
            datagridStok.DataSource = dt;
            label5.Text = dt.Compute("sum(gram)", "").ToString();
            label7.Text = dt.Compute("count(ayarID)", "").ToString();
            
            // String builder ile eğer bi stringi cok kere modify edeceksen bunu string builderla yapıp en sonunda son halini isteyebilriz. Append ile...
        }
    }
}
