namespace Proyecto_Grupo13.Administrador
{
    partial class ucReporteCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReporteCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Proveedor = new System.Windows.Forms.Label();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelReporteC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridReporteCompra = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.iconBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.textnumDocume = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridReporteCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(34, 52);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1340, 578);
            this.label16.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxBuscar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Proveedor);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelReporteC);
            this.panel1.Location = new System.Drawing.Point(48, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 114);
            this.panel1.TabIndex = 61;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(591, 45);
            this.comboBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(205, 28);
            this.comboBoxBuscar.TabIndex = 62;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(804, 49);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 24);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(325, 49);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSize = true;
            this.Proveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor.ForeColor = System.Drawing.Color.White;
            this.Proveedor.Location = new System.Drawing.Point(506, 51);
            this.Proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(80, 20);
            this.Proveedor.TabIndex = 50;
            this.Proveedor.Text = "Proveedor:";
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(245, 55);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(73, 20);
            this.labelFechaFin.TabIndex = 49;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicio.Location = new System.Drawing.Point(4, 55);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(90, 20);
            this.labelFechaInicio.TabIndex = 48;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelReporteC
            // 
            this.labelReporteC.AutoSize = true;
            this.labelReporteC.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelReporteC.ForeColor = System.Drawing.Color.White;
            this.labelReporteC.Location = new System.Drawing.Point(2, 11);
            this.labelReporteC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReporteC.Name = "labelReporteC";
            this.labelReporteC.Size = new System.Drawing.Size(178, 23);
            this.labelReporteC.TabIndex = 47;
            this.labelReporteC.Text = "Reporte Compra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GridReporteCompra);
            this.panel2.Controls.Add(this.iconBtnExcel);
            this.panel2.Controls.Add(this.iconBtnLimpiar);
            this.panel2.Controls.Add(this.iconBtnBuscar);
            this.panel2.Controls.Add(this.textnumDocume);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.labelBuscarPor2);
            this.panel2.Location = new System.Drawing.Point(48, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 421);
            this.panel2.TabIndex = 62;
            // 
            // GridReporteCompra
            // 
            this.GridReporteCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridReporteCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridReporteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridReporteCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDoc,
            this.MontoTotal,
            this.usuarioRegistro,
            this.docProveedor,
            this.RazonSoc,
            this.CodProd,
            this.NombreProd,
            this.Categoria,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.GridReporteCompra.Location = new System.Drawing.Point(-11, 50);
            this.GridReporteCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridReporteCompra.Name = "GridReporteCompra";
            this.GridReporteCompra.RowHeadersWidth = 51;
            this.GridReporteCompra.Size = new System.Drawing.Size(1356, 360);
            this.GridReporteCompra.TabIndex = 15;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 6;
            this.TipoDocumento.Name = "TipoDocumento";
            // 
            // NumeroDoc
            // 
            this.NumeroDoc.HeaderText = "Numero Documento";
            this.NumeroDoc.MinimumWidth = 6;
            this.NumeroDoc.Name = "NumeroDoc";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            // 
            // usuarioRegistro
            // 
            this.usuarioRegistro.HeaderText = "Usuario Registro";
            this.usuarioRegistro.MinimumWidth = 6;
            this.usuarioRegistro.Name = "usuarioRegistro";
            // 
            // docProveedor
            // 
            this.docProveedor.HeaderText = "Documento Proveedor";
            this.docProveedor.MinimumWidth = 6;
            this.docProveedor.Name = "docProveedor";
            // 
            // RazonSoc
            // 
            this.RazonSoc.HeaderText = "Razón Social";
            this.RazonSoc.MinimumWidth = 6;
            this.RazonSoc.Name = "RazonSoc";
            // 
            // CodProd
            // 
            this.CodProd.HeaderText = "Codigo Producto";
            this.CodProd.MinimumWidth = 6;
            this.CodProd.Name = "CodProd";
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "Nombre Producto";
            this.NombreProd.MinimumWidth = 6;
            this.NombreProd.Name = "NombreProd";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            // 
            // iconBtnExcel
            // 
            this.iconBtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExcel.IconColor = System.Drawing.Color.Black;
            this.iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExcel.IconSize = 15;
            this.iconBtnExcel.Location = new System.Drawing.Point(9, 15);
            this.iconBtnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconBtnExcel.Name = "iconBtnExcel";
            this.iconBtnExcel.Size = new System.Drawing.Size(138, 28);
            this.iconBtnExcel.TabIndex = 68;
            this.iconBtnExcel.Text = "Descargar Excel";
            this.iconBtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExcel.UseVisualStyleBackColor = false;
            // 
            // iconBtnLimpiar
            // 
            this.iconBtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconBtnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.iconBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnLimpiar.IconSize = 16;
            this.iconBtnLimpiar.Location = new System.Drawing.Point(852, 15);
            this.iconBtnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconBtnLimpiar.Name = "iconBtnLimpiar";
            this.iconBtnLimpiar.Size = new System.Drawing.Size(51, 24);
            this.iconBtnLimpiar.TabIndex = 67;
            this.iconBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.iconBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnBuscar.IconSize = 16;
            this.iconBtnBuscar.Location = new System.Drawing.Point(796, 15);
            this.iconBtnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(51, 24);
            this.iconBtnBuscar.TabIndex = 66;
            this.iconBtnBuscar.UseVisualStyleBackColor = false;
            // 
            // textnumDocume
            // 
            this.textnumDocume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textnumDocume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnumDocume.Location = new System.Drawing.Point(601, 10);
            this.textnumDocume.Margin = new System.Windows.Forms.Padding(2);
            this.textnumDocume.Multiline = true;
            this.textnumDocume.Name = "textnumDocume";
            this.textnumDocume.Size = new System.Drawing.Size(191, 29);
            this.textnumDocume.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fecha Registro",
            "Tipo Documento",
            "Numero Documento",
            "Monto total",
            "Usuario Registro ",
            "Documento Proveedor",
            "Razón Social",
            "Codigo Porducto",
            "Nombre Producto",
            "Categoria",
            "Precio Compra",
            "Precio Venta",
            "Cantidad",
            "SubTotal"});
            this.comboBox1.Location = new System.Drawing.Point(470, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 64;
            // 
            // labelBuscarPor2
            // 
            this.labelBuscarPor2.AutoSize = true;
            this.labelBuscarPor2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor2.Location = new System.Drawing.Point(384, 14);
            this.labelBuscarPor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor2.Name = "labelBuscarPor2";
            this.labelBuscarPor2.Size = new System.Drawing.Size(82, 20);
            this.labelBuscarPor2.TabIndex = 34;
            this.labelBuscarPor2.Text = "Buscar por:";
            // 
            // ucReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucReporteCompra";
            this.Size = new System.Drawing.Size(1392, 682);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridReporteCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelReporteC;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label Proveedor;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelBuscarPor2;
        private System.Windows.Forms.TextBox textnumDocume;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
        private FontAwesome.Sharp.IconButton iconBtnLimpiar;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private System.Windows.Forms.DataGridView GridReporteCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn docProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}
