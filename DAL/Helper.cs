using System;
using System.Data.SqlClient;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn = null;

       // static readonly Helper instance = new Helper();//Singleton Design Pattern  
        public static Helper Instance
        {
            get
            {
                return instance;
            }
        }

        Helper()
        {

            // Debug.WriteLine("Nesne oluştu");
        }

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
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
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
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
            try
            {
                using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                    if (p != null)
                    {
                        da.SelectCommand.Parameters.AddRange(p);
                    }
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
