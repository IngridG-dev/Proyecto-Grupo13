namespace Proyecto_Grupo13.Administrador
{
    partial class FormTicketCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNumCompra = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.iconBtnSalir = new FontAwesome.Sharp.IconButton();
            this.labelComprobante = new System.Windows.Forms.Label();
            this.labelTitulo2 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblProveedor);
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Controls.Add(this.lblNumCompra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(530, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE COMPRA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(373, 60);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(12, 15);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(373, 18);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(12, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "-";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(14, 90);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(12, 15);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "-";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(14, 60);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(12, 15);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "-";
            // 
            // lblNumCompra
            // 
            this.lblNumCompra.AutoSize = true;
            this.lblNumCompra.Location = new System.Drawing.Point(14, 26);
            this.lblNumCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCompra.Name = "lblNumCompra";
            this.lblNumCompra.Size = new System.Drawing.Size(12, 15);
            this.lblNumCompra.TabIndex = 4;
            this.lblNumCompra.Text = "-";
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(10, 222);
            this.dgvTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(530, 169);
            this.dgvTicket.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(355, 361);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "-";
            // 
            // iconBtnSalir
            // 
            this.iconBtnSalir.BackColor = System.Drawing.Color.LightGray;
            this.iconBtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.iconBtnSalir.ForeColor = System.Drawing.Color.Black;
            this.iconBtnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconBtnSalir.IconColor = System.Drawing.Color.Red;
            this.iconBtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSalir.IconSize = 25;
            this.iconBtnSalir.Location = new System.Drawing.Point(215, 405);
            this.iconBtnSalir.Name = "iconBtnSalir";
            this.iconBtnSalir.Size = new System.Drawing.Size(102, 31);
            this.iconBtnSalir.TabIndex = 91;
            this.iconBtnSalir.Text = "Salir";
            this.iconBtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSalir.UseVisualStyleBackColor = false;
            this.iconBtnSalir.Click += new System.EventHandler(this.iconBtnSalir_Click);
            // 
            // labelComprobante
            // 
            this.labelComprobante.AutoSize = true;
            this.labelComprobante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComprobante.Location = new System.Drawing.Point(197, 69);
            this.labelComprobante.Name = "labelComprobante";
            this.labelComprobante.Size = new System.Drawing.Size(179, 20);
            this.labelComprobante.TabIndex = 94;
            this.labelComprobante.Text = "Comprobante de Compra";
            // 
            // labelTitulo2
            // 
            this.labelTitulo2.AutoSize = true;
            this.labelTitulo2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo2.Location = new System.Drawing.Point(149, 45);
            this.labelTitulo2.Name = "labelTitulo2";
            this.labelTitulo2.Size = new System.Drawing.Size(265, 24);
            this.labelTitulo2.TabIndex = 93;
            this.labelTitulo2.Text = "TICKET    DE    COMPRA";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(170, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(207, 36);
            this.labelTitulo.TabIndex = 92;
            this.labelTitulo.Text = "THE B-SIDE";
            // 
            // FormTicketCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(549, 446);
            this.Controls.Add(this.labelComprobante);
            this.Controls.Add(this.labelTitulo2);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.iconBtnSalir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTicketCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTicketCompra";
            this.Load += new System.EventHandler(this.FormTicketCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblNumCompra;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label lblTotal;
        private FontAwesome.Sharp.IconButton iconBtnSalir;
        private System.Windows.Forms.Label labelComprobante;
        private System.Windows.Forms.Label labelTitulo2;
        private System.Windows.Forms.Label labelTitulo;
    }
}