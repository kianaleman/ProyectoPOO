namespace VeterinariaProyecto.Forms_Settings
{
    partial class FormChangeUser
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
            btnSave = new Button();
            btnClose = new Button();
            tbCurrentUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbNewUser = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(336, 184);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 43);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ButtonFace;
            btnClose.Location = new Point(101, 184);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(183, 43);
            btnClose.TabIndex = 1;
            btnClose.Text = "Volver";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbCurrentUser
            // 
            tbCurrentUser.BorderStyle = BorderStyle.FixedSingle;
            tbCurrentUser.Font = new Font("Century Gothic", 12F);
            tbCurrentUser.Location = new Point(308, 47);
            tbCurrentUser.Margin = new Padding(4, 3, 4, 3);
            tbCurrentUser.Name = "tbCurrentUser";
            tbCurrentUser.Size = new Size(228, 32);
            tbCurrentUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(65, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 19);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Usuario Actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(65, 109);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 19);
            label2.TabIndex = 5;
            label2.Text = "Nombre de Usuario Nuevo:";
            // 
            // tbNewUser
            // 
            tbNewUser.BorderStyle = BorderStyle.FixedSingle;
            tbNewUser.Font = new Font("Century Gothic", 12F);
            tbNewUser.Location = new Point(308, 109);
            tbNewUser.Margin = new Padding(4, 3, 4, 3);
            tbNewUser.Name = "tbNewUser";
            tbNewUser.Size = new Size(228, 32);
            tbNewUser.TabIndex = 4;
            // 
            // FormChangeUser
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(631, 250);
            Controls.Add(label2);
            Controls.Add(tbNewUser);
            Controls.Add(label1);
            Controls.Add(tbCurrentUser);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormChangeUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangeUser";
            Load += FormChangeUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private TextBox tbCurrentUser;
        private Label label1;
        private Label label2;
        private TextBox tbNewUser;
    }
}