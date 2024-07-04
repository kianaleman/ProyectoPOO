namespace VeterinariaProyecto
{
    partial class FormRegisterPet
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tbNamePet = new TextBox();
            tbSpecies = new TextBox();
            tbRace = new TextBox();
            tbAge = new TextBox();
            tbWeight = new TextBox();
            tbGender = new TextBox();
            tbDateBirth = new TextBox();
            tbColor = new TextBox();
            tbSterilized = new TextBox();
            tbRegistrationDate = new TextBox();
            tbNotes = new TextBox();
            btnSavePet = new Button();
            btnCancel = new Button();
            tbIdentificacionOwner = new TextBox();
            label14 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 133);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(15, 176);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 2;
            label3.Text = "Especie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(434, 176);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Raza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(434, 133);
            label5.Name = "label5";
            label5.Size = new Size(61, 19);
            label5.TabIndex = 4;
            label5.Text = "Edad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(624, 137);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 8;
            label6.Text = "Color:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(661, 183);
            label7.Name = "label7";
            label7.Size = new Size(165, 19);
            label7.TabIndex = 7;
            label7.Text = "Fecha Nacimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(822, 140);
            label8.Name = "label8";
            label8.Size = new Size(55, 19);
            label8.TabIndex = 6;
            label8.Text = "Sexo:";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(15, 230);
            label9.Name = "label9";
            label9.Size = new Size(92, 19);
            label9.TabIndex = 5;
            label9.Text = " Peso(kg):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(15, 278);
            label10.Name = "label10";
            label10.Size = new Size(61, 19);
            label10.TabIndex = 12;
            label10.Text = "Notas:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label11.Location = new Point(525, 100);
            label11.Name = "label11";
            label11.Size = new Size(0, 26);
            label11.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(525, 41);
            label12.Name = "label12";
            label12.Size = new Size(134, 19);
            label12.TabIndex = 10;
            label12.Text = "Fecha Registro:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(241, 230);
            label13.Name = "label13";
            label13.Size = new Size(104, 19);
            label13.TabIndex = 9;
            label13.Text = "Esterilizado:";
            label13.Click += label13_Click;
            // 
            // tbNamePet
            // 
            tbNamePet.BackColor = SystemColors.ButtonFace;
            tbNamePet.BorderStyle = BorderStyle.FixedSingle;
            tbNamePet.Font = new Font("Century Gothic", 12F);
            tbNamePet.Location = new Point(111, 135);
            tbNamePet.Name = "tbNamePet";
            tbNamePet.Size = new Size(306, 32);
            tbNamePet.TabIndex = 2;
            // 
            // tbSpecies
            // 
            tbSpecies.BackColor = SystemColors.ButtonFace;
            tbSpecies.BorderStyle = BorderStyle.FixedSingle;
            tbSpecies.Font = new Font("Century Gothic", 12F);
            tbSpecies.Location = new Point(111, 178);
            tbSpecies.Name = "tbSpecies";
            tbSpecies.Size = new Size(306, 32);
            tbSpecies.TabIndex = 6;
            // 
            // tbRace
            // 
            tbRace.BackColor = SystemColors.ButtonFace;
            tbRace.BorderStyle = BorderStyle.FixedSingle;
            tbRace.Font = new Font("Century Gothic", 12F);
            tbRace.Location = new Point(501, 176);
            tbRace.Name = "tbRace";
            tbRace.Size = new Size(141, 32);
            tbRace.TabIndex = 7;
            // 
            // tbAge
            // 
            tbAge.BackColor = SystemColors.ButtonFace;
            tbAge.BorderStyle = BorderStyle.FixedSingle;
            tbAge.Font = new Font("Century Gothic", 12F);
            tbAge.Location = new Point(501, 133);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(93, 32);
            tbAge.TabIndex = 3;
            // 
            // tbWeight
            // 
            tbWeight.BackColor = SystemColors.ButtonFace;
            tbWeight.BorderStyle = BorderStyle.FixedSingle;
            tbWeight.Font = new Font("Century Gothic", 12F);
            tbWeight.Location = new Point(111, 225);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(75, 32);
            tbWeight.TabIndex = 9;
            // 
            // tbGender
            // 
            tbGender.BackColor = SystemColors.ButtonFace;
            tbGender.BorderStyle = BorderStyle.FixedSingle;
            tbGender.Font = new Font("Century Gothic", 12F);
            tbGender.Location = new Point(888, 135);
            tbGender.Name = "tbGender";
            tbGender.Size = new Size(145, 32);
            tbGender.TabIndex = 5;
            // 
            // tbDateBirth
            // 
            tbDateBirth.BackColor = SystemColors.ButtonFace;
            tbDateBirth.BorderStyle = BorderStyle.FixedSingle;
            tbDateBirth.Font = new Font("Century Gothic", 12F);
            tbDateBirth.Location = new Point(832, 176);
            tbDateBirth.Name = "tbDateBirth";
            tbDateBirth.Size = new Size(201, 32);
            tbDateBirth.TabIndex = 8;
            // 
            // tbColor
            // 
            tbColor.BackColor = SystemColors.ButtonFace;
            tbColor.BorderStyle = BorderStyle.FixedSingle;
            tbColor.Font = new Font("Century Gothic", 12F);
            tbColor.Location = new Point(688, 133);
            tbColor.Name = "tbColor";
            tbColor.Size = new Size(105, 32);
            tbColor.TabIndex = 4;
            // 
            // tbSterilized
            // 
            tbSterilized.BackColor = SystemColors.ButtonFace;
            tbSterilized.BorderStyle = BorderStyle.FixedSingle;
            tbSterilized.Font = new Font("Century Gothic", 12F);
            tbSterilized.Location = new Point(351, 225);
            tbSterilized.Name = "tbSterilized";
            tbSterilized.Size = new Size(66, 32);
            tbSterilized.TabIndex = 10;
            // 
            // tbRegistrationDate
            // 
            tbRegistrationDate.BackColor = SystemColors.ButtonFace;
            tbRegistrationDate.BorderStyle = BorderStyle.FixedSingle;
            tbRegistrationDate.Font = new Font("Century Gothic", 12F);
            tbRegistrationDate.Location = new Point(729, 42);
            tbRegistrationDate.Name = "tbRegistrationDate";
            tbRegistrationDate.Size = new Size(272, 32);
            tbRegistrationDate.TabIndex = 0;
            tbRegistrationDate.TextChanged += tbRegistrationDate_TextChanged;
            // 
            // tbNotes
            // 
            tbNotes.BackColor = SystemColors.ButtonFace;
            tbNotes.BorderStyle = BorderStyle.FixedSingle;
            tbNotes.Font = new Font("Century Gothic", 12F);
            tbNotes.Location = new Point(111, 278);
            tbNotes.Multiline = true;
            tbNotes.Name = "tbNotes";
            tbNotes.Size = new Size(414, 167);
            tbNotes.TabIndex = 11;
            // 
            // btnSavePet
            // 
            btnSavePet.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSavePet.FlatStyle = FlatStyle.Flat;
            btnSavePet.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSavePet.Location = new Point(616, 363);
            btnSavePet.Margin = new Padding(5);
            btnSavePet.Name = "btnSavePet";
            btnSavePet.Size = new Size(183, 43);
            btnSavePet.TabIndex = 12;
            btnSavePet.Text = "Guardar";
            btnSavePet.UseVisualStyleBackColor = true;
            btnSavePet.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(818, 363);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 43);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Volver";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbIdentificacionOwner
            // 
            tbIdentificacionOwner.BackColor = SystemColors.ButtonFace;
            tbIdentificacionOwner.BorderStyle = BorderStyle.FixedSingle;
            tbIdentificacionOwner.Font = new Font("Century Gothic", 12F);
            tbIdentificacionOwner.Location = new Point(111, 87);
            tbIdentificacionOwner.Name = "tbIdentificacionOwner";
            tbIdentificacionOwner.Size = new Size(306, 32);
            tbIdentificacionOwner.TabIndex = 1;
            tbIdentificacionOwner.TextChanged += tbIdentificacionOwner_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(15, 87);
            label14.Name = "label14";
            label14.Size = new Size(68, 19);
            label14.TabIndex = 26;
            label14.Text = "Dueño:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 36);
            panel1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 80, 200);
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(247, 27);
            label1.TabIndex = 18;
            label1.Text = "REGISTRAR MASCOTA";
            // 
            // FormRegisterPet
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(1040, 482);
            Controls.Add(panel1);
            Controls.Add(tbIdentificacionOwner);
            Controls.Add(label14);
            Controls.Add(btnCancel);
            Controls.Add(btnSavePet);
            Controls.Add(tbNotes);
            Controls.Add(tbRegistrationDate);
            Controls.Add(tbSterilized);
            Controls.Add(tbColor);
            Controls.Add(tbDateBirth);
            Controls.Add(tbGender);
            Controls.Add(tbWeight);
            Controls.Add(tbAge);
            Controls.Add(tbRace);
            Controls.Add(tbSpecies);
            Controls.Add(tbNamePet);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormRegisterPet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegisterPet";
            Load += FormRegisterPet_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbNamePet;
        private TextBox tbSpecies;
        private TextBox tbRace;
        private TextBox tbAge;
        private TextBox tbWeight;
        private TextBox tbGender;
        private TextBox tbDateBirth;
        private TextBox tbColor;
        private TextBox tbSterilized;
        private TextBox tbRegistrationDate;
        private TextBox tbNotes;
        private Button btnSavePet;
        private Button btnCancel;
        private TextBox tbIdentificacionOwner;
        private Label label14;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        public Label label1;
    }
}