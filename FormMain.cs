using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaProyecto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOwnerPet_Click(object sender, EventArgs e)
        {
            FormOwnerPets OpenFormOwnerPets = new FormOwnerPets();
            OpenFormOwnerPets.ShowDialog();
        }
    }
}
