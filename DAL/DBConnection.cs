using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("server=TRANVANHAIDUONG; uid=sa; pwd=123; database=datbancafe");
    }
}
