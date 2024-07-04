using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaProyecto.Forms_Settings;

namespace VeterinariaProyecto.Forms_Main
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            FormChangeUser OpenFormChangeUser = new FormChangeUser();
            OpenFormChangeUser.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword OpenFormChangePassword = new FormChangePassword();
            OpenFormChangePassword.ShowDialog();
        }
    }
}
