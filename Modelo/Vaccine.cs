using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Modelo
{
    public class Vaccine
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public String vacuna { get; set; }
        public int idPet { get; set; }

    }
}
