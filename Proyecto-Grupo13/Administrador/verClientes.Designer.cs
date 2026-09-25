namespace Proyecto_Grupo13.Administrador
{
    partial class verClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verClientes));
            this.lClientes = new System.Windows.Forms.Label();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lClientes
            // 
            this.lClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lClientes.Location = new System.Drawing.Point(122, 36);
            this.lClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lClientes.Name = "lClientes";
            this.lClientes.Size = new System.Drawing.Size(802, 453);
            this.lClientes.TabIndex = 1;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(163, 178);
            this.dataGridClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersWidth = 51;
            this.dataGridClientes.RowTemplate.Height = 24;
            this.dataGridClientes.Size = new System.Drawing.Size(732, 254);
            this.dataGridClientes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(384, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENTES REGISTRADOS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(792, 436);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 43);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconBuscar);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.textBuscar);
            this.groupBox1.Controls.Add(this.labelBuscarPor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(163, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(732, 80);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cliente";
            // 
            // iconBuscar
            // 
            this.iconBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBuscar.ForeColor = System.Drawing.Color.White;
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 25;
            this.iconBuscar.Location = new System.Drawing.Point(501, 32);
            this.iconBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(85, 28);
            this.iconBuscar.TabIndex = 59;
            this.iconBuscar.Text = "Buscar";
            this.iconBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBuscar.UseVisualStyleBackColor = false;
            this.iconBuscar.Click += new System.EventHandler(this.iconBuscar_Click);
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
            "Nombre",
            "Apellido"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(198, 34);
            this.comboBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(119, 23);
            this.comboBoxBuscar.TabIndex = 50;
            // 
            // textBuscar
            // 
            this.textBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBuscar.ForeColor = System.Drawing.Color.White;
            this.textBuscar.Location = new System.Drawing.Point(322, 34);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(176, 24);
            this.textBuscar.TabIndex = 49;
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(129, 39);
            this.labelBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(66, 15);
            this.labelBuscarPor.TabIndex = 47;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // verClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.lClientes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "verClientes";
            this.Size = new System.Drawing.Size(1046, 513);
            this.Load += new System.EventHandler(this.verClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lClientes;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelBuscarPor;
    }
}
