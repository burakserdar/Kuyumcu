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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        urunEkle ekle = null;
        stokGor stoksor = null;
        SatisSor satissor = null;
        urunSatis urunsatis = null;
        UrunGuncelleSil urunguncelle = null;
        kategoriEkleSil kategoriekle = null;


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["urunEkle"] == null)
            {
                ekle = new urunEkle();
                ekle.Show();
            }
            else
            {
                ekle.Activate();
            }
        }

        private void btnStokSor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["stokGor"] == null)
            {
                stoksor = new stokGor();
                stoksor.Show();
            }
            else
            {
                stoksor.Activate();
            }
        }

        private void btnSatisSor_Click(object sender, EventArgs e)
        {
            
                if (Application.OpenForms["SatisSor"] == null)
                {
                    satissor = new SatisSor();
                    satissor.Show();
                }
                else
                {
                    satissor.Activate();
                }
            
        }

        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["urunSatis"] == null)
            {
                urunsatis = new urunSatis();
                urunsatis.Show();
            }
            else
            {
                urunsatis.Activate();
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunGuncelleSil"] == null)
            {
                urunguncelle = new UrunGuncelleSil();
                urunguncelle.Show();
            }
            else
            {
                urunguncelle.Activate();
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["kategoriEkleSil"] == null)
            {
                kategoriekle = new kategoriEkleSil();
                kategoriekle.Show();
            }
            else
            {
                kategoriekle.Activate();
            }
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
