namespace Proyecto_Grupo13.Gerente
{
    partial class ucEstadisticasV
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
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelReporteV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCantVentas = new System.Windows.Forms.TextBox();
            this.textProductosVendidos = new System.Windows.Forms.TextBox();
            this.textIngresos = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDescargarPDF = new FontAwesome.Sharp.IconButton();
            this.btnDescargarExcel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(279, 22);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(834, 578);
            this.label16.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelReporteV);
            this.panel1.Location = new System.Drawing.Point(289, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 113);
            this.panel1.TabIndex = 65;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(560, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 31);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(444, 65);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(102, 22);
            this.dtpFechaFin.TabIndex = 63;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(220, 67);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaInicio.TabIndex = 62;
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
            // labelReporteV
            // 
            this.labelReporteV.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelReporteV.ForeColor = System.Drawing.Color.White;
            this.labelReporteV.Location = new System.Drawing.Point(250, 14);
            this.labelReporteV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReporteV.Name = "labelReporteV";
            this.labelReporteV.Size = new System.Drawing.Size(312, 23);
            this.labelReporteV.TabIndex = 47;
            this.labelReporteV.Text = "ESTADÍSTICAS DE VENTAS                    ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(289, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 97);
            this.label1.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "CANTIDAD DE VENTAS:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(615, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "PRODUCTOS VENDIDOS:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(949, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = " INGRESOS:     ";
            // 
            // textCantVentas
            // 
            this.textCantVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textCantVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCantVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textCantVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textCantVentas.Location = new System.Drawing.Point(300, 209);
            this.textCantVentas.Name = "textCantVentas";
            this.textCantVentas.Size = new System.Drawing.Size(155, 30);
            this.textCantVentas.TabIndex = 69;
            this.textCantVentas.Text = "0";
            this.textCantVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textProductosVendidos
            // 
            this.textProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textProductosVendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textProductosVendidos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textProductosVendidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textProductosVendidos.Location = new System.Drawing.Point(619, 209);
            this.textProductosVendidos.Name = "textProductosVendidos";
            this.textProductosVendidos.Size = new System.Drawing.Size(155, 30);
            this.textProductosVendidos.TabIndex = 70;
            this.textProductosVendidos.Text = "0";
            this.textProductosVendidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textIngresos
            // 
            this.textIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIngresos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textIngresos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textIngresos.Location = new System.Drawing.Point(919, 209);
            this.textIngresos.Name = "textIngresos";
            this.textIngresos.Size = new System.Drawing.Size(155, 30);
            this.textIngresos.TabIndex = 71;
            this.textIngresos.Text = "0";
            this.textIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.CantProductos,
            this.totalVentas});
            this.dgvVentas.Location = new System.Drawing.Point(289, 277);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(804, 251);
            this.dgvVentas.TabIndex = 72;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // CantProductos
            // 
            this.CantProductos.HeaderText = "Cantidad de Productos";
            this.CantProductos.MinimumWidth = 6;
            this.CantProductos.Name = "CantProductos";
            // 
            // totalVentas
            // 
            this.totalVentas.HeaderText = "Total Ventas";
            this.totalVentas.MinimumWidth = 6;
            this.totalVentas.Name = "totalVentas";
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDescargarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescargarPDF.IconColor = System.Drawing.Color.Brown;
            this.btnDescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPDF.IconSize = 20;
            this.btnDescargarPDF.Location = new System.Drawing.Point(464, 533);
            this.btnDescargarPDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(146, 40);
            this.btnDescargarPDF.TabIndex = 73;
            this.btnDescargarPDF.Text = "Descargar PDF";
            this.btnDescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarPDF.UseVisualStyleBackColor = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // btnDescargarExcel
            // 
            this.btnDescargarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnDescargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDescargarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnDescargarExcel.IconColor = System.Drawing.Color.Green;
            this.btnDescargarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarExcel.IconSize = 20;
            this.btnDescargarExcel.Location = new System.Drawing.Point(765, 533);
            this.btnDescargarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargarExcel.Name = "btnDescargarExcel";
            this.btnDescargarExcel.Size = new System.Drawing.Size(146, 40);
            this.btnDescargarExcel.TabIndex = 74;
            this.btnDescargarExcel.Text = "Descargar Excel";
            this.btnDescargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargarExcel.UseVisualStyleBackColor = false;
            this.btnDescargarExcel.Click += new System.EventHandler(this.btnDescargarExcel_Click);
            // 
            // ucEstadisticasV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.btnDescargarExcel);
            this.Controls.Add(this.btnDescargarPDF);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.textIngresos);
            this.Controls.Add(this.textProductosVendidos);
            this.Controls.Add(this.textCantVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Name = "ucEstadisticasV";
            this.Size = new System.Drawing.Size(1392, 651);
            this.Load += new System.EventHandler(this.ucEstadisticasV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelReporteV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCantVentas;
        private System.Windows.Forms.TextBox textProductosVendidos;
        private System.Windows.Forms.TextBox textIngresos;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVentas;
        private FontAwesome.Sharp.IconButton btnDescargarPDF;
        private FontAwesome.Sharp.IconButton btnDescargarExcel;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}
