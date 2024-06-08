namespace VeterinariaProyecto
{
    partial class FormOwnerPets
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNames = new TextBox();
            tbAddress = new TextBox();
            tbNumber = new TextBox();
            tbLastNames = new TextBox();
            tbIdOwner = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgvOwners = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOwners).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellidos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 15);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 64);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Id Persona";
            // 
            // tbNames
            // 
            tbNames.Location = new Point(95, 64);
            tbNames.Name = "tbNames";
            tbNames.Size = new Size(244, 27);
            tbNames.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(548, 64);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(240, 27);
            tbAddress.TabIndex = 6;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(537, 15);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(251, 27);
            tbNumber.TabIndex = 7;
            // 
            // tbLastNames
            // 
            tbLastNames.Location = new Point(97, 118);
            tbLastNames.Name = "tbLastNames";
            tbLastNames.Size = new Size(242, 27);
            tbLastNames.TabIndex = 8;
            // 
            // tbIdOwner
            // 
            tbIdOwner.Location = new Point(95, 12);
            tbIdOwner.Name = "tbIdOwner";
            tbIdOwner.Size = new Size(125, 27);
            tbIdOwner.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(401, 118);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(630, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(515, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgvOwners
            // 
            dgvOwners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwners.Location = new Point(12, 179);
            dgvOwners.Name = "dgvOwners";
            dgvOwners.RowHeadersWidth = 51;
            dgvOwners.Size = new Size(776, 259);
            dgvOwners.TabIndex = 13;
            // 
            // FormOwnerPets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOwners);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(tbIdOwner);
            Controls.Add(tbLastNames);
            Controls.Add(tbNumber);
            Controls.Add(tbAddress);
            Controls.Add(tbNames);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormOwnerPets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OwnerPets";
            ((System.ComponentModel.ISupportInitialize)dgvOwners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNames;
        private TextBox tbAddress;
        private TextBox tbNumber;
        private TextBox tbLastNames;
        private TextBox tbIdOwner;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgvOwners;
    }
}