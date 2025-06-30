namespace POS
{
    partial class frmVentas
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnBuscar = new Button();
            btnAgregar = new Button();
            txtImporte = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            txtTotal = new TextBox();
            label7 = new Label();
            panel4 = new Panel();
            dgvProductos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(232, 23);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 1;
            label1.Text = "Modulo de ventas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ico_ventas;
            pictureBox1.Location = new Point(89, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(txtImporte);
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(txtClave);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 167);
            panel2.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.ico_lupa;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Location = new Point(363, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(50, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(386, 81);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(153, 80);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(232, 134);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(125, 27);
            txtImporte.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(232, 103);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 8;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            txtCantidad.KeyUp += txtCantidad_KeyUp;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(232, 74);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(232, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(307, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(232, 8);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(125, 27);
            txtClave.TabIndex = 5;
            txtClave.KeyDown += txtClave_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 137);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 4;
            label6.Text = "Importe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 106);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 3;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 77);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 44);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 11);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "Clave productto";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 509);
            panel3.Name = "panel3";
            panel3.Size = new Size(639, 96);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(414, 49);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 2;
            button1.Text = "PAGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(414, 16);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 19);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 0;
            label7.Text = "Total a pagar";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvProductos);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(639, 259);
            panel4.TabIndex = 3;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(639, 259);
            dgvProductos.TabIndex = 0;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 605);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnBuscar;
        private Button btnAgregar;
        private TextBox txtImporte;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtClave;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvProductos;
        private Button button1;
        private TextBox txtTotal;
        private Label label7;
    }
}