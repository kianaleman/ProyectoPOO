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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(17, 146);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 194);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 1;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(17, 242);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(17, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // tbNames
            // 
            tbNames.Location = new Point(127, 146);
            tbNames.Margin = new Padding(4);
            tbNames.Name = "tbNames";
            tbNames.Size = new Size(364, 31);
            tbNames.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(142, 295);
            tbAddress.Margin = new Padding(4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(349, 75);
            tbAddress.TabIndex = 6;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(127, 242);
            tbNumber.Margin = new Padding(4);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(364, 31);
            tbNumber.TabIndex = 7;
            // 
            // tbLastNames
            // 
            tbLastNames.Location = new Point(127, 194);
            tbLastNames.Margin = new Padding(4);
            tbLastNames.Name = "tbLastNames";
            tbLastNames.Size = new Size(364, 31);
            tbLastNames.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(630, 93);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 64);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OliveDrab;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 18);
            label5.Name = "label5";
            label5.Size = new Size(311, 38);
            label5.TabIndex = 18;
            label5.Text = "REGISTRO DE DUEÑO";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.Location = new Point(173, 93);
            tbIdentificacion.Margin = new Padding(4);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.Size = new Size(318, 31);
            tbIdentificacion.TabIndex = 15;
            tbIdentificacion.TextChanged += tbIdentificacion_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label7.Location = new Point(17, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 26);
            label7.TabIndex = 16;
            label7.Text = "Identificacion:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(630, 178);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 64);
            btnCancel.TabIndex = 17;
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
            // FormAddOwner
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(877, 383);
            Controls.Add(label5);
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
    }
}