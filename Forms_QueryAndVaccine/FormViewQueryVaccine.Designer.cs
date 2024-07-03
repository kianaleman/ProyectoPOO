namespace VeterinariaProyecto
{
    partial class FormViewQueryVaccine
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
            btnExit = new Button();
            label1 = new Label();
            dgvQuery = new DataGridView();
            dgvVaccine = new DataGridView();
            tbIdOwner = new TextBox();
            cmbPets = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            btnSearchQuery = new Button();
            btnVerTodo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(985, 418);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 96);
            btnExit.TabIndex = 0;
            btnExit.Text = "Volver";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 38);
            label1.TabIndex = 1;
            label1.Text = "CONSULTAS Y VACUNAS";
            // 
            // dgvQuery
            // 
            dgvQuery.AllowUserToAddRows = false;
            dgvQuery.AllowUserToDeleteRows = false;
            dgvQuery.AllowUserToResizeColumns = false;
            dgvQuery.AllowUserToResizeRows = false;
            dgvQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuery.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQuery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuery.Location = new Point(18, 147);
            dgvQuery.Name = "dgvQuery";
            dgvQuery.ReadOnly = true;
            dgvQuery.RowHeadersVisible = false;
            dgvQuery.RowHeadersWidth = 51;
            dgvQuery.Size = new Size(678, 367);
            dgvQuery.TabIndex = 4;
            // 
            // dgvVaccine
            // 
            dgvVaccine.AllowUserToAddRows = false;
            dgvVaccine.AllowUserToDeleteRows = false;
            dgvVaccine.AllowUserToResizeColumns = false;
            dgvVaccine.AllowUserToResizeRows = false;
            dgvVaccine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaccine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVaccine.Location = new Point(730, 147);
            dgvVaccine.Name = "dgvVaccine";
            dgvVaccine.ReadOnly = true;
            dgvVaccine.RowHeadersVisible = false;
            dgvVaccine.RowHeadersWidth = 51;
            dgvVaccine.Size = new Size(249, 367);
            dgvVaccine.TabIndex = 5;
            // 
            // tbIdOwner
            // 
            tbIdOwner.Location = new Point(18, 80);
            tbIdOwner.Name = "tbIdOwner";
            tbIdOwner.PlaceholderText = "Ingresar ID Dueño";
            tbIdOwner.Size = new Size(153, 27);
            tbIdOwner.TabIndex = 6;
            tbIdOwner.TextChanged += tbIdOwner_TextChanged;
            // 
            // cmbPets
            // 
            cmbPets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPets.Enabled = false;
            cmbPets.FormattingEnabled = true;
            cmbPets.Location = new Point(189, 79);
            cmbPets.Name = "cmbPets";
            cmbPets.Size = new Size(151, 28);
            cmbPets.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSearchQuery
            // 
            btnSearchQuery.Location = new Point(361, 76);
            btnSearchQuery.Name = "btnSearchQuery";
            btnSearchQuery.Size = new Size(127, 31);
            btnSearchQuery.TabIndex = 8;
            btnSearchQuery.Text = "Buscar Datos";
            btnSearchQuery.UseVisualStyleBackColor = true;
            btnSearchQuery.Click += btnSearchQuery_Click;
            // 
            // btnVerTodo
            // 
            btnVerTodo.Location = new Point(494, 76);
            btnVerTodo.Name = "btnVerTodo";
            btnVerTodo.Size = new Size(127, 31);
            btnVerTodo.TabIndex = 9;
            btnVerTodo.Text = "Ver Todo";
            btnVerTodo.UseVisualStyleBackColor = true;
            btnVerTodo.Click += btnVerTodo_Click;
            // 
            // FormViewQueryVaccine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1151, 556);
            Controls.Add(btnVerTodo);
            Controls.Add(btnSearchQuery);
            Controls.Add(cmbPets);
            Controls.Add(tbIdOwner);
            Controls.Add(dgvVaccine);
            Controls.Add(dgvQuery);
            Controls.Add(label1);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormViewQueryVaccine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += FormViewQueryVaccine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuery).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVaccine).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label label1;
        private DataGridView dgvQuery;
        private DataGridView dgvVaccine;
        private TextBox tbIdOwner;
        private ComboBox cmbPets;
        private ErrorProvider errorProvider1;
        private Button btnSearchQuery;
        private Button btnVerTodo;
    }
}