namespace Proyecto_Grupo13.Vendedor
{
    partial class FormTicket
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelTitulo2 = new System.Windows.Forms.Label();
            this.labelComprobante = new System.Windows.Forms.Label();
            this.lblNumeroVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.lblPagoCon = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.VENDEDOR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconBtnTicket = new FontAwesome.Sharp.IconButton();
            this.dgvProductosTicket = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(339, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(207, 36);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "THE B-SIDE";
            // 
            // labelTitulo2
            // 
            this.labelTitulo2.AutoSize = true;
            this.labelTitulo2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo2.Location = new System.Drawing.Point(318, 63);
            this.labelTitulo2.Name = "labelTitulo2";
            this.labelTitulo2.Size = new System.Drawing.Size(249, 24);
            this.labelTitulo2.TabIndex = 1;
            this.labelTitulo2.Text = "TICKET    DE    VENTA";
            // 
            // labelComprobante
            // 
            this.labelComprobante.AutoSize = true;
            this.labelComprobante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComprobante.Location = new System.Drawing.Point(366, 87);
            this.labelComprobante.Name = "labelComprobante";
            this.labelComprobante.Size = new System.Drawing.Size(163, 20);
            this.labelComprobante.TabIndex = 2;
            this.labelComprobante.Text = "Comprobante de Venta";
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Location = new System.Drawing.Point(143, 116);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(67, 13);
            this.lblNumeroVenta.TabIndex = 3;
            this.lblNumeroVenta.Text = "N°. de venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(148, 197);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(148, 221);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Documento";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(148, 268);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(44, 13);
            this.lblVendedor.TabIndex = 6;
            this.lblVendedor.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRODUCTOS";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(148, 487);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(81, 13);
            this.lblFormaPago.TabIndex = 8;
            this.lblFormaPago.Text = "Forma de pago:";
            // 
            // lblPagoCon
            // 
            this.lblPagoCon.AutoSize = true;
            this.lblPagoCon.Location = new System.Drawing.Point(148, 510);
            this.lblPagoCon.Name = "lblPagoCon";
            this.lblPagoCon.Size = new System.Drawing.Size(56, 13);
            this.lblPagoCon.TabIndex = 9;
            this.lblPagoCon.Text = "Pago con:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(444, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "label8";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(153, 535);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(42, 13);
            this.lblCambio.TabIndex = 11;
            this.lblCambio.Text = "Cambio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(148, 144);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(428, 116);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 13;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // VENDEDOR
            // 
            this.VENDEDOR.AutoSize = true;
            this.VENDEDOR.Location = new System.Drawing.Point(148, 246);
            this.VENDEDOR.Name = "VENDEDOR";
            this.VENDEDOR.Size = new System.Drawing.Size(68, 13);
            this.VENDEDOR.TabIndex = 14;
            this.VENDEDOR.Text = "VENDEDOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "TOTAL A PAGAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "GRACIAS POR SU COMPRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Conserve este comprobante";
            // 
            // iconBtnTicket
            // 
            this.iconBtnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconBtnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBtnTicket.ForeColor = System.Drawing.Color.Black;
            this.iconBtnTicket.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtnTicket.IconColor = System.Drawing.Color.Black;
            this.iconBtnTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnTicket.Location = new System.Drawing.Point(196, 604);
            this.iconBtnTicket.Name = "iconBtnTicket";
            this.iconBtnTicket.Size = new System.Drawing.Size(402, 23);
            this.iconBtnTicket.TabIndex = 19;
            this.iconBtnTicket.Text = "Imprimir Ticket";
            this.iconBtnTicket.UseVisualStyleBackColor = false;
            this.iconBtnTicket.Click += new System.EventHandler(this.iconBtnTicket_Click);
            // 
            // dgvProductosTicket
            // 
            this.dgvProductosTicket.AllowUserToAddRows = false;
            this.dgvProductosTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubtotal});
            this.dgvProductosTicket.Location = new System.Drawing.Point(151, 310);
            this.dgvProductosTicket.Name = "dgvProductosTicket";
            this.dgvProductosTicket.Size = new System.Drawing.Size(590, 133);
            this.dgvProductosTicket.TabIndex = 20;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio Unitario";
            this.colPrecio.Name = "colPrecio";
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "SubTotal";
            this.colSubtotal.Name = "colSubtotal";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.dgvProductosTicket);
            this.Controls.Add(this.iconBtnTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VENDEDOR);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPagoCon);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNumeroVenta);
            this.Controls.Add(this.labelComprobante);
            this.Controls.Add(this.labelTitulo2);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormTicket";
            this.Text = "FormTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTitulo2;
        private System.Windows.Forms.Label labelComprobante;
        private System.Windows.Forms.Label lblNumeroVenta;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.Label lblPagoCon;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label VENDEDOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton iconBtnTicket;
        private System.Windows.Forms.DataGridView dgvProductosTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}