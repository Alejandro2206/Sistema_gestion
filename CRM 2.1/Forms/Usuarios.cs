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
using System.Security.Cryptography;
namespace CRM_2._1.Forms
{
    
    public partial class Usuarios : Form
    {
        SqlCommand ComandoSQL;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            String PassEncrypt = EncriptarContraseña(txt_contraseña.Text);
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("INSERT INTO usuarios VALUES('" + txt_id.Text + "','" + txt_nombre.Text + "','"
            + txt_usuario.Text + "','" + txt_telefono.Text + "','" + txt_correo.Text + "','" + PassEncrypt + "')", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Usuario se ha registardo Exitosamente", "Informacion",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }
        private string EncriptarContraseña(string Pass)
        {
            MD5 md5 = MD5.Create();
            Byte[] Inputbyte = System.Text.Encoding.ASCII.GetBytes(Pass);
            byte[] hash = md5.ComputeHash(Inputbyte);
            Pass = BitConverter.ToString(hash).Replace("-", "");
            return Pass;
        }

        private void ConsultaDatosBD()
        {
            string Sql = ("Select * from usuarios");
            SqlDataAdapter CargadorDatos = new SqlDataAdapter(Sql, ParametrosGenerales.ConexionSqlGlobal);
            DataSet Datos = new DataSet();
            CargadorDatos.Fill(Datos, "f");
            Vista_usuarios.DataSource = Datos.Tables["f"];

        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("UPDATE usuarios SET Nombre='"
                + txt_nombre.Text + "', Usuario='" + txt_usuario.Text + "', Teléfono='"
                + txt_telefono.Text + "',[Correo-e] ='" + txt_correo.Text + "' WHERE ID = '" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("Los datos del usuario se actualizron con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ParametrosGenerales.ConexionSqlGlobal.Open();
            ComandoSQL = new SqlCommand("DELETE FROM usuarios WHERE ID='" + txt_id.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            ComandoSQL.ExecuteNonQuery();
            MessageBox.Show("El Usuario seleccionado ha sido eliminado", "información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParametrosGenerales.ConexionSqlGlobal.Close();
            ConsultaDatosBD();
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txt_id.Clear();
            txt_nombre.Clear();
            txt_usuario.Clear();
            txt_telefono.Clear();
            txt_correo.Clear();
            txt_contraseña.Clear();
            txt_nombre.Focus();
           
        }

        private void Vista_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = Vista_usuarios.SelectedCells[0].Value.ToString();
            txt_nombre.Text = Vista_usuarios.SelectedCells[1].Value.ToString();
            txt_usuario.Text = Vista_usuarios.SelectedCells[2].Value.ToString();
            txt_telefono.Text = Vista_usuarios.SelectedCells[3].Value.ToString();
            txt_correo.Text = Vista_usuarios.SelectedCells[4].Value.ToString();

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from usuarios", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_nombre;

            ConsultaDatosBD();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)), 0)+1 from usuarios", ParametrosGenerales.ConexionSqlGlobal);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_id.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = txt_nombre;

            
        }
    }
}
