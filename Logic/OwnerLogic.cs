using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using VeterinariaProyecto.Modelo;
using System.Data.SQLite;

namespace VeterinariaProyecto.Logic
{

    public class OwnerLogic
    {
        //Cadena de conexion con la DB
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static OwnerLogic _instancia = null;

        //constructor
        public OwnerLogic() {
        
        }

        //metodo que permite hacer una instancia la clase OwnerLogic
        //Patron de diseño Singleton
        //Singleton es un patrón de diseño creacional que garantiza que tan solo exista un objeto de su tipo
        //y proporciona un único punto de acceso a él para cualquier otro código
        public static OwnerLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new OwnerLogic();
                }
                return _instancia;
            }
        }
        
        public bool SaveOwner(Owner obj) {

            bool resp = true;

            using (SQLiteConnection conexion  = new SQLiteConnection(cadena))
            {
                //trabajar con parametros es lo recomendable para evitar el sqlinyection
                conexion.Open();
                string query = "insert into OwnerPet(Nombres,Apellidos,Telefono,Direccion) " +
                    "values (@nombres,@apellidos,@telefono,@direccion)";

                SQLiteCommand cmd = new SQLiteCommand(query,conexion);
                cmd.Parameters.Add(new SQLiteParameter("@nombres", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@direccion", obj.Direccion));
                //Ejecucion de un texto
                cmd.CommandType = System.Data.CommandType.Text;

                //ExecuteNonQuery va a retornar el numero de filas afectadas cuando han sido actualizadas
                //insertadas o elimanadas, si el insert estuvo correcto devolvera un numero mayor a 0(numero de filas afectadas)
                if (cmd.ExecuteNonQuery() < 1)
                {
                    resp = false;   
                }
            }
            return resp;
        }

        public List<Owner> Listar() {
            List<Owner> oLista = new List<Owner>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                //se leera lo de la db
                conexion.Open();
                string query = "select * from OwnerPet";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                //using sirve para ejecutar dentro de el lineas de codigo, luego todo pasara al olvido
                using(SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        oLista.Add(new Owner()
                        {
                            id = int.Parse(reader["id"].ToString()),
                            Nombres = reader["Nombres"].ToString(),
                            Apellidos = reader["Apellidos"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Direccion = reader["Direccion"].ToString()
                        });
                    }
                }
            }
            return oLista;
                
        }

    }
}
