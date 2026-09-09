namespace Proyecto_Grupo13.Administrador
{
    partial class UserControl2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.lDatosUser = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDni = new System.Windows.Forms.Label();
            this.lRol = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.labelListaUsuarios = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lDatosUser
            // 
            this.lDatosUser.AutoSize = true;
            this.lDatosUser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatosUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDatosUser.Location = new System.Drawing.Point(26, 3);
            this.lDatosUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDatosUser.Name = "lDatosUser";
            this.lDatosUser.Size = new System.Drawing.Size(154, 19);
            this.lDatosUser.TabIndex = 18;
            this.lDatosUser.Text = "Datos de usuarios";
            this.lDatosUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEstado.Location = new System.Drawing.Point(18, 296);
            this.lEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(42, 15);
            this.lEstado.TabIndex = 30;
            this.lEstado.Text = "Estado";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lNombre.Location = new System.Drawing.Point(15, 37);
            this.lNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(60, 30);
            this.lNombre.TabIndex = 20;
            this.lNombre.Text = "Nombre\r\nCompleto";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lTelefono.Location = new System.Drawing.Point(13, 174);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(53, 15);
            this.lTelefono.TabIndex = 29;
            this.lTelefono.Text = "Teléfono";
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDni.Location = new System.Drawing.Point(24, 89);
            this.lDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(27, 15);
            this.lDni.TabIndex = 21;
            this.lDni.Text = "DNI";
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lRol.Location = new System.Drawing.Point(27, 252);
            this.lRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(24, 15);
            this.lRol.TabIndex = 27;
            this.lRol.Text = "Rol";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEmail.Location = new System.Drawing.Point(24, 132);
            this.lEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(36, 15);
            this.lEmail.TabIndex = 23;
            this.lEmail.Text = "Email";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDireccion.Location = new System.Drawing.Point(9, 216);
            this.lDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(57, 15);
            this.lDireccion.TabIndex = 25;
            this.lDireccion.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(530, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Buscar por";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscar.Location = new System.Drawing.Point(252, 39);
            this.labelBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(52, 15);
            this.labelBuscar.TabIndex = 36;
            this.labelBuscar.Text = "Buscar";
            // 
            // labelListaUsuarios
            // 
            this.labelListaUsuarios.AutoSize = true;
            this.labelListaUsuarios.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelListaUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelListaUsuarios.Location = new System.Drawing.Point(454, 8);
            this.labelListaUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListaUsuarios.Name = "labelListaUsuarios";
            this.labelListaUsuarios.Size = new System.Drawing.Size(149, 19);
            this.labelListaUsuarios.TabIndex = 34;
            this.labelListaUsuarios.Text = "Lista de Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Email,
            this.Teléfono,
            this.Direccion,
            this.Rol,
            this.Estado});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dataGridView1.Location = new System.Drawing.Point(235, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(552, 359);
            this.dataGridView1.TabIndex = 40;
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
            // Rol
            // 
            this.Rol.HeaderText = "ROL";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(458, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 19);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(12, 327);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 44);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(111, 327);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 44);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            "Email",
            "Nombre Completo",
            "Rol"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(616, 34);
            this.comboBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(126, 23);
            this.comboBoxBuscar.TabIndex = 45;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textNombre.Location = new System.Drawing.Point(78, 44);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(123, 23);
            this.textNombre.TabIndex = 46;
            this.textNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDNI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textDNI.Location = new System.Drawing.Point(78, 81);
            this.textDNI.Margin = new System.Windows.Forms.Padding(2);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(123, 23);
            this.textDNI.TabIndex = 47;
            this.textDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDNI_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textEmail.Location = new System.Drawing.Point(78, 124);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(123, 23);
            this.textEmail.TabIndex = 48;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_KeyPress);
            // 
            // textTelefono
            // 
            this.textTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textTelefono.Location = new System.Drawing.Point(78, 166);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(123, 23);
            this.textTelefono.TabIndex = 49;
            this.textTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // textDireccion
            // 
            this.textDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textDireccion.Location = new System.Drawing.Point(78, 208);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(123, 23);
            this.textDireccion.TabIndex = 50;
            this.textDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDireccion.TextChanged += new System.EventHandler(this.textDireccion_TextChanged);
            this.textDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDireccion_KeyPress);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(78, 288);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(123, 23);
            this.comboBoxEstado.TabIndex = 51;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador",
            "Gerente",
            "Cliente"});
            this.comboBoxRol.Location = new System.Drawing.Point(78, 249);
            this.comboBoxRol.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(123, 23);
            this.comboBoxRol.TabIndex = 52;
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.textBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textBuscar.Location = new System.Drawing.Point(306, 32);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(146, 27);
            this.textBuscar.TabIndex = 53;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(63, 376);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 44);
            this.btnEditar.TabIndex = 55;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelListaUsuarios);
            this.Controls.Add(this.lDatosUser);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.lRol);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lDireccion);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(812, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lDatosUser;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Label labelListaUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnEditar;
    }
}
