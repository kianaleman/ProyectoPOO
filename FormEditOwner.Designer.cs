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
            label5 = new Label();
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
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.OliveDrab;
            label5.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 9);
            label5.Name = "label5";
            label5.Size = new Size(224, 38);
            label5.TabIndex = 32;
            label5.Text = "EDITAR DUEÑO";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(639, 169);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 64);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Volver";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label7.Location = new Point(26, 84);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 26);
            label7.TabIndex = 30;
            label7.Text = "Identificacion:";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.Location = new Point(182, 84);
            tbIdentificacion.Margin = new Padding(4);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.Size = new Size(318, 27);
            tbIdentificacion.TabIndex = 29;
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
            btnSave.Location = new Point(639, 84);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 64);
            btnSave.TabIndex = 27;
            btnSave.Text = "GUARDAR CAMBIOS";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // tbLastNames
            // 
            tbLastNames.Location = new Point(136, 185);
            tbLastNames.Margin = new Padding(4);
            tbLastNames.Name = "tbLastNames";
            tbLastNames.Size = new Size(364, 27);
            tbLastNames.TabIndex = 26;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(136, 233);
            tbNumber.Margin = new Padding(4);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(364, 27);
            tbNumber.TabIndex = 25;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(151, 286);
            tbAddress.Margin = new Padding(4);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(349, 75);
            tbAddress.TabIndex = 24;
            // 
            // tbName
            // 
            tbName.Location = new Point(136, 137);
            tbName.Margin = new Padding(4);
            tbName.Name = "tbName";
            tbName.Size = new Size(364, 27);
            tbName.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(26, 286);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 22;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(26, 233);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 21;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(26, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 26);
            label2.TabIndex = 20;
            label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(26, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 26);
            label1.TabIndex = 19;
            label1.Text = "Nombres:";
            // 
            // FormEditOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(892, 383);
            Controls.Add(label5);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label5;
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
    }
}