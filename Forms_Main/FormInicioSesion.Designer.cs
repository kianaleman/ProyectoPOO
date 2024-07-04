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
            tbPassword = new TextBox();
            tbUser = new TextBox();
            btnIngreso = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(39, 57, 80);
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Century Gothic", 12F);
            tbPassword.ForeColor = Color.Silver;
            tbPassword.Location = new Point(333, 165);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Contraseña";
            tbPassword.Size = new Size(369, 25);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            tbUser.BackColor = Color.FromArgb(39, 57, 80);
            tbUser.BorderStyle = BorderStyle.None;
            tbUser.Font = new Font("Century Gothic", 12F);
            tbUser.ForeColor = Color.Silver;
            tbUser.Location = new Point(333, 96);
            tbUser.Name = "tbUser";
            tbUser.PlaceholderText = "Usuario";
            tbUser.Size = new Size(369, 25);
            tbUser.TabIndex = 1;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(33, 53, 73);
            btnIngreso.FlatAppearance.BorderColor = Color.FromArgb(85, 159, 127);
            btnIngreso.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btnIngreso.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            btnIngreso.FlatStyle = FlatStyle.Flat;
            btnIngreso.Font = new Font("Century Gothic", 12F);
            btnIngreso.ForeColor = Color.LightGray;
            btnIngreso.Location = new Point(316, 224);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(408, 40);
            btnIngreso.TabIndex = 3;
            btnIngreso.Text = "Ingresar";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(33, 53, 73);
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 118, 126);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F);
            btnExit.ForeColor = Color.LightGray;
            btnExit.Location = new Point(674, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 100, 182);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 34);
            label1.TabIndex = 10;
            label1.Text = "VETERINARIA";
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(780, 330);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnIngreso);
            Controls.Add(tbUser);
            Controls.Add(tbPassword);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormInicioSesion";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Veterinaria El POO";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPassword;
        private TextBox tbUser;
        private Button btnIngreso;
        private ErrorProvider errorProvider1;
        private Button btnExit;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
