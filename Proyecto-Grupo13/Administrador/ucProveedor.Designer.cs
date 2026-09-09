namespace Proyecto_Grupo13.Administrador
{
    partial class ucProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProveedor));
            this.btnEditar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textRazonSocial = new System.Windows.Forms.TextBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelListaProveedores = new System.Windows.Forms.Label();
            this.lDatosUser = new System.Windows.Forms.Label();
            this.lEstado = new System.Windows.Forms.Label();
            this.lRazonSocial = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDni = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(65, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 44);
            this.btnEditar.TabIndex = 80;
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
            this.textBuscar.Location = new System.Drawing.Point(452, 39);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(291, 27);
            this.textBuscar.TabIndex = 79;
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
            this.comboBoxEstado.Location = new System.Drawing.Point(84, 211);
            this.comboBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(123, 23);
            this.comboBoxEstado.TabIndex = 77;
            // 
            // textTelefono
            // 
            this.textTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textTelefono.Location = new System.Drawing.Point(84, 173);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(123, 23);
            this.textTelefono.TabIndex = 75;
            this.textTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTelefono_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textEmail.Location = new System.Drawing.Point(84, 131);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(123, 23);
            this.textEmail.TabIndex = 74;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_KeyPress);
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDNI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textDNI.Location = new System.Drawing.Point(84, 88);
            this.textDNI.Margin = new System.Windows.Forms.Padding(2);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(123, 23);
            this.textDNI.TabIndex = 73;
            this.textDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDNI_KeyPress);
            // 
            // textRazonSocial
            // 
            this.textRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.textRazonSocial.Location = new System.Drawing.Point(84, 51);
            this.textRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.textRazonSocial.Name = "textRazonSocial";
            this.textRazonSocial.Size = new System.Drawing.Size(123, 23);
            this.textRazonSocial.TabIndex = 72;
            this.textRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRazonSocial_KeyPress);
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
            this.comboBoxBuscar.Location = new System.Drawing.Point(321, 41);
            this.comboBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(126, 23);
            this.comboBoxBuscar.TabIndex = 71;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(117, 247);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 44);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(10, 247);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 44);
            this.btnAgregar.TabIndex = 69;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(749, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(44, 22);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "button1";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridProveedor
            // 
            this.dataGridProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazonSocial,
            this.DNI,
            this.Email,
            this.Teléfono,
            this.Estado});
            this.dataGridProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.dataGridProveedor.Location = new System.Drawing.Point(241, 72);
            this.dataGridProveedor.Name = "dataGridProveedor";
            this.dataGridProveedor.RowHeadersWidth = 51;
            this.dataGridProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProveedor.Size = new System.Drawing.Size(552, 310);
            this.dataGridProveedor.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(238, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 66;
            this.label1.Text = "Buscar por";
            // 
            // labelListaProveedores
            // 
            this.labelListaProveedores.AutoSize = true;
            this.labelListaProveedores.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelListaProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelListaProveedores.Location = new System.Drawing.Point(460, 10);
            this.labelListaProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListaProveedores.Name = "labelListaProveedores";
            this.labelListaProveedores.Size = new System.Drawing.Size(176, 19);
            this.labelListaProveedores.TabIndex = 64;
            this.labelListaProveedores.Text = "Lista de Proveedores";
            // 
            // lDatosUser
            // 
            this.lDatosUser.AutoSize = true;
            this.lDatosUser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatosUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDatosUser.Location = new System.Drawing.Point(32, 10);
            this.lDatosUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDatosUser.Name = "lDatosUser";
            this.lDatosUser.Size = new System.Drawing.Size(154, 19);
            this.lDatosUser.TabIndex = 56;
            this.lDatosUser.Text = "Datos de usuarios";
            this.lDatosUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEstado.Location = new System.Drawing.Point(24, 219);
            this.lEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(42, 15);
            this.lEstado.TabIndex = 63;
            this.lEstado.Text = "Estado";
            // 
            // lRazonSocial
            // 
            this.lRazonSocial.AutoSize = true;
            this.lRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lRazonSocial.Location = new System.Drawing.Point(7, 59);
            this.lRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRazonSocial.Name = "lRazonSocial";
            this.lRazonSocial.Size = new System.Drawing.Size(73, 15);
            this.lRazonSocial.TabIndex = 57;
            this.lRazonSocial.Text = "Razón Social";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lTelefono.Location = new System.Drawing.Point(19, 181);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(53, 15);
            this.lTelefono.TabIndex = 62;
            this.lTelefono.Text = "Teléfono";
            // 
            // lDni
            // 
            this.lDni.AutoSize = true;
            this.lDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lDni.Location = new System.Drawing.Point(30, 96);
            this.lDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDni.Name = "lDni";
            this.lDni.Size = new System.Drawing.Size(27, 15);
            this.lDni.TabIndex = 58;
            this.lDni.Text = "DNI";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.lEmail.Location = new System.Drawing.Point(30, 139);
            this.lEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(36, 15);
            this.lEmail.TabIndex = 59;
            this.lEmail.Text = "Email";
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
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
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ucProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textRazonSocial);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListaProveedores);
            this.Controls.Add(this.lDatosUser);
            this.Controls.Add(this.lEstado);
            this.Controls.Add(this.lRazonSocial);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lDni);
            this.Controls.Add(this.lEmail);
            this.Name = "ucProveedor";
            this.Size = new System.Drawing.Size(812, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textRazonSocial;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelListaProveedores;
        private System.Windows.Forms.Label lDatosUser;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Label lRazonSocial;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDni;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
