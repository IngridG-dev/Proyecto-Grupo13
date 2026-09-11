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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.iconProductos = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconUsuarios = new FontAwesome.Sharp.IconMenuItem();
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
            this.menu.Size = new System.Drawing.Size(1177, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1177, 59);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuTitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "The B-Side";
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
            // 
            // iconVentas
            // 
            this.iconVentas.AutoSize = false;
            this.iconVentas.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.iconVentas.ForeColor = System.Drawing.Color.White;
            this.iconVentas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.iconVentas.IconColor = System.Drawing.Color.White;
            this.iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVentas.Name = "iconVentas";
            this.iconVentas.Size = new System.Drawing.Size(89, 69);
            this.iconVentas.Text = "Ventas";
            this.iconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.iconUsuarios.Text = "Usuarios";
            this.iconUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1177, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip2);
            this.Name = "menuVendedor";
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
    }
}