using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sereflikochisar
{
    public partial class SatisSor : Form
    {
        public SatisSor()
        {
            InitializeComponent();
        }

        DataTable dt = null;
        SatisBL satis = new SatisBL();
        private void satisSor_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dt = satis.satisSor();
            dataGridView1.DataSource = dt;
            label5.Text = dt.Compute("sum(gram)", "").ToString();
            label7.Text = dt.Compute("count(ayarID)", "").ToString();
            label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();

            comboBox1.Text = "Hepsi";

            comboBox2.DataSource = satis.comboGetir("select kategoriID,kategoriAd from tblKategori", comboBox2);
            comboBox2.DisplayMember = "kategoriAd";
            comboBox2.ValueMember = "kategoriID";




            comboBox3.DataSource = satis.comboGetir("select firmaID,firmaAd from tblFirma", comboBox3);
            comboBox3.DisplayMember = "firmaAd";
            comboBox3.ValueMember = "firmaID";


           
            if (int.Parse(label7.Text)%100==0)
            {
                MessageBox.Show("Ooo hadi yine iyisin, bayaa bişey satmışsın, hayırlı işler :)"); //dükkan sahibi arkadasım oluyor da :)
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ParametreModel param = new ParametreModel { tarih1 = dateTimePicker1.Value.Date, tarih2 = dateTimePicker2.Value.Date, payar = comboBox1.SelectedItem.ToString(), pkategori = comboBox2.SelectedValue.ToString(), pfirma = comboBox3.SelectedValue.ToString() };



            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && comboBox3.SelectedIndex != 0)
            {
               
                dt = satis.Listele("Select tblStok.satisfiyat, tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where tblStok.ayarID=@p1 and tblStok.kategoriID=@p2 and tblStok.firmaID=@p3  and  cikistarih between @tarih1 AND  @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
               
                dt = satis.Listele("Select tblStok.satisfiyat, tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where   cikistarih between @tarih1 AND  @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex != 0 && comboBox3.SelectedIndex != 0)
            {
                dt = satis.Listele("Select tblStok.satisfiyat,tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join tblKategori on tblKategori.kategoriID = tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID = tblStok.firmaID where tblStok.kategoriID = @p2 and tblStok.firmaID = @p3  and cikistarih between @tarih1 AND @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex != 0)
            {
                dt = satis.Listele("Select tblStok.satisfiyat,tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join tblKategori on tblKategori.kategoriID = tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID = tblStok.firmaID where tblStok.firmaID = @p3 and cikistarih between @tarih1 AND @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex != 0 && comboBox3.SelectedIndex == 0)
            {
                dt = satis.Listele("Select tblStok.satisfiyat,tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where  tblStok.kategoriID=@p2  and  cikistarih between @tarih1 AND  @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();
            }
            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                dt = satis.Listele("Select tblStok.satisfiyat,tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where  tblStok.ayarID=@p1  and  cikistarih between @tarih1 AND  @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();

            }
            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && comboBox3.SelectedIndex == 0)
            {
                dt = satis.Listele("Select tblStok.satisfiyat,tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where  tblStok.ayarID=@p1  and tblStok.KategoriID=@p2 and  cikistarih between @tarih1 AND  @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();

            }

            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex != 0)
            {
                dt = satis.Listele("Select tblStok.satisfiyat,tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where  tblStok.ayarID=@p1 and tblStok.firmaID=@p3  and  cikistarih between @tarih1 AND  @tarih2", param);
                dataGridView1.DataSource = dt;
                label5.Text = dt.Compute("sum(gram)", "").ToString();
                label7.Text = dt.Compute("count(ayarID)", "").ToString();
                label9.Text = dt.Compute("sum(satisfiyat)", "").ToString();

                //-çözüldü-comboboxta selected item yerine selectedtext deyince calısmıyor
                //-çözüldü-comboboxa "hepsi"ni row olarak eklemek
                //veritabanında mstudioda tarihi between ile kullanmak
                //-çözüldü-tek bir datatable ile sql command kullanmadan.
                //-çözüldü-datatable'dan gelen veri üzerinden sum+count işlemi yapmak??
                //-çözüldü-gram milyemi string yaptm yoksa float üzerinden virgül koymuyordu-tekrar değişti...
                

            }
          

        }


    }
}
