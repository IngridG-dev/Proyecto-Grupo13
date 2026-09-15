namespace Proyecto_Grupo13.Vendedor
{
    partial class ucDetalleVenta
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
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numVenta = new System.Windows.Forms.Label();
            this.fechaVenta = new System.Windows.Forms.Label();
            this.vendedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.lFechaHasta = new System.Windows.Forms.Label();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(181, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(753, 476);
            this.label15.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "MIS VENTAS";
            // 
            // numVenta
            // 
            this.numVenta.AutoSize = true;
            this.numVenta.ForeColor = System.Drawing.Color.White;
            this.numVenta.Location = new System.Drawing.Point(219, 77);
            this.numVenta.Name = "numVenta";
            this.numVenta.Size = new System.Drawing.Size(58, 13);
            this.numVenta.TabIndex = 47;
            this.numVenta.Text = "N° Ventas:";
            // 
            // fechaVenta
            // 
            this.fechaVenta.AutoSize = true;
            this.fechaVenta.ForeColor = System.Drawing.Color.White;
            this.fechaVenta.Location = new System.Drawing.Point(364, 77);
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.Size = new System.Drawing.Size(40, 13);
            this.fechaVenta.TabIndex = 48;
            this.fechaVenta.Text = "Fecha:";
            // 
            // vendedor
            // 
            this.vendedor.AutoSize = true;
            this.vendedor.ForeColor = System.Drawing.Color.White;
            this.vendedor.Location = new System.Drawing.Point(575, 77);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(56, 13);
            this.vendedor.TabIndex = 49;
            this.vendedor.Text = "Vendedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconBuscar);
            this.groupBox1.Controls.Add(this.lFechaHasta);
            this.groupBox1.Controls.Add(this.labelFechaDesde);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(222, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(663, 80);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDesde.ForeColor = System.Drawing.Color.White;
            this.labelFechaDesde.Location = new System.Drawing.Point(16, 33);
            this.labelFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(76, 15);
            this.labelFechaDesde.TabIndex = 23;
            this.labelFechaDesde.Text = "Fecha Desde:";
            // 
            // lFechaHasta
            // 
            this.lFechaHasta.AutoSize = true;
            this.lFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaHasta.ForeColor = System.Drawing.Color.White;
            this.lFechaHasta.Location = new System.Drawing.Point(183, 33);
            this.lFechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFechaHasta.Name = "lFechaHasta";
            this.lFechaHasta.Size = new System.Drawing.Size(74, 15);
            this.lFechaHasta.TabIndex = 24;
            this.lFechaHasta.Text = "Fecha Hasta:";
            // 
            // iconBuscar
            // 
            this.iconBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBuscar.ForeColor = System.Drawing.Color.White;
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 25;
            this.iconBuscar.Location = new System.Drawing.Point(485, 25);
            this.iconBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(92, 30);
            this.iconBuscar.TabIndex = 43;
            this.iconBuscar.Text = "Buscar";
            this.iconBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numVentas,
            this.fecha,
            this.Cliente,
            this.Dni,
            this.total,
            this.ver});
            this.dataGridView2.Location = new System.Drawing.Point(222, 212);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(663, 275);
            this.dataGridView2.TabIndex = 51;
            // 
            // numVentas
            // 
            this.numVentas.HeaderText = "N° Venta";
            this.numVentas.MinimumWidth = 6;
            this.numVentas.Name = "numVentas";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // ver
            // 
            this.ver.HeaderText = "Ver";
            this.ver.Name = "ver";
            // 
            // ucDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.fechaVenta);
            this.Controls.Add(this.numVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "ucDetalleVenta";
            this.Size = new System.Drawing.Size(1114, 546);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numVenta;
        private System.Windows.Forms.Label fechaVenta;
        private System.Windows.Forms.Label vendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lFechaHasta;
        private System.Windows.Forms.Label labelFechaDesde;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
    }
}
