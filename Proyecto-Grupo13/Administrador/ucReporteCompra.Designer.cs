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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.iconBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.textnumDocume = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelBuscarPor2 = new System.Windows.Forms.Label();
            this.NCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.panelTicket = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTicketFecha = new System.Windows.Forms.Label();
            this.lblTicketNumero = new System.Windows.Forms.Label();
            this.lblTicketProveedor = new System.Windows.Forms.Label();
            this.lblTicketUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panelTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(34, 52);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1340, 630);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnBuscar.Location = new System.Drawing.Point(804, 45);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 28);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 55);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 55);
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
            this.panel2.Controls.Add(this.dgvCompras);
            this.panel2.Controls.Add(this.iconBtnExcel);
            this.panel2.Controls.Add(this.iconBtnLimpiar);
            this.panel2.Controls.Add(this.iconBtnBuscar);
            this.panel2.Controls.Add(this.textnumDocume);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.labelBuscarPor2);
            this.panel2.Controls.Add(this.panelTicket);
            this.panel2.Location = new System.Drawing.Point(48, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 470);
            this.panel2.TabIndex = 62;
            // 
            // dgvCompras
            // 
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
            this.NCompra,
            this.Fecha,
            this.Proveedor1,
            this.Total,
            this.Ver});
            this.dgvCompras.Location = new System.Drawing.Point(17, 92);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.Size = new System.Drawing.Size(710, 360);
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
            this.iconBtnExcel.Location = new System.Drawing.Point(540, 22);
            this.iconBtnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnExcel.Name = "iconBtnExcel";
            this.iconBtnExcel.Size = new System.Drawing.Size(138, 29);
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
            this.iconBtnLimpiar.Location = new System.Drawing.Point(481, 22);
            this.iconBtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnLimpiar.Name = "iconBtnLimpiar";
            this.iconBtnLimpiar.Size = new System.Drawing.Size(51, 29);
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
            this.iconBtnBuscar.Location = new System.Drawing.Point(425, 22);
            this.iconBtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnBuscar.Name = "iconBtnBuscar";
            this.iconBtnBuscar.Size = new System.Drawing.Size(51, 29);
            this.iconBtnBuscar.TabIndex = 66;
            this.iconBtnBuscar.UseVisualStyleBackColor = false;
            this.iconBtnBuscar.Click += new System.EventHandler(this.iconBtnBuscar_Click);
            // 
            // textnumDocume
            // 
            this.textnumDocume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textnumDocume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnumDocume.Location = new System.Drawing.Point(230, 22);
            this.textnumDocume.Margin = new System.Windows.Forms.Padding(2);
            this.textnumDocume.Multiline = true;
            this.textnumDocume.Name = "textnumDocume";
            this.textnumDocume.Size = new System.Drawing.Size(191, 29);
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
            this.comboBox1.Location = new System.Drawing.Point(99, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 28);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelBuscarPor2
            // 
            this.labelBuscarPor2.AutoSize = true;
            this.labelBuscarPor2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor2.Location = new System.Drawing.Point(13, 26);
            this.labelBuscarPor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor2.Name = "labelBuscarPor2";
            this.labelBuscarPor2.Size = new System.Drawing.Size(82, 20);
            this.labelBuscarPor2.TabIndex = 34;
            this.labelBuscarPor2.Text = "Buscar por:";
            this.labelBuscarPor2.Click += new System.EventHandler(this.labelBuscarPor2_Click);
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
            // dgvDetalles
            // 
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.NombreProducto,
            this.PrecioCompra,
            this.subTotal});
            this.dgvDetalles.Location = new System.Drawing.Point(23, 124);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(425, 281);
            this.dgvDetalles.TabIndex = 74;
            // 
            // panelTicket
            // 
            this.panelTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.panelTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicket.Controls.Add(this.label5);
            this.panelTicket.Controls.Add(this.label4);
            this.panelTicket.Controls.Add(this.label3);
            this.panelTicket.Controls.Add(this.label2);
            this.panelTicket.Controls.Add(this.lblTicketUsuario);
            this.panelTicket.Controls.Add(this.dgvDetalles);
            this.panelTicket.Controls.Add(this.lblTicketProveedor);
            this.panelTicket.Controls.Add(this.lblTicketNumero);
            this.panelTicket.Controls.Add(this.lblTicketFecha);
            this.panelTicket.Controls.Add(this.label1);
            this.panelTicket.Location = new System.Drawing.Point(777, 22);
            this.panelTicket.Name = "panelTicket";
            this.panelTicket.Size = new System.Drawing.Size(465, 430);
            this.panelTicket.TabIndex = 75;
            this.panelTicket.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE COMPRA";
            // 
            // lblTicketFecha
            // 
            this.lblTicketFecha.AutoSize = true;
            this.lblTicketFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketFecha.ForeColor = System.Drawing.Color.White;
            this.lblTicketFecha.Location = new System.Drawing.Point(320, 43);
            this.lblTicketFecha.Name = "lblTicketFecha";
            this.lblTicketFecha.Size = new System.Drawing.Size(15, 20);
            this.lblTicketFecha.TabIndex = 1;
            this.lblTicketFecha.Text = "-";
            // 
            // lblTicketNumero
            // 
            this.lblTicketNumero.AutoSize = true;
            this.lblTicketNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketNumero.ForeColor = System.Drawing.Color.White;
            this.lblTicketNumero.Location = new System.Drawing.Point(117, 39);
            this.lblTicketNumero.Name = "lblTicketNumero";
            this.lblTicketNumero.Size = new System.Drawing.Size(15, 20);
            this.lblTicketNumero.TabIndex = 2;
            this.lblTicketNumero.Text = "-";
            // 
            // lblTicketProveedor
            // 
            this.lblTicketProveedor.AutoSize = true;
            this.lblTicketProveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketProveedor.ForeColor = System.Drawing.Color.White;
            this.lblTicketProveedor.Location = new System.Drawing.Point(125, 76);
            this.lblTicketProveedor.Name = "lblTicketProveedor";
            this.lblTicketProveedor.Size = new System.Drawing.Size(15, 20);
            this.lblTicketProveedor.TabIndex = 3;
            this.lblTicketProveedor.Text = "-";
            // 
            // lblTicketUsuario
            // 
            this.lblTicketUsuario.AutoSize = true;
            this.lblTicketUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTicketUsuario.Location = new System.Drawing.Point(380, 72);
            this.lblTicketUsuario.Name = "lblTicketUsuario";
            this.lblTicketUsuario.Size = new System.Drawing.Size(15, 20);
            this.lblTicketUsuario.TabIndex = 75;
            this.lblTicketUsuario.Text = "-";
            this.lblTicketUsuario.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "N° Ticket:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(264, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(228, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Usuario que registro:";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 125;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 125;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.MinimumWidth = 6;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 125;
            // 
            // ucReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReporteCompra";
            this.Size = new System.Drawing.Size(1392, 682);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panelTicket.ResumeLayout(false);
            this.panelTicket.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel panelTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTicketUsuario;
        private System.Windows.Forms.Label lblTicketProveedor;
        private System.Windows.Forms.Label lblTicketNumero;
        private System.Windows.Forms.Label lblTicketFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
    }
}
