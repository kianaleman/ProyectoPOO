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
            ((System.ComponentModel.ISupportInitialize)dgvPets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ownerLogicBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvPets
            // 
            dgvPets.AllowUserToAddRows = false;
            dgvPets.AllowUserToDeleteRows = false;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.Location = new Point(12, 189);
            dgvPets.Name = "dgvPets";
            dgvPets.ReadOnly = true;
            dgvPets.RowHeadersWidth = 51;
            dgvPets.Size = new Size(1232, 483);
            dgvPets.TabIndex = 0;
            // 
            // ownerLogicBindingSource
            // 
            ownerLogicBindingSource.DataSource = typeof(Logic.OwnerLogic);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 38);
            label1.TabIndex = 1;
            label1.Text = "DATOS DE MASCOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
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
            btnSearchOwner.Image = Properties.Resources.panda_png;
            btnSearchOwner.Location = new Point(491, 79);
            btnSearchOwner.Name = "btnSearchOwner";
            btnSearchOwner.Size = new Size(28, 29);
            btnSearchOwner.TabIndex = 29;
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
            btnCancel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(1061, 105);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 64);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Volver";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormsViewPets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1256, 684);
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
    }
}