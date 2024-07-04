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
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(12, 293);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(226, 43);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(61, 22);
            label1.Name = "label1";
            label1.Size = new Size(124, 34);
            label1.TabIndex = 1;
            label1.Text = "AJUSTES";
            // 
            // btnChangeUser
            // 
            btnChangeUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnChangeUser.FlatStyle = FlatStyle.Flat;
            btnChangeUser.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnChangeUser.ForeColor = SystemColors.ButtonFace;
            btnChangeUser.Location = new Point(12, 131);
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.Size = new Size(226, 43);
            btnChangeUser.TabIndex = 1;
            btnChangeUser.Text = "Cambiar Usuario";
            btnChangeUser.UseVisualStyleBackColor = true;
            btnChangeUser.Click += btnChangeUser_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnChangePassword.ForeColor = SystemColors.ButtonFace;
            btnChangePassword.Location = new Point(12, 216);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(226, 43);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "Cambiar Contraseña";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(250, 450);
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