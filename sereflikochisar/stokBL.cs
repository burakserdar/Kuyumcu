using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sereflikochisar
{
    class stokBL
    {

        Helper hlp = new Helper();
      
       
        public bool urunEkle(stokModel s)
        {
            try
            {
                SqlParameter[] p = {new SqlParameter("@ayar",s.ayarID),
                new SqlParameter("@kategori",s.kategoriID),
                new SqlParameter("@gram",s.gram),
                new SqlParameter("@milyem",s.milyem),
                new SqlParameter("@giristarih",s.giristarih),
                new SqlParameter("@firma",s.firmaID),
                

            };
                return hlp.ExecuteNonQuery("Insert into tblStok(ayarID,kategoriID,gram,milyem,giristarih,firmaID)values(@ayar,@kategori,@gram,@milyem,@giristarih,@firma);", p) > 0;
                
            }
            catch (SqlException)
            {
#if DEBUG
                throw;
#endif
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable stokGetir()
        {
            return hlp.GetDataTable("Select tblStok.ayarID  ,tblKategori.kategoriAd ,tblStok.gram , tblStok.milyem , tblFirma.firmaAd, tblStok.giristarih, tblStok.barkod  from tblStok inner join  tblKategori on tblKategori.kategoriID=tblStok.kategoriID  inner join tblFirma on tblFirma.firmaID=tblStok.firmaID where cikistarih is  null", null);
        }
        public bool KategoriEkle(kategoriModel k)
        {
            try
            {
                SqlParameter[] p = {new SqlParameter("@kategoriad",k.kategoriAd)
                
              

            };
                return hlp.ExecuteNonQuery("Insert into tblKategori(kategoriAd)values(@kategoriad)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public bool FirmaEkle(firmaModel f)
        {
            try
            {
                SqlParameter[] p = {new SqlParameter("@firmaad",f.firmaAd)



            };
                return hlp.ExecuteNonQuery("Insert into tblFirma(firmaAd)values(@firmaad)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }

        
        public int KategoriSil(int kategoriid)
        {
            SqlParameter[] p = {new SqlParameter("@kategoriid",kategoriid)



            };
            return hlp.ExecuteNonQuery("Delete from tblKategori where kategoriID=@kategoriid ",p);
        }
        public int FirmaSil(int firmaid)
        {
            SqlParameter[] p = {new SqlParameter("@firmaid",firmaid)



            };
            return hlp.ExecuteNonQuery("Delete from tblFirma where firmaID=@firmaid ", p);
        }
        public int IDno(SqlParameter[] p)
        {
            int idno=0;
            try
            {
                
                SqlDataReader dr = hlp.ExecuteReader("Select MAX(urunID)  from tblStok", p);
                if (dr.Read())
                {
                   idno=Convert.ToInt32(dr[0]);
                }
                dr.Close();
                return idno ;
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
