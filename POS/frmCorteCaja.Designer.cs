namespace POS
{
    partial class frmCorteCaja
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
            dtpFechaCorte = new DateTimePicker();
            label1 = new Label();
            btnBuscarVentas = new Button();
            panel2 = new Panel();
            label2 = new Label();
            btnGenerarCorte = new Button();
            txtTotalVendido = new TextBox();
            panel3 = new Panel();
            dgvVentasDelDia = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            ClaveProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Importe = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDelDia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtpFechaCorte);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuscarVentas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 84);
            panel1.TabIndex = 0;
            // 
            // dtpFechaCorte
            // 
            dtpFechaCorte.Format = DateTimePickerFormat.Short;
            dtpFechaCorte.Location = new Point(269, 36);
            dtpFechaCorte.Name = "dtpFechaCorte";
            dtpFechaCorte.Size = new Size(188, 27);
            dtpFechaCorte.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 1;
            label1.Text = "Selecciona la fecha del corte de caja";
            // 
            // btnBuscarVentas
            // 
            btnBuscarVentas.Location = new Point(463, 36);
            btnBuscarVentas.Name = "btnBuscarVentas";
            btnBuscarVentas.Size = new Size(94, 29);
            btnBuscarVentas.TabIndex = 0;
            btnBuscarVentas.Text = "Buscar Ventas";
            btnBuscarVentas.UseVisualStyleBackColor = true;
            btnBuscarVentas.Click += btnBuscarVentas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnGenerarCorte);
            panel2.Controls.Add(txtTotalVendido);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 689);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 90);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 9);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 2;
            label2.Text = "Total de la Venta";
            // 
            // btnGenerarCorte
            // 
            btnGenerarCorte.Location = new Point(490, 47);
            btnGenerarCorte.Name = "btnGenerarCorte";
            btnGenerarCorte.Size = new Size(183, 29);
            btnGenerarCorte.TabIndex = 1;
            btnGenerarCorte.Text = "Generar Corte";
            btnGenerarCorte.UseVisualStyleBackColor = true;
            btnGenerarCorte.Click += btnGenerarCorte_Click;
            // 
            // txtTotalVendido
            // 
            txtTotalVendido.Location = new Point(490, 6);
            txtTotalVendido.Name = "txtTotalVendido";
            txtTotalVendido.ReadOnly = true;
            txtTotalVendido.Size = new Size(183, 27);
            txtTotalVendido.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(dgvVentasDelDia);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(676, 605);
            panel3.TabIndex = 2;
            // 
            // dgvVentasDelDia
            // 
            dgvVentasDelDia.AllowUserToAddRows = false;
            dgvVentasDelDia.AllowUserToDeleteRows = false;
            dgvVentasDelDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasDelDia.BackgroundColor = Color.AliceBlue;
            dgvVentasDelDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasDelDia.Columns.AddRange(new DataGridViewColumn[] { Cantidad, ClaveProducto, NombreProducto, Importe });
            dgvVentasDelDia.Dock = DockStyle.Fill;
            dgvVentasDelDia.Location = new Point(0, 0);
            dgvVentasDelDia.Name = "dgvVentasDelDia";
            dgvVentasDelDia.ReadOnly = true;
            dgvVentasDelDia.RowHeadersWidth = 51;
            dgvVentasDelDia.Size = new Size(676, 605);
            dgvVentasDelDia.TabIndex = 0;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // ClaveProducto
            // 
            ClaveProducto.HeaderText = "Clave del Producto";
            ClaveProducto.MinimumWidth = 6;
            ClaveProducto.Name = "ClaveProducto";
            ClaveProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre del Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Importe
            // 
            Importe.HeaderText = "Importe";
            Importe.MinimumWidth = 6;
            Importe.Name = "Importe";
            Importe.ReadOnly = true;
            // 
            // frmCorteCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 779);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCorteCaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pantalla de Corte de Caja Diario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasDelDia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DateTimePicker dtpFechaCorte;
        private Label label1;
        private Button btnBuscarVentas;
        private Label label2;
        private Button btnGenerarCorte;
        private TextBox txtTotalVendido;
        private DataGridView dgvVentasDelDia;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn ClaveProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Importe;
    }
}