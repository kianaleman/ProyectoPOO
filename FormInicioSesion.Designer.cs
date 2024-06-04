namespace VeterinariaProyecto
{
    partial class FormInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tbPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbUser = new TextBox();
            btnIngreso = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 41);
            label1.TabIndex = 0;
            label1.Text = "Veterinaria El POO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 68);
            label2.Name = "label2";
            label2.Size = new Size(405, 68);
            label2.TabIndex = 2;
            label2.Text = "Bienvenido al Sistema de Datos de Mascotas de la Veterinaria POO!\r\n\r\nEs un gusto atenderle!\r\n\r\n";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(57, 237);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(279, 27);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 152);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 4;
            label3.Text = "Ingrese Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 214);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 5;
            label4.Text = "Ingrese Contraseña:";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(57, 175);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(279, 27);
            tbUser.TabIndex = 6;
            // 
            // btnIngreso
            // 
            btnIngreso.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIngreso.Location = new Point(139, 292);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(94, 29);
            btnIngreso.TabIndex = 7;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngreso);
            Controls.Add(tbUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veterinaria El POO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbPassword;
        private Label label3;
        private Label label4;
        private TextBox tbUser;
        private Button btnIngreso;
        private ErrorProvider errorProvider1;
    }
}
