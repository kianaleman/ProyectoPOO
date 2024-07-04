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
    public partial class FormEditPet : Form
    {
        private Pet currentPet;
        public FormEditPet(int idPet, String identificacionOwner)
        {
            InitializeComponent();

            currentPet = PetLogic.Instancia.ObtenerPetPorId(idPet);
            if (currentPet != null)
            {
                tbIdentificacionOwner.Text = identificacionOwner;
                tbNamePet.Text = currentPet?.nombre;
                tbSpecies.Text = currentPet?.especie;
                tbRace.Text = currentPet?.raza;
                tbAge.Text = currentPet?.edad.ToString();
                tbWeight.Text = currentPet?.peso.ToString();
                tbGender.Text = currentPet?.genero;
                tbDateBirth.Text = currentPet?.fechaNacimiento;
                tbColor.Text = currentPet?.color;
                tbSterilized.Text = currentPet?.esterilizado;
                tbRegistrationDate.Text = currentPet?.fechaRegistro.ToString();
                tbNotes.Text = currentPet?.notas;
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
                Pet objeto = new Pet()
                {
                    id = currentPet.id,
                    nombre = tbNamePet.Text,
                    especie = tbSpecies.Text,
                    raza = tbRace.Text,
                    edad = int.Parse(tbAge.Text),
                    peso = float.Parse(tbWeight.Text),
                    genero = tbGender.Text,
                    fechaNacimiento = tbDateBirth.Text,
                    color = tbColor.Text,
                    esterilizado = tbSterilized.Text,
                    fechaRegistro = currentPet.fechaRegistro,
                    notas = tbNotes.Text
                };

                bool respuesta = PetLogic.Instancia.EditPet(objeto);
                if (respuesta)
                {
                    MessageBox.Show("Mascota Editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControlUtils.LimpiarTextBoxs(this);
                }
                else
                {
                    MessageBox.Show("Error al Editar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            this.Close();
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
                { tbWeight, ( @"^[0-9]*\.?[0-9]+$", "El campo 'Peso' solo puede contener numeros.") },
                { tbGender, (@"^[a-zA-Z\s]+$", "El campo 'Genero' solo puede contener letras.") },
                { tbColor, (@"^[a-zA-Z\s]+$", "El campo 'Color' solo puede contener letras.") },
                { tbSterilized, (@"^[a-zA-Z\s]+$", "El campo 'Esterilizado' solo puede contener letras.") },
                { tbNotes, (@"^[a-zA-Z0-9\s-]+$", "El campo 'Notas' solo puede contener letras y numeros") }
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

            // Validación adicional de fecha de nacimiento y edad
            DateTime fechaNacimiento;
            if (DateTime.TryParseExact(tbDateBirth.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
            {
                int edad;
                if (int.TryParse(tbAge.Text, out edad))
                {
                    var fechaActual = DateTime.Now;
                    var edadCalculada = fechaActual.Year - fechaNacimiento.Year;

                    // Ajustar si la fecha de nacimiento aun no ha ocurrido en el año actual
                    if (fechaNacimiento > fechaActual.AddYears(-edadCalculada))
                    {
                        edadCalculada--;
                    }

                    if (edad != edadCalculada)
                    {
                        MessageBox.Show("La edad ingresada no coincide con la fecha de nacimiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbAge.Clear();
                        tbDateBirth.Clear();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El campo 'Edad' solo puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbAge.Clear();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo 'Fecha Nacimiento' debe estar en el formato DD/MM/YYYY.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDateBirth.Clear();
                return false;
            }

            return true;
        }

        private void FormRegisterPet_Load(object sender, EventArgs e)
        {
            tbRegistrationDate.Enabled = false;
            tbIdentificacionOwner.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
