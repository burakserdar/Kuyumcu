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
    class satisBL
    {
        Helper hlp = new Helper();
        stokModel s = new stokModel();
        parametreModel param = new parametreModel();

        DataTable dt = null;


        public DataTable satisSor()
        {
            return hlp.GetDataTable("Select tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd, tblStok.cikistarih from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where cikistarih is not null", null);
        }
        public DataTable comboGetir(string cmdtext,ComboBox combo)
        {
           dt=hlp.GetDataTable(cmdtext, null);
            DataRow row = dt.NewRow();
            row[1] = "Hepsi";
            dt.Rows.InsertAt(row, 0);
            combo.DataSource = dt;
            return dt;
            
        }

        public SqlParameter[] Parametre(parametreModel param)
        {
            SqlParameter[] p = {new SqlParameter("@tarih1", param.tarih1),
                new SqlParameter("@tarih2", param.tarih2),
                new SqlParameter("@p1", param.payar),
                new SqlParameter("@p2", param.pkategori),
                new SqlParameter("@p3", param.pfirma)};
            return p;
            

        }
        public DataTable Listele(string cmdtext,parametreModel param)
        {
           SqlParameter[] p= Parametre(param);
            return hlp.GetDataTable(cmdtext, p);
        }

        public stokModel satisBilgiGetir(string barkod)
        {
            try
            {
                stokModel sm = null;
                SqlParameter[] p = { new SqlParameter("@barkod", barkod) };
                SqlDataReader dr = hlp.ExecuteReader("Select tblStok.ayarID,tblKategori.kategoriAd,tblStok.gram, tblStok.milyem, tblFirma.firmaAd from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where tblStok.barkod=@barkod", p);
                if (dr.Read())
                {
                    sm = new stokModel { ayarID = Convert.ToInt32(dr[0]), kategoriAd = dr[1].ToString(), gram = dr[2].ToString(), milyem = dr[3].ToString(), firmaAd = dr[4].ToString() };
                }
                dr.Close();
                return sm;
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
    }
}
