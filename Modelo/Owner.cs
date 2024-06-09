using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Modelo
{
    public class Owner
    {
        //atributos de la db
        public int id {  get; set; }
        public string Nombres { get; set; }
        public string Apellidos {  get; set; }
        public string Telefono {  get; set; }
        public string Direccion { get; set; }
        public string NombreMascota {  get; set; }

    }
}
