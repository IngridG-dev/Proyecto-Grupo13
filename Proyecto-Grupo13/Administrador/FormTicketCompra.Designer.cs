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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblNumCompra = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.iconBtnSalir = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(263, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "THE B-SIDE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHora);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblProveedor);
            this.groupBox1.Controls.Add(this.lblAdmin);
            this.groupBox1.Controls.Add(this.lblNumCompra);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 153);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE COMPRA";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(466, 75);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(15, 20);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(466, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(15, 20);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "-";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(18, 113);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(15, 20);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "-";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(18, 75);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(15, 20);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "-";
            // 
            // lblNumCompra
            // 
            this.lblNumCompra.AutoSize = true;
            this.lblNumCompra.Location = new System.Drawing.Point(18, 33);
            this.lblNumCompra.Name = "lblNumCompra";
            this.lblNumCompra.Size = new System.Drawing.Size(15, 20);
            this.lblNumCompra.TabIndex = 4;
            this.lblNumCompra.Text = "-";
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(12, 227);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.RowHeadersWidth = 51;
            this.dgvTicket.RowTemplate.Height = 24;
            this.dgvTicket.Size = new System.Drawing.Size(662, 211);
            this.dgvTicket.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(444, 451);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(11, 16);
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
            this.iconBtnSalir.Location = new System.Drawing.Point(269, 506);
            this.iconBtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.iconBtnSalir.Name = "iconBtnSalir";
            this.iconBtnSalir.Size = new System.Drawing.Size(127, 39);
            this.iconBtnSalir.TabIndex = 91;
            this.iconBtnSalir.Text = "Salir";
            this.iconBtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSalir.UseVisualStyleBackColor = false;
            this.iconBtnSalir.Click += new System.EventHandler(this.iconBtnSalir_Click);
            // 
            // FormTicketCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(686, 558);
            this.Controls.Add(this.iconBtnSalir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblNumCompra;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.Label lblTotal;
        private FontAwesome.Sharp.IconButton iconBtnSalir;
    }
}