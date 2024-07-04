namespace VeterinariaProyecto.Forms_Settings
{
    partial class FormChangePassword
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
            label2 = new Label();
            tbNewPassword = new TextBox();
            label1 = new Label();
            tbCurrentPassWord = new TextBox();
            btnClose = new Button();
            btnSave = new Button();
            label3 = new Label();
            btnVerOcultar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 11;
            // 
            // tbNewPassword
            // 
            tbNewPassword.BorderStyle = BorderStyle.FixedSingle;
            tbNewPassword.Font = new Font("Century Gothic", 12F);
            tbNewPassword.Location = new Point(269, 85);
            tbNewPassword.Margin = new Padding(4, 3, 4, 3);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(228, 32);
            tbNewPassword.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(96, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 19);
            label1.TabIndex = 9;
            label1.Text = "Contraseña Actual:";
            // 
            // tbCurrentPassWord
            // 
            tbCurrentPassWord.BorderStyle = BorderStyle.FixedSingle;
            tbCurrentPassWord.Font = new Font("Century Gothic", 12F);
            tbCurrentPassWord.Location = new Point(269, 22);
            tbCurrentPassWord.Margin = new Padding(4, 3, 4, 3);
            tbCurrentPassWord.Name = "tbCurrentPassWord";
            tbCurrentPassWord.Size = new Size(228, 32);
            tbCurrentPassWord.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(104, 138);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(183, 43);
            btnClose.TabIndex = 7;
            btnClose.Text = "Volver";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(339, 138);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(96, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 19);
            label3.TabIndex = 12;
            label3.Text = "Contraseña Nueva:";
            // 
            // btnVerOcultar
            // 
            btnVerOcultar.Location = new Point(522, 51);
            btnVerOcultar.Margin = new Padding(4, 3, 4, 3);
            btnVerOcultar.Name = "btnVerOcultar";
            btnVerOcultar.Size = new Size(30, 28);
            btnVerOcultar.TabIndex = 13;
            btnVerOcultar.UseVisualStyleBackColor = true;
            btnVerOcultar.Click += btnVerOcultar_Click;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(609, 205);
            Controls.Add(btnVerOcultar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNewPassword);
            Controls.Add(label1);
            Controls.Add(tbCurrentPassWord);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangePassword";
            Load += FormChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tbNewPassword;
        private Label label1;
        private TextBox tbCurrentPassWord;
        private Button btnClose;
        private Button btnSave;
        private Label label3;
        private Button btnVerOcultar;
    }
}