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
    public partial class Asesores : Form
    {
        SqlCommand ComandoSQL;
        public Asesores()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("INSERT INTO asesores VALUES('" + txt_id.Text + "','" + txt_nombre.Text + "','"
            + txt_telefono.Text + "','" + txt_correo.Text + "','" + txt_direccion.Text + "')", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Asesor se ah Registrado con Exito.", "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void Vista_asesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Vista_asesores.SelectedCells[0].Value.ToString();
            txt_nombre.Text = Vista_asesores.SelectedCells[1].Value.ToString();
            txt_telefono.Text = Vista_asesores.SelectedCells[2].Value.ToString();
            txt_correo.Text = Vista_asesores.SelectedCells[3].Value.ToString();
            txt_direccion.Text = Vista_asesores.SelectedCells[4].Value.ToString();
        }
        private void ConsultaDatosBD()
        {
            string Sql = ("Select * from asesores");
            SqlDataAdapter CargadorDatos = new SqlDataAdapter(Sql, ParametrosGenerales.ConexionSqlGlobal);
            DataSet Datos = new DataSet();
            CargadorDatos.Fill(Datos, "f");
            Vista_asesores.DataSource = Datos.Tables["f"];

        }

        private void Asesores_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from asesores", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_nombre;

            ConsultaDatosBD();
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("DELETE FROM asesores WHERE ID='" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Asesor Seleccionado se ha Eliminado Correctamente.", "información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("UPDATE asesores SET Nombre='"
                + txt_nombre.Text + "', Teléfono='" + txt_telefono.Text + "', Email='"
                + txt_correo.Text + "',Dirección ='" + txt_direccion.Text + "'WHERE ID = '" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("La Informacion Del Asesor se Actualizo Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txt_id.Clear();
            txt_nombre.Clear();
            txt_telefono.Clear();
            txt_correo.Clear();
            txt_direccion.Clear();
            txt_nombre.Focus();
            

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from asesores", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_nombre;
        }

        private void Vista_asesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Vista_asesores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
