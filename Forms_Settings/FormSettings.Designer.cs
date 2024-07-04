namespace VeterinariaProyecto.Forms_Main
{
    partial class FormSettings
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
            btnSalir = new Button();
            label1 = new Label();
            btnChangeUser = new Button();
            btnChangePassword = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(70, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 58);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(61, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 1;
            label1.Text = "AJUSTES";
            // 
            // btnChangeUser
            // 
            btnChangeUser.Location = new Point(70, 129);
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.Size = new Size(103, 54);
            btnChangeUser.TabIndex = 2;
            btnChangeUser.Text = "Cambiar Usuario";
            btnChangeUser.UseVisualStyleBackColor = true;
            btnChangeUser.Click += btnChangeUser_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(70, 214);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(103, 51);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Cambiar Contraseña";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(269, 450);
            Controls.Add(btnChangePassword);
            Controls.Add(btnChangeUser);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label label1;
        private Button btnChangeUser;
        private Button btnChangePassword;
    }
}