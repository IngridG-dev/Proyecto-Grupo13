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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.labelBuscarPor = new System.Windows.Forms.Label();
            this.cmbBuscarPor = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFin = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelProdVendidos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textResultadoCantidad = new System.Windows.Forms.TextBox();
            this.textResultadoPrincipal = new System.Windows.Forms.TextBox();
            this.lUniVend = new System.Windows.Forms.Label();
            this.labelVendidos = new System.Windows.Forms.Label();
            this.dgvMasVendidos = new System.Windows.Forms.DataGridView();
            this.iconBtnExcel = new FontAwesome.Sharp.IconButton();
            this.iconBtnPDF = new FontAwesome.Sharp.IconButton();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelCantVentas = new System.Windows.Forms.Label();
            this.textVentas = new System.Windows.Forms.TextBox();
            this.textVendedor = new System.Windows.Forms.TextBox();
            this.chartMasVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEvolucion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.chartMetodoPago = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.iconBtnFiltro = new FontAwesome.Sharp.IconButton();
            this.MasVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingresos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasVendidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.labelBuscarPor);
            this.panel1.Controls.Add(this.cmbBuscarPor);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.labelFechaFin);
            this.panel1.Controls.Add(this.labelFechaInicio);
            this.panel1.Controls.Add(this.labelProdVendidos);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 104);
            this.panel1.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(685, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 31);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelBuscarPor
            // 
            this.labelBuscarPor.AutoSize = true;
            this.labelBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarPor.ForeColor = System.Drawing.Color.White;
            this.labelBuscarPor.Location = new System.Drawing.Point(481, 22);
            this.labelBuscarPor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBuscarPor.Name = "labelBuscarPor";
            this.labelBuscarPor.Size = new System.Drawing.Size(80, 20);
            this.labelBuscarPor.TabIndex = 65;
            this.labelBuscarPor.Text = "Buscar Por:";
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.FormattingEnabled = true;
            this.cmbBuscarPor.Items.AddRange(new object[] {
            "Productos",
            "Categoría"});
            this.cmbBuscarPor.Location = new System.Drawing.Point(485, 45);
            this.cmbBuscarPor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.Size = new System.Drawing.Size(193, 24);
            this.cmbBuscarPor.TabIndex = 64;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(336, 46);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(139, 22);
            this.dtpFin.TabIndex = 63;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(111, 46);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(139, 22);
            this.dtpInicio.TabIndex = 62;
            // 
            // labelFechaFin
            // 
            this.labelFechaFin.AutoSize = true;
            this.labelFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFin.ForeColor = System.Drawing.Color.White;
            this.labelFechaFin.Location = new System.Drawing.Point(256, 46);
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
            this.labelFechaInicio.Location = new System.Drawing.Point(15, 46);
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
            this.labelProdVendidos.Location = new System.Drawing.Point(16, 12);
            this.labelProdVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProdVendidos.Name = "labelProdVendidos";
            this.labelProdVendidos.Size = new System.Drawing.Size(179, 22);
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
            this.panel2.Location = new System.Drawing.Point(1330, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 261);
            this.panel2.TabIndex = 67;
            // 
            // textResultadoCantidad
            // 
            this.textResultadoCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textResultadoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResultadoCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textResultadoCantidad.ForeColor = System.Drawing.Color.White;
            this.textResultadoCantidad.Location = new System.Drawing.Point(92, 185);
            this.textResultadoCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textResultadoCantidad.Name = "textResultadoCantidad";
            this.textResultadoCantidad.Size = new System.Drawing.Size(188, 30);
            this.textResultadoCantidad.TabIndex = 71;
            this.textResultadoCantidad.Text = "0";
            // 
            // textResultadoPrincipal
            // 
            this.textResultadoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textResultadoPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResultadoPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textResultadoPrincipal.ForeColor = System.Drawing.Color.White;
            this.textResultadoPrincipal.Location = new System.Drawing.Point(92, 48);
            this.textResultadoPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.textResultadoPrincipal.Name = "textResultadoPrincipal";
            this.textResultadoPrincipal.Size = new System.Drawing.Size(188, 30);
            this.textResultadoPrincipal.TabIndex = 70;
            this.textResultadoPrincipal.Text = "0";
            // 
            // lUniVend
            // 
            this.lUniVend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUniVend.ForeColor = System.Drawing.Color.White;
            this.lUniVend.Location = new System.Drawing.Point(104, 160);
            this.lUniVend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lUniVend.Name = "lUniVend";
            this.lUniVend.Size = new System.Drawing.Size(179, 22);
            this.lUniVend.TabIndex = 69;
            this.lUniVend.Text = "UNIDADES VENDIDAS:";
            // 
            // labelVendidos
            // 
            this.labelVendidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendidos.ForeColor = System.Drawing.Color.White;
            this.labelVendidos.Location = new System.Drawing.Point(89, 12);
            this.labelVendidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendidos.Name = "labelVendidos";
            this.labelVendidos.Size = new System.Drawing.Size(192, 22);
            this.labelVendidos.TabIndex = 68;
            this.labelVendidos.Text = "MÁS VENDIDO:";
            // 
            // dgvMasVendidos
            // 
            this.dgvMasVendidos.AllowUserToAddRows = false;
            this.dgvMasVendidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.dgvMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MasVendidos,
            this.CantVendida,
            this.ingresos});
            this.dgvMasVendidos.Location = new System.Drawing.Point(4, 115);
            this.dgvMasVendidos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMasVendidos.Name = "dgvMasVendidos";
            this.dgvMasVendidos.ReadOnly = true;
            this.dgvMasVendidos.RowHeadersWidth = 51;
            this.dgvMasVendidos.RowTemplate.Height = 24;
            this.dgvMasVendidos.Size = new System.Drawing.Size(810, 106);
            this.dgvMasVendidos.TabIndex = 73;
            this.dgvMasVendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasVendidos_CellContentClick);
            // 
            // iconBtnExcel
            // 
            this.iconBtnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.iconBtnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconBtnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconBtnExcel.IconColor = System.Drawing.Color.Green;
            this.iconBtnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExcel.IconSize = 20;
            this.iconBtnExcel.Location = new System.Drawing.Point(1614, 694);
            this.iconBtnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.iconBtnPDF.Location = new System.Drawing.Point(1462, 694);
            this.iconBtnPDF.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnPDF.Name = "iconBtnPDF";
            this.iconBtnPDF.Size = new System.Drawing.Size(146, 40);
            this.iconBtnPDF.TabIndex = 76;
            this.iconBtnPDF.Text = "Descargar PDF";
            this.iconBtnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnPDF.UseVisualStyleBackColor = false;
            // 
            // labelVendedor
            // 
            this.labelVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.ForeColor = System.Drawing.Color.White;
            this.labelVendedor.Location = new System.Drawing.Point(561, 246);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(192, 22);
            this.labelVendedor.TabIndex = 72;
            this.labelVendedor.Text = "VENDEDOR DESTACADO:";
            // 
            // labelCantVentas
            // 
            this.labelCantVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantVentas.ForeColor = System.Drawing.Color.White;
            this.labelCantVentas.Location = new System.Drawing.Point(561, 312);
            this.labelCantVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCantVentas.Name = "labelCantVentas";
            this.labelCantVentas.Size = new System.Drawing.Size(192, 22);
            this.labelCantVentas.TabIndex = 73;
            this.labelCantVentas.Text = "VENTAS REALIZADAS:";
            // 
            // textVentas
            // 
            this.textVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textVentas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textVentas.ForeColor = System.Drawing.Color.White;
            this.textVentas.Location = new System.Drawing.Point(565, 345);
            this.textVentas.Margin = new System.Windows.Forms.Padding(2);
            this.textVentas.Name = "textVentas";
            this.textVentas.Size = new System.Drawing.Size(188, 30);
            this.textVentas.TabIndex = 74;
            // 
            // textVendedor
            // 
            this.textVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.textVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textVendedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textVendedor.ForeColor = System.Drawing.Color.White;
            this.textVendedor.Location = new System.Drawing.Point(565, 271);
            this.textVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.textVendedor.Name = "textVendedor";
            this.textVendedor.Size = new System.Drawing.Size(188, 30);
            this.textVendedor.TabIndex = 75;
            // 
            // chartMasVendidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMasVendidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMasVendidos.Legends.Add(legend1);
            this.chartMasVendidos.Location = new System.Drawing.Point(821, 48);
            this.chartMasVendidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartMasVendidos.Name = "chartMasVendidos";
            this.chartMasVendidos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMasVendidos.Series.Add(series1);
            this.chartMasVendidos.Size = new System.Drawing.Size(490, 341);
            this.chartMasVendidos.TabIndex = 77;
            this.chartMasVendidos.Text = "chart1";
            // 
            // chartVendedores
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVendedores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVendedores.Legends.Add(legend2);
            this.chartVendedores.Location = new System.Drawing.Point(4, 231);
            this.chartVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartVendedores.Name = "chartVendedores";
            this.chartVendedores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVendedores.Series.Add(series2);
            this.chartVendedores.Size = new System.Drawing.Size(544, 195);
            this.chartVendedores.TabIndex = 78;
            this.chartVendedores.Text = "chart1";
            // 
            // chartIngresos
            // 
            chartArea3.Name = "ChartArea1";
            this.chartIngresos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartIngresos.Legends.Add(legend3);
            this.chartIngresos.Location = new System.Drawing.Point(821, 448);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartIngresos.Name = "chartIngresos";
            this.chartIngresos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartIngresos.Series.Add(series3);
            this.chartIngresos.Size = new System.Drawing.Size(490, 314);
            this.chartIngresos.TabIndex = 79;
            this.chartIngresos.Text = "chart1";
            // 
            // chartEvolucion
            // 
            chartArea4.Name = "ChartArea1";
            this.chartEvolucion.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartEvolucion.Legends.Add(legend4);
            this.chartEvolucion.Location = new System.Drawing.Point(4, 479);
            this.chartEvolucion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartEvolucion.Name = "chartEvolucion";
            this.chartEvolucion.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartEvolucion.Series.Add(series4);
            this.chartEvolucion.Size = new System.Drawing.Size(810, 282);
            this.chartEvolucion.TabIndex = 80;
            this.chartEvolucion.Text = "chart2";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(26, 445);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(150, 24);
            this.cmbMes.TabIndex = 81;
            // 
            // chartMetodoPago
            // 
            chartArea5.Name = "ChartArea1";
            this.chartMetodoPago.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartMetodoPago.Legends.Add(legend5);
            this.chartMetodoPago.Location = new System.Drawing.Point(1330, 271);
            this.chartMetodoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartMetodoPago.Name = "chartMetodoPago";
            this.chartMetodoPago.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartMetodoPago.Series.Add(series5);
            this.chartMetodoPago.Size = new System.Drawing.Size(430, 265);
            this.chartMetodoPago.TabIndex = 82;
            this.chartMetodoPago.Text = "chart1";
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(185, 445);
            this.cmbAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(150, 24);
            this.cmbAño.TabIndex = 83;
            // 
            // iconBtnFiltro
            // 
            this.iconBtnFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconBtnFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconBtnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnFiltro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnFiltro.IconColor = System.Drawing.Color.Black;
            this.iconBtnFiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnFiltro.Location = new System.Drawing.Point(344, 442);
            this.iconBtnFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconBtnFiltro.Name = "iconBtnFiltro";
            this.iconBtnFiltro.Size = new System.Drawing.Size(94, 29);
            this.iconBtnFiltro.TabIndex = 84;
            this.iconBtnFiltro.Text = "Buscar";
            this.iconBtnFiltro.UseVisualStyleBackColor = false;
            this.iconBtnFiltro.Click += new System.EventHandler(this.iconBtnFiltro_Click);
            // 
            // MasVendidos
            // 
            this.MasVendidos.HeaderText = "MasVendidos";
            this.MasVendidos.MinimumWidth = 6;
            this.MasVendidos.Name = "MasVendidos";
            this.MasVendidos.ReadOnly = true;
            // 
            // CantVendida
            // 
            this.CantVendida.HeaderText = "Cantidad Vendida";
            this.CantVendida.MinimumWidth = 6;
            this.CantVendida.Name = "CantVendida";
            this.CantVendida.ReadOnly = true;
            // 
            // ingresos
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.ingresos.DefaultCellStyle = dataGridViewCellStyle1;
            this.ingresos.HeaderText = "Ingresos";
            this.ingresos.MinimumWidth = 6;
            this.ingresos.Name = "ingresos";
            this.ingresos.ReadOnly = true;
            // 
            // ucMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.iconBtnFiltro);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.chartMetodoPago);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.chartEvolucion);
            this.Controls.Add(this.chartIngresos);
            this.Controls.Add(this.textVentas);
            this.Controls.Add(this.textVendedor);
            this.Controls.Add(this.labelCantVentas);
            this.Controls.Add(this.iconBtnPDF);
            this.Controls.Add(this.chartVendedores);
            this.Controls.Add(this.iconBtnExcel);
            this.Controls.Add(this.chartMasVendidos);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.dgvMasVendidos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucMasVendidos";
            this.Size = new System.Drawing.Size(1858, 790);
            this.Load += new System.EventHandler(this.ucMasVendidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasVendidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEvolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMetodoPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
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
        private System.Windows.Forms.Label labelBuscarPor;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEvolucion;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMetodoPago;
        private System.Windows.Forms.ComboBox cmbAño;
        private FontAwesome.Sharp.IconButton iconBtnFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MasVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresos;
    }
}
