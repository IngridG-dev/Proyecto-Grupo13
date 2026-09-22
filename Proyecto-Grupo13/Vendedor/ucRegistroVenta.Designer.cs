namespace Proyecto_Grupo13.Vendedor
{
    partial class ucRegistroVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegistroVenta));
            this.iconBtnCrearVenta = new FontAwesome.Sharp.IconButton();
            this.textCambio = new System.Windows.Forms.TextBox();
            this.textPagaCon = new System.Windows.Forms.TextBox();
            this.textTotalPagar = new System.Windows.Forms.TextBox();
            this.lCambio = new System.Windows.Forms.Label();
            this.lPagaCon = new System.Windows.Forms.Label();
            this.lTotalPagar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelRegistrarV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textNombreComple = new System.Windows.Forms.TextBox();
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
            this.buttonBuscar2 = new System.Windows.Forms.Button();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCodigoProdu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconBtnAgregarV = new FontAwesome.Sharp.IconButton();
            this.btnDescargarTicket = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // iconBtnCrearVenta
            // 
            this.iconBtnCrearVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnCrearVenta.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconBtnCrearVenta.IconColor = System.Drawing.Color.Brown;
            this.iconBtnCrearVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCrearVenta.IconSize = 20;
            this.iconBtnCrearVenta.Location = new System.Drawing.Point(806, 370);
            this.iconBtnCrearVenta.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnCrearVenta.Name = "iconBtnCrearVenta";
            this.iconBtnCrearVenta.Size = new System.Drawing.Size(86, 43);
            this.iconBtnCrearVenta.TabIndex = 31;
            this.iconBtnCrearVenta.Text = "Registrar Venta";
            this.iconBtnCrearVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCrearVenta.UseVisualStyleBackColor = false;
            this.iconBtnCrearVenta.Click += new System.EventHandler(this.iconBtnCrearVenta_Click);
            // 
            // textCambio
            // 
            this.textCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCambio.Location = new System.Drawing.Point(806, 349);
            this.textCambio.Margin = new System.Windows.Forms.Padding(2);
            this.textCambio.Multiline = true;
            this.textCambio.Name = "textCambio";
            this.textCambio.Size = new System.Drawing.Size(86, 18);
            this.textCambio.TabIndex = 30;
            // 
            // textPagaCon
            // 
            this.textPagaCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPagaCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPagaCon.Location = new System.Drawing.Point(807, 304);
            this.textPagaCon.Margin = new System.Windows.Forms.Padding(2);
            this.textPagaCon.Multiline = true;
            this.textPagaCon.Name = "textPagaCon";
            this.textPagaCon.Size = new System.Drawing.Size(86, 18);
            this.textPagaCon.TabIndex = 29;
            this.textPagaCon.TextChanged += new System.EventHandler(this.textPagaCon_TextChanged);
            // 
            // textTotalPagar
            // 
            this.textTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotalPagar.Location = new System.Drawing.Point(806, 266);
            this.textTotalPagar.Margin = new System.Windows.Forms.Padding(2);
            this.textTotalPagar.Multiline = true;
            this.textTotalPagar.Name = "textTotalPagar";
            this.textTotalPagar.Size = new System.Drawing.Size(86, 18);
            this.textTotalPagar.TabIndex = 28;
            // 
            // lCambio
            // 
            this.lCambio.AutoSize = true;
            this.lCambio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lCambio.ForeColor = System.Drawing.Color.White;
            this.lCambio.Location = new System.Drawing.Point(804, 330);
            this.lCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCambio.Name = "lCambio";
            this.lCambio.Size = new System.Drawing.Size(52, 15);
            this.lCambio.TabIndex = 27;
            this.lCambio.Text = "Cambio:";
            // 
            // lPagaCon
            // 
            this.lPagaCon.AutoSize = true;
            this.lPagaCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lPagaCon.ForeColor = System.Drawing.Color.White;
            this.lPagaCon.Location = new System.Drawing.Point(804, 287);
            this.lPagaCon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPagaCon.Name = "lPagaCon";
            this.lPagaCon.Size = new System.Drawing.Size(59, 15);
            this.lPagaCon.TabIndex = 26;
            this.lPagaCon.Text = "Paga con:";
            // 
            // lTotalPagar
            // 
            this.lTotalPagar.AutoSize = true;
            this.lTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lTotalPagar.Location = new System.Drawing.Point(804, 245);
            this.lTotalPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTotalPagar.Name = "lTotalPagar";
            this.lTotalPagar.Size = new System.Drawing.Size(78, 15);
            this.lTotalPagar.TabIndex = 25;
            this.lTotalPagar.Text = "Total a Pagar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btnEditar,
            this.btnEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(250, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 204);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Codigo Producto";
            this.codigoProducto.MinimumWidth = 6;
            this.codigoProducto.Name = "codigoProducto";
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
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // labelRegistrarV
            // 
            this.labelRegistrarV.AutoSize = true;
            this.labelRegistrarV.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelRegistrarV.ForeColor = System.Drawing.Color.White;
            this.labelRegistrarV.Location = new System.Drawing.Point(246, 36);
            this.labelRegistrarV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrarV.Name = "labelRegistrarV";
            this.labelRegistrarV.Size = new System.Drawing.Size(138, 19);
            this.labelRegistrarV.TabIndex = 19;
            this.labelRegistrarV.Text = "Registrar Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(250, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(294, 70);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo Documento:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.comboBox1.Location = new System.Drawing.Point(157, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(5, 20);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(41, 15);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textNombreComple);
            this.groupBox2.Controls.Add(this.textNumDocumento);
            this.groupBox2.Controls.Add(this.labelNombComple);
            this.groupBox2.Controls.Add(this.labelNumDocumento);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(588, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(294, 70);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(122, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 19);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textNombreComple
            // 
            this.textNombreComple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombreComple.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombreComple.Location = new System.Drawing.Point(181, 41);
            this.textNombreComple.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreComple.Multiline = true;
            this.textNombreComple.Name = "textNombreComple";
            this.textNombreComple.Size = new System.Drawing.Size(108, 18);
            this.textNombreComple.TabIndex = 47;
            // 
            // textNumDocumento
            // 
            this.textNumDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumDocumento.Location = new System.Drawing.Point(9, 41);
            this.textNumDocumento.Margin = new System.Windows.Forms.Padding(2);
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
            this.labelNombComple.Location = new System.Drawing.Point(178, 22);
            this.labelNombComple.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombComple.Name = "labelNombComple";
            this.labelNombComple.Size = new System.Drawing.Size(110, 15);
            this.labelNombComple.TabIndex = 45;
            this.labelNombComple.Text = "Nombre Completo:";
            // 
            // labelNumDocumento
            // 
            this.labelNumDocumento.AutoSize = true;
            this.labelNumDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNumDocumento.ForeColor = System.Drawing.Color.White;
            this.labelNumDocumento.Location = new System.Drawing.Point(6, 22);
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
            this.groupBox3.Controls.Add(this.buttonBuscar2);
            this.groupBox3.Controls.Add(this.labelProducto);
            this.groupBox3.Controls.Add(this.labelCodigoProdu);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(250, 150);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(558, 71);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // numericCantidad
            // 
            this.numericCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.numericCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericCantidad.Location = new System.Drawing.Point(461, 44);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(2);
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
            this.textStock.Margin = new System.Windows.Forms.Padding(2);
            this.textStock.Multiline = true;
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(80, 18);
            this.textStock.TabIndex = 62;
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecio.Location = new System.Drawing.Point(269, 44);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecio.Multiline = true;
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(80, 18);
            this.textPrecio.TabIndex = 61;
            // 
            // textProducto
            // 
            this.textProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducto.Location = new System.Drawing.Point(173, 44);
            this.textProducto.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBoxCodProduct.Margin = new System.Windows.Forms.Padding(2);
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
            this.labelStock.Size = new System.Drawing.Size(39, 15);
            this.labelStock.TabIndex = 57;
            this.labelStock.Text = "Stock:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(266, 24);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(43, 15);
            this.labelPrecio.TabIndex = 56;
            this.labelPrecio.Text = "Precio:";
            // 
            // buttonBuscar2
            // 
            this.buttonBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.buttonBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.buttonBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar2.Image")));
            this.buttonBuscar2.Location = new System.Drawing.Point(101, 42);
            this.buttonBuscar2.Name = "buttonBuscar2";
            this.buttonBuscar2.Size = new System.Drawing.Size(45, 18);
            this.buttonBuscar2.TabIndex = 55;
            this.buttonBuscar2.UseVisualStyleBackColor = false;
            this.buttonBuscar2.Click += new System.EventHandler(this.buttonBuscar2_Click);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.White;
            this.labelProducto.Location = new System.Drawing.Point(170, 24);
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
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(230, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 452);
            this.label2.TabIndex = 35;
            // 
            // iconBtnAgregarV
            // 
            this.iconBtnAgregarV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnAgregarV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnAgregarV.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAgregarV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconBtnAgregarV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregarV.Location = new System.Drawing.Point(822, 166);
            this.iconBtnAgregarV.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnAgregarV.Name = "iconBtnAgregarV";
            this.iconBtnAgregarV.Size = new System.Drawing.Size(60, 56);
            this.iconBtnAgregarV.TabIndex = 23;
            this.iconBtnAgregarV.Text = "Agregar";
            this.iconBtnAgregarV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconBtnAgregarV.UseVisualStyleBackColor = false;
            this.iconBtnAgregarV.Click += new System.EventHandler(this.iconBtnAgregarV_Click);
            // 
            // btnDescargarTicket
            // 
            this.btnDescargarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDescargarTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDescargarTicket.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescargarTicket.IconColor = System.Drawing.Color.Brown;
            this.btnDescargarTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarTicket.IconSize = 20;
            this.btnDescargarTicket.Location = new System.Drawing.Point(790, 417);
            this.btnDescargarTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescargarTicket.Name = "btnDescargarTicket";
            this.btnDescargarTicket.Size = new System.Drawing.Size(117, 32);
            this.btnDescargarTicket.TabIndex = 42;
            this.btnDescargarTicket.Text = "Imprimir Ticket";
            this.btnDescargarTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarTicket.UseVisualStyleBackColor = false;
            // 
            // ucRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.btnDescargarTicket);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconBtnCrearVenta);
            this.Controls.Add(this.textCambio);
            this.Controls.Add(this.textPagaCon);
            this.Controls.Add(this.textTotalPagar);
            this.Controls.Add(this.lCambio);
            this.Controls.Add(this.lPagaCon);
            this.Controls.Add(this.lTotalPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iconBtnAgregarV);
            this.Controls.Add(this.labelRegistrarV);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucRegistroVenta";
            this.Size = new System.Drawing.Size(1114, 513);
            this.Load += new System.EventHandler(this.ucRegistroVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtnCrearVenta;
        private System.Windows.Forms.TextBox textCambio;
        private System.Windows.Forms.TextBox textPagaCon;
        private System.Windows.Forms.TextBox textTotalPagar;
        private System.Windows.Forms.Label lCambio;
        private System.Windows.Forms.Label lPagaCon;
        private System.Windows.Forms.Label lTotalPagar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelRegistrarV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textNombreComple;
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
        private System.Windows.Forms.Button buttonBuscar2;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCodigoProdu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private FontAwesome.Sharp.IconButton iconBtnAgregarV;
        private FontAwesome.Sharp.IconButton btnDescargarTicket;
    }
}
