namespace VeterinariaProyecto
{
    partial class FormAddOwner
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNames = new TextBox();
            tbAddress = new TextBox();
            tbNumber = new TextBox();
            tbLastNames = new TextBox();
            btnSave = new Button();
            label5 = new Label();
            tbIdentificacion = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            label6 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(45, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(43, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 1;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(50, 239);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(41, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // tbNames
            // 
            tbNames.BackColor = SystemColors.ButtonFace;
            tbNames.BorderStyle = BorderStyle.FixedSingle;
            tbNames.Font = new Font("Century Gothic", 12F);
            tbNames.ForeColor = Color.Black;
            tbNames.Location = new Point(159, 124);
            tbNames.Margin = new Padding(4);
            tbNames.Name = "tbNames";
            tbNames.Size = new Size(364, 32);
            tbNames.TabIndex = 2;
            // 
            // tbAddress
            // 
            tbAddress.BackColor = SystemColors.ButtonFace;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Font = new Font("Century Gothic", 12F);
            tbAddress.ForeColor = Color.Black;
            tbAddress.Location = new Point(159, 295);
            tbAddress.Margin = new Padding(4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(364, 75);
            tbAddress.TabIndex = 5;
            // 
            // tbNumber
            // 
            tbNumber.BackColor = SystemColors.ButtonFace;
            tbNumber.BorderStyle = BorderStyle.FixedSingle;
            tbNumber.Font = new Font("Century Gothic", 12F);
            tbNumber.ForeColor = Color.Black;
            tbNumber.Location = new Point(159, 234);
            tbNumber.Margin = new Padding(4);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(364, 32);
            tbNumber.TabIndex = 4;
            // 
            // tbLastNames
            // 
            tbLastNames.BackColor = SystemColors.ButtonFace;
            tbLastNames.BorderStyle = BorderStyle.FixedSingle;
            tbLastNames.Font = new Font("Century Gothic", 12F);
            tbLastNames.ForeColor = Color.Black;
            tbLastNames.Location = new Point(159, 178);
            tbLastNames.Margin = new Padding(4);
            tbLastNames.Name = "tbLastNames";
            tbLastNames.Size = new Size(364, 32);
            tbLastNames.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(603, 140);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 80, 200);
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(235, 27);
            label5.TabIndex = 18;
            label5.Text = "REGISTRO DE DUEÑO";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.BackColor = SystemColors.ButtonFace;
            tbIdentificacion.BorderStyle = BorderStyle.FixedSingle;
            tbIdentificacion.Font = new Font("Century Gothic", 12F);
            tbIdentificacion.ForeColor = Color.Black;
            tbIdentificacion.Location = new Point(159, 71);
            tbIdentificacion.Margin = new Padding(4);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.Size = new Size(364, 32);
            tbIdentificacion.TabIndex = 1;
            tbIdentificacion.TextChanged += tbIdentificacion_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(8, 76);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 16;
            label7.Text = "Identificacion:";
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(603, 206);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 42);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Volver";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(567, 148);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 26);
            label6.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 38);
            panel1.TabIndex = 19;
            // 
            // FormAddOwner
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
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
            Controls.Add(tbNames);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormAddOwner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OwnerPets";
            Load += FormOwnerPets_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        public Label label5;
        public Button btnCancel;
        private Label label7;
        public TextBox tbIdentificacion;
        private Label label6;
        public Button btnSave;
        public TextBox tbLastNames;
        public TextBox tbNumber;
        public TextBox tbAddress;
        public TextBox tbNames;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}