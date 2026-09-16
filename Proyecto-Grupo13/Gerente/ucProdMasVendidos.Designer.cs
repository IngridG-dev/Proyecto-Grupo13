namespace Proyecto_Grupo13.Gerente
{
    partial class ucProdMasVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProdMasVendidos));
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarP = new System.Windows.Forms.Button();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelProdVendidos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelVendidos = new System.Windows.Forms.Label();
            this.lUniVend = new System.Windows.Forms.Label();
            this.textProdMasVend = new System.Windows.Forms.TextBox();
            this.textUnidadesVendidas = new System.Windows.Forms.TextBox();
            this.dataGridProdVendidos = new System.Windows.Forms.DataGridView();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.iconBtnPDF = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(279, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(834, 570);
            this.label16.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscarP);
            this.panel1.Controls.Add(this.dateTimeFin);
            this.panel1.Controls.Add(this.dateTimeInicio);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelProdVendidos);
            this.panel1.Location = new System.Drawing.Point(294, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 113);
            this.panel1.TabIndex = 66;
            // 
            // btnBuscarP
            // 
            this.btnBuscarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscarP.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarP.Image")));
            this.btnBuscarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarP.Location = new System.Drawing.Point(593, 67);
            this.btnBuscarP.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarP.Name = "btnBuscarP";
            this.btnBuscarP.Size = new System.Drawing.Size(81, 25);
            this.btnBuscarP.TabIndex = 62;
            this.btnBuscarP.Text = "Buscar";
            this.btnBuscarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarP.UseVisualStyleBackColor = false;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFin.Location = new System.Drawing.Point(447, 68);
            this.dateTimeFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(139, 22);
            this.dateTimeFin.TabIndex = 63;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(222, 68);
            this.dateTimeInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(139, 22);
            this.dateTimeInicio.TabIndex = 62;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(367, 67);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(73, 20);
            this.labelFechaFin.TabIndex = 49;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicio.Location = new System.Drawing.Point(126, 67);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(90, 20);
            this.labelFechaInicio.TabIndex = 48;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelProdVendidos
            // 
            this.labelProdVendidos.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelProdVendidos.ForeColor = System.Drawing.Color.White;
            this.labelProdVendidos.Location = new System.Drawing.Point(250, 14);
            this.labelProdVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProdVendidos.Name = "labelProdVendidos";
            this.labelProdVendidos.Size = new System.Drawing.Size(324, 23);
            this.labelProdVendidos.TabIndex = 47;
            this.labelProdVendidos.Text = "PRODUCTOS MÁS VENDIDOS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textUnidadesVendidas);
            this.panel2.Controls.Add(this.textProdMasVend);
            this.panel2.Controls.Add(this.lUniVend);
            this.panel2.Controls.Add(this.labelVendidos);
            this.panel2.Location = new System.Drawing.Point(294, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 100);
            this.panel2.TabIndex = 67;
            // 
            // labelVendidos
            // 
            this.labelVendidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendidos.ForeColor = System.Drawing.Color.White;
            this.labelVendidos.Location = new System.Drawing.Point(126, 11);
            this.labelVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendidos.Name = "labelVendidos";
            this.labelVendidos.Size = new System.Drawing.Size(192, 23);
            this.labelVendidos.TabIndex = 68;
            this.labelVendidos.Text = "PRODUCTO MÁS VENDIDO:";
            // 
            // lUniVend
            // 
            this.lUniVend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUniVend.ForeColor = System.Drawing.Color.White;
            this.lUniVend.Location = new System.Drawing.Point(443, 11);
            this.lUniVend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUniVend.Name = "lUniVend";
            this.lUniVend.Size = new System.Drawing.Size(192, 23);
            this.lUniVend.TabIndex = 69;
            this.lUniVend.Text = "UNIDADES VENDIDAS:";
            // 
            // textProdMasVend
            // 
            this.textProdMasVend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textProdMasVend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textProdMasVend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textProdMasVend.Location = new System.Drawing.Point(130, 46);
            this.textProdMasVend.Name = "textProdMasVend";
            this.textProdMasVend.Size = new System.Drawing.Size(188, 27);
            this.textProdMasVend.TabIndex = 70;
            // 
            // textUnidadesVendidas
            // 
            this.textUnidadesVendidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textUnidadesVendidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUnidadesVendidas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textUnidadesVendidas.Location = new System.Drawing.Point(447, 46);
            this.textUnidadesVendidas.Name = "textUnidadesVendidas";
            this.textUnidadesVendidas.Size = new System.Drawing.Size(188, 27);
            this.textUnidadesVendidas.TabIndex = 71;
            this.textUnidadesVendidas.Text = "0";
            // 
            // dataGridProdVendidos
            // 
            this.dataGridProdVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProdVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dataGridProdVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProdVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productos,
            this.CantVendida,
            this.ingresos});
            this.dataGridProdVendidos.Location = new System.Drawing.Point(294, 270);
            this.dataGridProdVendidos.Name = "dataGridProdVendidos";
            this.dataGridProdVendidos.RowHeadersWidth = 51;
            this.dataGridProdVendidos.RowTemplate.Height = 24;
            this.dataGridProdVendidos.Size = new System.Drawing.Size(804, 251);
            this.dataGridProdVendidos.TabIndex = 73;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.MinimumWidth = 6;
            this.Productos.Name = "Productos";
            // 
            // CantVendida
            // 
            this.CantVendida.HeaderText = "Cantidad Vendida";
            this.CantVendida.MinimumWidth = 6;
            this.CantVendida.Name = "CantVendida";
            // 
            // ingresos
            // 
            this.ingresos.HeaderText = "Ingresos";
            this.ingresos.MinimumWidth = 6;
            this.ingresos.Name = "ingresos";
            // 
            // iconBtnExcel
            // 
            this.iconBtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExcel.IconColor = System.Drawing.Color.Green;
            this.iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExcel.IconSize = 20;
            this.iconBtnExcel.Location = new System.Drawing.Point(784, 526);
            this.iconBtnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnExcel.Name = "iconBtnExcel";
            this.iconBtnExcel.Size = new System.Drawing.Size(146, 40);
            this.iconBtnExcel.TabIndex = 75;
            this.iconBtnExcel.Text = "Descargar Excel";
            this.iconBtnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExcel.UseVisualStyleBackColor = false;
            // 
            // iconBtnPDF
            // 
            this.iconBtnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconBtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconBtnPDF.IconColor = System.Drawing.Color.Brown;
            this.iconBtnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnPDF.IconSize = 20;
            this.iconBtnPDF.Location = new System.Drawing.Point(467, 526);
            this.iconBtnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnPDF.Name = "iconBtnPDF";
            this.iconBtnPDF.Size = new System.Drawing.Size(146, 40);
            this.iconBtnPDF.TabIndex = 76;
            this.iconBtnPDF.Text = "Descargar PDF";
            this.iconBtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnPDF.UseVisualStyleBackColor = false;
            // 
            // ucProdMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.iconBtnPDF);
            this.Controls.Add(this.iconBtnExcel);
            this.Controls.Add(this.dataGridProdVendidos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Name = "ucProdMasVendidos";
            this.Size = new System.Drawing.Size(1392, 651);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProdVendidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarP;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelProdVendidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelVendidos;
        private System.Windows.Forms.Label lUniVend;
        private System.Windows.Forms.TextBox textUnidadesVendidas;
        private System.Windows.Forms.TextBox textProdMasVend;
        private System.Windows.Forms.DataGridView dataGridProdVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private FontAwesome.Sharp.IconButton iconBtnPDF;
    }
}
