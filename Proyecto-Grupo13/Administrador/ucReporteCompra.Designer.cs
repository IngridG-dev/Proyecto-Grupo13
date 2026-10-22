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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.iconBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.labelReporteC = new System.Windows.Forms.Label();
            this.labelBuscarPor2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.gbDetalle = new System.Windows.Forms.Panel();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelFechaReg = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelNCompra = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblNumCompra = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.labelTotalC = new System.Windows.Forms.Label();
            this.id_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(34, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1437, 709);
            this.label16.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.iconBtnLimpiar);
            this.panel1.Controls.Add(this.textBuscar);
            this.panel1.Controls.Add(this.iconBtnBuscar);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.cboBuscarPor);
            this.panel1.Controls.Add(this.labelReporteC);
            this.panel1.Controls.Add(this.labelBuscarPor2);
            this.panel1.Location = new System.Drawing.Point(48, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 114);
            this.panel1.TabIndex = 61;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(112, 75);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(116, 22);
            this.dtpFechaFin.TabIndex = 63;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(112, 49);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(116, 22);
            this.dtpFechaInicio.TabIndex = 62;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(4, 72);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(85, 23);
            this.labelFechaFin.TabIndex = 49;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // iconBtnLimpiar
            // 
            this.iconBtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconBtnLimpiar.IconColor = System.Drawing.Color.Black;
            this.iconBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnLimpiar.IconSize = 25;
            this.iconBtnLimpiar.Location = new System.Drawing.Point(959, 54);
            this.iconBtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnLimpiar.Name = "iconBtnLimpiar";
            this.iconBtnLimpiar.Size = new System.Drawing.Size(82, 29);
            this.iconBtnLimpiar.TabIndex = 67;
            this.iconBtnLimpiar.UseVisualStyleBackColor = false;
            this.iconBtnLimpiar.Click += new System.EventHandler(this.iconBtnLimpiar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBuscar.ForeColor = System.Drawing.Color.White;
            this.textBuscar.Location = new System.Drawing.Point(586, 56);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(254, 29);
            this.textBuscar.TabIndex = 65;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnBuscar.IconSize = 25;
            this.iconBtnBuscar.Location = new System.Drawing.Point(869, 54);
            this.iconBtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(82, 29);
            this.iconBtnBuscar.TabIndex = 66;
            this.iconBtnBuscar.UseVisualStyleBackColor = false;
            this.iconBtnBuscar.Click += new System.EventHandler(this.iconBtnBuscar_Click);
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelFechaInicio.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicio.Location = new System.Drawing.Point(4, 49);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(104, 23);
            this.labelFechaInicio.TabIndex = 48;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.cboBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Location = new System.Drawing.Point(369, 57);
            this.cboBuscarPor.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(202, 28);
            this.cboBuscarPor.TabIndex = 64;
            // 
            // labelReporteC
            // 
            this.labelReporteC.AutoSize = true;
            this.labelReporteC.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelReporteC.ForeColor = System.Drawing.Color.White;
            this.labelReporteC.Location = new System.Drawing.Point(13, 11);
            this.labelReporteC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReporteC.Name = "labelReporteC";
            this.labelReporteC.Size = new System.Drawing.Size(178, 23);
            this.labelReporteC.TabIndex = 47;
            this.labelReporteC.Text = "Reporte Compra";
            // 
            // labelBuscarPor2
            // 
            this.labelBuscarPor2.AutoSize = true;
            this.labelBuscarPor2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelBuscarPor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor2.Location = new System.Drawing.Point(258, 58);
            this.labelBuscarPor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor2.Name = "labelBuscarPor2";
            this.labelBuscarPor2.Size = new System.Drawing.Size(95, 23);
            this.labelBuscarPor2.TabIndex = 34;
            this.labelBuscarPor2.Text = "Buscar por:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCompras);
            this.panel2.Controls.Add(this.iconBtnExcel);
            this.panel2.Controls.Add(this.gbDetalle);
            this.panel2.Controls.Add(this.btnDescargarPdf);
            this.panel2.Location = new System.Drawing.Point(48, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1403, 517);
            this.panel2.TabIndex = 62;
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Compra,
            this.NCompra,
            this.Fecha,
            this.Proveedor1,
            this.Admin,
            this.Total});
            this.dgvCompras.Location = new System.Drawing.Point(4, 4);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.Size = new System.Drawing.Size(787, 449);
            this.dgvCompras.TabIndex = 15;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentClick);
            // 
            // iconBtnExcel
            // 
            this.iconBtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExcel.IconColor = System.Drawing.Color.Green;
            this.iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExcel.IconSize = 25;
            this.iconBtnExcel.Location = new System.Drawing.Point(9, 459);
            this.iconBtnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnExcel.Name = "iconBtnExcel";
            this.iconBtnExcel.Size = new System.Drawing.Size(167, 39);
            this.iconBtnExcel.TabIndex = 68;
            this.iconBtnExcel.Text = "Descargar Excel";
            this.iconBtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExcel.UseVisualStyleBackColor = false;
            this.iconBtnExcel.Click += new System.EventHandler(this.iconBtnExcel_Click);
            // 
            // gbDetalle
            // 
            this.gbDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.gbDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gbDetalle.Controls.Add(this.lblTotalDetalle);
            this.gbDetalle.Controls.Add(this.label2);
            this.gbDetalle.Controls.Add(this.labelTipoDoc);
            this.gbDetalle.Controls.Add(this.labelTotal);
            this.gbDetalle.Controls.Add(this.labelAdmin);
            this.gbDetalle.Controls.Add(this.labelFechaReg);
            this.gbDetalle.Controls.Add(this.labelProveedor);
            this.gbDetalle.Controls.Add(this.labelNCompra);
            this.gbDetalle.Controls.Add(this.lblAdmin);
            this.gbDetalle.Controls.Add(this.dgvDetalle);
            this.gbDetalle.Controls.Add(this.lblProveedor);
            this.gbDetalle.Controls.Add(this.lblNumCompra);
            this.gbDetalle.Controls.Add(this.lblFecha);
            this.gbDetalle.Controls.Add(this.label1);
            this.gbDetalle.Location = new System.Drawing.Point(809, 4);
            this.gbDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(582, 449);
            this.gbDetalle.TabIndex = 75;
            this.gbDetalle.Visible = false;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.lblTotalDetalle.ForeColor = System.Drawing.Color.White;
            this.lblTotalDetalle.Location = new System.Drawing.Point(56, 403);
            this.lblTotalDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(14, 20);
            this.lblTotalDetalle.TabIndex = 70;
            this.lblTotalDetalle.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(488, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "-";
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDoc.ForeColor = System.Drawing.Color.White;
            this.labelTipoDoc.Location = new System.Drawing.Point(354, 42);
            this.labelTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(130, 20);
            this.labelTipoDoc.TabIndex = 82;
            this.labelTipoDoc.Text = "Tipo Documento:";
            // 
            // btnDescargarPdf
            // 
            this.btnDescargarPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDescargarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDescargarPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescargarPdf.IconColor = System.Drawing.Color.Brown;
            this.btnDescargarPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPdf.IconSize = 25;
            this.btnDescargarPdf.Location = new System.Drawing.Point(196, 459);
            this.btnDescargarPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Size = new System.Drawing.Size(167, 39);
            this.btnDescargarPdf.TabIndex = 76;
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarPdf.UseVisualStyleBackColor = false;
            this.btnDescargarPdf.Click += new System.EventHandler(this.btnDescargarPdf_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(2, 400);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(50, 23);
            this.labelTotal.TabIndex = 80;
            this.labelTotal.Text = "Total:";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.White;
            this.labelAdmin.Location = new System.Drawing.Point(195, 76);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(116, 20);
            this.labelAdmin.TabIndex = 79;
            this.labelAdmin.Text = "Administrador:";
            // 
            // labelFechaReg
            // 
            this.labelFechaReg.AutoSize = true;
            this.labelFechaReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaReg.ForeColor = System.Drawing.Color.White;
            this.labelFechaReg.Location = new System.Drawing.Point(195, 42);
            this.labelFechaReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaReg.Name = "labelFechaReg";
            this.labelFechaReg.Size = new System.Drawing.Size(53, 20);
            this.labelFechaReg.TabIndex = 78;
            this.labelFechaReg.Text = "Fecha:";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.White;
            this.labelProveedor.Location = new System.Drawing.Point(19, 76);
            this.labelProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(86, 20);
            this.labelProveedor.TabIndex = 77;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // labelNCompra
            // 
            this.labelNCompra.AutoSize = true;
            this.labelNCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNCompra.ForeColor = System.Drawing.Color.White;
            this.labelNCompra.Location = new System.Drawing.Point(19, 42);
            this.labelNCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNCompra.Name = "labelNCompra";
            this.labelNCompra.Size = new System.Drawing.Size(90, 20);
            this.labelNCompra.TabIndex = 76;
            this.labelNCompra.Text = "N° Compra:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(311, 76);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(15, 20);
            this.lblAdmin.TabIndex = 75;
            this.lblAdmin.Text = "-";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.NombreProducto,
            this.PrecioCompra,
            this.subTotal});
            this.dgvDetalle.Location = new System.Drawing.Point(2, 110);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(575, 265);
            this.dgvDetalle.TabIndex = 74;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(110, 76);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(15, 20);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "-";
            // 
            // lblNumCompra
            // 
            this.lblNumCompra.AutoSize = true;
            this.lblNumCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNumCompra.ForeColor = System.Drawing.Color.White;
            this.lblNumCompra.Location = new System.Drawing.Point(110, 42);
            this.lblNumCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCompra.Name = "lblNumCompra";
            this.lblNumCompra.Size = new System.Drawing.Size(15, 20);
            this.lblNumCompra.TabIndex = 2;
            this.lblNumCompra.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(252, 42);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(15, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE COMPRA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.lblTotalCompras);
            this.panel3.Controls.Add(this.labelTotalC);
            this.panel3.Location = new System.Drawing.Point(1173, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 115);
            this.panel3.TabIndex = 63;
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblTotalCompras.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompras.Location = new System.Drawing.Point(117, 51);
            this.lblTotalCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(16, 23);
            this.lblTotalCompras.TabIndex = 69;
            this.lblTotalCompras.Text = "-";
            // 
            // labelTotalC
            // 
            this.labelTotalC.AutoSize = true;
            this.labelTotalC.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelTotalC.ForeColor = System.Drawing.Color.White;
            this.labelTotalC.Location = new System.Drawing.Point(40, 12);
            this.labelTotalC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalC.Name = "labelTotalC";
            this.labelTotalC.Size = new System.Drawing.Size(187, 23);
            this.labelTotalC.TabIndex = 68;
            this.labelTotalC.Text = "Total de Compras";
            // 
            // id_Compra
            // 
            this.id_Compra.HeaderText = "idCompra";
            this.id_Compra.MinimumWidth = 6;
            this.id_Compra.Name = "id_Compra";
            this.id_Compra.ReadOnly = true;
            this.id_Compra.Visible = false;
            // 
            // NCompra
            // 
            this.NCompra.HeaderText = "N° Compra";
            this.NCompra.MinimumWidth = 6;
            this.NCompra.Name = "NCompra";
            this.NCompra.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Proveedor1
            // 
            this.Proveedor1.HeaderText = "Proveedor";
            this.Proveedor1.MinimumWidth = 6;
            this.Proveedor1.Name = "Proveedor1";
            this.Proveedor1.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.HeaderText = "Administrador";
            this.Admin.MinimumWidth = 6;
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // ucReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReporteCompra";
            this.Size = new System.Drawing.Size(1475, 733);
            this.Load += new System.EventHandler(this.ucReporteCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelReporteC;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.Label labelBuscarPor2;
        private System.Windows.Forms.TextBox textBuscar;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
        private FontAwesome.Sharp.IconButton iconBtnLimpiar;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel gbDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblNumCompra;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelFechaReg;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelNCompra;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalC;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCompras;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
