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
using VeterinariaProyecto.Utilities;

namespace VeterinariaProyecto
{
    public partial class FormsViewPets : Form
    {
        public FormsViewPets()
        {
            InitializeComponent();
        }

        public void mostrar_Owners()
        {
            dgvOwners.DataSource = null;
            dgvOwners.DataSource = OwnerLogic.Instancia.ListarOwners();


            dgvOwners.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvOwners.Columns.Clear();


            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("Nombres", "Nombres"),
                ("Apellidos", "Apellidos"),
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

                dgvOwners.Columns.Add(column);
            }
        }
        public void mostrar_Pets()
        {
            dgvPets.DataSource = null;
            dgvPets.DataSource = PetLogic.Instancia.ListarPets();

            
            dgvPets.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvPets.Columns.Clear();
            

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
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
                /*if (DataPropertyName == "notas")
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }*/

                dgvPets.Columns.Add(column);
            }
        }


        private void FormsViewPets_Load(object sender, EventArgs e)
        {
            mostrar_Pets();
            mostrar_Owners();
        }

        private void btnSearchOwner_Click(object sender, EventArgs e)
        {
            if (ControlUtils.IsTextBoxNotEmpty(tbIdentificacion))
            {
                int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdentificacion.Text);
                if (respuesta != -1)
                {
                    FormPetWanted OpenFormPetWanted = new FormPetWanted(respuesta);
                    OpenFormPetWanted.ShowDialog();
                    mostrar_Pets();
                    mostrar_Owners();
                    tbIdentificacion.Clear();
                }
                else
                {
                    MessageBox.Show("El dueño con la identificación proporcionada no existe, tampoco existen mascotas.", "Búsqueda fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una identificación.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }


}
