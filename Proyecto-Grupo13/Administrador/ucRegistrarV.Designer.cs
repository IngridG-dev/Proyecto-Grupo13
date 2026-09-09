namespace Proyecto_Grupo13.Administrador
{
    partial class ucRegistrarV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegistrarV));
            this.labelRegistrarV = new System.Windows.Forms.Label();
            this.labelInfoVenta = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textNombreComple = new System.Windows.Forms.TextBox();
            this.textNumDocumento = new System.Windows.Forms.TextBox();
            this.labelNombComple = new System.Windows.Forms.Label();
            this.labelNumDocumento = new System.Windows.Forms.Label();
            this.labelInfoCliente = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.textBoxCodProduct = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.buttonBuscar2 = new System.Windows.Forms.Button();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCodigoProdu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBtnAgregarV = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lTotalPagar = new System.Windows.Forms.Label();
            this.lPagaCon = new System.Windows.Forms.Label();
            this.lCambio = new System.Windows.Forms.Label();
            this.textTotalPagar = new System.Windows.Forms.TextBox();
            this.textPagaCon = new System.Windows.Forms.TextBox();
            this.textCambio = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegistrarV
            // 
            this.labelRegistrarV.AutoSize = true;
            this.labelRegistrarV.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelRegistrarV.ForeColor = System.Drawing.Color.White;
            this.labelRegistrarV.Location = new System.Drawing.Point(13, 20);
            this.labelRegistrarV.Name = "labelRegistrarV";
            this.labelRegistrarV.Size = new System.Drawing.Size(173, 23);
            this.labelRegistrarV.TabIndex = 0;
            this.labelRegistrarV.Text = "Registrar Venta";
            this.labelRegistrarV.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelInfoVenta
            // 
            this.labelInfoVenta.AutoSize = true;
            this.labelInfoVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoVenta.ForeColor = System.Drawing.Color.White;
            this.labelInfoVenta.Location = new System.Drawing.Point(3, 0);
            this.labelInfoVenta.Name = "labelInfoVenta";
            this.labelInfoVenta.Size = new System.Drawing.Size(130, 20);
            this.labelInfoVenta.TabIndex = 1;
            this.labelInfoVenta.Text = "Información Venta";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(3, 37);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(50, 20);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Documento:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boleta"});
            this.comboBox1.Location = new System.Drawing.Point(152, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelInfoVenta);
            this.panel1.Controls.Add(this.labelFecha);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(17, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.textNombreComple);
            this.panel2.Controls.Add(this.textNumDocumento);
            this.panel2.Controls.Add(this.labelNombComple);
            this.panel2.Controls.Add(this.labelNumDocumento);
            this.panel2.Controls.Add(this.labelInfoCliente);
            this.panel2.Location = new System.Drawing.Point(381, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 100);
            this.panel2.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(149, 60);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 24);
            this.btnBuscar.TabIndex = 43;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textNombreComple
            // 
            this.textNombreComple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombreComple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombreComple.Location = new System.Drawing.Point(222, 62);
            this.textNombreComple.Multiline = true;
            this.textNombreComple.Name = "textNombreComple";
            this.textNombreComple.Size = new System.Drawing.Size(135, 22);
            this.textNombreComple.TabIndex = 4;
            this.textNombreComple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreComple_KeyPress);
            // 
            // textNumDocumento
            // 
            this.textNumDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumDocumento.Location = new System.Drawing.Point(7, 62);
            this.textNumDocumento.Multiline = true;
            this.textNumDocumento.Name = "textNumDocumento";
            this.textNumDocumento.Size = new System.Drawing.Size(135, 24);
            this.textNumDocumento.TabIndex = 3;
            this.textNumDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumDocumento_KeyPress);
            // 
            // labelNombComple
            // 
            this.labelNombComple.AutoSize = true;
            this.labelNombComple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNombComple.ForeColor = System.Drawing.Color.White;
            this.labelNombComple.Location = new System.Drawing.Point(218, 37);
            this.labelNombComple.Name = "labelNombComple";
            this.labelNombComple.Size = new System.Drawing.Size(137, 20);
            this.labelNombComple.TabIndex = 2;
            this.labelNombComple.Text = "Nombre Completo:";
            // 
            // labelNumDocumento
            // 
            this.labelNumDocumento.AutoSize = true;
            this.labelNumDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNumDocumento.ForeColor = System.Drawing.Color.White;
            this.labelNumDocumento.Location = new System.Drawing.Point(3, 37);
            this.labelNumDocumento.Name = "labelNumDocumento";
            this.labelNumDocumento.Size = new System.Drawing.Size(148, 20);
            this.labelNumDocumento.TabIndex = 1;
            this.labelNumDocumento.Text = "Número Documento:";
            // 
            // labelInfoCliente
            // 
            this.labelInfoCliente.AutoSize = true;
            this.labelInfoCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelInfoCliente.ForeColor = System.Drawing.Color.White;
            this.labelInfoCliente.Location = new System.Drawing.Point(3, 0);
            this.labelInfoCliente.Name = "labelInfoCliente";
            this.labelInfoCliente.Size = new System.Drawing.Size(139, 20);
            this.labelInfoCliente.TabIndex = 0;
            this.labelInfoCliente.Text = "Información Cliente";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numericCantidad);
            this.panel3.Controls.Add(this.textStock);
            this.panel3.Controls.Add(this.textPrecio);
            this.panel3.Controls.Add(this.textProducto);
            this.panel3.Controls.Add(this.textBoxCodProduct);
            this.panel3.Controls.Add(this.labelCantidad);
            this.panel3.Controls.Add(this.labelStock);
            this.panel3.Controls.Add(this.labelPrecio);
            this.panel3.Controls.Add(this.buttonBuscar2);
            this.panel3.Controls.Add(this.labelProducto);
            this.panel3.Controls.Add(this.labelCodigoProdu);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(17, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 100);
            this.panel3.TabIndex = 8;
            // 
            // numericCantidad
            // 
            this.numericCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.numericCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericCantidad.Location = new System.Drawing.Point(563, 58);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 18);
            this.numericCantidad.TabIndex = 9;
            // 
            // textStock
            // 
            this.textStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStock.Location = new System.Drawing.Point(439, 59);
            this.textStock.Multiline = true;
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(100, 22);
            this.textStock.TabIndex = 51;
            this.textStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStock_KeyPress);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecio.Location = new System.Drawing.Point(316, 60);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 22);
            this.textPrecio.TabIndex = 50;
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // textProducto
            // 
            this.textProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducto.Location = new System.Drawing.Point(172, 60);
            this.textProducto.Multiline = true;
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(123, 22);
            this.textProducto.TabIndex = 49;
            this.textProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProducto_KeyPress);
            // 
            // textBoxCodProduct
            // 
            this.textBoxCodProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBoxCodProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodProduct.Location = new System.Drawing.Point(7, 59);
            this.textBoxCodProduct.Multiline = true;
            this.textBoxCodProduct.Name = "textBoxCodProduct";
            this.textBoxCodProduct.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodProduct.TabIndex = 48;
            this.textBoxCodProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodProduct_KeyPress);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(559, 33);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(72, 20);
            this.labelCantidad.TabIndex = 47;
            this.labelCantidad.Text = "Cantidad:";
            this.labelCantidad.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(435, 33);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(48, 20);
            this.labelStock.TabIndex = 46;
            this.labelStock.Text = "Stock:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(312, 33);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(53, 20);
            this.labelPrecio.TabIndex = 45;
            this.labelPrecio.Text = "Precio:";
            // 
            // buttonBuscar2
            // 
            this.buttonBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.buttonBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.buttonBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar2.Image")));
            this.buttonBuscar2.Location = new System.Drawing.Point(109, 58);
            this.buttonBuscar2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar2.Name = "buttonBuscar2";
            this.buttonBuscar2.Size = new System.Drawing.Size(47, 24);
            this.buttonBuscar2.TabIndex = 44;
            this.buttonBuscar2.UseVisualStyleBackColor = false;
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.White;
            this.labelProducto.Location = new System.Drawing.Point(168, 33);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(72, 20);
            this.labelProducto.TabIndex = 10;
            this.labelProducto.Text = "Producto:";
            // 
            // labelCodigoProdu
            // 
            this.labelCodigoProdu.AutoSize = true;
            this.labelCodigoProdu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoProdu.ForeColor = System.Drawing.Color.White;
            this.labelCodigoProdu.Location = new System.Drawing.Point(3, 33);
            this.labelCodigoProdu.Name = "labelCodigoProdu";
            this.labelCodigoProdu.Size = new System.Drawing.Size(106, 20);
            this.labelCodigoProdu.TabIndex = 9;
            this.labelCodigoProdu.Text = "Cod. Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Información Producto";
            // 
            // iconBtnAgregarV
            // 
            this.iconBtnAgregarV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnAgregarV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnAgregarV.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAgregarV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconBtnAgregarV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregarV.Location = new System.Drawing.Point(714, 215);
            this.iconBtnAgregarV.Name = "iconBtnAgregarV";
            this.iconBtnAgregarV.Size = new System.Drawing.Size(75, 60);
            this.iconBtnAgregarV.TabIndex = 10;
            this.iconBtnAgregarV.Text = "Agregar";
            this.iconBtnAgregarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnAgregarV.UseVisualStyleBackColor = false;
            this.iconBtnAgregarV.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(18, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 192);
            this.dataGridView1.TabIndex = 11;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
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
            // lTotalPagar
            // 
            this.lTotalPagar.AutoSize = true;
            this.lTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lTotalPagar.Location = new System.Drawing.Point(685, 315);
            this.lTotalPagar.Name = "lTotalPagar";
            this.lTotalPagar.Size = new System.Drawing.Size(98, 20);
            this.lTotalPagar.TabIndex = 12;
            this.lTotalPagar.Text = "Total a Pagar:";
            // 
            // lPagaCon
            // 
            this.lPagaCon.AutoSize = true;
            this.lPagaCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lPagaCon.ForeColor = System.Drawing.Color.White;
            this.lPagaCon.Location = new System.Drawing.Point(685, 368);
            this.lPagaCon.Name = "lPagaCon";
            this.lPagaCon.Size = new System.Drawing.Size(72, 20);
            this.lPagaCon.TabIndex = 13;
            this.lPagaCon.Text = "Paga con:";
            // 
            // lCambio
            // 
            this.lCambio.AutoSize = true;
            this.lCambio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lCambio.ForeColor = System.Drawing.Color.White;
            this.lCambio.Location = new System.Drawing.Point(685, 422);
            this.lCambio.Name = "lCambio";
            this.lCambio.Size = new System.Drawing.Size(64, 20);
            this.lCambio.TabIndex = 14;
            this.lCambio.Text = "Cambio:";
            // 
            // textTotalPagar
            // 
            this.textTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotalPagar.Location = new System.Drawing.Point(689, 343);
            this.textTotalPagar.Multiline = true;
            this.textTotalPagar.Name = "textTotalPagar";
            this.textTotalPagar.Size = new System.Drawing.Size(108, 22);
            this.textTotalPagar.TabIndex = 15;
            // 
            // textPagaCon
            // 
            this.textPagaCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPagaCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPagaCon.Location = new System.Drawing.Point(689, 397);
            this.textPagaCon.Multiline = true;
            this.textPagaCon.Name = "textPagaCon";
            this.textPagaCon.Size = new System.Drawing.Size(108, 22);
            this.textPagaCon.TabIndex = 16;
            // 
            // textCambio
            // 
            this.textCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCambio.Location = new System.Drawing.Point(689, 445);
            this.textCambio.Multiline = true;
            this.textCambio.Name = "textCambio";
            this.textCambio.Size = new System.Drawing.Size(108, 22);
            this.textCambio.TabIndex = 17;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconButton1.IconColor = System.Drawing.Color.Brown;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(689, 473);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(108, 34);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "Crear Venta";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // ucRegistrarV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textCambio);
            this.Controls.Add(this.textPagaCon);
            this.Controls.Add(this.textTotalPagar);
            this.Controls.Add(this.lCambio);
            this.Controls.Add(this.lPagaCon);
            this.Controls.Add(this.lTotalPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconBtnAgregarV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRegistrarV);
            this.Name = "ucRegistrarV";
            this.Size = new System.Drawing.Size(824, 532);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistrarV;
        private System.Windows.Forms.Label labelInfoVenta;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNumDocumento;
        private System.Windows.Forms.Label labelInfoCliente;
        private System.Windows.Forms.Label labelNombComple;
        private System.Windows.Forms.TextBox textNombreComple;
        private System.Windows.Forms.TextBox textNumDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCodigoProdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscar2;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox textBoxCodProduct;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private FontAwesome.Sharp.IconButton iconBtnAgregarV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label lTotalPagar;
        private System.Windows.Forms.Label lPagaCon;
        private System.Windows.Forms.Label lCambio;
        private System.Windows.Forms.TextBox textTotalPagar;
        private System.Windows.Forms.TextBox textPagaCon;
        private System.Windows.Forms.TextBox textCambio;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
