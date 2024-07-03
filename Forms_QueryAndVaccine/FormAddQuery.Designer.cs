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
            label1.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(449, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 46);
            label1.TabIndex = 0;
            label1.Text = "CONSULTA";
            // 
            // tbIdOwner
            // 
            tbIdOwner.Location = new Point(12, 69);
            tbIdOwner.Name = "tbIdOwner";
            tbIdOwner.PlaceholderText = "Ingrese Identificacion del Dueño";
            tbIdOwner.Size = new Size(231, 27);
            tbIdOwner.TabIndex = 1;
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
            label2.Location = new Point(4, 258);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "ID MASCOTA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 92);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 4;
            label3.Text = "Motivo";
            // 
            // tbIdPet
            // 
            tbIdPet.Location = new Point(108, 255);
            tbIdPet.Name = "tbIdPet";
            tbIdPet.Size = new Size(100, 27);
            tbIdPet.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(696, 92);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 7;
            label4.Text = "Observaciones";
            // 
            // tbDate
            // 
            tbDate.Location = new Point(1052, 69);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(140, 27);
            tbDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(989, 72);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "FECHA:";
            // 
            // tbSintomas
            // 
            tbSintomas.Location = new Point(426, 306);
            tbSintomas.Multiline = true;
            tbSintomas.Name = "tbSintomas";
            tbSintomas.Size = new Size(264, 69);
            tbSintomas.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 283);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Sintomas";
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(426, 115);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(264, 69);
            tbMotivo.TabIndex = 13;
            tbMotivo.TextChanged += tbMotivo_TextChanged;
            // 
            // tbObservaciones
            // 
            tbObservaciones.Location = new Point(696, 115);
            tbObservaciones.Multiline = true;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.Size = new Size(264, 69);
            tbObservaciones.TabIndex = 14;
            // 
            // tbExamen
            // 
            tbExamen.Location = new Point(426, 213);
            tbExamen.Multiline = true;
            tbExamen.Name = "tbExamen";
            tbExamen.Size = new Size(264, 69);
            tbExamen.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 190);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 15;
            label7.Text = "Examen Realizado";
            // 
            // tbTratamiento
            // 
            tbTratamiento.Location = new Point(696, 213);
            tbTratamiento.Multiline = true;
            tbTratamiento.Name = "tbTratamiento";
            tbTratamiento.Size = new Size(264, 69);
            tbTratamiento.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(696, 190);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 17;
            label8.Text = "Tratamiento";
            // 
            // btnSaveQuery
            // 
            btnSaveQuery.Location = new Point(1067, 106);
            btnSaveQuery.Name = "btnSaveQuery";
            btnSaveQuery.Size = new Size(125, 78);
            btnSaveQuery.TabIndex = 19;
            btnSaveQuery.Text = "Guardar";
            btnSaveQuery.UseVisualStyleBackColor = true;
            btnSaveQuery.Click += btnSaveQuery_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1067, 198);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 78);
            btnExit.TabIndex = 20;
            btnExit.Text = "Volver";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearchPets
            // 
            btnSearchPets.Location = new Point(260, 69);
            btnSearchPets.Name = "btnSearchPets";
            btnSearchPets.Size = new Size(134, 29);
            btnSearchPets.TabIndex = 21;
            btnSearchPets.Text = "Buscar Mascotas";
            btnSearchPets.UseVisualStyleBackColor = true;
            btnSearchPets.Click += btnSearchPets_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 306);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 22;
            label9.Text = "Datos del Dueño";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 353);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 23;
            label10.Text = "Nombre(s):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 401);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 24;
            label11.Text = "Apellido(s):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 444);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 25;
            label12.Text = "Numero:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(4, 492);
            label13.Name = "label13";
            label13.Size = new Size(102, 20);
            label13.TabIndex = 26;
            label13.Text = "Identificacion:";
            // 
            // tbNameOwner
            // 
            tbNameOwner.Location = new Point(96, 352);
            tbNameOwner.Name = "tbNameOwner";
            tbNameOwner.Size = new Size(220, 27);
            tbNameOwner.TabIndex = 27;
            // 
            // tbLastNameOwner
            // 
            tbLastNameOwner.Location = new Point(95, 401);
            tbLastNameOwner.Name = "tbLastNameOwner";
            tbLastNameOwner.Size = new Size(221, 27);
            tbLastNameOwner.TabIndex = 28;
            // 
            // tbNumberOwner
            // 
            tbNumberOwner.Location = new Point(95, 444);
            tbNumberOwner.Name = "tbNumberOwner";
            tbNumberOwner.Size = new Size(221, 27);
            tbNumberOwner.TabIndex = 29;
            // 
            // tbCedOwner
            // 
            tbCedOwner.Location = new Point(123, 489);
            tbCedOwner.Name = "tbCedOwner";
            tbCedOwner.Size = new Size(193, 27);
            tbCedOwner.TabIndex = 30;
            // 
            // gpVaccine
            // 
            gpVaccine.Controls.Add(tbTypeVaccine);
            gpVaccine.Controls.Add(rBtnNo);
            gpVaccine.Controls.Add(rBtnYes);
            gpVaccine.Location = new Point(710, 306);
            gpVaccine.Name = "gpVaccine";
            gpVaccine.Size = new Size(250, 210);
            gpVaccine.TabIndex = 31;
            gpVaccine.TabStop = false;
            gpVaccine.Text = "Vacuna";
            // 
            // tbTypeVaccine
            // 
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
            rBtnNo.Size = new Size(50, 24);
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
            rBtnYes.Size = new Size(42, 24);
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
            BackColor = Color.FromArgb(128, 255, 128);
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