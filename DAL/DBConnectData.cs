using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnectData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection conn = new SqlConnection(@"Chuỗi kết nối của sql server!!!");
            return conn;
        }
    }
}
