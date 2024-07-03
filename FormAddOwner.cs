using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VeterinariaProyecto.Modelo;
using VeterinariaProyecto.Logic;
using VeterinariaProyecto.Utilities;
using System.Text.RegularExpressions;

namespace VeterinariaProyecto
{
    public partial class FormAddOwner : Form
    {
        private ErrorProvider errorProvider;
        private System.Windows.Forms.Timer searchTimer;


        public FormAddOwner()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            // Inicializar Timer
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 500; // Intervalo de 500 ms (medio segundo)
            searchTimer.Tick += new EventHandler(SearchTimer_Tick);
        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlUtils.TextBoxsNoVacios(this))
            {
                return;
            }

            if (validacionesTB())
            {
                string identificacion = tbIdentificacion.Text;
                int id_Owner = OwnerLogic.Instancia.SearchOwner(identificacion);

                if (id_Owner != -1)
                {
                    MessageBox.Show("El Dueño ya esta ingresado.", "Propietario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Owner objeto = new Owner()
                {
                    Nombres = tbNames.Text,
                    Apellidos = tbLastNames.Text,
                    Telefono = tbNumber.Text,
                    Direccion = tbAddress.Text,
                    Identificacion = tbIdentificacion.Text
                };

                try
                {
                    bool respuesta = OwnerLogic.Instancia.SaveOwner(objeto);

                    if (respuesta)
                    {
                        MessageBox.Show("Guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ControlUtils.LimpiarTextBoxs(this);
                        //mostrar_Owners();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public bool validacionesTB()
        {
            // Expresiones regulares para validaciones
            // Hacer una tupla para las validaciones
            var validaciones = new Dictionary<TextBox, (string regex, string mensaje)>
            {
                { tbNames, (@"^[a-zA-Z\s]+$", "El campo 'Nombres' solo puede contener letras.") },
                { tbLastNames, (@"^[a-zA-Z\s]+$", "El campo 'Apellidos' solo puede contener letras.") },
                { tbNumber, (@"^[278]\d{7}$", "Introduce un numero de telefono valido.") }
            };

            foreach (var validacion in validaciones)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(validacion.Key.Text, validacion.Value.regex))
                {
                    MessageBox.Show(validacion.Value.mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validacion.Key.Clear();
                    return false;
                }
            }

            if (!IsValidNicaraguanCedula(tbIdentificacion.Text))
            {
                MessageBox.Show("Introduce una cédula de identidad válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbIdentificacion.Clear();
                return false;
            }

            return true;
        }

        public bool IsValidNicaraguanCedula(string cedula)
        {
            // Patrón para verificar el formato básico
            string pattern = @"^\d{3}-\d{6}-\d{4}[A-Za-z]$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(cedula))
            {
                return false;
            }

            // Validar la fecha de nacimiento
            string datePart = cedula.Substring(4, 6);
            if (!IsValidDate(datePart))
            {
                return false;
            }

            return true;
        }


        public bool IsValidDate(string datePart)
        {
            // Validar que la fecha esté en el formato DDMMAA
            if (datePart.Length != 6)
            {
                return false;
            }

            int day = int.Parse(datePart.Substring(0, 2));
            int month = int.Parse(datePart.Substring(2, 2));
            int year = int.Parse(datePart.Substring(4, 2)) + 1900;

            // Ajuste para fechas después del 2000
            if (year < 1920)
            {
                year += 100;
            }

            // Verificar que el año esté en el rango de 1920 a 2008
            if (year < 1920 || year > 2008)
            {
                return false;
            }

            // Verificar que la fecha sea válida
            try
            {
                DateTime date = new DateTime(year, month, day);
            }
            catch
            {
                return false;
            }

            return true;
        }

        /*public void mostrar_Owners()
        {
            dgvOwners.DataSource = null;
            dgvOwners.DataSource = OwnerLogic.Instancia.ListarOwners();
        }*/

        private void FormOwnerPets_Load(object sender, EventArgs e)
        {
            //mostrar_Owners();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbIdentificacion_TextChanged(object sender, EventArgs e)
        {
            // Reiniciar el temporizador cada vez que se cambie el texto
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            //detener el temporizador
            searchTimer.Stop();

            // Verificar si el TextBox no está vacío
            if (ControlUtils.IsTextBoxNotEmpty(tbIdentificacion))
            {
                // Realizar la búsqueda en la base de datos
                int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdentificacion.Text);

                // Evaluar la respuesta y configurar el ErrorProvider
                if (respuesta != -1)
                {
                    errorProvider.SetError(tbIdentificacion, "El dueño con la identeificación proporcionada ya existe.");
                    errorProvider.Icon = SystemIcons.Error; // Icono de error por defecto
                    ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdentificacion,btnCancel);
                }
                else
                {
                    errorProvider.SetError(tbIdentificacion, "El dueño con la identificación proporcionada no existe.");
                    errorProvider.Icon = Properties.Resources.checkIcon;
                    ControlUtils.HabilitarDeshabilitarControles(this, true);
                }
            }
            else
            {
                // Configurar el ErrorProvider para campo vacío
                errorProvider.SetError(tbIdentificacion, "Por favor, ingrese una identificación.");
                errorProvider.Icon = SystemIcons.Error;
                ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdentificacion, btnCancel);
            }
        }


        /*private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ControlUtils.TextBoxsNoVacios(this))
            {
                return;
            }

            Owner objeto = new Owner()
            {
                id = int.Parse(tbIdOwner.Text),
                Nombres = tbNames.Text,
                Apellidos = tbLastNames.Text,
                Telefono = tbNumber.Text,
                Direccion = tbAddress.Text,
                Identificacion = tbIdentificacion.Text
            };

            bool respuesta = OwnerLogic.Instancia.EditOwner(objeto);

            if (respuesta)
            {
                ControlUtils.LimpiarTextBoxs(this);
                //mostrar_Owners();
            }
        }*/
    }
}
