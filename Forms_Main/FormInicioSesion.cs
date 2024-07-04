using VeterinariaProyecto.Logic;
using VeterinariaProyecto.Modelo;
using VeterinariaProyecto.VariablesGlobales;

namespace VeterinariaProyecto
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            DatosLogin.ID = UsuarioLogic.Instancia.SearchUser(tbUser.Text);
            if(DatosLogin.ID != -1)
            {
                Usuario currentUser = UsuarioLogic.Instancia.ObtenerUserPorId(DatosLogin.ID);
                if(currentUser != null) 
                {
                    DatosLogin.user = currentUser.usuario;
                    DatosLogin.password = currentUser.password;
                }

                if(tbPassword.Text != DatosLogin.password)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    tbPassword.Clear();
                    tbPassword.Focus();
                    return;
                }
                FormMain Form = new FormMain();
                Form.ShowDialog();
                tbPassword.Clear();
                tbUser.Clear();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
                tbUser.Clear();
                tbUser.Focus();
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
