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
            this.comboBoxPorcentaje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconBtnCancelar = new FontAwesome.Sharp.IconButton();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.iconBtnActualizarC = new FontAwesome.Sharp.IconButton();
            this.textPrecioVenta = new System.Windows.Forms.TextBox();
            this.textPrecioCompra = new System.Windows.Forms.TextBox();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.textCodProduct = new System.Windows.Forms.TextBox();
            this.iconBtnAgregarC = new FontAwesome.Sharp.IconButton();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCodigoProdu = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboTipoDocumento);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(172, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(460, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo Documento:";
            // 
            // comboTipoDocumento
            // 
            this.comboTipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTipoDocumento.ForeColor = System.Drawing.Color.White;
            this.comboTipoDocumento.FormattingEnabled = true;
            this.comboTipoDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.comboTipoDocumento.Location = new System.Drawing.Point(241, 46);
            this.comboTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.comboTipoDocumento.Name = "comboTipoDocumento";
            this.comboTipoDocumento.Size = new System.Drawing.Size(139, 31);
            this.comboTipoDocumento.TabIndex = 13;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(51, 23);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(50, 20);
            this.labelFecha.TabIndex = 10;
            this.labelFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 46);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 27);
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
            this.groupBox2.Location = new System.Drawing.Point(683, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(431, 88);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(164, 51);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 24);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRazonSocial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textRazonSocial.ForeColor = System.Drawing.Color.White;
            this.textRazonSocial.Location = new System.Drawing.Point(238, 51);
            this.textRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.textRazonSocial.Multiline = true;
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(135, 24);
            this.textRazonSocial.TabIndex = 47;
            this.textRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRazonSocial_KeyPress);
            // 
            // textNumDocumento
            // 
            this.textNumDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNumDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumDocumento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNumDocumento.ForeColor = System.Drawing.Color.White;
            this.textNumDocumento.Location = new System.Drawing.Point(22, 51);
            this.textNumDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.textNumDocumento.Multiline = true;
            this.textNumDocumento.Name = "textNumDocumento";
            this.textNumDocumento.Size = new System.Drawing.Size(135, 24);
            this.textNumDocumento.TabIndex = 46;
            this.textNumDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumDocumento_KeyPress);
            // 
            // labelNombComple
            // 
            this.labelNombComple.AutoSize = true;
            this.labelNombComple.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNombComple.ForeColor = System.Drawing.Color.White;
            this.labelNombComple.Location = new System.Drawing.Point(234, 28);
            this.labelNombComple.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombComple.Name = "labelNombComple";
            this.labelNombComple.Size = new System.Drawing.Size(97, 20);
            this.labelNombComple.TabIndex = 45;
            this.labelNombComple.Text = "Razón Social:";
            // 
            // labelNumDocumento
            // 
            this.labelNumDocumento.AutoSize = true;
            this.labelNumDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNumDocumento.ForeColor = System.Drawing.Color.White;
            this.labelNumDocumento.Location = new System.Drawing.Point(18, 28);
            this.labelNumDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumDocumento.Name = "labelNumDocumento";
            this.labelNumDocumento.Size = new System.Drawing.Size(148, 20);
            this.labelNumDocumento.TabIndex = 44;
            this.labelNumDocumento.Text = "Número Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxPorcentaje);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.numericCantidad);
            this.groupBox3.Controls.Add(this.textPrecioVenta);
            this.groupBox3.Controls.Add(this.textPrecioCompra);
            this.groupBox3.Controls.Add(this.textProducto);
            this.groupBox3.Controls.Add(this.textCodProduct);
            this.groupBox3.Controls.Add(this.labelCantidad);
            this.groupBox3.Controls.Add(this.labelStock);
            this.groupBox3.Controls.Add(this.labelPrecio);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.labelProducto);
            this.groupBox3.Controls.Add(this.labelCodigoProdu);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(172, 164);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(942, 144);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // comboBoxPorcentaje
            // 
            this.comboBoxPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxPorcentaje.FormattingEnabled = true;
            this.comboBoxPorcentaje.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "35",
            "40"});
            this.comboBoxPorcentaje.Location = new System.Drawing.Point(548, 82);
            this.comboBoxPorcentaje.Name = "comboBoxPorcentaje";
            this.comboBoxPorcentaje.Size = new System.Drawing.Size(123, 28);
            this.comboBoxPorcentaje.TabIndex = 93;
            this.comboBoxPorcentaje.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorcentaje_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(544, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Porcentaje:";
            // 
            // iconBtnCancelar
            // 
            this.iconBtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconBtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.iconBtnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconBtnCancelar.IconColor = System.Drawing.Color.Red;
            this.iconBtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCancelar.IconSize = 25;
            this.iconBtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnCancelar.Location = new System.Drawing.Point(1118, 269);
            this.iconBtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnCancelar.Name = "iconBtnCancelar";
            this.iconBtnCancelar.Size = new System.Drawing.Size(113, 39);
            this.iconBtnCancelar.TabIndex = 90;
            this.iconBtnCancelar.Text = "Cancelar";
            this.iconBtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCancelar.UseVisualStyleBackColor = false;
            this.iconBtnCancelar.Click += new System.EventHandler(this.iconBtnCancelar_Click);
            // 
            // numericCantidad
            // 
            this.numericCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.numericCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numericCantidad.ForeColor = System.Drawing.Color.White;
            this.numericCantidad.Location = new System.Drawing.Point(828, 83);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericCantidad.Size = new System.Drawing.Size(100, 26);
            this.numericCantidad.TabIndex = 52;
            this.numericCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iconBtnActualizarC
            // 
            this.iconBtnActualizarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnActualizarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnActualizarC.ForeColor = System.Drawing.Color.Black;
            this.iconBtnActualizarC.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.iconBtnActualizarC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconBtnActualizarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnActualizarC.IconSize = 25;
            this.iconBtnActualizarC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnActualizarC.Location = new System.Drawing.Point(1118, 224);
            this.iconBtnActualizarC.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnActualizarC.Name = "iconBtnActualizarC";
            this.iconBtnActualizarC.Size = new System.Drawing.Size(113, 39);
            this.iconBtnActualizarC.TabIndex = 56;
            this.iconBtnActualizarC.Text = "Actualizar";
            this.iconBtnActualizarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnActualizarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnActualizarC.UseVisualStyleBackColor = false;
            this.iconBtnActualizarC.Click += new System.EventHandler(this.iconBtnActualizarC_Click);
            // 
            // textPrecioVenta
            // 
            this.textPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.textPrecioVenta.Location = new System.Drawing.Point(691, 82);
            this.textPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecioVenta.Multiline = true;
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.Size = new System.Drawing.Size(122, 28);
            this.textPrecioVenta.TabIndex = 62;
            this.textPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStock_KeyPress);
            // 
            // textPrecioCompra
            // 
            this.textPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.textPrecioCompra.Location = new System.Drawing.Point(393, 82);
            this.textPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecioCompra.Multiline = true;
            this.textPrecioCompra.Name = "textPrecioCompra";
            this.textPrecioCompra.Size = new System.Drawing.Size(135, 28);
            this.textPrecioCompra.TabIndex = 61;
            this.textPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // textProducto
            // 
            this.textProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textProducto.ForeColor = System.Drawing.Color.White;
            this.textProducto.Location = new System.Drawing.Point(184, 82);
            this.textProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textProducto.Multiline = true;
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(188, 28);
            this.textProducto.TabIndex = 60;
            this.textProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProducto_KeyPress);
            // 
            // textCodProduct
            // 
            this.textCodProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textCodProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCodProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textCodProduct.ForeColor = System.Drawing.Color.White;
            this.textCodProduct.Location = new System.Drawing.Point(10, 82);
            this.textCodProduct.Margin = new System.Windows.Forms.Padding(2);
            this.textCodProduct.Multiline = true;
            this.textCodProduct.Name = "textCodProduct";
            this.textCodProduct.Size = new System.Drawing.Size(100, 28);
            this.textCodProduct.TabIndex = 59;
            this.textCodProduct.TextChanged += new System.EventHandler(this.textCodProduct_TextChanged);
            this.textCodProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodProduct_KeyPress);
            // 
            // iconBtnAgregarC
            // 
            this.iconBtnAgregarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAgregarC.ForeColor = System.Drawing.Color.Black;
            this.iconBtnAgregarC.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconBtnAgregarC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconBtnAgregarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregarC.IconSize = 25;
            this.iconBtnAgregarC.Location = new System.Drawing.Point(1118, 178);
            this.iconBtnAgregarC.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnAgregarC.Name = "iconBtnAgregarC";
            this.iconBtnAgregarC.Size = new System.Drawing.Size(113, 39);
            this.iconBtnAgregarC.TabIndex = 51;
            this.iconBtnAgregarC.Text = "Agregar";
            this.iconBtnAgregarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAgregarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAgregarC.UseVisualStyleBackColor = false;
            this.iconBtnAgregarC.Click += new System.EventHandler(this.iconBtnAgregarC_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(824, 44);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(83, 23);
            this.labelCantidad.TabIndex = 58;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelStock.ForeColor = System.Drawing.Color.White;
            this.labelStock.Location = new System.Drawing.Point(687, 44);
            this.labelStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(110, 23);
            this.labelStock.TabIndex = 57;
            this.labelStock.Text = "Precio Venta:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(389, 44);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(127, 23);
            this.labelPrecio.TabIndex = 56;
            this.labelPrecio.Text = "Precio Compra:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(116, 82);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(62, 28);
            this.btnBuscarProducto.TabIndex = 55;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelProducto.ForeColor = System.Drawing.Color.White;
            this.labelProducto.Location = new System.Drawing.Point(180, 44);
            this.labelProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(84, 23);
            this.labelProducto.TabIndex = 54;
            this.labelProducto.Text = "Producto:";
            // 
            // labelCodigoProdu
            // 
            this.labelCodigoProdu.AutoSize = true;
            this.labelCodigoProdu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCodigoProdu.ForeColor = System.Drawing.Color.White;
            this.labelCodigoProdu.Location = new System.Drawing.Point(6, 44);
            this.labelCodigoProdu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoProdu.Name = "labelCodigoProdu";
            this.labelCodigoProdu.Size = new System.Drawing.Size(124, 23);
            this.labelCodigoProdu.TabIndex = 53;
            this.labelCodigoProdu.Text = "Cod. Producto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.CodigoProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btnEditar,
            this.btnEliminar});
            this.dataGridView1.Location = new System.Drawing.Point(172, 328);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 208);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 70;
            // 
            // textTotalPagar
            // 
            this.textTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotalPagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTotalPagar.ForeColor = System.Drawing.Color.White;
            this.textTotalPagar.Location = new System.Drawing.Point(740, 548);
            this.textTotalPagar.Margin = new System.Windows.Forms.Padding(2);
            this.textTotalPagar.Multiline = true;
            this.textTotalPagar.Name = "textTotalPagar";
            this.textTotalPagar.Size = new System.Drawing.Size(135, 28);
            this.textTotalPagar.TabIndex = 53;
            this.textTotalPagar.Text = "0";
            this.textTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lTotalPagar
            // 
            this.lTotalPagar.AutoSize = true;
            this.lTotalPagar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lTotalPagar.ForeColor = System.Drawing.Color.White;
            this.lTotalPagar.Location = new System.Drawing.Point(624, 548);
            this.lTotalPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTotalPagar.Name = "lTotalPagar";
            this.lTotalPagar.Size = new System.Drawing.Size(112, 23);
            this.lTotalPagar.TabIndex = 52;
            this.lTotalPagar.Text = "Total a Pagar:";
            // 
            // iconBtnRegistrarC
            // 
            this.iconBtnRegistrarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnRegistrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.iconBtnRegistrarC.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconBtnRegistrarC.IconColor = System.Drawing.Color.Brown;
            this.iconBtnRegistrarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnRegistrarC.IconSize = 20;
            this.iconBtnRegistrarC.Location = new System.Drawing.Point(683, 580);
            this.iconBtnRegistrarC.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnRegistrarC.Name = "iconBtnRegistrarC";
            this.iconBtnRegistrarC.Size = new System.Drawing.Size(113, 39);
            this.iconBtnRegistrarC.TabIndex = 54;
            this.iconBtnRegistrarC.Text = "Registrar";
            this.iconBtnRegistrarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnRegistrarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRegistrarC.UseVisualStyleBackColor = false;
            this.iconBtnRegistrarC.Click += new System.EventHandler(this.iconBtnRegistrarC_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(158, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1099, 608);
            this.label3.TabIndex = 55;
            // 
            // usRegistrarCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.iconBtnAgregarC);
            this.Controls.Add(this.iconBtnRegistrarC);
            this.Controls.Add(this.iconBtnCancelar);
            this.Controls.Add(this.textTotalPagar);
            this.Controls.Add(this.lTotalPagar);
            this.Controls.Add(this.iconBtnActualizarC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "usRegistrarCom";
            this.Size = new System.Drawing.Size(1392, 649);
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
        private System.Windows.Forms.TextBox textPrecioVenta;
        private System.Windows.Forms.TextBox textPrecioCompra;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.TextBox textCodProduct;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCodigoProdu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconBtnAgregarC;
        private System.Windows.Forms.TextBox textTotalPagar;
        private System.Windows.Forms.Label lTotalPagar;
        private FontAwesome.Sharp.IconButton iconBtnRegistrarC;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconBtnActualizarC;
        private FontAwesome.Sharp.IconButton iconBtnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.ComboBox comboBoxPorcentaje;
    }
}
