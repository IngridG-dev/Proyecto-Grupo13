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
            this.textNumDocu = new System.Windows.Forms.TextBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
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
            this.menuStripTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripTitulo.Size = new System.Drawing.Size(1800, 59);
            this.menuStripTitulo.TabIndex = 8;
            this.menuStripTitulo.Text = "menuStrip2";
            this.menuStripTitulo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripTitulo_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 59);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1800, 102);
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
            this.reporteCompraToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.reporteCompraToolStripMenuItem.Text = "Estadísticas de ventas";
            this.reporteCompraToolStripMenuItem.Click += new System.EventHandler(this.reporteCompraToolStripMenuItem_Click);
            // 
            // iconMenuProdVendidos
            // 
            this.iconMenuProdVendidos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuProdVendidos.IconColor = System.Drawing.Color.Black;
            this.iconMenuProdVendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuProdVendidos.Name = "iconMenuProdVendidos";
            this.iconMenuProdVendidos.Size = new System.Drawing.Size(274, 26);
            this.iconMenuProdVendidos.Text = "Productos más vendidos";
            this.iconMenuProdVendidos.Click += new System.EventHandler(this.iconMenuProdVendidos_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panelContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 161);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1800, 588);
            this.panelContenido.TabIndex = 11;
            // 
            // textNumDocu
            // 
            this.textNumDocu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(27)))), ((int)(((byte)(105)))));
            this.textNumDocu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumDocu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textNumDocu.ForeColor = System.Drawing.Color.White;
            this.textNumDocu.Location = new System.Drawing.Point(1613, 11);
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
            this.textUsuario.Location = new System.Drawing.Point(1282, 11);
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
            this.lblDocumento.Location = new System.Drawing.Point(1458, 17);
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
            this.lblUsuario.Location = new System.Drawing.Point(1194, 17);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(83, 20);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario:";
            // 
            // menuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1800, 749);
            this.Controls.Add(this.textNumDocu);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuGerente";
            this.Load += new System.EventHandler(this.menuGerente_Load);
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
        private System.Windows.Forms.TextBox textNumDocu;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblUsuario;
    }
}