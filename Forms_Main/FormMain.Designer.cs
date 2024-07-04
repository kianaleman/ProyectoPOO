namespace VeterinariaProyecto
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            btnRegisterOwner = new Button();
            btnRegisterPet = new Button();
            btnViewPets = new Button();
            btnExit = new Button();
            btnAddQuery = new Button();
            btnViewQueryVac = new Button();
            btnSettings = new Button();
            panel1 = new Panel();
            tbTime = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterOwner
            // 
            btnRegisterOwner.BackColor = Color.FromArgb(39, 57, 90);
            btnRegisterOwner.FlatAppearance.BorderColor = Color.Gray;
            btnRegisterOwner.FlatAppearance.BorderSize = 0;
            btnRegisterOwner.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnRegisterOwner.FlatStyle = FlatStyle.Flat;
            btnRegisterOwner.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnRegisterOwner.ForeColor = Color.DarkGray;
            btnRegisterOwner.Location = new Point(83, 133);
            btnRegisterOwner.Name = "btnRegisterOwner";
            btnRegisterOwner.Size = new Size(172, 41);
            btnRegisterOwner.TabIndex = 1;
            btnRegisterOwner.Text = "Registrar Dueño";
            btnRegisterOwner.UseVisualStyleBackColor = false;
            btnRegisterOwner.Click += btnAddPet_Click;
            // 
            // btnRegisterPet
            // 
            btnRegisterPet.BackColor = Color.FromArgb(39, 57, 90);
            btnRegisterPet.FlatAppearance.BorderSize = 0;
            btnRegisterPet.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnRegisterPet.FlatStyle = FlatStyle.Flat;
            btnRegisterPet.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnRegisterPet.ForeColor = Color.DarkGray;
            btnRegisterPet.Location = new Point(83, 226);
            btnRegisterPet.Name = "btnRegisterPet";
            btnRegisterPet.Size = new Size(172, 41);
            btnRegisterPet.TabIndex = 2;
            btnRegisterPet.Text = "Registrar Mascota";
            btnRegisterPet.UseVisualStyleBackColor = false;
            btnRegisterPet.Click += btnRegisterPet_Click;
            // 
            // btnViewPets
            // 
            btnViewPets.BackColor = Color.FromArgb(39, 57, 90);
            btnViewPets.FlatAppearance.BorderSize = 0;
            btnViewPets.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnViewPets.FlatStyle = FlatStyle.Flat;
            btnViewPets.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnViewPets.ForeColor = Color.DarkGray;
            btnViewPets.Location = new Point(384, 133);
            btnViewPets.Name = "btnViewPets";
            btnViewPets.Size = new Size(172, 41);
            btnViewPets.TabIndex = 4;
            btnViewPets.Text = "Mascotas/Dueño";
            btnViewPets.UseVisualStyleBackColor = false;
            btnViewPets.Click += btnAddPets_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(39, 57, 90);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(482, 424);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 33);
            btnExit.TabIndex = 8;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddQuery
            // 
            btnAddQuery.BackColor = Color.FromArgb(39, 57, 90);
            btnAddQuery.FlatAppearance.BorderSize = 0;
            btnAddQuery.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnAddQuery.FlatStyle = FlatStyle.Flat;
            btnAddQuery.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAddQuery.ForeColor = Color.DarkGray;
            btnAddQuery.Location = new Point(83, 323);
            btnAddQuery.Name = "btnAddQuery";
            btnAddQuery.Size = new Size(172, 41);
            btnAddQuery.TabIndex = 3;
            btnAddQuery.Text = "Agregar Consulta";
            btnAddQuery.UseVisualStyleBackColor = false;
            btnAddQuery.Click += btnAddQuery_Click;
            // 
            // btnViewQueryVac
            // 
            btnViewQueryVac.BackColor = Color.FromArgb(39, 57, 90);
            btnViewQueryVac.FlatAppearance.BorderSize = 0;
            btnViewQueryVac.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnViewQueryVac.FlatStyle = FlatStyle.Flat;
            btnViewQueryVac.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnViewQueryVac.ForeColor = Color.DarkGray;
            btnViewQueryVac.Location = new Point(384, 226);
            btnViewQueryVac.Name = "btnViewQueryVac";
            btnViewQueryVac.Size = new Size(172, 41);
            btnViewQueryVac.TabIndex = 5;
            btnViewQueryVac.Text = "Consultas/Vacunas";
            btnViewQueryVac.UseVisualStyleBackColor = false;
            btnViewQueryVac.Click += btnViewQueryVac_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(39, 57, 90);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Navy;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnSettings.ForeColor = Color.DarkGray;
            btnSettings.Location = new Point(354, 323);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(202, 41);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Ajustes";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Controls.Add(tbTime);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 38);
            panel1.TabIndex = 12;
            // 
            // tbTime
            // 
            tbTime.BackColor = Color.FromArgb(0, 80, 200);
            tbTime.BorderStyle = BorderStyle.None;
            tbTime.Font = new Font("Century Gothic", 12F);
            tbTime.ForeColor = Color.Transparent;
            tbTime.Location = new Point(469, 12);
            tbTime.Name = "tbTime";
            tbTime.ReadOnly = true;
            tbTime.Size = new Size(145, 25);
            tbTime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(242, 34);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Registro;
            pictureBox1.Location = new Point(14, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ic_mascotas;
            pictureBox3.Location = new Point(14, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(81, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.ic_lupita;
            pictureBox5.InitialImage = null;
            pictureBox5.Location = new Point(312, 118);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(79, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.ic_librito;
            pictureBox6.Location = new Point(321, 211);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 67);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.ic_ajustecito;
            pictureBox8.Location = new Point(321, 306);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(80, 67);
            pictureBox8.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox8.TabIndex = 21;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Image = Properties.Resources.ic_plusesito;
            pictureBox9.InitialImage = null;
            pictureBox9.Location = new Point(31, 306);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(64, 67);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 22;
            pictureBox9.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(617, 469);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnSettings);
            Controls.Add(btnViewQueryVac);
            Controls.Add(btnAddQuery);
            Controls.Add(btnExit);
            Controls.Add(btnViewPets);
            Controls.Add(btnRegisterPet);
            Controls.Add(btnRegisterOwner);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegisterOwner;
        private Button btnRegisterPet;
        private Button btnViewPets;
        private Button btnExit;
        private Button btnAddQuery;
        private Button btnViewQueryVac;
        private Button btnSettings;
        private Panel panel1;
        private Label label1;
        private TextBox tbTime;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
    }
}