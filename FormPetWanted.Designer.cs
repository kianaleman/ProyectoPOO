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
            ((System.ComponentModel.ISupportInitialize)dgvOwnerData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPetsData).BeginInit();
            SuspendLayout();
            // 
            // dgvOwnerData
            // 
            dgvOwnerData.AllowUserToAddRows = false;
            dgvOwnerData.AllowUserToDeleteRows = false;
            dgvOwnerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnerData.Location = new Point(12, 52);
            dgvOwnerData.Name = "dgvOwnerData";
            dgvOwnerData.ReadOnly = true;
            dgvOwnerData.RowHeadersWidth = 51;
            dgvOwnerData.Size = new Size(1180, 106);
            dgvOwnerData.TabIndex = 0;
            // 
            // dgvPetsData
            // 
            dgvPetsData.AllowUserToAddRows = false;
            dgvPetsData.AllowUserToDeleteRows = false;
            dgvPetsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetsData.Location = new Point(12, 313);
            dgvPetsData.Name = "dgvPetsData";
            dgvPetsData.ReadOnly = true;
            dgvPetsData.RowHeadersWidth = 51;
            dgvPetsData.Size = new Size(1180, 188);
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
            // FormPetWanted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1204, 629);
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
    }
}