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
            btnOwnerPet = new Button();
            AddPet = new Button();
            btnAddQuery = new Button();
            btnAddPet = new Button();
            btnSettings = new Button();
            btnExit = new Button();
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
            // btnOwnerPet
            // 
            btnOwnerPet.BackColor = SystemColors.Info;
            btnOwnerPet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOwnerPet.ForeColor = Color.Brown;
            btnOwnerPet.Location = new Point(35, 165);
            btnOwnerPet.Name = "btnOwnerPet";
            btnOwnerPet.Size = new Size(137, 67);
            btnOwnerPet.TabIndex = 3;
            btnOwnerPet.Text = "Dueños de Mascotas";
            btnOwnerPet.UseVisualStyleBackColor = false;
            btnOwnerPet.Click += btnOwnerPet_Click;
            // 
            // AddPet
            // 
            AddPet.BackColor = SystemColors.Info;
            AddPet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AddPet.ForeColor = Color.Brown;
            AddPet.Location = new Point(216, 261);
            AddPet.Name = "AddPet";
            AddPet.Size = new Size(137, 67);
            AddPet.TabIndex = 4;
            AddPet.Text = "Editar Mascotas";
            AddPet.UseVisualStyleBackColor = false;
            // 
            // btnAddQuery
            // 
            btnAddQuery.BackColor = SystemColors.Info;
            btnAddQuery.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAddQuery.ForeColor = Color.Brown;
            btnAddQuery.Location = new Point(216, 165);
            btnAddQuery.Name = "btnAddQuery";
            btnAddQuery.Size = new Size(137, 67);
            btnAddQuery.TabIndex = 5;
            btnAddQuery.Text = "Agregar Consulta";
            btnAddQuery.UseVisualStyleBackColor = false;
            // 
            // btnAddPet
            // 
            btnAddPet.BackColor = SystemColors.Info;
            btnAddPet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPet.ForeColor = Color.Brown;
            btnAddPet.Location = new Point(35, 261);
            btnAddPet.Name = "btnAddPet";
            btnAddPet.Size = new Size(137, 67);
            btnAddPet.TabIndex = 6;
            btnAddPet.Text = "Añadir Mascota";
            btnAddPet.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = SystemColors.Info;
            btnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSettings.ForeColor = Color.Brown;
            btnSettings.Location = new Point(35, 350);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(137, 67);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "Ajustes";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Info;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.Brown;
            btnExit.Location = new Point(216, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 67);
            btnExit.TabIndex = 8;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSettings);
            Controls.Add(btnAddPet);
            Controls.Add(btnAddQuery);
            Controls.Add(AddPet);
            Controls.Add(btnOwnerPet);
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
        private Button btnOwnerPet;
        private Button AddPet;
        private Button btnAddQuery;
        private Button btnAddPet;
        private Button btnSettings;
        private Button btnExit;
    }
}