namespace Proyecto_Grupo13.Administrador
{
    partial class ucVerDetalleV
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
            this.labelDetalleVenta = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMontoT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumDocu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNomCliente = new System.Windows.Forms.Label();
            this.textDocCliente = new System.Windows.Forms.TextBox();
            this.textNombreCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelRegistrarV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textnumDocume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.coumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textMontoTotal = new System.Windows.Forms.TextBox();
            this.textMontoPago = new System.Windows.Forms.TextBox();
            this.textMontoCambio = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.iconLimpiar = new FontAwesome.Sharp.IconButton();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textTipoDoc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDocumentoCliente = new System.Windows.Forms.TextBox();
            this.textNomCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDetalleVenta
            // 
            this.labelDetalleVenta.AutoSize = true;
            this.labelDetalleVenta.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelDetalleVenta.ForeColor = System.Drawing.Color.White;
            this.labelDetalleVenta.Location = new System.Drawing.Point(23, 23);
            this.labelDetalleVenta.Name = "labelDetalleVenta";
            this.labelDetalleVenta.Size = new System.Drawing.Size(147, 23);
            this.labelDetalleVenta.TabIndex = 2;
            this.labelDetalleVenta.Text = "Detalle Venta";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
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
            this.dataGridView1.Location = new System.Drawing.Point(27, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(818, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelMontoT
            // 
            this.labelMontoT.AutoSize = true;
            this.labelMontoT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMontoT.ForeColor = System.Drawing.Color.White;
            this.labelMontoT.Location = new System.Drawing.Point(24, 486);
            this.labelMontoT.Name = "labelMontoT";
            this.labelMontoT.Size = new System.Drawing.Size(93, 20);
            this.labelMontoT.TabIndex = 6;
            this.labelMontoT.Text = "Monto Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(243, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto Pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(462, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto Cambio:";
            // 
            // labelNumDocu
            // 
            this.labelNumDocu.AutoSize = true;
            this.labelNumDocu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumDocu.ForeColor = System.Drawing.Color.White;
            this.labelNumDocu.Location = new System.Drawing.Point(333, 54);
            this.labelNumDocu.Name = "labelNumDocu";
            this.labelNumDocu.Size = new System.Drawing.Size(148, 20);
            this.labelNumDocu.TabIndex = 9;
            this.labelNumDocu.Text = "Número Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 13;
            // 
            // labelNomCliente
            // 
            this.labelNomCliente.AutoSize = true;
            this.labelNomCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomCliente.ForeColor = System.Drawing.Color.White;
            this.labelNomCliente.Location = new System.Drawing.Point(287, 29);
            this.labelNomCliente.Name = "labelNomCliente";
            this.labelNomCliente.Size = new System.Drawing.Size(0, 20);
            this.labelNomCliente.TabIndex = 14;
            // 
            // textDocCliente
            // 
            this.textDocCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDocCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDocCliente.Location = new System.Drawing.Point(17, 52);
            this.textDocCliente.Multiline = true;
            this.textDocCliente.Name = "textDocCliente";
            this.textDocCliente.Size = new System.Drawing.Size(196, 22);
            this.textDocCliente.TabIndex = 15;
            // 
            // textNombreCliente
            // 
            this.textNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombreCliente.Location = new System.Drawing.Point(291, 52);
            this.textNombreCliente.Multiline = true;
            this.textNombreCliente.Name = "textNombreCliente";
            this.textNombreCliente.Size = new System.Drawing.Size(196, 22);
            this.textNombreCliente.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textNombreCliente);
            this.groupBox2.Controls.Add(this.textDocCliente);
            this.groupBox2.Controls.Add(this.labelNomCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(28, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacón Cliente";
            // 
            // labelRegistrarV
            // 
            this.labelRegistrarV.AutoSize = true;
            this.labelRegistrarV.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelRegistrarV.ForeColor = System.Drawing.Color.White;
            this.labelRegistrarV.Location = new System.Drawing.Point(280, 40);
            this.labelRegistrarV.Name = "labelRegistrarV";
            this.labelRegistrarV.Size = new System.Drawing.Size(173, 23);
            this.labelRegistrarV.TabIndex = 20;
            this.labelRegistrarV.Text = "Registrar Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTipoDoc);
            this.groupBox1.Controls.Add(this.textFecha);
            this.groupBox1.Controls.Add(this.textUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(284, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsuario.Location = new System.Drawing.Point(563, 57);
            this.textUsuario.Multiline = true;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(211, 27);
            this.textUsuario.TabIndex = 28;
            this.textUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(559, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo Documento:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(20, 29);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(50, 20);
            this.labelFecha.TabIndex = 23;
            this.labelFecha.Text = "Fecha:";
            // 
            // textnumDocume
            // 
            this.textnumDocume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textnumDocume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnumDocume.Location = new System.Drawing.Point(672, 65);
            this.textnumDocume.Multiline = true;
            this.textnumDocume.Name = "textnumDocume";
            this.textnumDocume.Size = new System.Drawing.Size(217, 24);
            this.textnumDocume.TabIndex = 32;
            this.textnumDocume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnumDocume_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(508, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Número Documento:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coumProducto,
            this.ColumPrecio,
            this.ColumnCantidad,
            this.ColumSubTotal});
            this.dataGridView2.Location = new System.Drawing.Point(284, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(829, 255);
            this.dataGridView2.TabIndex = 34;
            // 
            // coumProducto
            // 
            this.coumProducto.HeaderText = "Producto";
            this.coumProducto.MinimumWidth = 6;
            this.coumProducto.Name = "coumProducto";
            // 
            // ColumPrecio
            // 
            this.ColumPrecio.HeaderText = "Precio";
            this.ColumPrecio.MinimumWidth = 6;
            this.ColumPrecio.Name = "ColumPrecio";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MinimumWidth = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumSubTotal
            // 
            this.ColumSubTotal.HeaderText = "Sub Total";
            this.ColumSubTotal.MinimumWidth = 6;
            this.ColumSubTotal.Name = "ColumSubTotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(281, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Monto Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(500, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Monto Pago:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(719, 578);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Monto Cambio:";
            // 
            // textMontoTotal
            // 
            this.textMontoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMontoTotal.Location = new System.Drawing.Point(387, 578);
            this.textMontoTotal.Multiline = true;
            this.textMontoTotal.Name = "textMontoTotal";
            this.textMontoTotal.Size = new System.Drawing.Size(100, 22);
            this.textMontoTotal.TabIndex = 38;
            // 
            // textMontoPago
            // 
            this.textMontoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textMontoPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMontoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textMontoPago.Location = new System.Drawing.Point(606, 578);
            this.textMontoPago.Multiline = true;
            this.textMontoPago.Name = "textMontoPago";
            this.textMontoPago.Size = new System.Drawing.Size(100, 22);
            this.textMontoPago.TabIndex = 39;
            this.textMontoPago.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textMontoCambio
            // 
            this.textMontoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textMontoCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMontoCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textMontoCambio.Location = new System.Drawing.Point(844, 578);
            this.textMontoCambio.Multiline = true;
            this.textMontoCambio.Name = "textMontoCambio";
            this.textMontoCambio.Size = new System.Drawing.Size(100, 22);
            this.textMontoCambio.TabIndex = 40;
            this.textMontoCambio.TextChanged += new System.EventHandler(this.textMontoCambio_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton1.IconColor = System.Drawing.Color.Brown;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(967, 570);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(146, 40);
            this.iconButton1.TabIndex = 41;
            this.iconButton1.Text = "Descargar PDF";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconBuscar
            // 
            this.iconBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBuscar.ForeColor = System.Drawing.Color.White;
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBuscar.IconColor = System.Drawing.Color.Black;
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 25;
            this.iconBuscar.Location = new System.Drawing.Point(895, 60);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(106, 35);
            this.iconBuscar.TabIndex = 42;
            this.iconBuscar.Text = "Buscar";
            this.iconBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBuscar.UseVisualStyleBackColor = true;
            // 
            // iconLimpiar
            // 
            this.iconLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconLimpiar.ForeColor = System.Drawing.Color.White;
            this.iconLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconLimpiar.IconColor = System.Drawing.Color.Black;
            this.iconLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLimpiar.IconSize = 25;
            this.iconLimpiar.Location = new System.Drawing.Point(1007, 60);
            this.iconLimpiar.Name = "iconLimpiar";
            this.iconLimpiar.Size = new System.Drawing.Size(106, 35);
            this.iconLimpiar.TabIndex = 43;
            this.iconLimpiar.Text = "Limpiar";
            this.iconLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLimpiar.UseVisualStyleBackColor = true;
            this.iconLimpiar.Click += new System.EventHandler(this.iconLimpiar_Click);
            // 
            // textFecha
            // 
            this.textFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFecha.Location = new System.Drawing.Point(24, 54);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(211, 27);
            this.textFecha.TabIndex = 29;
            // 
            // textTipoDoc
            // 
            this.textTipoDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTipoDoc.Location = new System.Drawing.Point(269, 58);
            this.textTipoDoc.Name = "textTipoDoc";
            this.textTipoDoc.Size = new System.Drawing.Size(211, 27);
            this.textTipoDoc.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(184, -197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(670, 597);
            this.label11.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 29;
            // 
            // textDocumentoCliente
            // 
            this.textDocumentoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDocumentoCliente.Location = new System.Drawing.Point(24, 55);
            this.textDocumentoCliente.Multiline = true;
            this.textDocumentoCliente.Name = "textDocumentoCliente";
            this.textDocumentoCliente.Size = new System.Drawing.Size(208, 27);
            this.textDocumentoCliente.TabIndex = 30;
            this.textDocumentoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDocumentoCliente_KeyPress);
            // 
            // textNomCliente
            // 
            this.textNomCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNomCliente.Location = new System.Drawing.Point(344, 55);
            this.textNomCliente.Name = "textNomCliente";
            this.textNomCliente.Size = new System.Drawing.Size(212, 27);
            this.textNomCliente.TabIndex = 31;
            this.textNomCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNomCliente_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textNomCliente);
            this.groupBox3.Controls.Add(this.textDocumentoCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(284, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 100);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(284, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(829, 100);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Información Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Nombre Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(344, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(24, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 27);
            this.textBox2.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(20, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Documento Cliente:";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(236, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(941, 595);
            this.label15.TabIndex = 44;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // ucVerDetalleV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.iconLimpiar);
            this.Controls.Add(this.iconBuscar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textMontoCambio);
            this.Controls.Add(this.textMontoPago);
            this.Controls.Add(this.textMontoTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textnumDocume);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRegistrarV);
            this.Controls.Add(this.label15);
            this.Name = "ucVerDetalleV";
            this.Size = new System.Drawing.Size(1392, 682);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMontoT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumDocu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNomCliente;
        private System.Windows.Forms.TextBox textDocCliente;
        private System.Windows.Forms.TextBox textNombreCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRegistrarV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textnumDocume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMontoTotal;
        private System.Windows.Forms.TextBox textMontoPago;
        private System.Windows.Forms.TextBox textMontoCambio;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private FontAwesome.Sharp.IconButton iconLimpiar;
        private System.Windows.Forms.TextBox textTipoDoc;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDocumentoCliente;
        private System.Windows.Forms.TextBox textNomCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}
