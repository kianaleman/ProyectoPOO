namespace VeterinariaProyecto
{
    partial class FormEditOwner
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
            btnCancel = new Button();
            label7 = new Label();
            tbIdentificacion = new TextBox();
            label6 = new Label();
            btnSave = new Button();
            tbLastNames = new TextBox();
            tbNumber = new TextBox();
            tbAddress = new TextBox();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(608, 236);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 43);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Volver";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(26, 74);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 30;
            label7.Text = "Identificacion:";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.BackColor = SystemColors.ButtonFace;
            tbIdentificacion.BorderStyle = BorderStyle.FixedSingle;
            tbIdentificacion.Font = new Font("Century Gothic", 12F);
            tbIdentificacion.Location = new Point(182, 74);
            tbIdentificacion.Margin = new Padding(4);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.Size = new Size(364, 32);
            tbIdentificacion.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 139);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 28;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(608, 161);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 43);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // tbLastNames
            // 
            tbLastNames.BackColor = SystemColors.ButtonFace;
            tbLastNames.Font = new Font("Century Gothic", 12F);
            tbLastNames.Location = new Point(182, 182);
            tbLastNames.Margin = new Padding(4);
            tbLastNames.Name = "tbLastNames";
            tbLastNames.Size = new Size(364, 32);
            tbLastNames.TabIndex = 2;
            // 
            // tbNumber
            // 
            tbNumber.BackColor = SystemColors.ButtonFace;
            tbNumber.Font = new Font("Century Gothic", 12F);
            tbNumber.Location = new Point(182, 236);
            tbNumber.Margin = new Padding(4);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(364, 32);
            tbNumber.TabIndex = 3;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = SystemColors.ButtonFace;
            tbAddress.Font = new Font("Century Gothic", 12F);
            tbAddress.Location = new Point(182, 295);
            tbAddress.Margin = new Padding(4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(364, 75);
            tbAddress.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ButtonFace;
            tbName.Font = new Font("Century Gothic", 12F);
            tbName.Location = new Point(182, 127);
            tbName.Margin = new Padding(4);
            tbName.Name = "tbName";
            tbName.Size = new Size(364, 32);
            tbName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(54, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 22;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(63, 236);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 21;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(56, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 20;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(63, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 19;
            label1.Text = "Nombres:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 38);
            panel1.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 80, 200);
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(3, 9);
            label8.Name = "label8";
            label8.Size = new Size(171, 27);
            label8.TabIndex = 18;
            label8.Text = "EDITAR DUEÑO";
            // 
            // FormEditOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(829, 383);
            Controls.Add(panel1);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(tbIdentificacion);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(tbLastNames);
            Controls.Add(tbNumber);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditOwner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditOwner";
            Load += FormEditOwner_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnCancel;
        private Label label7;
        public TextBox tbIdentificacion;
        private Label label6;
        public Button btnSave;
        public TextBox tbLastNames;
        public TextBox tbNumber;
        public TextBox tbAddress;
        public TextBox tbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        public Label label8;
    }
}