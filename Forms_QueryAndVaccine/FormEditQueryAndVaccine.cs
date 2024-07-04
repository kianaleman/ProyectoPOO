using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VeterinariaProyecto.Logic;
using VeterinariaProyecto.Modelo;
using VeterinariaProyecto.Utilities;

namespace VeterinariaProyecto.Forms_QueryAndVaccine
{
    public partial class FormEditQueryAndVaccine : Form
    {
        private Owner currentOwner;
        private ErrorProvider errorProvider;
        private System.Windows.Forms.Timer searchTimer;

        public FormEditQueryAndVaccine()
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

        private void FormEditQueryAndVaccine_Load(object sender, EventArgs e)
        {
            ControlUtils.BloquearTextBoxs(tbIdPet, tbIdOwner, tbNameOwner, tbLastNameOwner, tbNumberOwner);
            tbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            searchTimer.Stop();

            if (tbIdOwner.Text.Length == 16)
            {
                int respuesta = OwnerLogic.Instancia.SearchOwner(tbIdOwner.Text);

                if (respuesta != -1)
                {
                    errorProvider.SetError(tbIdOwner, "");
                    ControlUtils.HabilitarDeshabilitarControles(this, true, tbIdPet, tbDate, tbIdOwner, tbNameOwner, tbLastNameOwner, tbNumberOwner);
                    cargarOwner(respuesta);
                    tbTypeVaccine.Enabled = !rBtnNo.Checked;
                    mostrar_Pets(respuesta);
                }
                else
                {
                    MostrarError("Identificacion no Encontrada");
                }
            }
            else
            {
                MostrarError("Ingrese una identificacion Valida");
            }
        }

        private void MostrarError(string mensaje)
        {
            errorProvider.SetError(tbIdOwner, mensaje);
            errorProvider.Icon = SystemIcons.Error;
            ControlUtils.HabilitarDeshabilitarControles(this, false, tbIdOwner, btnExit);
            ControlUtils.LimpiarTextBoxs(this, tbIdOwner, tbDate, tbExamen, tbMotivo, tbObservaciones, tbSintomas, tbTratamiento, tbTypeVaccine);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchPets_Click(object sender, EventArgs e)
        {
            int idOwner = int.Parse(tbIdOwner.Text);
            mostrar_Pets(idOwner);
        }

        public void mostrar_Pets(int idOwner)
        {
            dgvPets.DataSource = null;
            dgvPets.DataSource = PetLogic.Instancia.ListarPets(idOwner);

            dgvPets.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPets.Columns.Clear();

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("id", "ID"),
                ("nombre", "Nombre")
            };

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

        private void dgvPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dgvPets.Rows[e.RowIndex].Cells["id"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int idPet))
                {
                    tbIdPet.Text = idPet.ToString();
                    mostrar_Consultas(idPet);
                }
                else
                {
                    tbIdPet.Text = string.Empty;
                }
            }
        }

        public void cargarOwner(int idOwner)
        {
            currentOwner = OwnerLogic.Instancia.ObtenerOwnerPorId(idOwner);

            if (currentOwner != null)
            {
                tbIdOwner.Text = currentOwner.Identificacion;
                tbNameOwner.Text = currentOwner.Nombres;
                tbLastNameOwner.Text = currentOwner.Apellidos;
                tbNumberOwner.Text = currentOwner.Telefono;
            }
        }

        private void btnSaveQuery_Click(object sender, EventArgs e)
        {
            if (rBtnNo.Checked)
            {
                if (!ControlUtils.TextBoxsNoVacios(this, tbTypeVaccine))
                {
                    return;
                }
                GuardarQuery();
                ReiniciarFormulario();
            }
            else
            {
                if (!ControlUtils.TextBoxsNoVacios(this))
                {
                    return;
                }
                GuardarQuery();
                GuardarVaccine();
                ReiniciarFormulario();
            }
        }

        private void ReiniciarFormulario()
        {
            dgvPets.DataSource = null;
            dgvPets.Rows.Clear();
            ControlUtils.LimpiarTextBoxs(this, tbDate);
        }

        public void GuardarVaccine()
        {
            Vaccine objeto = new Vaccine
            {
                fecha = DateTime.Now,
                tipoVacuna = tbTypeVaccine.Text,
                idPet = int.Parse(tbIdPet.Text)
            };

            bool respuesta = VaccineLogic.Instancia.SaveVaccine(objeto);
            MostrarMensaje(respuesta, "Vacuna Guardada correctamente.", "Error al guardar la Vacuna.");
        }

        public void GuardarQuery()
        {
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

            bool respuesta = QueryLogic.Instancia.saveQuery(objeto);
            MostrarMensaje(respuesta, "Consulta Guardada correctamente.", "Error al guardar la Consulta.");
        }

        private void MostrarMensaje(bool respuesta, string mensajeExito, string mensajeError)
        {
            if (respuesta)
            {
                MessageBox.Show(mensajeExito, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrar_Consultas(int idPet)
        {
            dgvPets.DataSource = null;
            dgvPets.DataSource = QueryLogic.Instancia.ObtenerConsultasPorIdPet(idPet);

            dgvPets.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPets.Columns.Clear();

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("fecha", "Fecha y Hora"),
                ("motivo", "Motivo"),
                ("sintomas", "Síntomas"),
                ("examenFisico", "Examen Físico"),
                ("observaciones", "Observaciones"),
                ("tratamiento", "Tratamiento")
            };

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
    }
}
