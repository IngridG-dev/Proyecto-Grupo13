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
            this.vendedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.lFechaHasta = new System.Windows.Forms.Label();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            this.lDetallePago = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.lFechaTicket = new System.Windows.Forms.Label();
            this.lNumeroVenta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(59, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1028, 476);
            this.label15.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "MIS VENTAS";
            // 
            // numVenta
            // 
            this.numVenta.AutoSize = true;
            this.numVenta.ForeColor = System.Drawing.Color.White;
            this.numVenta.Location = new System.Drawing.Point(284, 73);
            this.numVenta.Name = "numVenta";
            this.numVenta.Size = new System.Drawing.Size(58, 13);
            this.numVenta.TabIndex = 47;
            this.numVenta.Text = "N° Ventas:";
            // 
            // vendedor
            // 
            this.vendedor.AutoSize = true;
            this.vendedor.ForeColor = System.Drawing.Color.White;
            this.vendedor.Location = new System.Drawing.Point(623, 73);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(56, 13);
            this.vendedor.TabIndex = 49;
            this.vendedor.Text = "Vendedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.iconBuscar);
            this.groupBox1.Controls.Add(this.lFechaHasta);
            this.groupBox1.Controls.Add(this.labelFechaDesde);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(72, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(663, 80);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(340, 36);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 23);
            this.dateTimePicker1.TabIndex = 44;
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
            this.iconBuscar.Location = new System.Drawing.Point(522, 27);
            this.iconBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(82, 30);
            this.iconBuscar.TabIndex = 43;
            this.iconBuscar.Text = "Buscar";
            this.iconBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBuscar.UseVisualStyleBackColor = false;
            // 
            // lFechaHasta
            // 
            this.lFechaHasta.AutoSize = true;
            this.lFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaHasta.ForeColor = System.Drawing.Color.White;
            this.lFechaHasta.Location = new System.Drawing.Point(337, 18);
            this.lFechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFechaHasta.Name = "lFechaHasta";
            this.lFechaHasta.Size = new System.Drawing.Size(74, 15);
            this.lFechaHasta.TabIndex = 24;
            this.lFechaHasta.Text = "Fecha Hasta:";
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDesde.ForeColor = System.Drawing.Color.White;
            this.labelFechaDesde.Location = new System.Drawing.Point(117, 18);
            this.labelFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(76, 15);
            this.labelFechaDesde.TabIndex = 23;
            this.labelFechaDesde.Text = "Fecha Desde:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numVentas,
            this.fecha,
            this.Cliente,
            this.Dni,
            this.total,
            this.ver});
            this.dataGridView1.Location = new System.Drawing.Point(72, 209);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 275);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // ver
            // 
            this.ver.HeaderText = "Ver";
            this.ver.MinimumWidth = 6;
            this.ver.Name = "ver";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 71);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 52;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(685, 68);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 54;
            // 
            // panelTicket
            // 
            this.panelTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.panelTicket.Controls.Add(this.btnDescargarPdf);
            this.panelTicket.Controls.Add(this.lDetallePago);
            this.panelTicket.Controls.Add(this.lTotal);
            this.panelTicket.Controls.Add(this.dataGridView2);
            this.panelTicket.Controls.Add(this.label7);
            this.panelTicket.Controls.Add(this.lDNI);
            this.panelTicket.Controls.Add(this.lCliente);
            this.panelTicket.Controls.Add(this.lFechaTicket);
            this.panelTicket.Controls.Add(this.lNumeroVenta);
            this.panelTicket.Location = new System.Drawing.Point(739, 115);
            this.panelTicket.Margin = new System.Windows.Forms.Padding(2);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(335, 369);
            this.panelTicket.TabIndex = 55;
            this.panelTicket.Visible = false;
            // 
            // btnDescargarPdf
            // 
            this.btnDescargarPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDescargarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDescargarPdf.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.btnDescargarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescargarPdf.IconColor = System.Drawing.Color.Brown;
            this.btnDescargarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPdf.IconSize = 15;
            this.btnDescargarPdf.Location = new System.Drawing.Point(130, 343);
            this.btnDescargarPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Size = new System.Drawing.Size(94, 24);
            this.btnDescargarPdf.TabIndex = 42;
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarPdf.UseVisualStyleBackColor = false;
            // 
            // lDetallePago
            // 
            this.lDetallePago.AutoSize = true;
            this.lDetallePago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lDetallePago.ForeColor = System.Drawing.Color.White;
            this.lDetallePago.Location = new System.Drawing.Point(5, 275);
            this.lDetallePago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDetallePago.Name = "lDetallePago";
            this.lDetallePago.Size = new System.Drawing.Size(97, 15);
            this.lDetallePago.TabIndex = 8;
            this.lDetallePago.Text = "Detalles de Pago:";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lTotal.ForeColor = System.Drawing.Color.White;
            this.lTotal.Location = new System.Drawing.Point(4, 250);
            this.lTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(44, 15);
            this.lTotal.TabIndex = 7;
            this.lTotal.Text = "TOTAL:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProd,
            this.ColumnCant,
            this.ColumnPrecio,
            this.Column1Sub});
            this.dataGridView2.Location = new System.Drawing.Point(7, 100);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(326, 135);
            this.dataGridView2.TabIndex = 6;
            // 
            // ColumnProd
            // 
            this.ColumnProd.HeaderText = "Producto";
            this.ColumnProd.MinimumWidth = 6;
            this.ColumnProd.Name = "ColumnProd";
            this.ColumnProd.ReadOnly = true;
            this.ColumnProd.Width = 125;
            // 
            // ColumnCant
            // 
            this.ColumnCant.HeaderText = "Cant.";
            this.ColumnCant.MinimumWidth = 6;
            this.ColumnCant.Name = "ColumnCant";
            this.ColumnCant.ReadOnly = true;
            this.ColumnCant.Width = 125;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio Unitario";
            this.ColumnPrecio.MinimumWidth = 6;
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            this.ColumnPrecio.Width = 125;
            // 
            // Column1Sub
            // 
            this.Column1Sub.HeaderText = "Subtotal";
            this.Column1Sub.MinimumWidth = 6;
            this.Column1Sub.Name = "Column1Sub";
            this.Column1Sub.ReadOnly = true;
            this.Column1Sub.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(4, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "COMPROBANTE DE VENTA";
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lDNI.ForeColor = System.Drawing.Color.White;
            this.lDNI.Location = new System.Drawing.Point(173, 66);
            this.lDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(30, 15);
            this.lDNI.TabIndex = 3;
            this.lDNI.Text = "DNI:";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lCliente.ForeColor = System.Drawing.Color.White;
            this.lCliente.Location = new System.Drawing.Point(4, 66);
            this.lCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(47, 15);
            this.lCliente.TabIndex = 2;
            this.lCliente.Text = "Cliente:";
            // 
            // lFechaTicket
            // 
            this.lFechaTicket.AutoSize = true;
            this.lFechaTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lFechaTicket.ForeColor = System.Drawing.Color.White;
            this.lFechaTicket.Location = new System.Drawing.Point(162, 39);
            this.lFechaTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFechaTicket.Name = "lFechaTicket";
            this.lFechaTicket.Size = new System.Drawing.Size(41, 15);
            this.lFechaTicket.TabIndex = 1;
            this.lFechaTicket.Text = "Fecha:";
            // 
            // lNumeroVenta
            // 
            this.lNumeroVenta.AutoSize = true;
            this.lNumeroVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lNumeroVenta.ForeColor = System.Drawing.Color.White;
            this.lNumeroVenta.Location = new System.Drawing.Point(2, 39);
            this.lNumeroVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNumeroVenta.Name = "lNumeroVenta";
            this.lNumeroVenta.Size = new System.Drawing.Size(75, 15);
            this.lNumeroVenta.TabIndex = 0;
            this.lNumeroVenta.Text = "N° de Ticket:";
            // 
            // ucDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panelTicket);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.numVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "ucDetalleVenta";
            this.Size = new System.Drawing.Size(1114, 546);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numVenta;
        private System.Windows.Forms.Label vendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lFechaHasta;
        private System.Windows.Forms.Label labelFechaDesde;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelTicket;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lDNI;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lFechaTicket;
        private System.Windows.Forms.Label lNumeroVenta;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Sub;
        private System.Windows.Forms.Label lDetallePago;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
    }
}
