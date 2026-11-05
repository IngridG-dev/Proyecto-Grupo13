namespace Proyecto_Grupo13.Vendedor
{
    partial class menuVendedor
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iconProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenidoV = new System.Windows.Forms.Panel();
            this.textNumDocu = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconUsuarios,
            this.iconVentas,
            this.iconProductos});
            this.menu.Location = new System.Drawing.Point(0, 59);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1800, 88);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // iconUsuarios
            // 
            this.iconUsuarios.AutoSize = false;
            this.iconUsuarios.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.iconUsuarios.ForeColor = System.Drawing.Color.White;
            this.iconUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconUsuarios.IconColor = System.Drawing.Color.White;
            this.iconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconUsuarios.Name = "iconUsuarios";
            this.iconUsuarios.Size = new System.Drawing.Size(89, 69);
            this.iconUsuarios.Text = "Clientes";
            this.iconUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconUsuarios.Click += new System.EventHandler(this.iconUsuarios_Click);
            // 
            // iconVentas
            // 
            this.iconVentas.AutoSize = false;
            this.iconVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.verDetalleToolStripMenuItem});
            this.iconVentas.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.iconVentas.ForeColor = System.Drawing.Color.White;
            this.iconVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconVentas.IconColor = System.Drawing.Color.White;
            this.iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVentas.Name = "iconVentas";
            this.iconVentas.Size = new System.Drawing.Size(122, 69);
            this.iconVentas.Text = " Ventas";
            this.iconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.registrarToolStripMenuItem.Text = "Registrar venta";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click_1);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetalleToolStripMenuItem1});
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.verDetalleToolStripMenuItem.Text = "Mis ventas";
            // 
            // verDetalleToolStripMenuItem1
            // 
            this.verDetalleToolStripMenuItem1.Name = "verDetalleToolStripMenuItem1";
            this.verDetalleToolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.verDetalleToolStripMenuItem1.Text = "Ver detalle";
            this.verDetalleToolStripMenuItem1.Click += new System.EventHandler(this.verDetalleToolStripMenuItem1_Click);
            // 
            // iconProductos
            // 
            this.iconProductos.AutoSize = false;
            this.iconProductos.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.iconProductos.ForeColor = System.Drawing.Color.White;
            this.iconProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.iconProductos.IconColor = System.Drawing.Color.White;
            this.iconProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProductos.Name = "iconProductos";
            this.iconProductos.Size = new System.Drawing.Size(89, 69);
            this.iconProductos.Text = "Productos";
            this.iconProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconProductos.Click += new System.EventHandler(this.iconProductos_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1800, 59);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuTitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "The B-Side";
            // 
            // panelContenidoV
            // 
            this.panelContenidoV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoV.Location = new System.Drawing.Point(0, 147);
            this.panelContenidoV.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenidoV.Name = "panelContenidoV";
            this.panelContenidoV.Size = new System.Drawing.Size(1800, 602);
            this.panelContenidoV.TabIndex = 10;
            // 
            // textNumDocu
            // 
            this.textNumDocu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.textNumDocu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumDocu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNumDocu.ForeColor = System.Drawing.Color.White;
            this.textNumDocu.Location = new System.Drawing.Point(1624, 12);
            this.textNumDocu.Name = "textNumDocu";
            this.textNumDocu.ReadOnly = true;
            this.textNumDocu.Size = new System.Drawing.Size(147, 34);
            this.textNumDocu.TabIndex = 17;
            this.textNumDocu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNumDocu.Enter += new System.EventHandler(this.textNumDocu_Enter);
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textUsuario.ForeColor = System.Drawing.Color.White;
            this.textUsuario.Location = new System.Drawing.Point(1300, 12);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.ReadOnly = true;
            this.textUsuario.Size = new System.Drawing.Size(147, 34);
            this.textUsuario.TabIndex = 16;
            this.textUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            this.textUsuario.Enter += new System.EventHandler(this.textUsuario_Enter);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblDocumento.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.lblDocumento.ForeColor = System.Drawing.Color.White;
            this.lblDocumento.Location = new System.Drawing.Point(1471, 17);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(138, 20);
            this.lblDocumento.TabIndex = 15;
            this.lblDocumento.Text = "N° Documento:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblUsuario.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(1212, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 20);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario:";
            // 
            // menuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1800, 749);
            this.Controls.Add(this.textNumDocu);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelContenidoV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuVendedor";
            this.Load += new System.EventHandler(this.menuVendedor_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconProductos;
        private FontAwesome.Sharp.IconMenuItem iconUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconVentas;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem1;
        private System.Windows.Forms.Panel panelContenidoV;
        private System.Windows.Forms.TextBox textNumDocu;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblUsuario;
    }
}