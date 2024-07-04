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
            btnSave.Location = new Point(315, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(127, 192);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 42);
            btnClose.TabIndex = 1;
            btnClose.Text = "Volver";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbCurrentUser
            // 
            tbCurrentUser.Location = new Point(246, 49);
            tbCurrentUser.Name = "tbCurrentUser";
            tbCurrentUser.Size = new Size(183, 27);
            tbCurrentUser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Usuario Actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 115);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre de Usuario Nuevo:";
            // 
            // tbNewUser
            // 
            tbNewUser.Location = new Point(246, 115);
            tbNewUser.Name = "tbNewUser";
            tbNewUser.Size = new Size(183, 27);
            tbNewUser.TabIndex = 4;
            // 
            // FormChangeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(505, 263);
            Controls.Add(label2);
            Controls.Add(tbNewUser);
            Controls.Add(label1);
            Controls.Add(tbCurrentUser);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
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