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
    public partial class FormEditOwner : Form
    {
        int idOwner;
        private Owner currentOwner;
        public FormEditOwner(int idOwner)
        {
            InitializeComponent();
            this.idOwner = idOwner;

            // Obtener y mostrar los datos actuales del propietario
            currentOwner = OwnerLogic.Instancia.ObtenerOwnerPorId(idOwner); 

            if (currentOwner != null)
            {
                tbIdentificacion.Text = currentOwner?.Identificacion;
                tbName.Text = currentOwner?.Nombres;
                tbLastNames.Text = currentOwner?.Apellidos;
                tbNumber.Text = currentOwner?.Telefono;
                tbAddress.Text = currentOwner?.Direccion;
            }
        }


        protected void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ControlUtils.TextBoxsNoVacios(this))
            {
                return;
            }

            if (validacionesTB())
            {   // Crear un nuevo objeto Owner y asignar los valores de los TextBox
                Owner ownerToUpdate = new Owner
                {
                    id = idOwner, // Asume que el id ya se recibe como parámetro en el form
                    Identificacion = tbIdentificacion.Text,
                    Nombres = tbName.Text,
                    Apellidos = tbLastNames.Text,
                    Telefono = tbNumber.Text,
                    Direccion = tbAddress.Text
                };

                // Llamar a la función EditOwner para actualizar los datos en la base de datos
                bool result = OwnerLogic.Instancia.EditOwner(ownerToUpdate);

                // Verificar el resultado y mostrar un mensaje adecuado
                if (result)
                {
                    MessageBox.Show("Los datos del dueño han sido actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar los datos del dueño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public bool validacionesTB()
        {
            // Expresiones regulares para validaciones
            // Hacer una tupla para las validaciones
            var validaciones = new Dictionary<TextBox, (string regex, string mensaje)>
            {
                { tbName, (@"^[a-zA-Z\s]+$", "El campo 'Nombres' solo puede contener letras.") },
                { tbLastNames, (@"^[a-zA-Z\s]+$", "El campo 'Apellidos' solo puede contener letras.") },
                { tbNumber, (@"^[0-9]+$", "El campo 'Telefono' solo puede contener números.") }
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditOwner_Load_1(object sender, EventArgs e)
        {
            tbIdentificacion.Enabled = false;
        }
    }
}

