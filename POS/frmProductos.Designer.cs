namespace POS
{
    partial class frmProductos
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
            btnCerrar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel3 = new Panel();
            btnBuscar = new Button();
            txtMaximo = new TextBox();
            txtMinimo = new TextBox();
            txtExistencia = new TextBox();
            txtPrecioVenta = new TextBox();
            txtPrecioCompra = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtUbicacion = new TextBox();
            txtMedida = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtClave = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 109);
            panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = Properties.Resources.ico_salir_2;
            btnCerrar.Location = new Point(823, 25);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(48, 54);
            btnCerrar.TabIndex = 2;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ico_productos;
            pictureBox1.Location = new Point(67, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(169, 36);
            label1.Name = "label1";
            label1.Size = new Size(275, 32);
            label1.TabIndex = 0;
            label1.Text = "Catálogo de Productos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 541);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 80);
            panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.ico_limpiar;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(712, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 53);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.ico_save;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(542, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 53);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(txtMaximo);
            panel3.Controls.Add(txtMinimo);
            panel3.Controls.Add(txtExistencia);
            panel3.Controls.Add(txtPrecioVenta);
            panel3.Controls.Add(txtPrecioCompra);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtUbicacion);
            panel3.Controls.Add(txtMedida);
            panel3.Controls.Add(txtDescripcion);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtClave);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(883, 432);
            panel3.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.ico_lupa;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Location = new Point(384, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(60, 29);
            btnBuscar.TabIndex = 24;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtMaximo
            // 
            txtMaximo.Location = new Point(248, 351);
            txtMaximo.Name = "txtMaximo";
            txtMaximo.Size = new Size(401, 27);
            txtMaximo.TabIndex = 23;
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(248, 318);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(401, 27);
            txtMinimo.TabIndex = 22;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(247, 285);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(401, 27);
            txtExistencia.TabIndex = 21;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(247, 252);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(401, 27);
            txtPrecioVenta.TabIndex = 20;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(247, 219);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(401, 27);
            txtPrecioCompra.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(123, 351);
            label12.Name = "label12";
            label12.Size = new Size(103, 20);
            label12.TabIndex = 16;
            label12.Text = "Maximo Stock";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(126, 318);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 15;
            label11.Text = "Minimo Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(152, 285);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 14;
            label10.Text = "Existencia";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(151, 186);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 13;
            label9.Text = "Ubicación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 219);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 12;
            label8.Text = "Precio Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(135, 252);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 11;
            label7.Text = "Precio Venta";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(247, 186);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(401, 27);
            txtUbicacion.TabIndex = 10;
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(247, 153);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(401, 27);
            txtMedida.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(247, 120);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(401, 27);
            txtDescripcion.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(247, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(401, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(247, 54);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(401, 27);
            txtClave.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(247, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 153);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 4;
            label6.Text = "Unidad de medida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 120);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 3;
            label5.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 87);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 54);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 1;
            label3.Text = "Clave Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 21);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 0;
            label2.Text = "Id";
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 621);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductos";
            Load += frmProductos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnGuardar;
        private Panel panel3;
        private TextBox txtUbicacion;
        private TextBox txtMedida;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtClave;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtMaximo;
        private TextBox txtMinimo;
        private TextBox txtExistencia;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnBuscar;
        private Button btnCancelar;
        private Button btnCerrar;
    }
}