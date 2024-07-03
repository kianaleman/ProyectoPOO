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


namespace VeterinariaProyecto.Forms_QueryAndVaccine
{
    public partial class FormEditQueryAndVaccine : Form
    {

        private DataGridViewRow originalRow;
        public FormEditQueryAndVaccine()
        {
            InitializeComponent();
        }


        public void SetData(DataGridViewRow row)
        {

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("motivo", "Motivo"),
                ("tratamiento", "Tratamiento"),
                ("sintomas", "Sintomas"),
                ("examenFisico", "Examen"),
                ("observaciones", "Observaciones"),
                ("fecha", "Fecha"),
                ("nombreMascota", "Mascota")
            };
            originalRow = row;

            tbMotivo.Text = row.Cells["Motivo"].Value.ToString();
            tbTratamiento.Text = row.Cells["Tratamiento"].Value.ToString();
            tbSintomas.Text = row.Cells["Sintomas"].Value.ToString();
            tbExamen.Text = row.Cells["Examen"].Value.ToString();
            tbObservaciones.Text = row.Cells["Observaciones"].Value.ToString();
            tbDate.Text = Convert.ToDateTime(row.Cells["Fecha"].Value).ToString("yyyy-MM-dd");
        }

        public Query GetUpdatedData()
        {
            return new Query
            {
                id = Convert.ToInt32(originalRow.Cells["id"].Value),
                motivo = tbMotivo.Text,
                tratamiento = tbTratamiento.Text,
                fecha = Convert.ToDateTime(tbDate.Text),
                sintomas = tbSintomas.Text,
                examenFisico = tbExamen.Text,
                observaciones = tbObservaciones.Text
            };
        }

        public void SetDataVaccine(DataGridViewRow row)
        {

            var columns = new List<(string DataPropertyName, string HeaderText)>
            {
                ("tipoVacuna", "Vacuna"),
                ("fecha", "Fecha")
            };
            originalRow = row;


            tbTypeVaccine.Text = row.Cells["Vacuna"].Value.ToString();
            tbDate.Text = Convert.ToDateTime(row.Cells["Fecha"].Value).ToString("yyyy-MM-dd");
        }

        public Vaccine GetUpdatedDataVaccine()
        {
            return new Vaccine
            {
                id = Convert.ToInt32(originalRow.Cells["id"].Value),
                tipoVacuna = tbTypeVaccine.Text,
                fecha = Convert.ToDateTime(tbDate.Text),
                nombreMascota = originalRow.Cells["Mascota"].Value.ToString()


            };
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FormEditQueryAndVaccine_Load(object sender, EventArgs e)
        {

        }

        private void tbIdPet_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNameOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastNameOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumberOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdOwner_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMotivo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbExamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTratamiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTypeVaccine_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveQuery_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

      
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
        


    }
}
