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
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 11;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(215, 89);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(183, 27);
            tbNewPassword.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 30);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 9;
            label1.Text = "Contraseña Actual:";
            // 
            // tbCurrentPassWord
            // 
            tbCurrentPassWord.Location = new Point(215, 23);
            tbCurrentPassWord.Name = "tbCurrentPassWord";
            tbCurrentPassWord.Size = new Size(183, 27);
            tbCurrentPassWord.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(96, 166);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 42);
            btnClose.TabIndex = 7;
            btnClose.Text = "Volver";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(284, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 42);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 92);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 12;
            label3.Text = "Contraseña Nueva:";
            // 
            // btnVerOcultar
            // 
            btnVerOcultar.Location = new Point(418, 54);
            btnVerOcultar.Name = "btnVerOcultar";
            btnVerOcultar.Size = new Size(24, 29);
            btnVerOcultar.TabIndex = 13;
            btnVerOcultar.UseVisualStyleBackColor = true;
            btnVerOcultar.Click += btnVerOcultar_Click;
            // 
            // FormChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(487, 216);
            Controls.Add(btnVerOcultar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNewPassword);
            Controls.Add(label1);
            Controls.Add(tbCurrentPassWord);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
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