using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=VUONG\SQLSERVERDB;Initial Catalog=QuanLyHocSinh;Persist Security Info=True;User ID=sa;Password=123456");
    }
}
