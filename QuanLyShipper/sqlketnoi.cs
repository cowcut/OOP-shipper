using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyShipper
{
    public class Sqlketnoi
    {

        private SqlConnection connection;
        private SqlCommand cmd;

        public Sqlketnoi()
        {
            string connectionString = @"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = connection;
        }

        public SqlCommand Cmd
        {
            get { return cmd; }
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=LAPTOP-MPPJ3B2F\RENTRE;Initial Catalog=QuanLyShipper;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
