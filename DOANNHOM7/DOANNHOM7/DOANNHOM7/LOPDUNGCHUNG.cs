using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANNHOM7
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open(); // Mở kết nối ngay lập tức
            return conn;
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object LayGT(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public object DocGL(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public object LoadScalar(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                object result = comm.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

