namespace VeterinariaProyecto
{
    public partial class InicioSesion : Form
    {
        string user = "admon";
        string password = "123";

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Deshabilitar el btnIngreso al iniciar el programa, solo se habilitara al cumplir
            //las condiciones de la textBoxs(tbUser,tbPassword)
            btnIngreso.Enabled = false;

        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //el metodo .Trim() se utiliza para eliminar espacios atras y adelante de lo ingresado
            //por el usuario
            if(tbUser.Text.Trim() != user && tbPassword.Text.Trim() != password) 
            {
                //evaluar en que se equivoco para luego mostrar el mensaje de error
                if(tbUser.Text.Trim() != user)
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

                if (tbPassword.Text.Trim() != password)
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
                MessageBox.Show("Ha ingresado exitosamente");
            }

        }
    }
}
