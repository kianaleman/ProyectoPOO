using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Modelo
{
    public class Query
    {
        //atributos de la db
        public int id { get; set; }
        public string motivo { get; set; }
        public string tratamiento { get; set; }
        public  DateTime fecha { get; set; }
        public string sintomas { get; set; }
        public string examenFisico { get; set; }
        public string observaciones { get; set; }
        public int idPet {  get; set; }

        // Propiedad para el Inner Join
        public string nombreMascota { get; set; }
    }
}
