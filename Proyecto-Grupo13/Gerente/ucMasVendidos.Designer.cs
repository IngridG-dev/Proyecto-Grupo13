namespace Proyecto_Grupo13.Gerente
{
    partial class ucMasVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMasVendidos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelProdVendidos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textResultadoCantidad = new System.Windows.Forms.TextBox();
            this.textResultadoPrincipal = new System.Windows.Forms.TextBox();
            this.lUniVend = new System.Windows.Forms.Label();
            this.labelVendidos = new System.Windows.Forms.Label();
            this.dgvMasVendidos = new System.Windows.Forms.DataGridView();
            this.MasVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.iconBtnPDF = new FontAwesome.Sharp.IconButton();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelCantVentas = new System.Windows.Forms.Label();
            this.textVentas = new System.Windows.Forms.TextBox();
            this.textVendedor = new System.Windows.Forms.TextBox();
            this.chartMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1076, 456);
            this.label16.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelBuscarPor);
            this.panel1.Controls.Add(this.cmbBuscarPor);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dateTimeFin);
            this.panel1.Controls.Add(this.dateTimeInicio);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelProdVendidos);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 91);
            this.panel1.TabIndex = 66;
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.White;
            this.labelBuscarPor.Location = new System.Drawing.Point(388, 34);
            this.labelBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(66, 15);
            this.labelBuscarPor.TabIndex = 65;
            this.labelBuscarPor.Text = "Buscar Por:";
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Items.AddRange(new object[] {
            "Productos",
            "Categoría"});
            this.cmbBuscarPor.Location = new System.Drawing.Point(391, 52);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(155, 21);
            this.cmbBuscarPor.TabIndex = 64;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(552, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 20);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFin.Location = new System.Drawing.Point(272, 53);
            this.dateTimeFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(112, 20);
            this.dateTimeFin.TabIndex = 63;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInicio.Location = new System.Drawing.Point(92, 53);
            this.dateTimeInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(112, 20);
            this.dateTimeInicio.TabIndex = 62;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(208, 53);
            this.labelFechaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFin.Name = "labelFechaFin";
            this.labelFechaFin.Size = new System.Drawing.Size(60, 15);
            this.labelFechaFin.TabIndex = 49;
            this.labelFechaFin.Text = "Fecha Fin:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.ForeColor = System.Drawing.Color.White;
            this.labelFechaInicio.Location = new System.Drawing.Point(15, 53);
            this.labelFechaInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(73, 15);
            this.labelFechaInicio.TabIndex = 48;
            this.labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // labelProdVendidos
            // 
            this.labelProdVendidos.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.labelProdVendidos.ForeColor = System.Drawing.Color.White;
            this.labelProdVendidos.Location = new System.Drawing.Point(13, 10);
            this.labelProdVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProdVendidos.Name = "labelProdVendidos";
            this.labelProdVendidos.Size = new System.Drawing.Size(143, 18);
            this.labelProdVendidos.TabIndex = 47;
            this.labelProdVendidos.Text = "MÁS VENDIDOS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textResultadoCantidad);
            this.panel2.Controls.Add(this.textResultadoPrincipal);
            this.panel2.Controls.Add(this.lUniVend);
            this.panel2.Controls.Add(this.labelVendidos);
            this.panel2.Location = new System.Drawing.Point(13, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 80);
            this.panel2.TabIndex = 67;
            // 
            // textResultadoCantidad
            // 
            this.textResultadoCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textResultadoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResultadoCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textResultadoCantidad.Location = new System.Drawing.Point(233, 34);
            this.textResultadoCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textResultadoCantidad.Name = "textResultadoCantidad";
            this.textResultadoCantidad.Size = new System.Drawing.Size(151, 23);
            this.textResultadoCantidad.TabIndex = 71;
            this.textResultadoCantidad.Text = "0";
            // 
            // textResultadoPrincipal
            // 
            this.textResultadoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textResultadoPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResultadoPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textResultadoPrincipal.Location = new System.Drawing.Point(53, 34);
            this.textResultadoPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.textResultadoPrincipal.Name = "textResultadoPrincipal";
            this.textResultadoPrincipal.Size = new System.Drawing.Size(151, 23);
            this.textResultadoPrincipal.TabIndex = 70;
            // 
            // lUniVend
            // 
            this.lUniVend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUniVend.ForeColor = System.Drawing.Color.White;
            this.lUniVend.Location = new System.Drawing.Point(230, 14);
            this.lUniVend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUniVend.Name = "lUniVend";
            this.lUniVend.Size = new System.Drawing.Size(154, 18);
            this.lUniVend.TabIndex = 69;
            this.lUniVend.Text = "UNIDADES VENDIDAS:";
            // 
            // labelVendidos
            // 
            this.labelVendidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendidos.ForeColor = System.Drawing.Color.White;
            this.labelVendidos.Location = new System.Drawing.Point(50, 14);
            this.labelVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendidos.Name = "labelVendidos";
            this.labelVendidos.Size = new System.Drawing.Size(154, 18);
            this.labelVendidos.TabIndex = 68;
            this.labelVendidos.Text = "MÁS VENDIDO:";
            // 
            // dgvMasVendidos
            // 
            this.dgvMasVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dgvMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MasVendidos,
            this.CantVendida,
            this.ingresos});
            this.dgvMasVendidos.Location = new System.Drawing.Point(13, 195);
            this.dgvMasVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMasVendidos.Name = "dgvMasVendidos";
            this.dgvMasVendidos.RowHeadersWidth = 51;
            this.dgvMasVendidos.RowTemplate.Height = 24;
            this.dgvMasVendidos.Size = new System.Drawing.Size(385, 214);
            this.dgvMasVendidos.TabIndex = 73;
            // 
            // MasVendidos
            // 
            this.MasVendidos.HeaderText = "MasVendidos";
            this.MasVendidos.MinimumWidth = 6;
            this.MasVendidos.Name = "MasVendidos";
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
            this.iconBtnExcel.Location = new System.Drawing.Point(225, 414);
            this.iconBtnExcel.Name = "iconBtnExcel";
            this.iconBtnExcel.Size = new System.Drawing.Size(117, 32);
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
            this.iconBtnPDF.Location = new System.Drawing.Point(31, 414);
            this.iconBtnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnPDF.Name = "iconBtnPDF";
            this.iconBtnPDF.Size = new System.Drawing.Size(117, 32);
            this.iconBtnPDF.TabIndex = 76;
            this.iconBtnPDF.Text = "Descargar PDF";
            this.iconBtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnPDF.UseVisualStyleBackColor = false;
            // 
            // labelVendedor
            // 
            this.labelVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.ForeColor = System.Drawing.Color.White;
            this.labelVendedor.Location = new System.Drawing.Point(813, 29);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(154, 18);
            this.labelVendedor.TabIndex = 72;
            this.labelVendedor.Text = "VENDEDOR DESTACADO:";
            // 
            // labelCantVentas
            // 
            this.labelCantVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantVentas.ForeColor = System.Drawing.Color.White;
            this.labelCantVentas.Location = new System.Drawing.Point(813, 111);
            this.labelCantVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantVentas.Name = "labelCantVentas";
            this.labelCantVentas.Size = new System.Drawing.Size(154, 18);
            this.labelCantVentas.TabIndex = 73;
            this.labelCantVentas.Text = "VENTAS REALIZADAS:";
            // 
            // textVentas
            // 
            this.textVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textVentas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textVentas.Location = new System.Drawing.Point(816, 146);
            this.textVentas.Margin = new System.Windows.Forms.Padding(2);
            this.textVentas.Name = "textVentas";
            this.textVentas.Size = new System.Drawing.Size(151, 23);
            this.textVentas.TabIndex = 74;
            // 
            // textVendedor
            // 
            this.textVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textVendedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textVendedor.Location = new System.Drawing.Point(816, 66);
            this.textVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.textVendedor.Name = "textVendedor";
            this.textVendedor.Size = new System.Drawing.Size(151, 23);
            this.textVendedor.TabIndex = 75;
            // 
            // chartMasVendidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMasVendidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMasVendidos.Legends.Add(legend1);
            this.chartMasVendidos.Location = new System.Drawing.Point(405, 195);
            this.chartMasVendidos.Name = "chartMasVendidos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMasVendidos.Series.Add(series1);
            this.chartMasVendidos.Size = new System.Drawing.Size(344, 251);
            this.chartMasVendidos.TabIndex = 77;
            this.chartMasVendidos.Text = "chart1";
            // 
            // chartVendedores
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVendedores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVendedores.Legends.Add(legend2);
            this.chartVendedores.Location = new System.Drawing.Point(755, 195);
            this.chartVendedores.Name = "chartVendedores";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVendedores.Series.Add(series2);
            this.chartVendedores.Size = new System.Drawing.Size(313, 251);
            this.chartVendedores.TabIndex = 78;
            this.chartVendedores.Text = "chart1";
            // 
            // ucMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.textVentas);
            this.Controls.Add(this.textVendedor);
            this.Controls.Add(this.labelCantVentas);
            this.Controls.Add(this.chartVendedores);
            this.Controls.Add(this.chartMasVendidos);
            this.Controls.Add(this.iconBtnPDF);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.iconBtnExcel);
            this.Controls.Add(this.dgvMasVendidos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMasVendidos";
            this.Size = new System.Drawing.Size(1114, 521);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.Label labelFechaFin;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelProdVendidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelVendidos;
        private System.Windows.Forms.Label lUniVend;
        private System.Windows.Forms.TextBox textResultadoCantidad;
        private System.Windows.Forms.TextBox textResultadoPrincipal;
        private System.Windows.Forms.DataGridView dgvMasVendidos;
        private FontAwesome.Sharp.IconButton iconBtnExcel;
        private FontAwesome.Sharp.IconButton iconBtnPDF;
        private System.Windows.Forms.ComboBox cmbBuscarPor;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.TextBox textVendedor;
        private System.Windows.Forms.TextBox textVentas;
        private System.Windows.Forms.Label labelCantVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos;
        private System.Windows.Forms.Label labelBuscarPor;
    }
}
