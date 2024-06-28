using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
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
    public partial class FormPetWanted : Form
    {
        private int ownerID;
        public FormPetWanted(int ownerID)
        {
            InitializeComponent();
            this.ownerID = ownerID;
        }

        private void FormPetWanted_Load(object sender, EventArgs e)
        {
            mostrar_Owner();
            mostrar_Pets();
        }

        public void mostrar_Owner()
        {
            dgvOwnerData.DataSource = null;
            dgvOwnerData.DataSource = OwnerLogic.Instancia.ListarOwners(ownerID);

            dgvOwnerData.AutoGenerateColumns = false;
            dgvOwnerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOwnerData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Ajusta automáticamente la altura de las filas
            dgvOwnerData.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvOwnerData.Columns.Clear();
            dgvOwnerData.AllowUserToResizeRows = false; // Deshabilita el ajuste manual del tamaño de las filas
            dgvOwnerData.AllowUserToResizeColumns = false; // Deshabilita el ajuste manual del tamaño de las columnas

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("id", "ID"),
                ("Nombres", "Nombres"),
                ("Apellidos", "Appellidos"),
                ("Telefono", "Telefono"),
                ("Direccion", "Direccion"),
                ("Identificacion", "Identificacion")
            };

            // Añade las columnas utilizando un bucle
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };
                dgvOwnerData.Columns.Add(column);
            }

        }

        public void mostrar_Pets()
        {
            dgvPetsData.DataSource = null;
            dgvPetsData.DataSource = PetLogic.Instancia.ListarPets(ownerID);

            dgvPetsData.AutoGenerateColumns = false;
            dgvPetsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPetsData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Ajusta automáticamente la altura de las filas
            dgvPetsData.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvPetsData.Columns.Clear();
            dgvPetsData.AllowUserToResizeRows = false; // Deshabilita el ajuste manual del tamaño de las filas
            dgvPetsData.AllowUserToResizeColumns = false; // Deshabilita el ajuste manual del tamaño de las columnas

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("id", "ID"),
                ("nombre", "Nombre"),
                ("especie", "Especie"),
                ("raza", "Raza"),
                ("edad", "Edad"),
                ("peso", "Peso(kg)"),
                ("genero", "Genero"),
                ("fechaNacimiento", "Fecha Nacimiento"),
                ("color", "Color"),
                ("esterilizado", "Esterilizado"),
                ("fechaRegistro", "Fecha de Registro"),
                ("idOwner", "ID Dueño"),
                ("notas", "Notas")
            };

            // Añade las columnas utilizando un bucle
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };

                // Si es la columna de "Notas", habilita el ajuste de texto
                if (DataPropertyName == "notas")
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                dgvPetsData.Columns.Add(column);
            }

        }

        private void btnEditOwner_Click(object sender, EventArgs e)
        {
            FormEditOwner formEditOwner = new FormEditOwner(ownerID);
            formEditOwner.ShowDialog();
            mostrar_Owner();
            mostrar_Pets();
        }


        
        /*private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este dueño y todas sus mascotas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Obtener el objeto Owner actual
                    Owner currentOwner = OwnerLogic.Instancia.ObtenerOwnerPorId(ownerID);

                    if (currentOwner != null)
                    {
                        bool deleteSuccess = false;

                        // Eliminar todas las mascotas asociadas al dueño si existen
                        List<Pet> petsToDelete = PetLogic.Instancia.ListarPets(currentOwner.id);

                        foreach (Pet pet in petsToDelete)
                        {
                            bool petDeleted = PetLogic.Instancia.DeletePet(pet);
                            if (!petDeleted)
                            {
                                MessageBox.Show($"Error al eliminar la mascota {pet.id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Salir del método si falla la eliminación de una mascota
                            }
                        }

                        // Eliminar el dueño después de eliminar todas las mascotas
                        deleteSuccess = OwnerLogic.Instancia.DeleteOwner(currentOwner);

                        if (deleteSuccess)
                        {
                            MessageBox.Show("El dueño y todas sus mascotas han sido eliminados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Cerrar el formulario después de eliminar correctamente
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al eliminar el dueño.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el dueño actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/

        /*private void btnDeletePet_Click(object sender, EventArgs e)
        {
            // Validar si el campo ID está vacío
            if (string.IsNullOrWhiteSpace(tbIdPet.Text))
            {
                MessageBox.Show("El campo 'ID' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar confirmación al usuario antes de eliminar
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta mascota?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Crear objeto Pet con el ID proporcionado
                    Pet petToDelete = new Pet
                    {
                        id = int.Parse(tbIdPet.Text)
                    };

                    // Intentar eliminar la mascota
                    bool deleteSuccess = PetLogic.Instancia.DeletePet(petToDelete);

                    if (deleteSuccess)
                    {
                        MessageBox.Show("La mascota ha sido eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrar_Pets();
                        // Limpiar los TextBox después de eliminar correctamente
                        ControlUtils.LimpiarTextBoxs(this);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/

    }
}
