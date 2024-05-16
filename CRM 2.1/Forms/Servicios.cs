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

namespace CRM_2._1.Forms
{
    public partial class Servicios : Form
    {
        SqlCommand ComandoSQL;
        public Servicios()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("INSERT INTO servicios VALUES('" + txt_id.Text + "','" + txt_servicio.Text + "','" + txt_costo.Text + "')", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Servicio se ah Registrado con Exito.", "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            LimpiarCampos();
            ConsultaDatosBD();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("UPDATE servicios SET Servicios='"
                + txt_servicio.Text + "', [$Costo]='" + txt_costo.Text + "'WHERE ID = '" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("La Informacion Del Servicio se Actualizo Correctamente.", "Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("DELETE FROM servicios WHERE ID='" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Servicio Seleccionado se ha Eliminado Correctamente.", "información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txt_id.Clear();
            txt_servicio.Clear();
            txt_costo.Clear();

        }
        private void ConsultaDatosBD()
        {
            string Sql = ("Select * from servicios");
            SqlDataAdapter CargadorDatos = new SqlDataAdapter(Sql, ParametrosGenerales.ConexionSqlGlobal);
            DataSet Datos = new DataSet();
            CargadorDatos.Fill(Datos, "f");
            Vista_servicios.DataSource = Datos.Tables["f"];

        }

        private void Vista_servicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Vista_servicios.SelectedCells[0].Value.ToString();
            txt_servicio.Text = Vista_servicios.SelectedCells[1].Value.ToString();
            txt_costo.Text = Vista_servicios.SelectedCells[2].Value.ToString();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from servicios", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_servicio;

            ConsultaDatosBD();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from servicios", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_servicio;
        }
    }
}
