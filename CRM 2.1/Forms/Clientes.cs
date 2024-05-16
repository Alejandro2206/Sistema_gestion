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
    public partial class Clientes : Form
    {
        SqlCommand ComandoSQL;
        public Clientes()
        {
            InitializeComponent();
        }

        

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("INSERT INTO clientes VALUES('" + txt_id.Text + "','" + txt_nombrecliente.Text + "','" + txt_correocliente.Text + "','" + txt_telefono1.Text + "','" + txt_telefono2.Text + "','" + txt_razonsocial.Text + "','" + txt_giro.Text + "')", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Cliente se ah Registrado con Exito.", "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("UPDATE clientes SET Nombre='"
                + txt_nombrecliente.Text + "', [Correo-e]='"
                + txt_correocliente.Text + "',Teléfono1 ='" + txt_telefono1.Text + "',Teléfono2 ='" + txt_telefono2.Text + "',RazonSocial ='" + txt_razonsocial.Text + "',Giro ='" + txt_giro.Text + "'WHERE ID = '" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("La Informacion Del Cliente se Actualizo Correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("DELETE FROM clientes WHERE ID='" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Cliente Seleccionado se ha Eliminado Correctamente.", "información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txt_id.Clear();
            txt_nombrecliente.Clear();
            txt_correocliente.Clear();
            txt_telefono1.Clear();
            txt_telefono2.Clear();
            txt_razonsocial.Clear();
            txt_giro.Clear();
            txt_nombrecliente.Focus();

        }
        private void ConsultaDatosBD()
        {
            string Sql = ("Select * from clientes");
            SqlDataAdapter CargadorDatos = new SqlDataAdapter(Sql, ParametrosGenerales.ConexionSqlGlobal);
            DataSet Datos = new DataSet();
            CargadorDatos.Fill(Datos, "f");
            Vista_clientes.DataSource = Datos.Tables["f"];

        }

        private void Vista_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Vista_clientes.SelectedCells[0].Value.ToString();
            txt_nombrecliente.Text = Vista_clientes.SelectedCells[1].Value.ToString();
            txt_correocliente.Text = Vista_clientes.SelectedCells[2].Value.ToString();
            txt_telefono1.Text = Vista_clientes.SelectedCells[3].Value.ToString();
            txt_telefono2.Text = Vista_clientes.SelectedCells[4].Value.ToString();
            txt_razonsocial.Text = Vista_clientes.SelectedCells[5].Value.ToString();
            txt_giro.Text = Vista_clientes.SelectedCells[6].Value.ToString();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from clientes", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_nombrecliente;

            ConsultaDatosBD();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from clientes", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_nombrecliente;
            
        }
    }
}
