namespace VeterinariaProyecto.Forms_QueryAndVaccine
{
    partial class FormEditQueryAndVaccine
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
            gpVaccine = new GroupBox();
            tbTypeVaccine = new TextBox();
            rBtnNo = new RadioButton();
            rBtnYes = new RadioButton();
            tbNumberOwner = new TextBox();
            tbLastNameOwner = new TextBox();
            tbNameOwner = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnExit = new Button();
            btnSaveQuery = new Button();
            tbTratamiento = new TextBox();
            label8 = new Label();
            tbExamen = new TextBox();
            label7 = new Label();
            tbObservaciones = new TextBox();
            tbMotivo = new TextBox();
            tbSintomas = new TextBox();
            label6 = new Label();
            label4 = new Label();
            tbIdPet = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearchPets = new Button();
            dgvPets = new DataGridView();
            tbIdOwner = new TextBox();
            tbDate = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            gpVaccine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            SuspendLayout();
            // 
            // gpVaccine
            // 
            gpVaccine.Controls.Add(tbTypeVaccine);
            gpVaccine.Controls.Add(rBtnNo);
            gpVaccine.Controls.Add(rBtnYes);
            gpVaccine.Location = new Point(734, 304);
            gpVaccine.Name = "gpVaccine";
            gpVaccine.Size = new Size(250, 210);
            gpVaccine.TabIndex = 59;
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
            // 
            // tbNumberOwner
            // 
            tbNumberOwner.Location = new Point(119, 442);
            tbNumberOwner.Name = "tbNumberOwner";
            tbNumberOwner.Size = new Size(221, 27);
            tbNumberOwner.TabIndex = 58;
            // 
            // tbLastNameOwner
            // 
            tbLastNameOwner.Location = new Point(119, 399);
            tbLastNameOwner.Name = "tbLastNameOwner";
            tbLastNameOwner.Size = new Size(221, 27);
            tbLastNameOwner.TabIndex = 57;
            // 
            // tbNameOwner
            // 
            tbNameOwner.Location = new Point(120, 350);
            tbNameOwner.Name = "tbNameOwner";
            tbNameOwner.Size = new Size(220, 27);
            tbNameOwner.TabIndex = 56;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 442);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 55;
            label12.Text = "Numero:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 399);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 54;
            label11.Text = "Apellido(s):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 351);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 53;
            label10.Text = "Nombre(s):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 304);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 52;
            label9.Text = "Datos del Dueño";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1091, 196);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 78);
            btnExit.TabIndex = 50;
            btnExit.Text = "Volver";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSaveQuery
            // 
            btnSaveQuery.Location = new Point(1091, 104);
            btnSaveQuery.Name = "btnSaveQuery";
            btnSaveQuery.Size = new Size(125, 78);
            btnSaveQuery.TabIndex = 49;
            btnSaveQuery.Text = "Guardar";
            btnSaveQuery.UseVisualStyleBackColor = true;
            // 
            // tbTratamiento
            // 
            tbTratamiento.Location = new Point(720, 211);
            tbTratamiento.Multiline = true;
            tbTratamiento.Name = "tbTratamiento";
            tbTratamiento.Size = new Size(264, 69);
            tbTratamiento.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(720, 188);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 47;
            label8.Text = "Tratamiento";
            // 
            // tbExamen
            // 
            tbExamen.ForeColor = Color.YellowGreen;
            tbExamen.Location = new Point(450, 211);
            tbExamen.Multiline = true;
            tbExamen.Name = "tbExamen";
            tbExamen.Size = new Size(264, 69);
            tbExamen.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 188);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 45;
            label7.Text = "Examen Realizado";
            // 
            // tbObservaciones
            // 
            tbObservaciones.Location = new Point(720, 113);
            tbObservaciones.Multiline = true;
            tbObservaciones.Name = "tbObservaciones";
            tbObservaciones.Size = new Size(264, 69);
            tbObservaciones.TabIndex = 44;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(450, 113);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(264, 69);
            tbMotivo.TabIndex = 43;
            // 
            // tbSintomas
            // 
            tbSintomas.Location = new Point(450, 304);
            tbSintomas.Multiline = true;
            tbSintomas.Name = "tbSintomas";
            tbSintomas.Size = new Size(264, 69);
            tbSintomas.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(450, 281);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 41;
            label6.Text = "Sintomas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(720, 90);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 38;
            label4.Text = "Observaciones";
            // 
            // tbIdPet
            // 
            tbIdPet.Location = new Point(132, 253);
            tbIdPet.Name = "tbIdPet";
            tbIdPet.Size = new Size(100, 27);
            tbIdPet.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 90);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 36;
            label3.Text = "Motivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 256);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 35;
            label2.Text = "ID MASCOTA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(886, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 46);
            label1.TabIndex = 32;
            label1.Text = "EDITAR CONSULTA";
            // 
            // btnSearchPets
            // 
            btnSearchPets.Location = new Point(411, 42);
            btnSearchPets.Name = "btnSearchPets";
            btnSearchPets.Size = new Size(134, 29);
            btnSearchPets.TabIndex = 62;
            btnSearchPets.Text = "Buscar Mascotas";
            btnSearchPets.UseVisualStyleBackColor = true;
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
            dgvPets.Location = new Point(28, 90);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 51;
            dgvPets.Size = new Size(319, 115);
            dgvPets.TabIndex = 61;
            // 
            // tbIdOwner
            // 
            tbIdOwner.Location = new Point(28, 44);
            tbIdOwner.Name = "tbIdOwner";
            tbIdOwner.PlaceholderText = "Ingrese Identificacion del Dueño";
            tbIdOwner.Size = new Size(231, 27);
            tbIdOwner.TabIndex = 60;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(1072, 304);
            tbDate.Name = "tbDate";
            tbDate.ReadOnly = true;
            tbDate.Size = new Size(140, 27);
            tbDate.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1009, 307);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 65;
            label5.Text = "FECHA:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 44);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 67;
            // 
            // FormEditQueryAndVaccine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 521);
            Controls.Add(textBox1);
            Controls.Add(tbDate);
            Controls.Add(label5);
            Controls.Add(btnSearchPets);
            Controls.Add(dgvPets);
            Controls.Add(tbIdOwner);
            Controls.Add(gpVaccine);
            Controls.Add(tbNumberOwner);
            Controls.Add(tbLastNameOwner);
            Controls.Add(tbNameOwner);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
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
            Controls.Add(label4);
            Controls.Add(tbIdPet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditQueryAndVaccine";
            Text = "FormEditQueryAndVaccine";
            gpVaccine.ResumeLayout(false);
            gpVaccine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpVaccine;
        private TextBox tbTypeVaccine;
        private RadioButton rBtnNo;
        private RadioButton rBtnYes;
        private TextBox tbNumberOwner;
        private TextBox tbLastNameOwner;
        private TextBox tbNameOwner;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnExit;
        private Button btnSaveQuery;
        private TextBox tbTratamiento;
        private Label label8;
        private TextBox tbExamen;
        private Label label7;
        private TextBox tbObservaciones;
        private TextBox tbMotivo;
        private TextBox tbSintomas;
        private Label label6;
        private Label label4;
        private TextBox tbIdPet;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearchPets;
        private DataGridView dgvPets;
        private TextBox tbIdOwner;
        private TextBox tbDate;
        private Label label5;
        private TextBox textBox1;
    }
}