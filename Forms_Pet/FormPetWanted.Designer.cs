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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            dgvOwnerData.BackgroundColor = Color.FromArgb(39, 57, 90);
            dgvOwnerData.BorderStyle = BorderStyle.None;
            dgvOwnerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnerData.GridColor = SystemColors.ActiveCaptionText;
            dgvOwnerData.Location = new Point(12, 52);
            dgvOwnerData.Name = "dgvOwnerData";
            dgvOwnerData.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOwnerData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOwnerData.RowHeadersVisible = false;
            dgvOwnerData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dgvOwnerData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvOwnerData.Size = new Size(1180, 123);
            dgvOwnerData.TabIndex = 0;
            // 
            // dgvPetsData
            // 
            dgvPetsData.AllowUserToAddRows = false;
            dgvPetsData.AllowUserToDeleteRows = false;
            dgvPetsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPetsData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPetsData.BackgroundColor = Color.FromArgb(39, 57, 90);
            dgvPetsData.BorderStyle = BorderStyle.None;
            dgvPetsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetsData.GridColor = SystemColors.InactiveCaptionText;
            dgvPetsData.Location = new Point(12, 313);
            dgvPetsData.Name = "dgvPetsData";
            dgvPetsData.ReadOnly = true;
            dgvPetsData.RowHeadersVisible = false;
            dgvPetsData.RowHeadersWidth = 51;
            dgvPetsData.Size = new Size(1180, 225);
            dgvPetsData.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(506, 11);
            label1.Name = "label1";
            label1.Size = new Size(268, 34);
            label1.TabIndex = 2;
            label1.Text = "DATOS DEL DUEÑO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(456, 272);
            label2.Name = "label2";
            label2.Size = new Size(369, 34);
            label2.TabIndex = 3;
            label2.Text = "DATOS DE LAS MASCOTAS";
            // 
            // btnEditOwner
            // 
            btnEditOwner.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnEditOwner.FlatStyle = FlatStyle.Flat;
            btnEditOwner.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnEditOwner.ForeColor = SystemColors.ButtonFace;
            btnEditOwner.Location = new Point(531, 181);
            btnEditOwner.Name = "btnEditOwner";
            btnEditOwner.Size = new Size(183, 43);
            btnEditOwner.TabIndex = 3;
            btnEditOwner.Text = "Modificar";
            btnEditOwner.UseVisualStyleBackColor = true;
            btnEditOwner.Click += btnEditOwner_Click;
            // 
            // btnEditPet
            // 
            btnEditPet.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnEditPet.FlatStyle = FlatStyle.Flat;
            btnEditPet.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnEditPet.ForeColor = SystemColors.ButtonFace;
            btnEditPet.Location = new Point(531, 581);
            btnEditPet.Name = "btnEditPet";
            btnEditPet.Size = new Size(183, 43);
            btnEditPet.TabIndex = 2;
            btnEditPet.Text = "Modificar";
            btnEditPet.UseVisualStyleBackColor = true;
            btnEditPet.Click += btnEditPet_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(1080, 555);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 43);
            btnExit.TabIndex = 4;
            btnExit.Text = "VOLVER";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbIdPet
            // 
            tbIdPet.Location = new Point(318, 590);
            tbIdPet.Name = "tbIdPet";
            tbIdPet.Size = new Size(207, 27);
            tbIdPet.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(315, 567);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 8;
            label3.Text = "Ingresa ID de mascota";
            // 
            // FormPetWanted
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
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
            FormBorderStyle = FormBorderStyle.None;
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