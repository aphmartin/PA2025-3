namespace POS
{
    partial class frnPrincipal
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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            catálogosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            corteDeCajaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            barra_nombre = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            barra_version = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, catálogosToolStripMenuItem, operacionesToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1129, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // catálogosToolStripMenuItem
            // 
            catálogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, productosToolStripMenuItem });
            catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            catálogosToolStripMenuItem.Size = new Size(90, 24);
            catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(158, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(158, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, corteDeCajaToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(106, 24);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(182, 26);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // corteDeCajaToolStripMenuItem
            // 
            corteDeCajaToolStripMenuItem.Name = "corteDeCajaToolStripMenuItem";
            corteDeCajaToolStripMenuItem.Size = new Size(182, 26);
            corteDeCajaToolStripMenuItem.Text = "Corte de Caja";
            corteDeCajaToolStripMenuItem.Click += corteDeCajaToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, barra_nombre, toolStripStatusLabel2, barra_version });
            statusStrip1.Location = new Point(0, 659);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1129, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(142, 20);
            toolStripStatusLabel1.Text = "Nombre de Usuario:";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // barra_nombre
            // 
            barra_nombre.Name = "barra_nombre";
            barra_nombre.Size = new Size(61, 20);
            barra_nombre.Text = "nombre";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(854, 20);
            toolStripStatusLabel2.Spring = true;
            // 
            // barra_version
            // 
            barra_version.Name = "barra_version";
            barra_version.Size = new Size(57, 20);
            barra_version.Text = "Version";
            // 
            // frnPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 685);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frnPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frnPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += frnPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem catálogosToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem corteDeCajaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel barra_nombre;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel barra_version;
    }
}