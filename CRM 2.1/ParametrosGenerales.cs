using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRM_2._1
{
    class ParametrosGenerales
    {
        public static SqlConnection ConexionSqlGlobal = new SqlConnection(@"Data Source=DESKTOP-P8BGO4H\LOCAL;Initial Catalog=CRM;Integrated Security=True");
    }
}
