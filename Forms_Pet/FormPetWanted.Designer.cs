namespace VeterinariaProyecto
{
    partial class FormPetWanted
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
            dgvOwnerData = new DataGridView();
            dgvPetsData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnEditOwner = new Button();
            btnEditPet = new Button();
            btnExit = new Button();
            tbIdPet = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOwnerData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPetsData).BeginInit();
            SuspendLayout();
            // 
            // dgvOwnerData
            // 
            dgvOwnerData.AllowUserToAddRows = false;
            dgvOwnerData.AllowUserToDeleteRows = false;
            dgvOwnerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOwnerData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOwnerData.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgvOwnerData.BorderStyle = BorderStyle.None;
            dgvOwnerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnerData.GridColor = SystemColors.ActiveCaptionText;
            dgvOwnerData.Location = new Point(12, 52);
            dgvOwnerData.Name = "dgvOwnerData";
            dgvOwnerData.ReadOnly = true;
            dgvOwnerData.RowHeadersWidth = 51;
            dgvOwnerData.Size = new Size(1180, 123);
            dgvOwnerData.TabIndex = 0;
            // 
            // dgvPetsData
            // 
            dgvPetsData.AllowUserToAddRows = false;
            dgvPetsData.AllowUserToDeleteRows = false;
            dgvPetsData.AllowUserToResizeColumns = false;
            dgvPetsData.AllowUserToResizeRows = false;
            dgvPetsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPetsData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPetsData.BackgroundColor = Color.FromArgb(128, 255, 128);
            dgvPetsData.BorderStyle = BorderStyle.None;
            dgvPetsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetsData.GridColor = SystemColors.InactiveCaptionText;
            dgvPetsData.Location = new Point(12, 313);
            dgvPetsData.Name = "dgvPetsData";
            dgvPetsData.ReadOnly = true;
            dgvPetsData.RowHeadersWidth = 51;
            dgvPetsData.Size = new Size(1180, 225);
            dgvPetsData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(506, 11);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 2;
            label1.Text = "DATOS DUEÑO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(478, 272);
            label2.Name = "label2";
            label2.Size = new Size(267, 38);
            label2.TabIndex = 3;
            label2.Text = "DATOS MASCOTAS";
            // 
            // btnEditOwner
            // 
            btnEditOwner.Location = new Point(531, 181);
            btnEditOwner.Name = "btnEditOwner";
            btnEditOwner.Size = new Size(162, 70);
            btnEditOwner.TabIndex = 4;
            btnEditOwner.Text = "EDITAR DUEÑO";
            btnEditOwner.UseVisualStyleBackColor = true;
            btnEditOwner.Click += btnEditOwner_Click;
            // 
            // btnEditPet
            // 
            btnEditPet.Location = new Point(531, 547);
            btnEditPet.Name = "btnEditPet";
            btnEditPet.Size = new Size(162, 70);
            btnEditPet.TabIndex = 5;
            btnEditPet.Text = "EDITAR MASCOTA";
            btnEditPet.UseVisualStyleBackColor = true;
            btnEditPet.Click += btnEditPet_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1052, 559);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 58);
            btnExit.TabIndex = 6;
            btnExit.Text = "VOLVER";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbIdPet
            // 
            tbIdPet.Location = new Point(318, 590);
            tbIdPet.Name = "tbIdPet";
            tbIdPet.Size = new Size(207, 27);
            tbIdPet.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 567);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 8;
            label3.Text = "Ingresa ID de mascota a Editar";
            // 
            // FormPetWanted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1204, 629);
            Controls.Add(label3);
            Controls.Add(tbIdPet);
            Controls.Add(btnExit);
            Controls.Add(btnEditPet);
            Controls.Add(btnEditOwner);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPetsData);
            Controls.Add(dgvOwnerData);
            Name = "FormPetWanted";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPetWanted";
            Load += FormPetWanted_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOwnerData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPetsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOwnerData;
        private DataGridView dgvPetsData;
        private Label label1;
        private Label label2;
        private Button btnEditOwner;
        private Button btnEditPet;
        private Button btnExit;
        private TextBox tbIdPet;
        private Label label3;
    }
}