namespace Proyecto_Grupo13.Administrador
{
    partial class menuAdministrador
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
            this.menuStripTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iconMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuCompra = new FontAwesome.Sharp.IconMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTitulo
            // 
            this.menuStripTitulo.AutoSize = false;
            this.menuStripTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.menuStripTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuStripTitulo.Name = "menuStripTitulo";
            this.menuStripTitulo.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripTitulo.Size = new System.Drawing.Size(1054, 47);
            this.menuStripTitulo.TabIndex = 7;
            this.menuStripTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "The B-Side";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuUsuarios,
            this.iconMenuProductos,
            this.iconMenuProveedor,
            this.iconMenuCompra,
            this.iconMenuVentas,
            this.iconMenuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 47);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 70);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuUsuarios
            // 
            this.iconMenuUsuarios.AutoSize = false;
            this.iconMenuUsuarios.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconMenuUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuUsuarios.Name = "iconMenuUsuarios";
            this.iconMenuUsuarios.Size = new System.Drawing.Size(80, 69);
            this.iconMenuUsuarios.Text = "Usuarios";
            this.iconMenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuUsuarios.Click += new System.EventHandler(this.iconMenuUsuarios_Click);
            // 
            // iconMenuProductos
            // 
            this.iconMenuProductos.AutoSize = false;
            this.iconMenuProductos.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.iconMenuProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuProductos.Name = "iconMenuProductos";
            this.iconMenuProductos.Size = new System.Drawing.Size(80, 69);
            this.iconMenuProductos.Text = "Productos";
            this.iconMenuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuProductos.Click += new System.EventHandler(this.iconMenuProductos_Click);
            // 
            // iconMenuProveedor
            // 
            this.iconMenuProveedor.AutoSize = false;
            this.iconMenuProveedor.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuProveedor.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconMenuProveedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuProveedor.Name = "iconMenuProveedor";
            this.iconMenuProveedor.Size = new System.Drawing.Size(80, 69);
            this.iconMenuProveedor.Text = "Proveedores";
            this.iconMenuProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuProveedor.Click += new System.EventHandler(this.iconMenuProveedor_Click);
            // 
            // iconMenuCompra
            // 
            this.iconMenuCompra.AutoSize = false;
            this.iconMenuCompra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.verDetalleToolStripMenuItem1});
            this.iconMenuCompra.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuCompra.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconMenuCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuCompra.Name = "iconMenuCompra";
            this.iconMenuCompra.Size = new System.Drawing.Size(80, 69);
            this.iconMenuCompra.Text = "Compras";
            this.iconMenuCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // verDetalleToolStripMenuItem1
            // 
            this.verDetalleToolStripMenuItem1.Name = "verDetalleToolStripMenuItem1";
            this.verDetalleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.verDetalleToolStripMenuItem1.Text = "Ver Detalle";
            // 
            // iconMenuVentas
            // 
            this.iconMenuVentas.AutoSize = false;
            this.iconMenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetalleToolStripMenuItem});
            this.iconMenuVentas.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconMenuVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuVentas.Name = "iconMenuVentas";
            this.iconMenuVentas.Size = new System.Drawing.Size(80, 69);
            this.iconMenuVentas.Text = "Ventas";
            this.iconMenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuVentas.Click += new System.EventHandler(this.iconMenuVentas_Click);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.verDetalleToolStripMenuItem.Text = "Ver Detalle";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
            // 
            // iconMenuReportes
            // 
            this.iconMenuReportes.AutoSize = false;
            this.iconMenuReportes.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconMenuReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.iconMenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuReportes.Name = "iconMenuReportes";
            this.iconMenuReportes.Size = new System.Drawing.Size(80, 69);
            this.iconMenuReportes.Text = "Reportes";
            this.iconMenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 117);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1054, 482);
            this.panelContenido.TabIndex = 0;
            // 
            // menuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1054, 599);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripTitulo);
            this.Name = "menuAdministrador";
            this.Text = "menuAdministrador";
            this.Load += new System.EventHandler(this.menuAdministrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem iconMenuProductos;
        private FontAwesome.Sharp.IconMenuItem iconMenuProveedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuCompra;
        private FontAwesome.Sharp.IconMenuItem iconMenuVentas;
        private FontAwesome.Sharp.IconMenuItem iconMenuReportes;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem1;
    }
}