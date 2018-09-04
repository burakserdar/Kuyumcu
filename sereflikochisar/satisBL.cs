using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sereflikochisar
{
    class SatisBL
    {
        Helper hlp = new Helper();
        stokModel s = new stokModel();
        ParametreModel param = new ParametreModel();


        DataTable dt = null;


        public DataTable satisSor()
        {
            return hlp.GetDataTable("Select tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih,tblStok.satisfiyat from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where cikistarih is not null", null);
        }
        public DataTable comboGetir(string cmdtext, ComboBox combo)
        {
            dt = hlp.GetDataTable(cmdtext, null);
            DataRow row = dt.NewRow();
            row[1] = "Hepsi";
            dt.Rows.InsertAt(row, 0);
            combo.DataSource = dt;
            return dt;

        }

        public SqlParameter[] Parametre(ParametreModel param)
        {
            SqlParameter[] p = {new SqlParameter("@tarih1", param.tarih1),
                new SqlParameter("@tarih2", param.tarih2),
                new SqlParameter("@p1", param.payar),
                new SqlParameter("@p2", param.pkategori),
                new SqlParameter("@p3", param.pfirma)};
            return p;


        }
        public DataTable Listele(string cmdtext, ParametreModel param)
        {
            SqlParameter[] p = Parametre(param);
            return hlp.GetDataTable(cmdtext, p);
        }

        public stokModel satisBilgiGetir(string barkod)
        {
           
                stokModel sm = null;
                SqlParameter[] p = { new SqlParameter("@barkod", barkod) };
                SqlDataReader dr = hlp.ExecuteReader("Select tblStok.ayarID,tblKategori.kategoriAd, tblKategori.kategoriID, tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblFirma.firmaID from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where tblStok.barkod=@barkod", p);
                if (dr.Read())
                {
                    sm = new stokModel { ayarID = Convert.ToInt32(dr[0]), kategoriAd = dr[1].ToString(), kategoriID=Convert.ToInt32(dr[2]), gram =decimal.Parse(dr[3].ToString()), milyem =decimal.Parse(dr[4].ToString()), firmaAd = dr[5].ToString(),firmaID=Convert.ToInt32(dr[6]) };
                }
                dr.Close();
                return sm;
            
        



        }
        
        public bool SatisYap(stokModel s)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@cikistarih", s.cikistarih), new SqlParameter("@satisfiyat", s.satisfiyat), new SqlParameter("@barkod", s.barkod) };

                int sonuc = hlp.ExecuteNonQuery("Update tblStok Set cikistarih=@cikistarih,satisfiyat=@satisfiyat Where barkod=@barkod", p);
                return sonuc > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UrunGuncelle(stokModel s)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ayar", s.ayarID), new SqlParameter("@kategori", s.kategoriID), new SqlParameter("@firma", s.firmaID), new SqlParameter("@gram", s.gram), new SqlParameter("@milyem", s.milyem), new SqlParameter("@barkod", s.barkod) };

                int sonuc = hlp.ExecuteNonQuery("Update tblStok Set ayarID=@ayar,kategoriID=@kategori, firmaID=@firma,gram=@gram,milyem=@milyem Where barkod=@barkod", p);
                return sonuc > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool BarkodEkle(stokModel s)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@barkod", s.barkod), new SqlParameter("@urunID", s.urunID) };

                int sonuc = hlp.ExecuteNonQuery("Update tblStok Set barkod=@barkod Where urunID=@urunID", p);
                return sonuc > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UrunSil(string barkod)
        {
            try
            {
                SqlParameter[] p = {new SqlParameter("@barkod",barkod)



            };
                return hlp.ExecuteNonQuery("Delete from tblStok where barkod=@barkod ", p);
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
