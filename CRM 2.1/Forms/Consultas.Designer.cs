namespace CRM_2._1.Forms
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.limpiar = new FontAwesome.Sharp.IconButton();
            this.encontrar = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pautasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMDataSet = new CRM_2._1.CRMDataSet();
            this.pautasTableAdapter = new CRM_2._1.CRMDataSetTableAdapters.pautasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pautasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(130, 12);
            this.txt_busqueda.Multiline = true;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(211, 32);
            this.txt_busqueda.TabIndex = 1;
            this.txt_busqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Red;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.limpiar.IconColor = System.Drawing.Color.Maroon;
            this.limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiar.Location = new System.Drawing.Point(572, 12);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(178, 48);
            this.limpiar.TabIndex = 204;
            this.limpiar.Text = "Borrar";
            this.limpiar.UseVisualStyleBackColor = false;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // encontrar
            // 
            this.encontrar.BackColor = System.Drawing.Color.ForestGreen;
            this.encontrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encontrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encontrar.ForeColor = System.Drawing.Color.Black;
            this.encontrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.encontrar.IconColor = System.Drawing.Color.Maroon;
            this.encontrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.encontrar.Location = new System.Drawing.Point(368, 12);
            this.encontrar.Name = "encontrar";
            this.encontrar.Size = new System.Drawing.Size(178, 48);
            this.encontrar.TabIndex = 205;
            this.encontrar.Text = "Cargar Reporte";
            this.encontrar.UseVisualStyleBackColor = false;
            this.encontrar.Click += new System.EventHandler(this.encontrar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Window;
            this.ID.Location = new System.Drawing.Point(12, 16);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(89, 21);
            this.ID.TabIndex = 206;
            this.ID.Text = "Ingresa ID";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.pautasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRM_2._1.Formatodepautas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 66);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1152, 528);
            this.reportViewer1.TabIndex = 207;
            // 
            // pautasBindingSource
            // 
            this.pautasBindingSource.DataMember = "pautas";
            this.pautasBindingSource.DataSource = this.cRMDataSet;
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pautasTableAdapter
            // 
            this.pautasTableAdapter.ClearBeforeFill = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1151, 594);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.encontrar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.txt_busqueda);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pautasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_busqueda;
       
        private FontAwesome.Sharp.IconButton limpiar;
        private FontAwesome.Sharp.IconButton encontrar;
        private System.Windows.Forms.Label ID;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pautasBindingSource;
        private CRMDataSet cRMDataSet;
        private CRMDataSetTableAdapters.pautasTableAdapter pautasTableAdapter;
    }
}