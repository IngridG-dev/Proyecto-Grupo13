namespace Proyecto_Grupo13.Administrador
{
    partial class UcProductos2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcProductos2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.comboBoxCatego = new System.Windows.Forms.ComboBox();
            this.textStock = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lStock = new System.Windows.Forms.Label();
            this.lCategoria = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lCodigo = new System.Windows.Forms.Label();
            this.lNombreP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProductos = new System.Windows.Forms.Label();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.buttonBuscar2 = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor2 = new System.Windows.Forms.ComboBox();
            this.labelBuscar2 = new System.Windows.Forms.Label();
            this.textBuscar2 = new System.Windows.Forms.TextBox();
            this.labelBuscarPor2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.labelProductos);
            this.panel1.Controls.Add(this.btnEliminarProd);
            this.panel1.Controls.Add(this.btnAgregarProd);
            this.panel1.Controls.Add(this.btnEditarProd);
            this.panel1.Controls.Add(this.comboBoxCatego);
            this.panel1.Controls.Add(this.textStock);
            this.panel1.Controls.Add(this.textDescripcion);
            this.panel1.Controls.Add(this.textCodigo);
            this.panel1.Controls.Add(this.textNombre);
            this.panel1.Controls.Add(this.lStock);
            this.panel1.Controls.Add(this.lCategoria);
            this.panel1.Controls.Add(this.lDescripcion);
            this.panel1.Controls.Add(this.lCodigo);
            this.panel1.Controls.Add(this.lNombreP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 711);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEliminarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProd.Image")));
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(93, 353);
            this.btnEliminarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(124, 48);
            this.btnEliminarProd.TabIndex = 10;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnAgregarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProd.Image")));
            this.btnAgregarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProd.Location = new System.Drawing.Point(159, 299);
            this.btnAgregarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(117, 49);
            this.btnAgregarProd.TabIndex = 9;
            this.btnAgregarProd.Text = "Agregar";
            this.btnAgregarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarProd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEditarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProd.Image")));
            this.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProd.Location = new System.Drawing.Point(27, 299);
            this.btnEditarProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(101, 49);
            this.btnEditarProd.TabIndex = 0;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // comboBoxCatego
            // 
            this.comboBoxCatego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxCatego.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboBoxCatego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBoxCatego.FormattingEnabled = true;
            this.comboBoxCatego.Items.AddRange(new object[] {
            "Vinilos",
            "CDs",
            "Instrumentos Musicales",
            "Reproductores"});
            this.comboBoxCatego.Location = new System.Drawing.Point(139, 192);
            this.comboBoxCatego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCatego.Name = "comboBoxCatego";
            this.comboBoxCatego.Size = new System.Drawing.Size(153, 33);
            this.comboBoxCatego.TabIndex = 0;
            // 
            // textStock
            // 
            this.textStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textStock.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textStock.Location = new System.Drawing.Point(139, 245);
            this.textStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(153, 25);
            this.textStock.TabIndex = 8;
            this.textStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStock_KeyPress);
            // 
            // textDescripcion
            // 
            this.textDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textDescripcion.Location = new System.Drawing.Point(139, 147);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(153, 25);
            this.textDescripcion.TabIndex = 6;
            this.textDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDescripcion_KeyPress);
            // 
            // textCodigo
            // 
            this.textCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCodigo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textCodigo.Location = new System.Drawing.Point(139, 102);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(153, 25);
            this.textCodigo.TabIndex = 5;
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textNombre.Location = new System.Drawing.Point(139, 53);
            this.textNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(153, 24);
            this.textNombre.TabIndex = 0;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lStock.Location = new System.Drawing.Point(3, 239);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(60, 28);
            this.lStock.TabIndex = 4;
            this.lStock.Text = "Stock";
            // 
            // lCategoria
            // 
            this.lCategoria.AutoSize = true;
            this.lCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lCategoria.Location = new System.Drawing.Point(3, 191);
            this.lCategoria.Name = "lCategoria";
            this.lCategoria.Size = new System.Drawing.Size(97, 28);
            this.lCategoria.TabIndex = 3;
            this.lCategoria.Text = "Categoría";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDescripcion.Location = new System.Drawing.Point(3, 144);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(114, 28);
            this.lDescripcion.TabIndex = 2;
            this.lDescripcion.Text = "Descripción";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lCodigo.Location = new System.Drawing.Point(3, 93);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(77, 28);
            this.lCodigo.TabIndex = 1;
            this.lCodigo.Text = "Código";
            this.lCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lNombreP
            // 
            this.lNombreP.AutoSize = true;
            this.lNombreP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lNombreP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lNombreP.Location = new System.Drawing.Point(3, 48);
            this.lNombreP.Name = "lNombreP";
            this.lNombreP.Size = new System.Drawing.Size(85, 28);
            this.lNombreP.TabIndex = 0;
            this.lNombreP.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.labelBuscarPor2);
            this.panel2.Controls.Add(this.buttonBuscar2);
            this.panel2.Controls.Add(this.comboBoxBuscarPor2);
            this.panel2.Controls.Add(this.labelBuscar2);
            this.panel2.Controls.Add(this.textBuscar2);
            this.panel2.Controls.Add(this.labelListaProductos);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(317, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 711);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Codigo,
            this.Descripcion,
            this.Categoria,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 631);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelProductos.Location = new System.Drawing.Point(68, 14);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(179, 23);
            this.labelProductos.TabIndex = 1;
            this.labelProductos.Text = "Datos Productos";
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.AutoSize = true;
            this.labelListaProductos.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelListaProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelListaProductos.Location = new System.Drawing.Point(326, 14);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(200, 23);
            this.labelListaProductos.TabIndex = 11;
            this.labelListaProductos.Text = "Lista de Productos";
            this.labelListaProductos.Click += new System.EventHandler(this.labelListaProductos_Click);
            // 
            // buttonBuscar2
            // 
            this.buttonBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.buttonBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar2.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar2.Image")));
            this.buttonBuscar2.Location = new System.Drawing.Point(274, 42);
            this.buttonBuscar2.Name = "buttonBuscar2";
            this.buttonBuscar2.Size = new System.Drawing.Size(58, 23);
            this.buttonBuscar2.TabIndex = 26;
            this.buttonBuscar2.UseVisualStyleBackColor = false;
            // 
            // comboBoxBuscarPor2
            // 
            this.comboBoxBuscarPor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxBuscarPor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBuscarPor2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxBuscarPor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBoxBuscarPor2.FormattingEnabled = true;
            this.comboBoxBuscarPor2.Items.AddRange(new object[] {
            "DNI",
            "Email",
            "Nombre Completo"});
            this.comboBoxBuscarPor2.Location = new System.Drawing.Point(559, 39);
            this.comboBoxBuscarPor2.Name = "comboBoxBuscarPor2";
            this.comboBoxBuscarPor2.Size = new System.Drawing.Size(156, 28);
            this.comboBoxBuscarPor2.TabIndex = 25;
            // 
            // labelBuscar2
            // 
            this.labelBuscar2.AutoSize = true;
            this.labelBuscar2.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.labelBuscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscar2.Location = new System.Drawing.Point(6, 47);
            this.labelBuscar2.Name = "labelBuscar2";
            this.labelBuscar2.Size = new System.Drawing.Size(61, 17);
            this.labelBuscar2.TabIndex = 24;
            this.labelBuscar2.Text = "Buscar";
            this.labelBuscar2.Click += new System.EventHandler(this.labelBuscar_Click);
            // 
            // textBuscar2
            // 
            this.textBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBuscar2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscar2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textBuscar2.Location = new System.Drawing.Point(73, 42);
            this.textBuscar2.Multiline = true;
            this.textBuscar2.Name = "textBuscar2";
            this.textBuscar2.Size = new System.Drawing.Size(195, 22);
            this.textBuscar2.TabIndex = 23;
            // 
            // labelBuscarPor2
            // 
            this.labelBuscarPor2.AutoSize = true;
            this.labelBuscarPor2.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.labelBuscarPor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor2.Location = new System.Drawing.Point(461, 44);
            this.labelBuscarPor2.Name = "labelBuscarPor2";
            this.labelBuscarPor2.Size = new System.Drawing.Size(92, 17);
            this.labelBuscarPor2.TabIndex = 27;
            this.labelBuscarPor2.Text = "Buscar por";
            // 
            // UcProductos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcProductos2";
            this.Size = new System.Drawing.Size(995, 711);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lNombreP;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lStock;
        private System.Windows.Forms.Label lCategoria;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.ComboBox comboBoxCatego;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelListaProductos;
        private System.Windows.Forms.Button buttonBuscar2;
        private System.Windows.Forms.ComboBox comboBoxBuscarPor2;
        private System.Windows.Forms.Label labelBuscar2;
        private System.Windows.Forms.TextBox textBuscar2;
        private System.Windows.Forms.Label labelBuscarPor2;
    }
}
