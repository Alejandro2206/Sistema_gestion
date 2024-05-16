using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRM_2._1
{
    class DATOSSERVICIOSD: Forms.Pautas
    {
        SqlConnection cnn;
        SqlCommand cm;
        private SqlDataReader dr;
        public DATOSSERVICIOSD()
        {
            cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            cnn.Open();
        }

        public void Completarservicio(ComboBox cb)
        {
            cm = new SqlCommand("Select Servicios from servicios", cnn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr["Servicios"].ToString());
            }
            cb.SelectedItem = 0;
            cnn.Close();
        }
    }
}
