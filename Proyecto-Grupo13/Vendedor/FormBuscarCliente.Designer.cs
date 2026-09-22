namespace Proyecto_Grupo13.Vendedor
{
    partial class FormBuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lProductos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconBtnLimpiar = new FontAwesome.Sharp.IconButton();
            this.iconBuscar = new FontAwesome.Sharp.IconButton();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.textnumDocume = new System.Windows.Forms.TextBox();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lProductos
            // 
            this.lProductos.AutoSize = true;
            this.lProductos.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lProductos.ForeColor = System.Drawing.Color.White;
            this.lProductos.Location = new System.Drawing.Point(261, 9);
            this.lProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProductos.Name = "lProductos";
            this.lProductos.Size = new System.Drawing.Size(94, 19);
            this.lProductos.TabIndex = 14;
            this.lProductos.Text = "CLIENTES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconBtnLimpiar);
            this.groupBox1.Controls.Add(this.iconBuscar);
            this.groupBox1.Controls.Add(this.comboBoxBuscar);
            this.groupBox1.Controls.Add(this.textnumDocume);
            this.groupBox1.Controls.Add(this.labelBuscarPor);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(614, 64);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Clientes";
            // 
            // iconBtnLimpiar
            // 
            this.iconBtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.iconBtnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconBtnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.iconBtnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLimpiar.IconSize = 25;
            this.iconBtnLimpiar.Location = new System.Drawing.Point(499, 22);
            this.iconBtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnLimpiar.Name = "iconBtnLimpiar";
            this.iconBtnLimpiar.Size = new System.Drawing.Size(65, 28);
            this.iconBtnLimpiar.TabIndex = 60;
            this.iconBtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // iconBuscar
            // 
            this.iconBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBuscar.ForeColor = System.Drawing.Color.White;
            this.iconBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBuscar.IconSize = 25;
            this.iconBuscar.Location = new System.Drawing.Point(433, 22);
            this.iconBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.iconBuscar.Name = "iconBuscar";
            this.iconBuscar.Size = new System.Drawing.Size(65, 28);
            this.iconBuscar.TabIndex = 59;
            this.iconBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBuscar.UseVisualStyleBackColor = false;
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
            "Nombre"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(121, 26);
            this.comboBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(119, 23);
            this.comboBoxBuscar.TabIndex = 50;
            // 
            // textnumDocume
            // 
            this.textnumDocume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textnumDocume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnumDocume.Location = new System.Drawing.Point(254, 26);
            this.textnumDocume.Margin = new System.Windows.Forms.Padding(2);
            this.textnumDocume.Multiline = true;
            this.textnumDocume.Name = "textnumDocume";
            this.textnumDocume.Size = new System.Drawing.Size(175, 23);
            this.textnumDocume.TabIndex = 49;
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.labelBuscarPor.Location = new System.Drawing.Point(51, 29);
            this.labelBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(66, 15);
            this.labelBuscarPor.TabIndex = 47;
            this.labelBuscarPor.Text = "Buscar por:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.NOMBRE});
            this.dgvClientes.Location = new System.Drawing.Point(36, 98);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(564, 283);
            this.dgvClientes.TabIndex = 61;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick_1);
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(636, 404);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lProductos);
            this.Name = "FormBuscarCliente";
            this.Text = "FormBuscarCliente";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconBtnLimpiar;
        private FontAwesome.Sharp.IconButton iconBuscar;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox textnumDocume;
        private System.Windows.Forms.Label labelBuscarPor;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
    }
}