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
    public partial class FormChangePassword : Form
    {
        private bool passwordVisible = false; // Variable para controlar el estado de visibilidad de contraseñas
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlUtils.TextBoxsNoVacios(this))
            {
                return;
            }
            ActualizarPassword();
            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public void ActualizarPassword()
        {
            Usuario newUsuario = new Usuario();
            newUsuario.id = DatosLogin.ID;
            newUsuario.password = tbNewPassword.Text;
            UsuarioLogic.Instancia.EditPassword(newUsuario);
            DatosLogin.password = newUsuario.password;
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            tbCurrentPassWord.Text = DatosLogin.password;
            tbCurrentPassWord.Enabled = false;
            tbCurrentPassWord.UseSystemPasswordChar = true;
            tbNewPassword.UseSystemPasswordChar = true;
        }

        private void btnVerOcultar_Click(object sender, EventArgs e)
        {
            // Cambiar el estado de visibilidad de contraseñas
            passwordVisible = !passwordVisible;

            // Aplicar el estado a las TextBox
            tbCurrentPassWord.UseSystemPasswordChar = !passwordVisible;
            tbNewPassword.UseSystemPasswordChar = !passwordVisible;
        }
    }
}
