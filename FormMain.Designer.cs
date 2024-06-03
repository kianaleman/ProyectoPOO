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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
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
            // button1
            // 
            button1.Location = new Point(35, 165);
            button1.Name = "button1";
            button1.Size = new Size(137, 67);
            button1.TabIndex = 3;
            button1.Text = "Dueños de Mascotas";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(216, 261);
            button2.Name = "button2";
            button2.Size = new Size(137, 67);
            button2.TabIndex = 4;
            button2.Text = "Editar Mascotas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(216, 165);
            button3.Name = "button3";
            button3.Size = new Size(137, 67);
            button3.TabIndex = 5;
            button3.Text = "Agregar Consulta";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(35, 261);
            button4.Name = "button4";
            button4.Size = new Size(137, 67);
            button4.TabIndex = 6;
            button4.Text = "Añadir Mascota";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(35, 350);
            button5.Name = "button5";
            button5.Size = new Size(137, 67);
            button5.TabIndex = 7;
            button5.Text = "Ajustes";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(216, 350);
            button6.Name = "button6";
            button6.Size = new Size(137, 67);
            button6.TabIndex = 8;
            button6.Text = "Salir";
            button6.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}