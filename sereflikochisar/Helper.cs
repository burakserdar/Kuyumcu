using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sereflikochisar
{
    public class Helper
    {
        SqlConnection cn = null;

        //static readonly Helper instance = new Helper();//Singleton Design Pattern  
        //public static Helper Instance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}

        string ad =SystemInformation.UserName;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            try
            {
                using (cn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = kuyumcuDB; Integrated Security = true;"))
                {
                    using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                            
                        }
                        OpenConnection();
                        
                        int sonuc = cmd.ExecuteNonQuery();
                        return sonuc;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
           
        }
       
       

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = kuyumcuDB; Integrated Security = true;");
                using (SqlCommand cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    OpenConnection();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);

                }

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

        void OpenConnection()
        {
            if (cn != null && cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }

        void CloseConnection()
        {
            if (cn != null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        public DataTable GetDataTable(string cmdtext, SqlParameter[] p)
        {
            using (cn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = kuyumcuDB; Integrated Security = true;"))
            {


                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);

                }
              

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();

             
                return dt;
            }


        }
        public DataTable GetCombo(string cmdtext, SqlParameter[] p,ComboBox combo)
        {
            using (cn = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = kuyumcuDB; Integrated Security = true;"))
            {


                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);

                }


                DataTable dt = new DataTable();
                da.Fill(dt);

               
               
                cn.Close();


                return dt;
            }


        }
    }
}

