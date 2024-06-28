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

namespace VeterinariaProyecto
{
    public partial class FormRegisterPet : Form
    {
        private ErrorProvider errorProvider;
        private System.Windows.Forms.Timer searchTimer;
        public FormRegisterPet()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            // Inicializar Timer
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 500; // Intervalo de 500 ms (medio segundo)
            searchTimer.Tick += new EventHandler(SearchTimer_Tick);
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            //detener el temporizador
            searchTimer.Stop();

            // Verificar si el TextBox no está vacío
            if (ControlUtils.IsTextBoxNotEmpty(tbIdentificacionOwner))
            {
                // Realizar la búsqueda en la base de datos
                int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdentificacionOwner.Text);

                // Evaluar la respuesta y configurar el ErrorProvider
                if (respuesta != -1)
                {
                    errorProvider.SetError(tbIdentificacionOwner, "El dueño con la identeificación proporcionada ya existe.");
                    errorProvider.Icon = Properties.Resources.checkIcon;
                    ControlUtils.HabilitarDeshabilitarControles(this, true);
                }
                else
                {
                    errorProvider.SetError(tbIdentificacionOwner, "El dueño con la identificación proporcionada no existe.");
                    errorProvider.Icon = SystemIcons.Error; // Icono de error por defecto
                    ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdentificacionOwner, btnCancel);
                }
            }
            else
            {
                // Configurar el ErrorProvider para campo vacío
                errorProvider.SetError(tbIdentificacionOwner, "Por favor, ingrese una identificación.");
                errorProvider.Icon = SystemIcons.Error;
                ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdentificacionOwner, btnCancel);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ControlUtils.TextBoxsNoVacios(this))
            {
                return;
            }

            if (validacionesTB())
            {
                string identificacion = tbIdentificacionOwner.Text;
                int id_Owner = OwnerLogic.Instancia.SearchOwner(identificacion);

                if (id_Owner == -1)
                {
                    MessageBox.Show("No se encontró ningún propietario con la identificación proporcionada.", "Propietario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pet objeto = new Pet()
                {
                    nombre = tbNamePet.Text,
                    especie = tbSpecies.Text,
                    raza = tbRace.Text,
                    edad = int.Parse(tbAge.Text),
                    peso = float.Parse(tbWeight.Text),
                    genero = tbGender.Text,
                    fechaNacimiento = tbDateBirth.Text,
                    color = tbColor.Text,
                    esterilizado = tbSterilized.Text,
                    fechaRegistro = DateTime.Now,
                    idOwner = id_Owner,
                    notas = tbNotes.Text
                };

                bool respuesta = PetLogic.Instancia.savePet(objeto);
                if (respuesta)
                {
                    MessageBox.Show("Mascota guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControlUtils.LimpiarTextBoxs(this);
                }
                else
                {
                    MessageBox.Show("Error al guardar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public bool validacionesTB()
        {
            // Expresiones regulares para validaciones
            // Hacer una tupla para las validaciones
            var validaciones = new Dictionary<TextBox, (string regex, string mensaje)>
            {
                { tbNamePet, (@"^[a-zA-Z\s]+$", "El campo 'Nombre' solo puede contener letras.") },
                { tbSpecies, (@"^[a-zA-Z\s]+$", "El campo 'Especie' solo puede contener letras.") },
                { tbRace, (@"^[a-zA-Z\s]+$", "El campo 'Raza' solo puede contener letras.") },
                { tbAge, (@"^[0-9]+$", "El campo 'Edad' solo puede contener números.") },
                { tbWeight, ( @"^[0-9]*\.?[0-9]+$", "El campo 'Peso' solo puede contener numeros.") },
                { tbGender, (@"^[a-zA-Z\s]+$", "El campo 'Genero' solo puede contener letras.") },
                { tbDateBirth, (@"^\d{2}/\d{2}/\d{4}$", "El campo 'Fecha Nacimiento' debe estar en el formato xx/xx/xxxx.") },
                { tbColor, (@"^[a-zA-Z\s]+$", "El campo 'Color' solo puede contener letras.") },
                { tbSterilized, (@"^[a-zA-Z\s]+$", "El campo 'Esterilizado' solo puede contener letras.") },
                { tbNotes, (@"^[a-zA-Z\s]+$", "El campo 'Notas' solo puede contener letras.") }
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

            return true;
        }

        private void tbRegistrationDate_TextChanged(object sender, EventArgs e)
        {
            tbRegistrationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FormRegisterPet_Load(object sender, EventArgs e)
        {
            tbRegistrationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tbIdentificacionOwner_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }
    }
}
