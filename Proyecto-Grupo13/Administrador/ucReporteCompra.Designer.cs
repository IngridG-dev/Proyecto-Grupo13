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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelReporteC = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.iconBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.textnumDocume = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor2 = new System.Windows.Forms.Label();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelFechaReg = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelNCompra = new System.Windows.Forms.Label();
            this.lblTicketUsuario = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.lblTicketProveedor = new System.Windows.Forms.Label();
            this.lblTicketNumero = new System.Windows.Forms.Label();
            this.lblTicketFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelMPago = new System.Windows.Forms.Label();
            this.btnDescargarPdf = new FontAwesome.Sharp.IconButton();
            this.NCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotalC = new System.Windows.Forms.Label();
            this.labelTipoDoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.panelTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(27, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1072, 504);
            this.label16.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.iconBtnLimpiar);
            this.panel1.Controls.Add(this.textnumDocume);
            this.panel1.Controls.Add(this.iconBtnBuscar);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelReporteC);
            this.panel1.Controls.Add(this.labelBuscarPor2);
            this.panel1.Location = new System.Drawing.Point(38, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 92);
            this.panel1.TabIndex = 61;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 44);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(196, 44);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(60, 15);
            this.labelFechaFin.TabIndex = 49;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicio.Location = new System.Drawing.Point(3, 44);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(73, 15);
            this.labelFechaInicio.TabIndex = 48;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelReporteC
            // 
            this.labelReporteC.AutoSize = true;
            this.labelReporteC.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelReporteC.ForeColor = System.Drawing.Color.White;
            this.labelReporteC.Location = new System.Drawing.Point(2, 9);
            this.labelReporteC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReporteC.Name = "labelReporteC";
            this.labelReporteC.Size = new System.Drawing.Size(144, 19);
            this.labelReporteC.TabIndex = 47;
            this.labelReporteC.Text = "Reporte Compra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCompras);
            this.panel2.Controls.Add(this.iconBtnExcel);
            this.panel2.Controls.Add(this.panelTicket);
            this.panel2.Location = new System.Drawing.Point(38, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 376);
            this.panel2.TabIndex = 62;
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NCompra,
            this.Fecha,
            this.Proveedor1,
            this.Admin,
            this.Total,
            this.Ver});
            this.dgvCompras.Location = new System.Drawing.Point(3, 3);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.Size = new System.Drawing.Size(568, 330);
            this.dgvCompras.TabIndex = 15;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentClick);
            // 
            // iconBtnExcel
            // 
            this.iconBtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExcel.IconColor = System.Drawing.Color.Black;
            this.iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExcel.IconSize = 15;
            this.iconBtnExcel.Location = new System.Drawing.Point(7, 339);
            this.iconBtnExcel.Name = "iconBtnExcel";
            this.iconBtnExcel.Size = new System.Drawing.Size(110, 23);
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
            this.iconBtnLimpiar.Location = new System.Drawing.Point(693, 41);
            this.iconBtnLimpiar.Name = "iconBtnLimpiar";
            this.iconBtnLimpiar.Size = new System.Drawing.Size(41, 23);
            this.iconBtnLimpiar.TabIndex = 67;
            this.iconBtnLimpiar.UseVisualStyleBackColor = false;
            this.iconBtnLimpiar.Click += new System.EventHandler(this.iconBtnLimpiar_Click);
            // 
            // iconBtnBuscar
            // 
            this.iconBtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBtnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.iconBtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnBuscar.IconSize = 16;
            this.iconBtnBuscar.Location = new System.Drawing.Point(646, 41);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(41, 23);
            this.iconBtnBuscar.TabIndex = 66;
            this.iconBtnBuscar.UseVisualStyleBackColor = false;
            this.iconBtnBuscar.Click += new System.EventHandler(this.iconBtnBuscar_Click);
            // 
            // textnumDocume
            // 
            this.textnumDocume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textnumDocume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnumDocume.Location = new System.Drawing.Point(489, 41);
            this.textnumDocume.Margin = new System.Windows.Forms.Padding(2);
            this.textnumDocume.Multiline = true;
            this.textnumDocume.Name = "textnumDocume";
            this.textnumDocume.Size = new System.Drawing.Size(153, 23);
            this.textnumDocume.TabIndex = 65;
            this.textnumDocume.TextChanged += new System.EventHandler(this.textnumDocume_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Numero de Compra",
            "Proveedor",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(384, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 23);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelBuscarPor2
            // 
            this.labelBuscarPor2.AutoSize = true;
            this.labelBuscarPor2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor2.Location = new System.Drawing.Point(381, 23);
            this.labelBuscarPor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor2.Name = "labelBuscarPor2";
            this.labelBuscarPor2.Size = new System.Drawing.Size(66, 15);
            this.labelBuscarPor2.TabIndex = 34;
            this.labelBuscarPor2.Text = "Buscar por:";
            this.labelBuscarPor2.Click += new System.EventHandler(this.labelBuscarPor2_Click);
            // 
            // panelTicket
            // 
            this.panelTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.panelTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicket.Controls.Add(this.label2);
            this.panelTicket.Controls.Add(this.labelTipoDoc);
            this.panelTicket.Controls.Add(this.btnDescargarPdf);
            this.panelTicket.Controls.Add(this.labelMPago);
            this.panelTicket.Controls.Add(this.labelTotal);
            this.panelTicket.Controls.Add(this.labelAdmin);
            this.panelTicket.Controls.Add(this.labelFechaReg);
            this.panelTicket.Controls.Add(this.labelProveedor);
            this.panelTicket.Controls.Add(this.labelNCompra);
            this.panelTicket.Controls.Add(this.lblTicketUsuario);
            this.panelTicket.Controls.Add(this.dgvDetalles);
            this.panelTicket.Controls.Add(this.lblTicketProveedor);
            this.panelTicket.Controls.Add(this.lblTicketNumero);
            this.panelTicket.Controls.Add(this.lblTicketFecha);
            this.panelTicket.Controls.Add(this.label1);
            this.panelTicket.Location = new System.Drawing.Point(587, 0);
            this.panelTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(466, 362);
            this.panelTicket.TabIndex = 75;
            this.panelTicket.Visible = false;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.White;
            this.labelAdmin.Location = new System.Drawing.Point(156, 61);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(89, 15);
            this.labelAdmin.TabIndex = 79;
            this.labelAdmin.Text = "Administrador:";
            // 
            // labelFechaReg
            // 
            this.labelFechaReg.AutoSize = true;
            this.labelFechaReg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaReg.ForeColor = System.Drawing.Color.White;
            this.labelFechaReg.Location = new System.Drawing.Point(156, 34);
            this.labelFechaReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaReg.Name = "labelFechaReg";
            this.labelFechaReg.Size = new System.Drawing.Size(42, 15);
            this.labelFechaReg.TabIndex = 78;
            this.labelFechaReg.Text = "Fecha:";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.White;
            this.labelProveedor.Location = new System.Drawing.Point(15, 61);
            this.labelProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(69, 15);
            this.labelProveedor.TabIndex = 77;
            this.labelProveedor.Text = "Proveedor:";
            // 
            // labelNCompra
            // 
            this.labelNCompra.AutoSize = true;
            this.labelNCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNCompra.ForeColor = System.Drawing.Color.White;
            this.labelNCompra.Location = new System.Drawing.Point(15, 34);
            this.labelNCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNCompra.Name = "labelNCompra";
            this.labelNCompra.Size = new System.Drawing.Size(70, 15);
            this.labelNCompra.TabIndex = 76;
            this.labelNCompra.Text = "N° Compra:";
            // 
            // lblTicketUsuario
            // 
            this.lblTicketUsuario.AutoSize = true;
            this.lblTicketUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTicketUsuario.Location = new System.Drawing.Point(249, 61);
            this.lblTicketUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketUsuario.Name = "lblTicketUsuario";
            this.lblTicketUsuario.Size = new System.Drawing.Size(12, 15);
            this.lblTicketUsuario.TabIndex = 75;
            this.lblTicketUsuario.Text = "-";
            this.lblTicketUsuario.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.NombreProducto,
            this.PrecioCompra,
            this.subTotal});
            this.dgvDetalles.Location = new System.Drawing.Point(2, 88);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(460, 212);
            this.dgvDetalles.TabIndex = 74;
            // 
            // lblTicketProveedor
            // 
            this.lblTicketProveedor.AutoSize = true;
            this.lblTicketProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketProveedor.ForeColor = System.Drawing.Color.White;
            this.lblTicketProveedor.Location = new System.Drawing.Point(88, 61);
            this.lblTicketProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketProveedor.Name = "lblTicketProveedor";
            this.lblTicketProveedor.Size = new System.Drawing.Size(12, 15);
            this.lblTicketProveedor.TabIndex = 3;
            this.lblTicketProveedor.Text = "-";
            // 
            // lblTicketNumero
            // 
            this.lblTicketNumero.AutoSize = true;
            this.lblTicketNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketNumero.ForeColor = System.Drawing.Color.White;
            this.lblTicketNumero.Location = new System.Drawing.Point(88, 34);
            this.lblTicketNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketNumero.Name = "lblTicketNumero";
            this.lblTicketNumero.Size = new System.Drawing.Size(12, 15);
            this.lblTicketNumero.TabIndex = 2;
            this.lblTicketNumero.Text = "-";
            // 
            // lblTicketFecha
            // 
            this.lblTicketFecha.AutoSize = true;
            this.lblTicketFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketFecha.ForeColor = System.Drawing.Color.White;
            this.lblTicketFecha.Location = new System.Drawing.Point(202, 34);
            this.lblTicketFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketFecha.Name = "lblTicketFecha";
            this.lblTicketFecha.Size = new System.Drawing.Size(12, 15);
            this.lblTicketFecha.TabIndex = 1;
            this.lblTicketFecha.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE COMPRA";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(14, 315);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 15);
            this.labelTotal.TabIndex = 80;
            this.labelTotal.Text = "Total:";
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
            // labelMPago
            // 
            this.labelMPago.AutoSize = true;
            this.labelMPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMPago.ForeColor = System.Drawing.Color.White;
            this.labelMPago.Location = new System.Drawing.Point(14, 338);
            this.labelMPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMPago.Name = "labelMPago";
            this.labelMPago.Size = new System.Drawing.Size(84, 15);
            this.labelMPago.TabIndex = 81;
            this.labelMPago.Text = "Metodo Pago:";
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
            this.btnDescargarPdf.Location = new System.Drawing.Point(368, 332);
            this.btnDescargarPdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescargarPdf.Name = "btnDescargarPdf";
            this.btnDescargarPdf.Size = new System.Drawing.Size(94, 26);
            this.btnDescargarPdf.TabIndex = 76;
            this.btnDescargarPdf.Text = "Descargar PDF";
            this.btnDescargarPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarPdf.UseVisualStyleBackColor = false;
            // 
            // NCompra
            // 
            this.NCompra.HeaderText = "N° Compra";
            this.NCompra.MinimumWidth = 6;
            this.NCompra.Name = "NCompra";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // Proveedor1
            // 
            this.Proveedor1.HeaderText = "Proveedor";
            this.Proveedor1.MinimumWidth = 6;
            this.Proveedor1.Name = "Proveedor1";
            // 
            // Admin
            // 
            this.Admin.HeaderText = "Administrador";
            this.Admin.Name = "Admin";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.MinimumWidth = 6;
            this.Ver.Name = "Ver";
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.panel3.Controls.Add(this.labelTotalC);
            this.panel3.Location = new System.Drawing.Point(791, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 92);
            this.panel3.TabIndex = 63;
            // 
            // labelTotalC
            // 
            this.labelTotalC.AutoSize = true;
            this.labelTotalC.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalC.ForeColor = System.Drawing.Color.White;
            this.labelTotalC.Location = new System.Drawing.Point(46, 10);
            this.labelTotalC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalC.Name = "labelTotalC";
            this.labelTotalC.Size = new System.Drawing.Size(114, 14);
            this.labelTotalC.TabIndex = 68;
            this.labelTotalC.Text = "Total de Compras";
            // 
            // labelTipoDoc
            // 
            this.labelTipoDoc.AutoSize = true;
            this.labelTipoDoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDoc.ForeColor = System.Drawing.Color.White;
            this.labelTipoDoc.Location = new System.Drawing.Point(283, 34);
            this.labelTipoDoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoDoc.Name = "labelTipoDoc";
            this.labelTipoDoc.Size = new System.Drawing.Size(103, 15);
            this.labelTipoDoc.TabIndex = 82;
            this.labelTipoDoc.Text = "Tipo Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(390, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "-";
            // 
            // ucReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Name = "ucReporteCompra";
            this.Size = new System.Drawing.Size(1114, 546);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelBuscarPor2;
        private System.Windows.Forms.TextBox textnumDocume;
        private FontAwesome.Sharp.IconButton iconBtnBuscar;
        private FontAwesome.Sharp.IconButton iconBtnLimpiar;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel panelTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTicketUsuario;
        private System.Windows.Forms.Label lblTicketProveedor;
        private System.Windows.Forms.Label lblTicketNumero;
        private System.Windows.Forms.Label lblTicketFecha;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelFechaReg;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelNCompra;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private FontAwesome.Sharp.IconButton btnDescargarPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotalC;
        private System.Windows.Forms.Label labelTipoDoc;
        private System.Windows.Forms.Label label2;
    }
}
