using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaProyecto.Logic;
using VeterinariaProyecto.Modelo;
using VeterinariaProyecto.Utilities;
using VeterinariaProyecto.VariablesGlobales;

namespace VeterinariaProyecto.Forms_Settings
{
    public partial class FormChangeUser : Form
    {
        public FormChangeUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormChangeUser_Load(object sender, EventArgs e)
        {
            tbCurrentUser.Text = DatosLogin.user;
            tbCurrentUser.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlUtils.TextBoxsNoVacios(this))
            {
                return;
            }
            ActualizarUsuario();
            MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public void ActualizarUsuario()
        {
            Usuario newUsuario = new Usuario();
            newUsuario.id = DatosLogin.ID;
            newUsuario.usuario = tbNewUser.Text;
            UsuarioLogic.Instancia.EditUsuario(newUsuario);
            DatosLogin.user = newUsuario.usuario;
        }
    }
}
