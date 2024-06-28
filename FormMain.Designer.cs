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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnRegisterOwner = new Button();
            btnRegisterPet = new Button();
            btnViewPets = new Button();
            btnExit = new Button();
            btnAddQuery = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 12F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(198, 21);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.panda_png;
            pictureBox1.Location = new Point(216, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(386, 25);
            label2.TabIndex = 2;
            label2.Text = "Seleccione una de las siguientes opciones:";
            // 
            // btnRegisterOwner
            // 
            btnRegisterOwner.BackColor = SystemColors.Info;
            btnRegisterOwner.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterOwner.ForeColor = Color.Brown;
            btnRegisterOwner.Location = new Point(35, 165);
            btnRegisterOwner.Name = "btnRegisterOwner";
            btnRegisterOwner.Size = new Size(137, 67);
            btnRegisterOwner.TabIndex = 3;
            btnRegisterOwner.Text = "Registrar Dueño";
            btnRegisterOwner.UseVisualStyleBackColor = false;
            btnRegisterOwner.Click += btnAddPet_Click;
            // 
            // btnRegisterPet
            // 
            btnRegisterPet.BackColor = SystemColors.Info;
            btnRegisterPet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegisterPet.ForeColor = Color.Brown;
            btnRegisterPet.Location = new Point(216, 165);
            btnRegisterPet.Name = "btnRegisterPet";
            btnRegisterPet.Size = new Size(137, 67);
            btnRegisterPet.TabIndex = 5;
            btnRegisterPet.Text = "Registrar Mascota";
            btnRegisterPet.UseVisualStyleBackColor = false;
            btnRegisterPet.Click += btnRegisterPet_Click;
            // 
            // btnViewPets
            // 
            btnViewPets.BackColor = SystemColors.Info;
            btnViewPets.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewPets.ForeColor = Color.Brown;
            btnViewPets.Location = new Point(35, 261);
            btnViewPets.Name = "btnViewPets";
            btnViewPets.Size = new Size(137, 67);
            btnViewPets.TabIndex = 6;
            btnViewPets.Text = "Ver Mascotas";
            btnViewPets.UseVisualStyleBackColor = false;
            btnViewPets.Click += btnAddPets_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.Brown;
            btnExit.Location = new Point(35, 352);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 67);
            btnExit.TabIndex = 8;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAddQuery
            // 
            btnAddQuery.BackColor = SystemColors.Info;
            btnAddQuery.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddQuery.ForeColor = Color.Brown;
            btnAddQuery.Location = new Point(216, 261);
            btnAddQuery.Name = "btnAddQuery";
            btnAddQuery.Size = new Size(137, 67);
            btnAddQuery.TabIndex = 9;
            btnAddQuery.Text = "Agregar Consulta";
            btnAddQuery.UseVisualStyleBackColor = false;
            btnAddQuery.Click += btnAddQuery_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddQuery);
            Controls.Add(btnExit);
            Controls.Add(btnViewPets);
            Controls.Add(btnRegisterPet);
            Controls.Add(btnRegisterOwner);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnRegisterOwner;
        private Button btnRegisterPet;
        private Button btnViewPets;
        private Button btnExit;
        private Button btnAddQuery;
    }
}