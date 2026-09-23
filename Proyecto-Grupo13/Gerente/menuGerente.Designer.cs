namespace Proyecto_Grupo13.Gerente
{
    partial class menuGerente
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
            this.iconMenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.reporteCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuProdVendidos = new FontAwesome.Sharp.IconMenuItem();
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
            this.menuStripTitulo.TabIndex = 8;
            this.menuStripTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "The B-Side";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 47);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 82);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuReportes
            // 
            this.iconMenuReportes.AutoSize = false;
            this.iconMenuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteCompraToolStripMenuItem,
            this.iconMenuProdVendidos});
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
            // reporteCompraToolStripMenuItem
            // 
            this.reporteCompraToolStripMenuItem.Name = "reporteCompraToolStripMenuItem";
            this.reporteCompraToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.reporteCompraToolStripMenuItem.Text = "Estadísticas de ventas";
            this.reporteCompraToolStripMenuItem.Click += new System.EventHandler(this.reporteCompraToolStripMenuItem_Click);
            // 
            // iconMenuProdVendidos
            // 
            this.iconMenuProdVendidos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuProdVendidos.IconColor = System.Drawing.Color.Black;
            this.iconMenuProdVendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProdVendidos.Name = "iconMenuProdVendidos";
            this.iconMenuProdVendidos.Size = new System.Drawing.Size(226, 26);
            this.iconMenuProdVendidos.Text = "Productos más vendidos";
            this.iconMenuProdVendidos.Click += new System.EventHandler(this.iconMenuProdVendidos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 129);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1054, 470);
            this.panelContenido.TabIndex = 11;
            // 
            // menuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1054, 599);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "menuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuGerente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelContenido;
        private FontAwesome.Sharp.IconMenuItem iconMenuReportes;
        private System.Windows.Forms.ToolStripMenuItem reporteCompraToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuProdVendidos;
    }
}