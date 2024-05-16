using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace CRM_2._1
{
    public partial class Login : Form
    {
        SqlCommand Comando;
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
             
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;

            }

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string PassDB = "";
            String PassEncrypt = EncriptarContraseña(txtpass.Text);
            ParametrosGenerales.ConexionSqlGlobal.Open();
            Comando = new SqlCommand("SELECT Password FROM usuarios WHERE Usuario='" + txtuser.Text + "'", ParametrosGenerales.ConexionSqlGlobal);
            SqlDataReader Lec = Comando.ExecuteReader();
            if (Lec.Read())
            {
                PassDB = Lec[0].ToString();
            }
            if (PassDB == PassEncrypt)
            {

                this.Hide();
                Bienvenida a = new Bienvenida();
                a.ShowDialog();
                
                Form1 b = new Form1();
                b.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
            ParametrosGenerales.ConexionSqlGlobal.Close();
        }
        private string EncriptarContraseña(string Pass)
        {
            MD5 md5 = MD5.Create();
            Byte[] Inputbyte = System.Text.Encoding.ASCII.GetBytes(Pass);
            byte[] hash = md5.ComputeHash(Inputbyte);
            Pass = BitConverter.ToString(hash).Replace("-", "");
            return Pass;
        }
    }
    }

