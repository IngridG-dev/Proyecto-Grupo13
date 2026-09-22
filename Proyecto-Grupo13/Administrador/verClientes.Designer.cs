namespace Proyecto_Grupo13.Administrador
{
    partial class verClientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lClientes = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lClientes
            // 
            this.lClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lClientes.Location = new System.Drawing.Point(153, 45);
            this.lClientes.Name = "lClientes";
            this.lClientes.Size = new System.Drawing.Size(1002, 483);
            this.lClientes.TabIndex = 1;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(191, 115);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersWidth = 51;
            this.dataGridClientes.RowTemplate.Height = 24;
            this.dataGridClientes.Size = new System.Drawing.Size(915, 393);
            this.dataGridClientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENTES REGISTRADOS";
            // 
            // verClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.lClientes);
            this.Name = "verClientes";
            this.Size = new System.Drawing.Size(1308, 573);
            this.Load += new System.EventHandler(this.verClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lClientes;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Label label1;
    }
}
