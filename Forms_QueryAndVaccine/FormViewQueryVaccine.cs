using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaProyecto.Logic;
using VeterinariaProyecto.Utilities;

namespace VeterinariaProyecto
{
    public partial class FormViewQueryVaccine : Form
    {
        private bool shouldRestartTimer = true;
        private ErrorProvider errorProvider;
        private System.Windows.Forms.Timer searchTimer; // Timer para realizar la busqueda del Owner luego de 500ms
        public FormViewQueryVaccine()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            searchTimer = new System.Windows.Forms.Timer
            {
                Interval = 500 // Intervalo de 500 ms (medio segundo)
            };
            searchTimer.Tick += new EventHandler(SearchTimer_Tick);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            // Detener el Temporizador
            searchTimer.Stop();

            // Verificar que en la TextBox esten 16 carácteres incluyendo los guiones (cédula)
            if (tbIdOwner.Text.Length == 16)
            {
                // Se realiza la busqueda del dueño, si existe es != 1, de lo contrario no existe
                int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdOwner.Text);
                // En caso que exista se omite el errorProvider, se Habilitan los controles excepto a los que el usuario no debe de acceder
                if (respuesta != -1)
                {
                    errorProvider.SetError(tbIdOwner, "");
                    ControlUtils.HabilitarDeshabilitarControles(this, true);
                    mostrar_Pets();
                }
                else
                {
                    // En el caso en que devuelva -1, no se encontro el dueño
                    MostrarError("Identificacion no Encontrada");
                }
            }
            else
            {
                // En caso que la longitud sea != 16
                MostrarError("Ingrese una identificacion Valida");
            }
        }



        public void mostrar_Pets()
        {
            // Se busca al dueño, el cual devolverá un entero que pertenece a su ID
            int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdOwner.Text);

            // Se obtiene la lista de mascotas pertenecientes al mismo dueño
            var pets = PetLogic.Instancia.ListarPets(respuesta);

            // Se configura el ComboBox
            cmbPets.DataSource = null; // Limpia el ComboBox
            cmbPets.DisplayMember = "nombre"; // Campo que se mostrará
            cmbPets.DataSource = pets; // Asigna la lista de mascotas como fuente de datos
            cmbPets.SelectedIndex = -1;
        }

        public void mostrarVaccine()
        {
            int respuesta = PetLogic.Instancia.SearchPet(cmbPets.Text);
            dgvVaccine.DataSource = null;
            dgvVaccine.DataSource = VaccineLogic.Instancia.ListarVaccines(respuesta);
            dgvVaccine.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvVaccine.Columns.Clear();

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("tipoVacuna", "Vacuna"),
                ("fecha", "Fecha")
            };

            // Añade las columnas utilizando un bucle
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };
                dgvVaccine.Columns.Add(column);
            }

        }

        public void mostrarQuery()
        {
            int respuesta = PetLogic.Instancia.SearchPet(cmbPets.Text);
            dgvQuery.DataSource = null;
            dgvQuery.DataSource = QueryLogic.Instancia.ListarQuery(respuesta);
            dgvQuery.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvQuery.Columns.Clear();

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("motivo", "Motivo"),
                ("tratamiento", "Tratamiento"),
                ("sintomas", "Sintomas"),
                ("examenFisico", "Examen"),
                ("observaciones", "Observaciones"),
                ("fecha", "Fecha")
            };

            // Añade las columnas utilizando un bucle
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };
                dgvQuery.Columns.Add(column);
            }
        }

        private void tbIdOwner_TextChanged(object sender, EventArgs e)
        {
            //  El proposito de este patron (detener y reiniciar el temporizador) es crear un retraso
            //  controlado antes de ejecutar una accion (como buscar en la base de datos) despues de que el usuario deje de escribir
            if (shouldRestartTimer)
            {
                searchTimer.Stop();
                searchTimer.Start();
            }
        }

        private void MostrarError(string mensaje)
        {
            errorProvider.SetError(tbIdOwner, mensaje);
            errorProvider.Icon = SystemIcons.Error;
            ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdOwner, btnExit, btnVerTodo, dgvVaccine, dgvQuery);
            ControlUtils.LimpiarTextBoxs(this, tbIdOwner);
        }

        private void btnSearchQuery_Click(object sender, EventArgs e)
        {
            mostrarVaccine();
            mostrarQuery();
        }

        private void FormViewQueryVaccine_Load(object sender, EventArgs e)
        {
            mostrarVaccine();
            mostrarQuery();
            btnSearchQuery.Enabled = false;
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            // Desactiva el reinicio del temporizador
            shouldRestartTimer = false;

            // Detiene el temporizador
            searchTimer.Stop();
            errorProvider.SetError(tbIdOwner, "");
            ControlUtils.HabilitarDeshabilitarControles(this, true, cmbPets);
            ControlUtils.LimpiarTextBoxs(this);
            cmbPets.Text = null;
            dgvVaccine.DataSource = null;
            dgvVaccine.DataSource = VaccineLogic.Instancia.ListarVaccinesConNombreMascota();
            dgvVaccine.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvVaccine.Columns.Clear();

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("tipoVacuna", "Vacuna"),
                ("fecha", "Fecha"),
                ("nombreMascota", "Mascota")
            };

            // Añade las columnas utilizando un bucle
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };
                dgvVaccine.Columns.Add(column);
            }

            dgvQuery.DataSource = null;
            dgvQuery.DataSource = QueryLogic.Instancia.ListarQueryConNombreMascota();
            dgvQuery.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permite el ajuste de texto
            dgvQuery.Columns.Clear();

            columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("motivo", "Motivo"),
                ("tratamiento", "Tratamiento"),
                ("sintomas", "Sintomas"),
                ("examenFisico", "Examen"),
                ("observaciones", "Observaciones"),
                ("fecha", "Fecha"),
                ("nombreMascota", "Mascota")
            };

            // Añade las columnas utilizando un bucle
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };
                dgvQuery.Columns.Add(column);
            }

            shouldRestartTimer = true;
        }
    }
}
