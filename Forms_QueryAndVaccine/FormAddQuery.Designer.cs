namespace VeterinariaProyecto
{
    partial class FormAddQuery
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
            label1 = new Label();
            tbIdOwner = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            dgvPets = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            tbIdPet = new TextBox();
            label4 = new Label();
            tbDate = new TextBox();
            label5 = new Label();
            tbSintomas = new TextBox();
            label6 = new Label();
            tbMotivo = new TextBox();
            tbObservaciones = new TextBox();
            tbExamen = new TextBox();
            label7 = new Label();
            tbTratamiento = new TextBox();
            label8 = new Label();
            btnSaveQuery = new Button();
            btnExit = new Button();
            btnSearchPets = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tbNameOwner = new TextBox();
            tbLastNameOwner = new TextBox();
            tbNumberOwner = new TextBox();
            tbCedOwner = new TextBox();
            gpVaccine = new GroupBox();
            tbTypeVaccine = new TextBox();
            rBtnNo = new RadioButton();
            rBtnYes = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            gpVaccine.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(449, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 34);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA";
            // 
            // tbIdOwner
            // 
            tbIdOwner.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            tbIdOwner.Location = new Point(13, 70);
            tbIdOwner.Name = "tbIdOwner";
            tbIdOwner.PlaceholderText = "Ingrese Identificacion del Dueño";
            tbIdOwner.Size = new Size(231, 28);
            tbIdOwner.TabIndex = 0;
            tbIdOwner.TextChanged += tbIdOwner_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.AllowUserToDeleteRows = false;
            dgvPets.AllowUserToResizeColumns = false;
            dgvPets.AllowUserToResizeRows = false;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPets.BackgroundColor = SystemColors.Control;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Location = new Point(12, 115);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 51;
            dgvPets.Size = new Size(319, 115);
            dgvPets.TabIndex = 2;
            dgvPets.CellContentClick += dgvPets_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(4, 258);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 3;
            label2.Text = "ID MASCOTA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(426, 92);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 4;
            label3.Text = "Motivo";
            // 
            // tbIdPet
            // 
            tbIdPet.BorderStyle = BorderStyle.FixedSingle;
            tbIdPet.Font = new Font("Century Gothic", 9F);
            tbIdPet.ForeColor = SystemColors.ButtonFace;
            tbIdPet.Location = new Point(129, 255);
            tbIdPet.Name = "tbIdPet";
            tbIdPet.Size = new Size(100, 26);
            tbIdPet.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(696, 92);
            label4.Name = "label4";
            label4.Size = new Size(134, 19);
            label4.TabIndex = 7;
            label4.Text = "Observaciones";
            // 
            // tbDate
            // 
            tbDate.BorderStyle = BorderStyle.FixedSingle;
            tbDate.Font = new Font("Century Gothic", 9F);
            tbDate.ForeColor = SystemColors.ButtonFace;
            tbDate.Location = new Point(1059, 69);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(140, 26);
            tbDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(989, 72);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 9;
            label5.Text = "FECHA:";
            // 
            // tbSintomas
            // 
            tbSintomas.BorderStyle = BorderStyle.FixedSingle;
            tbSintomas.Font = new Font("Century Gothic", 9F);
            tbSintomas.ForeColor = SystemColors.ButtonFace;
            tbSintomas.Location = new Point(426, 306);
            tbSintomas.Multiline = true;
            tbSintomas.Name = "tbSintomas";
            tbSintomas.Size = new Size(264, 69);
            tbSintomas.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(426, 283);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 11;
            label6.Text = "Sintomas";
            // 
            // tbMotivo
            // 
            tbMotivo.BorderStyle = BorderStyle.FixedSingle;
            tbMotivo.Font = new Font("Century Gothic", 9F);
            tbMotivo.ForeColor = SystemColors.ButtonFace;
            tbMotivo.Location = new Point(426, 115);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(264, 69);
            tbMotivo.TabIndex = 6;
            tbMotivo.TextChanged += tbMotivo_TextChanged;
            // 
            // tbObservaciones
            // 
            tbObservaciones.BorderStyle = BorderStyle.FixedSingle;
            tbObservaciones.Font = new Font("Century Gothic", 9F);
            tbObservaciones.ForeColor = SystemColors.ButtonFace;
            tbObservaciones.Location = new Point(696, 115);
            tbObservaciones.Multiline = true;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.Size = new Size(264, 69);
            tbObservaciones.TabIndex = 7;
            // 
            // tbExamen
            // 
            tbExamen.BorderStyle = BorderStyle.FixedSingle;
            tbExamen.Font = new Font("Century Gothic", 9F);
            tbExamen.ForeColor = SystemColors.ButtonFace;
            tbExamen.Location = new Point(426, 213);
            tbExamen.Multiline = true;
            tbExamen.Name = "tbExamen";
            tbExamen.Size = new Size(264, 69);
            tbExamen.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(426, 190);
            label7.Name = "label7";
            label7.Size = new Size(162, 19);
            label7.TabIndex = 15;
            label7.Text = "Examen Realizado";
            // 
            // tbTratamiento
            // 
            tbTratamiento.BorderStyle = BorderStyle.FixedSingle;
            tbTratamiento.Font = new Font("Century Gothic", 9F);
            tbTratamiento.ForeColor = SystemColors.ButtonFace;
            tbTratamiento.Location = new Point(696, 213);
            tbTratamiento.Multiline = true;
            tbTratamiento.Name = "tbTratamiento";
            tbTratamiento.Size = new Size(264, 69);
            tbTratamiento.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(696, 190);
            label8.Name = "label8";
            label8.Size = new Size(103, 19);
            label8.TabIndex = 17;
            label8.Text = "Tratamiento";
            // 
            // btnSaveQuery
            // 
            btnSaveQuery.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSaveQuery.FlatStyle = FlatStyle.Flat;
            btnSaveQuery.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSaveQuery.ForeColor = SystemColors.ButtonFace;
            btnSaveQuery.Location = new Point(1059, 434);
            btnSaveQuery.Name = "btnSaveQuery";
            btnSaveQuery.Size = new Size(183, 43);
            btnSaveQuery.TabIndex = 19;
            btnSaveQuery.Text = "Guardar";
            btnSaveQuery.UseVisualStyleBackColor = true;
            btnSaveQuery.Click += btnSaveQuery_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(1058, 483);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 43);
            btnExit.TabIndex = 20;
            btnExit.Text = "Volver";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearchPets
            // 
            btnSearchPets.FlatStyle = FlatStyle.Flat;
            btnSearchPets.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSearchPets.ForeColor = SystemColors.ButtonFace;
            btnSearchPets.Location = new Point(250, 62);
            btnSearchPets.Name = "btnSearchPets";
            btnSearchPets.Size = new Size(86, 40);
            btnSearchPets.TabIndex = 21;
            btnSearchPets.Text = "Buscar";
            btnSearchPets.UseVisualStyleBackColor = true;
            btnSearchPets.Click += btnSearchPets_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(4, 306);
            label9.Name = "label9";
            label9.Size = new Size(145, 19);
            label9.TabIndex = 22;
            label9.Text = "Datos del Dueño";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(4, 353);
            label10.Name = "label10";
            label10.Size = new Size(101, 19);
            label10.TabIndex = 23;
            label10.Text = "Nombre(s):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(4, 401);
            label11.Name = "label11";
            label11.Size = new Size(103, 19);
            label11.TabIndex = 24;
            label11.Text = "Apellido(s):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(4, 444);
            label12.Name = "label12";
            label12.Size = new Size(80, 19);
            label12.TabIndex = 25;
            label12.Text = "Numero:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(4, 492);
            label13.Name = "label13";
            label13.Size = new Size(126, 19);
            label13.TabIndex = 26;
            label13.Text = "Identificacion:";
            // 
            // tbNameOwner
            // 
            tbNameOwner.BorderStyle = BorderStyle.FixedSingle;
            tbNameOwner.Font = new Font("Century Gothic", 9F);
            tbNameOwner.ForeColor = SystemColors.ButtonFace;
            tbNameOwner.Location = new Point(111, 351);
            tbNameOwner.Name = "tbNameOwner";
            tbNameOwner.Size = new Size(220, 26);
            tbNameOwner.TabIndex = 2;
            // 
            // tbLastNameOwner
            // 
            tbLastNameOwner.BorderStyle = BorderStyle.FixedSingle;
            tbLastNameOwner.Font = new Font("Century Gothic", 9F);
            tbLastNameOwner.ForeColor = SystemColors.ButtonFace;
            tbLastNameOwner.Location = new Point(110, 401);
            tbLastNameOwner.Name = "tbLastNameOwner";
            tbLastNameOwner.Size = new Size(221, 26);
            tbLastNameOwner.TabIndex = 3;
            // 
            // tbNumberOwner
            // 
            tbNumberOwner.BorderStyle = BorderStyle.FixedSingle;
            tbNumberOwner.Font = new Font("Century Gothic", 9F);
            tbNumberOwner.ForeColor = SystemColors.ButtonFace;
            tbNumberOwner.Location = new Point(110, 444);
            tbNumberOwner.Name = "tbNumberOwner";
            tbNumberOwner.Size = new Size(221, 26);
            tbNumberOwner.TabIndex = 4;
            // 
            // tbCedOwner
            // 
            tbCedOwner.BorderStyle = BorderStyle.FixedSingle;
            tbCedOwner.Font = new Font("Century Gothic", 9F);
            tbCedOwner.ForeColor = SystemColors.ButtonFace;
            tbCedOwner.Location = new Point(138, 490);
            tbCedOwner.Name = "tbCedOwner";
            tbCedOwner.Size = new Size(193, 26);
            tbCedOwner.TabIndex = 5;
            // 
            // gpVaccine
            // 
            gpVaccine.Controls.Add(tbTypeVaccine);
            gpVaccine.Controls.Add(rBtnNo);
            gpVaccine.Controls.Add(rBtnYes);
            gpVaccine.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            gpVaccine.ForeColor = SystemColors.Control;
            gpVaccine.Location = new Point(710, 306);
            gpVaccine.Name = "gpVaccine";
            gpVaccine.Size = new Size(250, 210);
            gpVaccine.TabIndex = 31;
            gpVaccine.TabStop = false;
            gpVaccine.Text = "Vacuna";
            // 
            // tbTypeVaccine
            // 
            tbTypeVaccine.Font = new Font("Century Gothic", 9F);
            tbTypeVaccine.Location = new Point(18, 68);
            tbTypeVaccine.Multiline = true;
            tbTypeVaccine.Name = "tbTypeVaccine";
            tbTypeVaccine.Size = new Size(174, 107);
            tbTypeVaccine.TabIndex = 2;
            // 
            // rBtnNo
            // 
            rBtnNo.AutoSize = true;
            rBtnNo.Location = new Point(80, 38);
            rBtnNo.Name = "rBtnNo";
            rBtnNo.Size = new Size(54, 23);
            rBtnNo.TabIndex = 1;
            rBtnNo.Text = "No";
            rBtnNo.UseVisualStyleBackColor = true;
            rBtnNo.CheckedChanged += rBtnNo_CheckedChanged;
            // 
            // rBtnYes
            // 
            rBtnYes.AutoSize = true;
            rBtnYes.Checked = true;
            rBtnYes.Location = new Point(18, 38);
            rBtnYes.Name = "rBtnYes";
            rBtnYes.Size = new Size(43, 23);
            rBtnYes.TabIndex = 0;
            rBtnYes.TabStop = true;
            rBtnYes.Text = "Si";
            rBtnYes.UseVisualStyleBackColor = true;
            rBtnYes.CheckedChanged += rBtnYes_CheckedChanged;
            // 
            // FormAddQuery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(1263, 568);
            Controls.Add(gpVaccine);
            Controls.Add(tbCedOwner);
            Controls.Add(tbNumberOwner);
            Controls.Add(tbLastNameOwner);
            Controls.Add(tbNameOwner);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnSearchPets);
            Controls.Add(btnExit);
            Controls.Add(btnSaveQuery);
            Controls.Add(tbTratamiento);
            Controls.Add(label8);
            Controls.Add(tbExamen);
            Controls.Add(label7);
            Controls.Add(tbObservaciones);
            Controls.Add(tbMotivo);
            Controls.Add(tbSintomas);
            Controls.Add(label6);
            Controls.Add(tbDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbIdPet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvPets);
            Controls.Add(tbIdOwner);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddQuery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddQuery";
            Load += FormAddQuery_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            gpVaccine.ResumeLayout(false);
            gpVaccine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbIdOwner;
        private ErrorProvider errorProvider1;
        private DataGridView dgvPets;
        private Label label4;
        private TextBox tbIdPet;
        private Label label3;
        private Label label2;
        private TextBox tbDate;
        private Label label5;
        private TextBox tbSintomas;
        private Label label6;
        private TextBox tbMotivo;
        private TextBox tbTratamiento;
        private Label label8;
        private TextBox tbExamen;
        private Label label7;
        private TextBox tbObservaciones;
        private Button btnExit;
        private Button btnSaveQuery;
        private Button btnSearchPets;
        private Label label10;
        private Label label9;
        private TextBox tbCedOwner;
        private TextBox tbNumberOwner;
        private TextBox tbLastNameOwner;
        private TextBox tbNameOwner;
        private Label label13;
        private Label label12;
        private Label label11;
        private GroupBox gpVaccine;
        private TextBox tbTypeVaccine;
        private RadioButton rBtnNo;
        private RadioButton rBtnYes;
    }
}