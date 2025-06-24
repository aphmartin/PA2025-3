namespace POS
{
    partial class frmUsuarios
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnGuardar = new Button();
            panel3 = new Panel();
            btnBuscar = new Button();
            label8 = new Label();
            txtUsuario = new TextBox();
            txtPwd = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtAp1 = new TextBox();
            txtAp2 = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 97);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ico_grupo_usuarios;
            pictureBox1.Location = new Point(45, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(140, 31);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 0;
            label1.Text = "Catálogo de usuarios";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnGuardar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 493);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 59);
            panel2.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(835, 18);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(btnBuscar);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(txtPwd);
            panel3.Controls.Add(txtCorreo);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(txtAp1);
            panel3.Controls.Add(txtAp2);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 396);
            panel3.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.ico_lupa;
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Location = new Point(419, 34);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(140, 259);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 13;
            label8.Text = "Usuario";
            label8.Click += label8_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(283, 252);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(343, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(283, 293);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(343, 27);
            txtPwd.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(283, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(343, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(283, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(343, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtAp1
            // 
            txtAp1.Location = new Point(283, 122);
            txtAp1.Name = "txtAp1";
            txtAp1.Size = new Size(343, 27);
            txtAp1.TabIndex = 3;
            // 
            // txtAp2
            // 
            txtAp2.Location = new Point(283, 166);
            txtAp2.Name = "txtAp2";
            txtAp2.Size = new Size(343, 27);
            txtAp2.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(283, 34);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 300);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 5;
            label7.Text = "Cotraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 217);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 4;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 173);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 3;
            label5.Text = "Segundo Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 85);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 129);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 1;
            label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 41);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Folio";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 552);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
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
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnGuardar;
        private Panel panel3;
        private TextBox txtPwd;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtAp1;
        private TextBox txtAp2;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtUsuario;
        private Label label8;
        private Button btnBuscar;
    }
}