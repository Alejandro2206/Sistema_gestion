using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
namespace CRM_2._1.Forms
{
    public partial class Pautas : Form
    {
        
        SqlCommand ComandoSQL;
        private SqlConnection cn;

        public Pautas()
        {
            InitializeComponent();
        }


        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from pautas", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
        }

        private void Pautas_Load(object sender, EventArgs e)
        {
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from pautas", ParametrosGenerales.ConexionSqlGlobal);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txt_id.Text = dt.Rows[0][0].ToString();


            }


            {
                DATOS dt = new DATOS();
                dt.rellenarCombobox(combocliente);
            }
            {
                DATOSASESOR dt = new DATOSASESOR();
                dt.rellenarasesor(cboasesorcomercial);
            }

            {
                DATOSSERVICIOS dt = new DATOSSERVICIOS();
                dt.Completarservicio(comboservicioA);
            }
            {
                DATOSSERVICIOSB dt = new DATOSSERVICIOSB();
                dt.Completarservicio(comboservicioB);
            }
            {
                DATOSSERVICIOSC dt = new DATOSSERVICIOSC();
                dt.Completarservicio(comboservicioC);
            }
            {
                DATOSSERVICIOSD dt = new DATOSSERVICIOSD();
                dt.Completarservicio(comboservicioD);
            }
            {
                DATOSSERVICIOSE dt = new DATOSSERVICIOSE();
                dt.Completarservicio(comboservicioE);
            }
            {
                DATOSSERVICIOSF dt = new DATOSSERVICIOSF();
                dt.Completarservicio(comboservicioF);
            }

            ConsultaDatosBD();




        }

        private void combocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            string cadcon = "Select *from clientes where Nombre = '" + combocliente.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, cnn);
            cnn.Open();

            SqlDataReader leer = cm.ExecuteReader();

            if (leer.Read() == true)
            {
                txt_telefono.Text = leer["Teléfono1"].ToString();
                txt_giro.Text = leer["Giro"].ToString();
                txt_razon.Text = leer["RazonSocial"].ToString();
                txt_correo.Text = leer["Correo-e"].ToString();
            }
            else
            {
                txt_telefono.Text = "";
                txt_giro.Text = "";
                txt_razon.Text = "";
                txt_correo.Text = string.Empty;

            }
            cnn.Close();


        }





        private void comboservicioA_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select*from servicios where Servicios ='" + comboservicioA.Text + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                costoA.Text = dr["$Costo"].ToString();
            }
            cnn.Close();
        }

        private void comboservicioB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select*from servicios where Servicios ='" + comboservicioB.Text + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                costoB.Text = dr["$Costo"].ToString();
            }
            cnn.Close();
        }

        private void comboservicioC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select*from servicios where Servicios ='" + comboservicioC.Text + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                costoC.Text = dr["$Costo"].ToString();
            }
            cnn.Close();
        }

        private void comboservicioD_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select*from servicios where Servicios ='" + comboservicioD.Text + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                costoD.Text = dr["$Costo"].ToString();
            }
            cnn.Close();
        }

        private void comboservicioE_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select*from servicios where Servicios ='" + comboservicioE.Text + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                costoE.Text = dr["$Costo"].ToString();
            }
            cnn.Close();

        }

        private void comboservicioF_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-P8BGO4H\\LOCAL;Initial Catalog=CRM;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select*from servicios where Servicios ='" + comboservicioF.Text + "'", cnn);
            cnn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read() == true)
            {
                costoF.Text = dr["$Costo"].ToString();
            }
            cnn.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("INSERT INTO pautas VALUES('" + txt_id.Text + "','" + cboasesorcomercial.Text + "','" + dateInicio.Value.ToString("yyyy/MM/dd").ToString() + "','" + dateFin.Value.ToString("yyyy/MM/dd").ToString() + "','" + combocliente.Text
                + "','" + txt_razon.Text + "','" + txt_telefono.Text + "','" + txt_correo.Text + "','" + txt_giro.Text + "','" + txt_direccion.Text + "','" + comboservicioA.Text + "','"
                + costoA.Text + "','" + comboservicioB.Text + "','" + costoB.Text + "','" + comboservicioC.Text + "','" + costoC.Text + "','" + comboservicioD.Text + "','" + costoD.Text + "','" + comboservicioE.Text + "','"
                + costoE.Text + "','" + comboservicioF.Text + "','" + costoF.Text + "','" + txt_insercionestotal.Text + "','" + txt_subtotal.Text + "','" + txt_iva.Text + "','" + txt_total.Text + "','" + txt_observaciones.Text + "')", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("La Pauta se ah Generado con Exito.", "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }
        private void ConsultaDatosBD()
        {
            string Sql = ("Select * from pautas");
            SqlDataAdapter CargadorDatos = new SqlDataAdapter(Sql, ParametrosGenerales.ConexionSqlGlobal);
            DataSet Datos = new DataSet();
            CargadorDatos.Fill(Datos, "f");
            Vista_pautas.DataSource = Datos.Tables["f"];

        }



        private void LimpiarCampos()
        {
            txt_id.Clear();
            cboasesorcomercial.Text = "";
            dateInicio.ResetText();
            dateFin.ResetText();
            combocliente.Text = "";
            txt_razon.Clear();
            txt_telefono.Clear();
            txt_correo.Clear();
            txt_giro.Clear();
            txt_direccion.Clear();
            comboservicioA.Text = "";
            costoA.Clear();
            comboservicioB.Text = "";
            costoB.Clear();
            comboservicioC.Text = "";
            costoC.Clear();
            comboservicioD.Text = "";
            costoD.Clear();
            comboservicioE.Text = "";
            costoE.Clear();
            comboservicioF.Text = "";
            costoF.Clear();
            txt_insercionestotal.Clear();
            txt_subtotal.Clear();
            txt_iva.Clear();
            txt_total.Clear();
            txt_observaciones.Clear();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("DELETE FROM pautas WHERE ID='" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("La Pauta Seleccionada se ha Eliminado Correctamente.", "información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("UPDATE pautas SET AsesorComercial ='" + cboasesorcomercial.Text + "',InicioContrato ='" + dateInicio.Value.ToString("yyyy/MM/dd").ToString() + "',TerminoContrato ='" + dateFin.Value.ToString("yyyy/MM/dd").ToString() + "',Cliente ='" + combocliente.Text
                + "',RazonSocial ='" + txt_razon.Text + "',Telefono ='" + txt_telefono.Text + "',Email ='" + txt_correo.Text + "',Giro ='" + txt_giro.Text + "',Direccion ='" + txt_direccion.Text + "',Servicio1 ='" + comboservicioA.Text + "',Costo1 ='"
                + costoA.Text + "',Servicio2 ='" + comboservicioB.Text + "',Costo2 ='" + costoB.Text + "',Servicio3 ='" + comboservicioC.Text + "',Costo3 ='" + costoC.Text + "',Servicio4 ='" + comboservicioD.Text + "',Costo4 ='" + costoD.Text + "',Servicio5 ='" + comboservicioE.Text + "',Costo5 ='"
                + costoE.Text + "',Servicio6 ='" + comboservicioF.Text + "',Costo6 ='" + costoF.Text + "',Total_Inser ='" + txt_insercionestotal.Text + "',SubTotal ='" + txt_subtotal.Text + "',Iva ='" + txt_iva.Text + "',Total ='" + txt_total.Text + "',Observaciones ='" + txt_observaciones.Text + "'WHERE ID = '" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("La Informacion Del Cliente se Actualizo Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void Vista_pautas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Vista_pautas.SelectedCells[0].Value.ToString();
            cboasesorcomercial.Text = Vista_pautas.SelectedCells[1].Value.ToString();
            dateInicio.Text = Vista_pautas.SelectedCells[2].Value.ToString();
            dateFin.Text = Vista_pautas.SelectedCells[3].Value.ToString();
            combocliente.Text = Vista_pautas.SelectedCells[4].Value.ToString();
            txt_razon.Text = Vista_pautas.SelectedCells[5].Value.ToString();
            txt_telefono.Text = Vista_pautas.SelectedCells[6].Value.ToString();
            txt_correo.Text = Vista_pautas.SelectedCells[7].Value.ToString();
            txt_giro.Text = Vista_pautas.SelectedCells[8].Value.ToString();
            txt_direccion.Text = Vista_pautas.SelectedCells[9].Value.ToString();
            comboservicioA.Text = Vista_pautas.SelectedCells[10].Value.ToString();
            costoA.Text = Vista_pautas.SelectedCells[11].Value.ToString();
            comboservicioB.Text = Vista_pautas.SelectedCells[12].Value.ToString();
            costoB.Text = Vista_pautas.SelectedCells[13].Value.ToString();
            comboservicioC.Text = Vista_pautas.SelectedCells[14].Value.ToString();
            costoC.Text = Vista_pautas.SelectedCells[15].Value.ToString();
            comboservicioD.Text = Vista_pautas.SelectedCells[16].Value.ToString();
            costoD.Text = Vista_pautas.SelectedCells[17].Value.ToString();
            comboservicioE.Text = Vista_pautas.SelectedCells[18].Value.ToString();
            costoE.Text = Vista_pautas.SelectedCells[19].Value.ToString();
            comboservicioF.Text = Vista_pautas.SelectedCells[20].Value.ToString();
            costoF.Text = Vista_pautas.SelectedCells[21].Value.ToString();
            txt_insercionestotal.Text = Vista_pautas.SelectedCells[22].Value.ToString();
            txt_subtotal.Text = Vista_pautas.SelectedCells[23].Value.ToString();
           txt_iva.Text = Vista_pautas.SelectedCells[24].Value.ToString();
            txt_total.Text = Vista_pautas.SelectedCells[25].Value.ToString();
            txt_observaciones.Text = Vista_pautas.SelectedCells[26].Value.ToString();

        }




        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double costo1, costo2, costo3, costo4, costo5, costo6, totalI, subtotal, iva, total;
            //checbox

            if (String.IsNullOrWhiteSpace(txt_insercionestotal.Text))
            {
                txt_insercionestotal.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(costoA.Text))
            {
                costoA.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(costoB.Text))
            {
                costoB.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(costoC.Text))
            {
                costoC.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(costoD.Text))
            {
                costoD.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(costoE.Text))
            {
                costoE.Text = "0";
            }

            if (String.IsNullOrWhiteSpace(costoF.Text))
            {
                costoF.Text = "0";
            }





            costo1 = double.Parse(costoA.Text.Replace("$", ""));
            costo2 = double.Parse(costoB.Text.Replace("$", ""));
            costo3 = double.Parse(costoC.Text.Replace("$", ""));
            costo4 = double.Parse(costoD.Text.Replace("$", ""));
            costo5 = double.Parse(costoE.Text.Replace("$", ""));
            costo6 = double.Parse(costoF.Text.Replace("$", ""));

            totalI = double.Parse(txt_insercionestotal.Text);

            if (coniva.Checked)
            {
                subtotal = costo1 * totalI + costo2 + costo3 + costo4 + costo5 + costo6;

                iva = subtotal * 0.16;

                total = subtotal + iva;
                txt_subtotal.Text = subtotal.ToString();
                txt_iva.Text = iva.ToString();
                txt_total.Text = total.ToString();

                

            }

            if (siniva.Checked)
            {
                subtotal = costo1 * totalI + costo2 + costo3 + costo4 + costo5 + costo6;

                total = subtotal;
                txt_subtotal.Text = subtotal.ToString();
                txt_total.Text = total.ToString();
                txt_iva.Clear();
            }


        }
       
    }
}