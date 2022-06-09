using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FitnessCenterAutomation
{
    public class Sql
    {
        public SqlConnection conn()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-C45MJKA\SQLEXPRESS;Initial Catalog=FitnessCenterDB;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
