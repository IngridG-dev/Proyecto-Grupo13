namespace Proyecto_Grupo13.Vendedor
{
    partial class ucClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucClientes));
            this.btnEditar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelListaClientes = new System.Windows.Forms.Label();
            this.lDatosCliente = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDni = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelCliente2 = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(315, 419);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 46);
            this.btnEditar.TabIndex = 108;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.textBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textBuscar.Location = new System.Drawing.Point(748, 84);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(320, 28);
            this.textBuscar.TabIndex = 107;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "DNI",
            "Nombre Completo",
            "Email",
            "Telefono",
            "Dirección"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(575, 84);
            this.comboBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(166, 28);
            this.comboBoxBuscar.TabIndex = 99;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(195, 419);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 46);
            this.btnAgregar.TabIndex = 97;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1076, 84);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 30);
            this.btnBuscar.TabIndex = 96;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GridClientes
            // 
            this.GridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Email,
            this.Teléfono,
            this.Direccion});
            this.GridClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.GridClientes.Location = new System.Drawing.Point(475, 126);
            this.GridClientes.Margin = new System.Windows.Forms.Padding(4);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.RowHeadersWidth = 51;
            this.GridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridClientes.Size = new System.Drawing.Size(736, 380);
            this.GridClientes.TabIndex = 95;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.MinimumWidth = 6;
            this.Teléfono.Name = "Teléfono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(471, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Buscar por";
            // 
            // labelListaClientes
            // 
            this.labelListaClientes.AutoSize = true;
            this.labelListaClientes.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelListaClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelListaClientes.Location = new System.Drawing.Point(744, 50);
            this.labelListaClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListaClientes.Name = "labelListaClientes";
            this.labelListaClientes.Size = new System.Drawing.Size(219, 23);
            this.labelListaClientes.TabIndex = 92;
            this.labelListaClientes.Text = "Clientes Registrados";
            // 
            // lDatosCliente
            // 
            this.lDatosCliente.AutoSize = true;
            this.lDatosCliente.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatosCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDatosCliente.Location = new System.Drawing.Point(228, 50);
            this.lDatosCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDatosCliente.Name = "lDatosCliente";
            this.lDatosCliente.Size = new System.Drawing.Size(181, 23);
            this.lDatosCliente.TabIndex = 84;
            this.lDatosCliente.Text = "Datos del Cliente";
            this.lDatosCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lTelefono.Location = new System.Drawing.Point(191, 297);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(67, 20);
            this.lTelefono.TabIndex = 90;
            this.lTelefono.Text = "Teléfono";
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDni.Location = new System.Drawing.Point(203, 195);
            this.lDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(35, 20);
            this.lDni.TabIndex = 86;
            this.lDni.Text = "DNI";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEmail.Location = new System.Drawing.Point(202, 246);
            this.lEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(46, 20);
            this.lEmail.TabIndex = 87;
            this.lEmail.Text = "Email";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDireccion.Location = new System.Drawing.Point(191, 348);
            this.lDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(72, 20);
            this.lDireccion.TabIndex = 88;
            this.lDireccion.Text = "Dirección";
            // 
            // labelCliente
            // 
            this.labelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCliente.Location = new System.Drawing.Point(168, 42);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(286, 547);
            this.labelCliente.TabIndex = 109;
            // 
            // labelCliente2
            // 
            this.labelCliente2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCliente2.Location = new System.Drawing.Point(460, 42);
            this.labelCliente2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCliente2.Name = "labelCliente2";
            this.labelCliente2.Size = new System.Drawing.Size(764, 547);
            this.labelCliente2.TabIndex = 110;
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDNI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textDNI.Location = new System.Drawing.Point(266, 193);
            this.textDNI.Margin = new System.Windows.Forms.Padding(2);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(163, 27);
            this.textDNI.TabIndex = 112;
            this.textDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDNI_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textEmail.Location = new System.Drawing.Point(266, 244);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(163, 27);
            this.textEmail.TabIndex = 113;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_KeyPress);
            // 
            // textTelefono
            // 
            this.textTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textTelefono.Location = new System.Drawing.Point(266, 295);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(163, 27);
            this.textTelefono.TabIndex = 114;
            this.textTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // textDireccion
            // 
            this.textDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textDireccion.Location = new System.Drawing.Point(266, 346);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(163, 27);
            this.textDireccion.TabIndex = 115;
            this.textDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDireccion_KeyPress);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnActualizar.IconColor = System.Drawing.Color.Green;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 30;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(195, 495);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(113, 46);
            this.btnActualizar.TabIndex = 116;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancelar.IconColor = System.Drawing.Color.Red;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(315, 495);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 46);
            this.btnCancelar.TabIndex = 117;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelApellido.Location = new System.Drawing.Point(191, 144);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(66, 20);
            this.labelApellido.TabIndex = 121;
            this.labelApellido.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textApellido.Location = new System.Drawing.Point(266, 142);
            this.textApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(163, 27);
            this.textApellido.TabIndex = 120;
            this.textApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellido_KeyPress);
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textNombre.Location = new System.Drawing.Point(266, 91);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(163, 27);
            this.textNombre.TabIndex = 119;
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lNombre.Location = new System.Drawing.Point(191, 94);
            this.lNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(64, 20);
            this.lNombre.TabIndex = 118;
            this.lNombre.Text = "Nombre\r\n";
            // 
            // ucClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.GridClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListaClientes);
            this.Controls.Add(this.lDatosCliente);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.labelCliente2);
            this.Controls.Add(this.labelCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucClientes";
            this.Size = new System.Drawing.Size(1392, 682);
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView GridClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelListaClientes;
        private System.Windows.Forms.Label lDatosCliente;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCliente2;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lNombre;
    }
}
