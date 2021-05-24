using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductManagementSytem
{
    public class DAL: IDisposable
    {
        SqlConnection sqlConn = null;
        public bool IsConnected { get; private set; }

        public DAL()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnString"].ConnectionString;

            IsConnected = false;
            try
            {
                sqlConn.Open();
                IsConnected = true;
            }
            catch (Exception)
            {
                //REPORT AN OCCURRENCE OF AN ERROR
                throw;
            }
        }

        void IDisposable.Dispose()
        {
            sqlConn.Close();
        }


        public DataTable GetDataTable(string spName, SqlParameter[] param = null)
        {
            using (SqlCommand cmd = new SqlCommand(spName, sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                    cmd.Parameters.AddRange(param);

                try
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }


        public bool ExecuteNonQuery(string spName, SqlParameter[] param = null)
        {
            bool isSuccess = false;
            using (SqlCommand cmd = new SqlCommand(spName, sqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (param != null)
                    cmd.Parameters.AddRange(param);

                try
                {
                    cmd.ExecuteNonQuery();
                    isSuccess = true;
                }
                catch (Exception ex)
                {
                }
            }

            return isSuccess;
        }
    }
}