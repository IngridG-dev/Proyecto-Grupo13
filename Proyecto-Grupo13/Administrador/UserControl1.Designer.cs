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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.lRol = new System.Windows.Forms.Label();
            this.textDireccionCalle = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.lDni = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDatosUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(132, 355);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 43);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Location = new System.Drawing.Point(19, 354);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 44);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.comboBoxEstado.Location = new System.Drawing.Point(83, 312);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(123, 23);
            this.comboBoxEstado.TabIndex = 15;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEstado.Location = new System.Drawing.Point(29, 319);
            this.lEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(42, 15);
            this.lEstado.TabIndex = 14;
            this.lEstado.Text = "Estado";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lTelefono.Location = new System.Drawing.Point(18, 181);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(53, 15);
            this.lTelefono.TabIndex = 13;
            this.lTelefono.Text = "Teléfono";
            // 
            // textTelefono
            // 
            this.textTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefono.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefono.Location = new System.Drawing.Point(83, 179);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(123, 22);
            this.textTelefono.TabIndex = 12;
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.comboBoxRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxRol.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador",
            "Gerente"});
            this.comboBoxRol.Location = new System.Drawing.Point(83, 267);
            this.comboBoxRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(123, 21);
            this.comboBoxRol.TabIndex = 0;
            // 
            // lRol
            // 
            this.lRol.AutoSize = true;
            this.lRol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lRol.Location = new System.Drawing.Point(33, 274);
            this.lRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRol.Name = "lRol";
            this.lRol.Size = new System.Drawing.Size(24, 15);
            this.lRol.TabIndex = 11;
            this.lRol.Text = "Rol";
            // 
            // textDireccionCalle
            // 
            this.textDireccionCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDireccionCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDireccionCalle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccionCalle.Location = new System.Drawing.Point(83, 223);
            this.textDireccionCalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDireccionCalle.Name = "textDireccionCalle";
            this.textDireccionCalle.Size = new System.Drawing.Size(123, 22);
            this.textDireccionCalle.TabIndex = 8;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDireccion.Location = new System.Drawing.Point(20, 225);
            this.lDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(57, 15);
            this.lDireccion.TabIndex = 7;
            this.lDireccion.Text = "Dirección";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(83, 139);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(123, 22);
            this.textEmail.TabIndex = 6;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEmail.Location = new System.Drawing.Point(29, 139);
            this.lEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(36, 15);
            this.lEmail.TabIndex = 5;
            this.lEmail.Text = "Email";
            // 
            // textDni
            // 
            this.textDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDni.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(83, 96);
            this.textDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(123, 22);
            this.textDni.TabIndex = 4;
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDni.Location = new System.Drawing.Point(29, 96);
            this.lDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(27, 15);
            this.lDni.TabIndex = 3;
            this.lDni.Text = "DNI";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(83, 54);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(123, 22);
            this.textNombre.TabIndex = 0;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lNombre.Location = new System.Drawing.Point(20, 44);
            this.lNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(60, 30);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre\r\nCompleto";
            // 
            // lDatosUser
            // 
            this.lDatosUser.AutoSize = true;
            this.lDatosUser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatosUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDatosUser.Location = new System.Drawing.Point(52, 10);
            this.lDatosUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDatosUser.Name = "lDatosUser";
            this.lDatosUser.Size = new System.Drawing.Size(154, 19);
            this.lDatosUser.TabIndex = 0;
            this.lDatosUser.Text = "Datos de usuarios";
            this.lDatosUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Rol,
            this.Estado});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dataGridView1.Location = new System.Drawing.Point(254, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 542);
            this.dataGridView1.TabIndex = 17;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "ROL";
            this.Rol.Name = "Rol";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // ucUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.lDatosUser);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.lRol);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.textDireccionCalle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucUsuarios";
            this.Size = new System.Drawing.Size(1079, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDatosUser;
        private System.Windows.Forms.TextBox textDireccionCalle;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label lRol;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewButtonColumn Estado;
    }
}
