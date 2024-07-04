namespace VeterinariaProyecto
{
    partial class FormsViewPets
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
            dgvPets = new DataGridView();
            ownerLogicBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            tbIdentificacion = new TextBox();
            btnSearchOwner = new Button();
            linkLabel1 = new LinkLabel();
            btnCancel = new Button();
            dgvOwners = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ownerLogicBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOwners).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.AllowUserToDeleteRows = false;
            dgvPets.AllowUserToResizeColumns = false;
            dgvPets.AllowUserToResizeRows = false;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPets.BackgroundColor = Color.FromArgb(39, 57, 90);
            dgvPets.BorderStyle = BorderStyle.None;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.GridColor = SystemColors.InactiveCaptionText;
            dgvPets.Location = new Point(12, 171);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersVisible = false;
            dgvPets.RowHeadersWidth = 51;
            dgvPets.Size = new Size(1232, 198);
            dgvPets.TabIndex = 0;
            // 
            // ownerLogicBindingSource
            // 
            ownerLogicBindingSource.DataSource = typeof(Logic.OwnerLogic);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(491, 9);
            label1.Name = "label1";
            label1.Size = new Size(313, 34);
            label1.TabIndex = 1;
            label1.Text = "DATOS DE MASCOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 2;
            label2.Text = "Buscar Mascota:";
            // 
            // tbIdentificacion
            // 
            tbIdentificacion.Location = new Point(174, 83);
            tbIdentificacion.Name = "tbIdentificacion";
            tbIdentificacion.PlaceholderText = "INGRESE LA IDENTIFICACION DEL DUEÑO";
            tbIdentificacion.Size = new Size(288, 27);
            tbIdentificacion.TabIndex = 3;
            // 
            // btnSearchOwner
            // 
            btnSearchOwner.FlatStyle = FlatStyle.Flat;
            btnSearchOwner.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnSearchOwner.ForeColor = SystemColors.ButtonFace;
            btnSearchOwner.Location = new Point(472, 76);
            btnSearchOwner.Name = "btnSearchOwner";
            btnSearchOwner.Size = new Size(88, 43);
            btnSearchOwner.TabIndex = 29;
            btnSearchOwner.Text = "Buscar";
            btnSearchOwner.UseVisualStyleBackColor = true;
            btnSearchOwner.Click += btnSearchOwner_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(233, 127);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(1113, 83);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 43);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Volver";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvOwners
            // 
            dgvOwners.AllowUserToAddRows = false;
            dgvOwners.AllowUserToDeleteRows = false;
            dgvOwners.AllowUserToResizeColumns = false;
            dgvOwners.AllowUserToResizeRows = false;
            dgvOwners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOwners.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOwners.BackgroundColor = Color.FromArgb(39, 57, 90);
            dgvOwners.BorderStyle = BorderStyle.None;
            dgvOwners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwners.GridColor = SystemColors.InactiveCaptionText;
            dgvOwners.Location = new Point(12, 474);
            dgvOwners.Name = "dgvOwners";
            dgvOwners.ReadOnly = true;
            dgvOwners.RowHeadersVisible = false;
            dgvOwners.RowHeadersWidth = 51;
            dgvOwners.Size = new Size(1232, 198);
            dgvOwners.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(516, 418);
            label3.Name = "label3";
            label3.Size = new Size(271, 34);
            label3.TabIndex = 34;
            label3.Text = "DATOS DE DUEÑOS";
            // 
            // FormsViewPets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 57, 90);
            ClientSize = new Size(1256, 684);
            Controls.Add(label3);
            Controls.Add(dgvOwners);
            Controls.Add(btnCancel);
            Controls.Add(linkLabel1);
            Controls.Add(btnSearchOwner);
            Controls.Add(tbIdentificacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPets);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormsViewPets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormsViewPets";
            Load += FormsViewPets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPets).EndInit();
            ((System.ComponentModel.ISupportInitialize)ownerLogicBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOwners).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPets;
        private BindingSource ownerLogicBindingSource;
        private Label label1;
        private Label label2;
        private TextBox tbIdentificacion;
        private Button btnSearchOwner;
        private LinkLabel linkLabel1;
        private Button btnCancel;
        private DataGridView dgvOwners;
        private Label label3;
    }
}