using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;
using System.Xml.Linq;
using VeterinariaProyecto.Logic;
using VeterinariaProyecto.Modelo;
using VeterinariaProyecto.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeterinariaProyecto
{
    public partial class FormAddQuery : Form
    {
        private Owner currentOwner;  // Cargar los datos del Owner(Nombre, Apellido, Numero, Etc)
        private ErrorProvider errorProvider; // errorProvider utilizado al momento de realizar la busqueda de las mascotas mediante el dueño
        private System.Windows.Forms.Timer searchTimer; // Timer para realizar la busqueda del Owner luego de 500ms

        public FormAddQuery()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

            // Inicializar Timer
            searchTimer = new System.Windows.Forms.Timer
            {
                Interval = 500 // Intervalo de 500 ms (medio segundo)
            };
            searchTimer.Tick += new EventHandler(SearchTimer_Tick);
        }

        private void FormAddQuery_Load(object sender, EventArgs e)
        {
            // Bloquear los TextBoxs a los cuales el usuario no podrá acceder
            ControlUtils.BloquearTextBoxs(tbIdPet, tbCedOwner, tbNameOwner, tbLastNameOwner, tbNumberOwner);
            // Cargar una base del DataGridView para que no se vea vacío
            mostrar_Pets();
            // Darle el valor al TextBox de la fecha el cual tendrá la fecha del día en que se realice la consulta
            tbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
                    ControlUtils.HabilitarDeshabilitarControles(this, true, tbIdPet, tbDate, tbCedOwner, tbNameOwner, tbLastNameOwner, tbNumberOwner);
                    // cargarOwner() carga automaticante los datos del dueño en caso que exista
                    cargarOwner();
                    // Si el rBtnNo esta seleccionado (true), la tbTypeVaccine estara desactivada (false), con el operador ! se invierte el booleano
                    tbTypeVaccine.Enabled = !rBtnNo.Checked;
                }
                else
                {
                    // En el caso en que devuelva -1, no se encotro el dueño
                    MostrarError("Identificacion no Encontrada");
                }
            }
            else
            {
                // En caso que la longitud sea != 16
                MostrarError("Ingrese una identificacion Valida");
            }
        }

        // Función Utilizada en la función anterior, valga la redundancia
        private void MostrarError(string mensaje)
        {
            errorProvider.SetError(tbIdOwner, mensaje);
            errorProvider.Icon = SystemIcons.Error;
            ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdOwner, btnExit);
            // No se borraran los detalles de la consulta en caso que ocurra una equivocación en la escritura de la identificacion
            ControlUtils.LimpiarTextBoxs(this, tbIdOwner, tbDate, tbExamen, tbMotivo, tbObservaciones, tbSintomas, tbTratamiento, tbTypeVaccine);
        }

        private void tbIdOwner_TextChanged(object sender, EventArgs e)
        {
            //  El propósito de este patrón (detener y reiniciar el temporizador) es crear un retraso
            //  controlado antes de ejecutar una acción (como buscar en la base de datos) después de que el usuario deje de escribir.
            searchTimer.Stop();
            searchTimer.Start();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cerrar el Form
            this.Close();
        }

        private void btnSearchPets_Click(object sender, EventArgs e)
        {
            // Al tocar el botón Buscar Mascota, se mostrará las mascotas que estén a nombre del dueño
            mostrar_Pets();
        }

        public void mostrar_Pets()
        {
            // Se busca al dueño, el cual devolvera un entero que pertenece a su ID
            int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdOwner.Text);
            dgvPets.DataSource = null;
            // Aqui se devuelve una lista de las Mascotas pertenecientes al mismo dueño
            dgvPets.DataSource = PetLogic.Instancia.ListarPets(respuesta);

            // Se mejora la legibilidad del DataGridView
            dgvPets.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPets.Columns.Clear();

            // Se crean los headers del DGV, y aqui mismo se seleccionan los unicos datos a mostrar, el id y el nombre de la mascota
            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("id", "ID"),
                ("nombre", "Nombre")
            };

            // Se itera sobre cada tupla en la lista columns
            foreach (var (DataPropertyName, HeaderText) in columns)
            {
                var column = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = DataPropertyName,
                    HeaderText = HeaderText,
                };
                dgvPets.Columns.Add(column);
            }
        }


        // Esta función permite saber si se selecciona algún dato del DGV
        private void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Se obtiene el valor seleccionado
                object cellValue = dgvPets.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Se valida que no sea nulo y que sea entero, en el caso que sea entero se asigna el valor a una TextBox
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int intValue))
                {
                    tbIdPet.Text = intValue.ToString();
                }
                // En el caso contrario no se asigna nada, o se limpia
                else
                {
                    tbIdPet.Text = string.Empty;
                }
            }
        }

        // Esta funcion permite cargar un prototipo de como se vera el DGV al buscar la mascota, con el fin de no dejar un espacio 
        // vacío
        /*public void cargarDGV()
        {
            dgvPets.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "idColumn"
            };

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                Name = "nombreColumn"
            };

            dgvPets.Columns.Add(idColumn);
            dgvPets.Columns.Add(nombreColumn);
        }*/


        // Con esta función se carga el dueño, y se le asigna el valor de los datos a distintas TextBoxs
        public void cargarOwner()
        {
            int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdOwner.Text);
            currentOwner = OwnerLogic.Instancia.ObtenerOwnerPorId(respuesta);

            if (currentOwner != null)
            {
                tbCedOwner.Text = currentOwner.Identificacion;
                tbNameOwner.Text = currentOwner.Nombres;
                tbLastNameOwner.Text = currentOwner.Apellidos;
                tbNumberOwner.Text = currentOwner.Telefono;
            }
        }

        // Función Guardar
        private void btnSaveQuery_Click(object sender, EventArgs e)
        {
            // Se verifica que el radioBtn "NO" este seleccionado(true)
            // En el caso que este seleccionado únicamente se guardaran los datos de la consulta y no los de la vacuna
            // sin importar que haya algún dato en la textbox de Vacuna
            if (rBtnNo.Checked)
            {
                // Se verifica que los TextBoxs no esten vacios, exceptuando el de vacuna, ya que ese no se guardara
                if (!ControlUtils.TextBoxsNoVacios(this, tbTypeVaccine))
                {
                    return;
                }
                // Mediante la función GuardarQuery(); Se guarda la consulta en la Base de Datos
                GuardarQuery();
                // Se borran todos los datos del formulario
                ReiniciarFormulario();
            }
            // En el caso contrario, es decir que radioBtn "NO" no este seleccionado (false)
            else
            {
                // Se verifica que ningún TextBox este vacío, incluyendo el TextBox de Vacuna, ahora si se guardará
                if (!ControlUtils.TextBoxsNoVacios(this))
                {
                    return;
                }
                // Mediante dos funciones distintas, una para cada cosa se guardarán los datos en la base de Datos
                GuardarQuery();
                GuardarVaccine();
                ReiniciarFormulario();
            }
        }

        // La funcion ReiniciarFormulario permite limpiar el DGV y las TB
        private void ReiniciarFormulario()
        {
            dgvPets.DataSource = null;
            dgvPets.Rows.Clear();
            ControlUtils.LimpiarTextBoxs(this, tbDate);
            mostrar_Pets();
        }

        // Esta función permite Guardar los datos de Vacuna en la Base de Datos
        public void GuardarVaccine()
        {
            // Se asignan los datos al objeto de tipo Vacuna 
            Vaccine objeto = new Vaccine
            {
                fecha = DateTime.Now,
                tipoVacuna = tbTypeVaccine.Text,
                idPet = int.Parse(tbIdPet.Text)
            };

            // Luego el objeto será un parametro de una función la cual se encargara de guardar los datos
            bool respuesta = VaccineLogic.Instancia.SaveVaccine(objeto);
            // Se crea la variable respuesta de tipo booleano, si es == True, muestra el primer mensaje de lo contrario muestra le segunda
            MostrarMensaje(respuesta, "Vacuna Guardada correctamente.", "Error al guardar la Vacuna.");
        }

        public void GuardarQuery()
        {
            // Se asigan los datos al objeto de tipo Query
            Query objeto = new Query
            {
                motivo = tbMotivo.Text,
                tratamiento = tbTratamiento.Text,
                fecha = DateTime.Now,
                sintomas = tbSintomas.Text,
                examenFisico = tbExamen.Text,
                observaciones = tbObservaciones.Text,
                idPet = int.Parse(tbIdPet.Text)
            };

            // Luego el objeto será un parametro de una función la cual se encargara de guardar los datos
            bool respuesta = QueryLogic.Instancia.saveQuery(objeto);
            // Se crea la variable respuesta de tipo booleano, si es == True, muestra el primer mensaje de lo contrario muestra le segunda
            MostrarMensaje(respuesta, "Consulta guardada correctamente.", "Error al guardar la Consulta.");
        }

        // La función MostrarMensaje se encarga de mostrar los mensajes de error, exito, dependiendo del parametro booleano
        private void MostrarMensaje(bool exito, string mensajeExito, string mensajeError)
        {
            if (exito)
            {
                MessageBox.Show(mensajeExito, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Verifica que si el Radio BTN "Si" esta seleccionado la TB se activara
        private void rBtnYes_CheckedChanged(object sender, EventArgs e)
        {
            tbTypeVaccine.Enabled = true;
        }

        // Verifica que si el Radio BTN "No" esta seleccionado la TB se desactivara
        private void rBtnNo_CheckedChanged(object sender, EventArgs e)
        {
            tbTypeVaccine.Enabled = false;
        }

        private void tbMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

