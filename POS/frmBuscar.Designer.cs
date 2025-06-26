namespace POS
{
    partial class frmBuscar
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
            panel1 = new Panel();
            btnFiltrar = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            dGV_datos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_datos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnFiltrar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 105);
            panel1.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(546, 48);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(40, 49);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(469, 27);
            txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Texto a buscar";
            // 
            // dGV_datos
            // 
            dGV_datos.AllowUserToAddRows = false;
            dGV_datos.AllowUserToDeleteRows = false;
            dGV_datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV_datos.Dock = DockStyle.Fill;
            dGV_datos.Location = new Point(0, 105);
            dGV_datos.Name = "dGV_datos";
            dGV_datos.ReadOnly = true;
            dGV_datos.RowHeadersWidth = 51;
            dGV_datos.Size = new Size(754, 500);
            dGV_datos.TabIndex = 1;
            dGV_datos.CellDoubleClick += dGV_datos_CellDoubleClick;
            // 
            // frmBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 605);
            Controls.Add(dGV_datos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmBuscar";
            Text = "Pantalla de busquedad";
            Load += frmBuscar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGV_datos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFiltrar;
        private TextBox txtBuscar;
        private Label label1;
        private DataGridView dGV_datos;
    }
}