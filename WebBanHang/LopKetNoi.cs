using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebBanHang
{
    public class LopKetNoi
    {
        SqlConnection connect;
        private void moKN()
        {
            string sqlconnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DOAN_chinh\WebBanHang\WebBanHang\App_Data\BanHang.mdf;Integrated Security=True";
            connect = new SqlConnection(sqlconnect);
            connect.Open();
       
        }

        private void dongKN()
        {
            if (connect.State == ConnectionState.Open) connect.Close();
        }

        public DataTable layDL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                moKN();
                SqlDataAdapter adt = new SqlDataAdapter(sql, connect);
                adt.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongKN();
            }
            
            return dt;

        }
        public int capnhat(string sql)
        {
            int kq = 0;
            try
            {
                moKN();
                SqlCommand command = new SqlCommand(sql, connect);
                kq = command.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                dongKN();
            }
            return kq;
        }

        public string layCot(string sql)
        {
            string kq = "";
            try
            {
                moKN();
                SqlCommand cmd = new SqlCommand(sql, connect);
                kq = ((string)cmd.ExecuteScalar());
            }
            catch
            {

            }
            finally
            {
                dongKN();
            }


            return kq;
        }
        public float layCot_float(string sql)
        {
            float kq = 0;
            try
            {
                moKN();
                SqlCommand cmd = new SqlCommand(sql, connect);
                object kq_layra = cmd.ExecuteScalar();
                if (kq_layra!=null && kq_layra!= DBNull.Value)
                {
                    kq = Convert.ToSingle(kq_layra);
                }
                else
                {
                    kq = 1;
                }
               
            }
            catch
            {

            }
            finally
            {
                dongKN();
            }


            return kq;
        }

    }
}