using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_2._1.Forms
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            

        }

        private void encontrar_Click(object sender, EventArgs e)
        {
            int valor;
            valor = Convert.ToInt32(txt_busqueda.Text);
            this.pautasTableAdapter.Fill(this.cRMDataSet.pautas,valor);
            this.ActiveControl = txt_busqueda;
            this.reportViewer1.RefreshReport();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            this.ActiveControl = txt_busqueda;
        }
    }
}
