using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRM_2._1
{
    class DATOSASESOR : Forms.Pautas
    {
        SqlConnection cnn;
        SqlCommand cm;
        private SqlDataReader dr;

        public DATOSASESOR()
        {
            cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            cnn.Open();
        }

        public void rellenarasesor(ComboBox cb)
        {
            cm = new SqlCommand("Select Nombre from asesores", cnn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["Nombre"].ToString());
            }
            cb.SelectedItem = 0;
            cnn.Close();
        }
    }
}
