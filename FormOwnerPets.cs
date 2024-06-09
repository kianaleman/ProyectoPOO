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

namespace VeterinariaProyecto
{
    public partial class FormOwnerPets : Form
    {
        public FormOwnerPets()
        {

            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validacionesTB())
            {
                Owner objeto = new Owner()
                {
                    Nombres = tbNames.Text,
                    Apellidos = tbLastNames.Text,
                    Telefono = tbNumber.Text,
                    Direccion = tbAddress.Text,
                    NombreMascota = tbNamePet.Text
                };

                bool respuesta = OwnerLogic.Instancia.SaveOwner(objeto);

                if (respuesta)
                {
                    limpiarTextBoxs();
                    mostrar_Owners();
                }
            }
        }

        public bool validacionesTB()
        {
            // Expresiones regulares para validaciones
            var validaciones = new Dictionary<TextBox, (string regex, string mensaje)>
    {
                { tbNames, (@"^[a-zA-Z]+$", "El campo 'Nombres' solo puede contener letras.") },
                { tbLastNames, (@"^[a-zA-Z]+$", "El campo 'Apellidos' solo puede contener letras.") },
                { tbNumber, (@"^[0-9]+$", "El campo 'Telefono' solo puede contener números.") },
                { tbAddress, (@"^[a-zA-Z]+$", "El campo 'Direccion' solo puede contener letras.") },
                { tbNamePet, (@"^[a-zA-Z]+$", "El campo 'Nombre Mascota' solo puede contener letras.") }
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

        public void limpiarTextBoxs()
        {
            tbIdOwner.Clear();
            tbNames.Clear();
            tbLastNames.Clear();
            tbNumber.Clear();
            tbAddress.Clear();
            tbNamePet.Clear();
        }

        public void mostrar_Owners()
        {
            dgvOwners.DataSource = null;
            dgvOwners.DataSource = OwnerLogic.Instancia.Listar();
        }
        private void FormOwnerPets_Load(object sender, EventArgs e)
        {
            mostrar_Owners();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Owner objeto = new Owner()
            {
                id = int.Parse(tbIdOwner.Text),
                Nombres = tbNames.Text,
                Apellidos = tbLastNames.Text,
                Telefono = tbNumber.Text,
                Direccion = tbAddress.Text,
                NombreMascota = tbNamePet.Text
            };

            bool respuesta = OwnerLogic.Instancia.EditOwner(objeto);

            if (respuesta)
            {
                limpiarTextBoxs();
                mostrar_Owners();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Owner objeto = new Owner()
            {
                id = int.Parse(tbIdOwner.Text)
            };

            bool respuesta = OwnerLogic.Instancia.DeleteOwner(objeto);

            if (respuesta)
            {
                limpiarTextBoxs();
                mostrar_Owners();
            }

        }
    }
}
