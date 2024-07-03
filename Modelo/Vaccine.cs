using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Modelo
{
    public class Vaccine
    {
        //atributos de la db
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public String tipoVacuna { get; set; }
        public int idPet { get; set; }

        // Propiedad para el Inner Join
        public string nombreMascota { get; set; }

    }
}
