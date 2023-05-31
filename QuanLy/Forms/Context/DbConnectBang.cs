using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMainMenu.Forms.Context
{
    public abstract class DbConnectBang
    {
        private readonly string connectionString;
        public DbConnectBang()
        {
            connectionString = "data source=.;initial catalog=QuanLyBangDK;integrated security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
