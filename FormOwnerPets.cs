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
            Owner objeto = new Owner()
            {
                Nombres = tbNames.Text,
                Apellidos =  tbLastNames.Text,  
                Telefono = tbNumber.Text,
                Direccion = tbAddress.Text
            };

            bool respuesta = OwnerLogic.Instancia.SaveOwner(objeto);

            if (respuesta)
            {
                mostrar_Owners();
            }

        }

        public void mostrar_Owners()
        {
            dgvOwners.DataSource = null;
            dgvOwners.DataSource = OwnerLogic.Instancia.Listar();
        }
    }
}
