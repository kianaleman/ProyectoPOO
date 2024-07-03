using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Modelo
{
    public class Pet
    {
        //atributos de la db
        public int id { get; set; }
        public string nombre { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
        public float peso { get; set; }
        public string genero { get; set; }
        public string fechaNacimiento { get; set; }
        public string color { get; set; }
        public string esterilizado { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int idOwner { get; set; }
        public string notas { get; set; }


    }
}
