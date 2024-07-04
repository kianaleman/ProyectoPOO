using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaProyecto.Forms_Main;

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

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            FormAddOwner OpenFormAddOwner = new FormAddOwner();
            OpenFormAddOwner.ShowDialog();
        }

        private void btnAddPets_Click(object sender, EventArgs e)
        {
            FormsViewPets OpenFormViewPets = new FormsViewPets();
            OpenFormViewPets.ShowDialog();
        }

        private void btnRegisterPet_Click(object sender, EventArgs e)
        {
            FormRegisterPet OpenFormRegisterPet = new FormRegisterPet();
            OpenFormRegisterPet.ShowDialog();
        }


        private void btnAddQuery_Click(object sender, EventArgs e)
        {
            FormAddQuery OpenFormAddQuery = new FormAddQuery();
            OpenFormAddQuery.ShowDialog();
        }

        private void btnViewQueryVac_Click(object sender, EventArgs e)
        {
            FormViewQueryVaccine OpenFormViewQueryVaccine = new FormViewQueryVaccine();
            OpenFormViewQueryVaccine.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings OpenFormSettings = new FormSettings();
            OpenFormSettings.ShowDialog();
        }
    }
}
