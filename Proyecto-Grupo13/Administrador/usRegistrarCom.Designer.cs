namespace Proyecto_Grupo13.Administrador
{
    partial class usRegistrarCom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usRegistrarCom));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textRazonSocial = new System.Windows.Forms.TextBox();
            this.textNumDocumento = new System.Windows.Forms.TextBox();
            this.labelNombComple = new System.Windows.Forms.Label();
            this.labelNumDocumento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.textBoxCodProduct = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCodigoProdu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iconBtnAgregarC = new FontAwesome.Sharp.IconButton();
            this.textTotalPagar = new System.Windows.Forms.TextBox();
            this.lTotalPagar = new System.Windows.Forms.Label();
            this.iconBtnRegistrarC = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registar Compra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboTipoDocumento);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(234, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(294, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Documento:";
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.comboTipoDocumento.Location = new System.Drawing.Point(157, 35);
            this.comboTipoDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.Size = new System.Drawing.Size(112, 23);
            this.comboTipoDocumento.TabIndex = 13;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(5, 17);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(41, 15);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textRazonSocial);
            this.groupBox2.Controls.Add(this.textNumDocumento);
            this.groupBox2.Controls.Add(this.labelNombComple);
            this.groupBox2.Controls.Add(this.labelNumDocumento);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(542, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(315, 70);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(131, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 19);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRazonSocial.Location = new System.Drawing.Point(190, 41);
            this.textRazonSocial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRazonSocial.Multiline = true;
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(108, 18);
            this.textRazonSocial.TabIndex = 47;
            // 
            // textNumDocumento
            // 
            this.textNumDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumDocumento.Location = new System.Drawing.Point(18, 41);
            this.textNumDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNumDocumento.Multiline = true;
            this.textNumDocumento.Name = "textNumDocumento";
            this.textNumDocumento.Size = new System.Drawing.Size(108, 19);
            this.textNumDocumento.TabIndex = 46;
            // 
            // labelNombComple
            // 
            this.labelNombComple.AutoSize = true;
            this.labelNombComple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNombComple.ForeColor = System.Drawing.Color.White;
            this.labelNombComple.Location = new System.Drawing.Point(187, 22);
            this.labelNombComple.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombComple.Name = "labelNombComple";
            this.labelNombComple.Size = new System.Drawing.Size(76, 15);
            this.labelNombComple.TabIndex = 45;
            this.labelNombComple.Text = "Razón Social:";
            // 
            // labelNumDocumento
            // 
            this.labelNumDocumento.AutoSize = true;
            this.labelNumDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNumDocumento.ForeColor = System.Drawing.Color.White;
            this.labelNumDocumento.Location = new System.Drawing.Point(14, 22);
            this.labelNumDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumDocumento.Name = "labelNumDocumento";
            this.labelNumDocumento.Size = new System.Drawing.Size(120, 15);
            this.labelNumDocumento.TabIndex = 44;
            this.labelNumDocumento.Text = "Número Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericCantidad);
            this.groupBox3.Controls.Add(this.textStock);
            this.groupBox3.Controls.Add(this.textPrecio);
            this.groupBox3.Controls.Add(this.textProducto);
            this.groupBox3.Controls.Add(this.textBoxCodProduct);
            this.groupBox3.Controls.Add(this.labelCantidad);
            this.groupBox3.Controls.Add(this.labelStock);
            this.groupBox3.Controls.Add(this.labelPrecio);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.labelProducto);
            this.groupBox3.Controls.Add(this.labelCodigoProdu);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(234, 149);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(558, 71);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // numericCantidad
            // 
            this.numericCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.numericCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericCantidad.ForeColor = System.Drawing.Color.White;
            this.numericCantidad.Location = new System.Drawing.Point(461, 44);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(80, 19);
            this.numericCantidad.TabIndex = 52;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textStock
            // 
            this.textStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStock.Location = new System.Drawing.Point(365, 44);
            this.textStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textStock.Multiline = true;
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(80, 18);
            this.textStock.TabIndex = 62;
            this.textStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStock_KeyPress);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecio.Location = new System.Drawing.Point(269, 44);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(80, 18);
            this.textPrecio.TabIndex = 61;
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // textProducto
            // 
            this.textProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducto.Location = new System.Drawing.Point(163, 43);
            this.textProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textProducto.Multiline = true;
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(80, 18);
            this.textProducto.TabIndex = 60;
            // 
            // textBoxCodProduct
            // 
            this.textBoxCodProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBoxCodProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodProduct.Location = new System.Drawing.Point(16, 44);
            this.textBoxCodProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCodProduct.Multiline = true;
            this.textBoxCodProduct.Name = "textBoxCodProduct";
            this.textBoxCodProduct.Size = new System.Drawing.Size(80, 18);
            this.textBoxCodProduct.TabIndex = 59;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(458, 24);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(58, 15);
            this.labelCantidad.TabIndex = 58;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(362, 24);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(75, 15);
            this.labelStock.TabIndex = 57;
            this.labelStock.Text = "Precio Venta:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(266, 24);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(89, 15);
            this.labelPrecio.TabIndex = 56;
            this.labelPrecio.Text = "Precio Compra:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(102, 44);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 18);
            this.btnBuscarProducto.TabIndex = 55;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.White;
            this.labelProducto.Location = new System.Drawing.Point(160, 24);
            this.labelProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(59, 15);
            this.labelProducto.TabIndex = 54;
            this.labelProducto.Text = "Producto:";
            // 
            // labelCodigoProdu
            // 
            this.labelCodigoProdu.AutoSize = true;
            this.labelCodigoProdu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProdu.ForeColor = System.Drawing.Color.White;
            this.labelCodigoProdu.Location = new System.Drawing.Point(13, 24);
            this.labelCodigoProdu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoProdu.Name = "labelCodigoProdu";
            this.labelCodigoProdu.Size = new System.Drawing.Size(87, 15);
            this.labelCodigoProdu.TabIndex = 53;
            this.labelCodigoProdu.Text = "Cod. Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Producto,
            this.PrecioVenta,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal,
            this.btnEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(234, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 181);
            this.dataGridView1.TabIndex = 50;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "id_Producto";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Visible = false;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Width = 125;
            // 
            // iconBtnAgregarC
            // 
            this.iconBtnAgregarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnAgregarC.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAgregarC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconBtnAgregarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregarC.Location = new System.Drawing.Point(797, 158);
            this.iconBtnAgregarC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconBtnAgregarC.Name = "iconBtnAgregarC";
            this.iconBtnAgregarC.Size = new System.Drawing.Size(75, 62);
            this.iconBtnAgregarC.TabIndex = 51;
            this.iconBtnAgregarC.Text = "Agregar";
            this.iconBtnAgregarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnAgregarC.UseVisualStyleBackColor = false;
            // 
            // textTotalPagar
            // 
            this.textTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTotalPagar.ForeColor = System.Drawing.Color.White;
            this.textTotalPagar.Location = new System.Drawing.Point(797, 347);
            this.textTotalPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTotalPagar.Multiline = true;
            this.textTotalPagar.Name = "textTotalPagar";
            this.textTotalPagar.Size = new System.Drawing.Size(86, 18);
            this.textTotalPagar.TabIndex = 53;
            this.textTotalPagar.Text = "0";
            // 
            // lTotalPagar
            // 
            this.lTotalPagar.AutoSize = true;
            this.lTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lTotalPagar.Location = new System.Drawing.Point(794, 325);
            this.lTotalPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTotalPagar.Name = "lTotalPagar";
            this.lTotalPagar.Size = new System.Drawing.Size(78, 15);
            this.lTotalPagar.TabIndex = 52;
            this.lTotalPagar.Text = "Total a Pagar:";
            // 
            // iconBtnRegistrarC
            // 
            this.iconBtnRegistrarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnRegistrarC.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconBtnRegistrarC.IconColor = System.Drawing.Color.Brown;
            this.iconBtnRegistrarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnRegistrarC.IconSize = 20;
            this.iconBtnRegistrarC.Location = new System.Drawing.Point(797, 377);
            this.iconBtnRegistrarC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconBtnRegistrarC.Name = "iconBtnRegistrarC";
            this.iconBtnRegistrarC.Size = new System.Drawing.Size(86, 27);
            this.iconBtnRegistrarC.TabIndex = 54;
            this.iconBtnRegistrarC.Text = "Registrar";
            this.iconBtnRegistrarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRegistrarC.UseVisualStyleBackColor = false;
            this.iconBtnRegistrarC.Click += new System.EventHandler(this.iconBtnCrearVenta_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(215, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(680, 390);
            this.label3.TabIndex = 55;
            // 
            // usRegistrarCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.iconBtnRegistrarC);
            this.Controls.Add(this.textTotalPagar);
            this.Controls.Add(this.lTotalPagar);
            this.Controls.Add(this.iconBtnAgregarC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "usRegistrarCom";
            this.Size = new System.Drawing.Size(1114, 451);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTipoDocumento;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.TextBox textNumDocumento;
        private System.Windows.Forms.Label labelNombComple;
        private System.Windows.Forms.Label labelNumDocumento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox textBoxCodProduct;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCodigoProdu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private FontAwesome.Sharp.IconButton iconBtnAgregarC;
        private System.Windows.Forms.TextBox textTotalPagar;
        private System.Windows.Forms.Label lTotalPagar;
        private FontAwesome.Sharp.IconButton iconBtnRegistrarC;
        private System.Windows.Forms.Label label3;
    }
}
