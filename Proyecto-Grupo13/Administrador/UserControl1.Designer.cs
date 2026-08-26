namespace Proyecto_Grupo13.Administrador
{
    partial class ucUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lDatosUser = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lDireccionCalle = new System.Windows.Forms.Label();
            this.textDireccionCalle = new System.Windows.Forms.TextBox();
            this.lDireccionNro = new System.Windows.Forms.Label();
            this.textDireccionNro = new System.Windows.Forms.TextBox();
            this.lRol = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lListaUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.comboBoxEstado);
            this.panel1.Controls.Add(this.lEstado);
            this.panel1.Controls.Add(this.lTelefono);
            this.panel1.Controls.Add(this.textTelefono);
            this.panel1.Controls.Add(this.comboBoxRol);
            this.panel1.Controls.Add(this.lRol);
            this.panel1.Controls.Add(this.textDireccionNro);
            this.panel1.Controls.Add(this.lDireccionNro);
            this.panel1.Controls.Add(this.textDireccionCalle);
            this.panel1.Controls.Add(this.lDireccionCalle);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.lEmail);
            this.panel1.Controls.Add(this.textDni);
            this.panel1.Controls.Add(this.lDni);
            this.panel1.Controls.Add(this.textNombre);
            this.panel1.Controls.Add(this.lNombre);
            this.panel1.Controls.Add(this.lDatosUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 711);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.lListaUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(275, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 711);
            this.panel2.TabIndex = 1;
            // 
            // lDatosUser
            // 
            this.lDatosUser.AutoSize = true;
            this.lDatosUser.Location = new System.Drawing.Point(66, 35);
            this.lDatosUser.Name = "lDatosUser";
            this.lDatosUser.Size = new System.Drawing.Size(116, 16);
            this.lDatosUser.TabIndex = 0;
            this.lDatosUser.Text = "Datos de usuarios";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(16, 125);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(65, 32);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre\r\nCompleto";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(84, 125);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(163, 22);
            this.textNombre.TabIndex = 0;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Location = new System.Drawing.Point(32, 165);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(30, 16);
            this.lDni.TabIndex = 3;
            this.lDni.Text = "DNI";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(84, 165);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(163, 22);
            this.textDni.TabIndex = 4;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(29, 218);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(41, 16);
            this.lEmail.TabIndex = 5;
            this.lEmail.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(84, 218);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(163, 22);
            this.textEmail.TabIndex = 6;
            // 
            // lDireccionCalle
            // 
            this.lDireccionCalle.AutoSize = true;
            this.lDireccionCalle.Location = new System.Drawing.Point(32, 307);
            this.lDireccionCalle.Name = "lDireccionCalle";
            this.lDireccionCalle.Size = new System.Drawing.Size(38, 16);
            this.lDireccionCalle.TabIndex = 7;
            this.lDireccionCalle.Text = "Calle";
            // 
            // textDireccionCalle
            // 
            this.textDireccionCalle.Location = new System.Drawing.Point(84, 301);
            this.textDireccionCalle.Name = "textDireccionCalle";
            this.textDireccionCalle.Size = new System.Drawing.Size(163, 22);
            this.textDireccionCalle.TabIndex = 8;
            // 
            // lDireccionNro
            // 
            this.lDireccionNro.AutoSize = true;
            this.lDireccionNro.Location = new System.Drawing.Point(22, 347);
            this.lDireccionNro.Name = "lDireccionNro";
            this.lDireccionNro.Size = new System.Drawing.Size(55, 16);
            this.lDireccionNro.TabIndex = 9;
            this.lDireccionNro.Text = "Número";
            // 
            // textDireccionNro
            // 
            this.textDireccionNro.Location = new System.Drawing.Point(84, 341);
            this.textDireccionNro.Name = "textDireccionNro";
            this.textDireccionNro.Size = new System.Drawing.Size(163, 22);
            this.textDireccionNro.TabIndex = 10;
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Location = new System.Drawing.Point(32, 390);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(28, 16);
            this.lRol.TabIndex = 11;
            this.lRol.Text = "Rol";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador",
            "Gerente"});
            this.comboBoxRol.Location = new System.Drawing.Point(84, 382);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(163, 24);
            this.comboBoxRol.TabIndex = 0;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(84, 259);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(163, 22);
            this.textTelefono.TabIndex = 12;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(16, 265);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(61, 16);
            this.lTelefono.TabIndex = 13;
            this.lTelefono.Text = "Teléfono";
            // 
            // lListaUser
            // 
            this.lListaUser.AutoSize = true;
            this.lListaUser.Location = new System.Drawing.Point(195, 35);
            this.lListaUser.Name = "lListaUser";
            this.lListaUser.Size = new System.Drawing.Size(111, 16);
            this.lListaUser.TabIndex = 14;
            this.lListaUser.Text = "Lista de Usuarios";
            this.lListaUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Email,
            this.Telefono,
            this.Rol,
            this.Estado,
            this.Editar});
            this.dataGridView1.Location = new System.Drawing.Point(16, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(503, 366);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Location = new System.Drawing.Point(22, 432);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(50, 16);
            this.lEstado.TabIndex = 14;
            this.lEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(84, 424);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(163, 24);
            this.comboBoxEstado.TabIndex = 15;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(80, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 46);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(80, 528);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 44);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ucUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucUsuarios";
            this.Size = new System.Drawing.Size(810, 711);
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
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDatosUser;
        private System.Windows.Forms.TextBox textDireccionCalle;
        private System.Windows.Forms.Label lDireccionCalle;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox textDireccionNro;
        private System.Windows.Forms.Label lDireccionNro;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label lListaUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}
