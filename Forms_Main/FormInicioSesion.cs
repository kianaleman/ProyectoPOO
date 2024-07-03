namespace VeterinariaProyecto
{
    public partial class FormInicioSesion : Form
    {
        public string user = "admon";
        public string password = "1234";

        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //el metodo .Trim() se utiliza para eliminar espacios atras y adelante de lo ingresado
            //por el usuario
            if (tbUser.Text != user || tbPassword.Text != password)
            {
                //evaluar en que se equivoco para luego mostrar el mensaje de error
                if (tbUser.Text != user)
                {
                    //MessageBox.Show para mostrar el mensaje de error
                    //tbUser.Clear() para limpiar la caja de texto
                    //tbUser.Focus() para ubicar el cursor en la caja de texto
                    //return para que no realice nada mas
                    MessageBox.Show("Usuario Incorrecto");
                    tbUser.Clear();
                    tbUser.Focus();
                    return;
                }

                if (tbPassword.Text != password)
                {
                    //MessageBox.Show para mostrar el mensaje de error
                    //tbPassword.Clear() para limpiar la caja de texto
                    //tbPassword.Focus() para ubicar el cursor en la caja de texto
                    //return para que no realice nada mas
                    MessageBox.Show("Contraseña Incorrecta");
                    tbPassword.Clear();
                    tbPassword.Focus();
                    return;
                }

            }
            else
            {
                tbUser.Clear();
                tbPassword.Clear();
                FormMain Form = new FormMain();
                Form.ShowDialog();
            }

        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
