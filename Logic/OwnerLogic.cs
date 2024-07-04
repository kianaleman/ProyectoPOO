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
    // Clase que Hereda de DataAccess<T> y maneja operaciones CRUD para la entidad Owner
    public class OwnerLogic : DataAccess<Owner>
    {
        // Campo estatico privado para implementar el patron Singleton
        private static OwnerLogic? _instancia = null;

        // Constructor privado para evitar instanciacion directa
        private OwnerLogic() { }

        // Propiedad estatica para obtener la instancia unica de OwnerLogic (patron de diseño Singleton)
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

        // Metodo para guardar un propietario en la base de datos
        public bool SaveOwner(Owner obj)
        {
            // Consulta SQL de insercion
            string query = "INSERT INTO OwnerPet(Nombres, Apellidos, Telefono, Direccion, Identificacion)" +
                           "VALUES (@Nombres, @Apellidos, @Telefono, @Direccion, @Identificacion)";

            // Parametros de la consulta
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@Nombres", obj.Nombres),
                new SQLiteParameter("@Apellidos", obj.Apellidos),
                new SQLiteParameter("@Telefono", obj.Telefono),
                new SQLiteParameter("@Direccion", obj.Direccion),
                new SQLiteParameter("@Identificacion", obj.Identificacion)
            };

            try
            {
                // Llama al metodo Save de la clase base para ejecutar la consulta
                return Save(obj, query, parameters);
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepción que ocurra
                Console.WriteLine($"Error al guardar el propietario {obj.Nombres} {obj.Apellidos}: {ex.Message}");
                return false;
            }
        }

        // Metodo para listar todos los propietarios
        public List<Owner> ListarOwners()
        {
            // Consulta SQL para seleccionar todos los propietarios
            string query = "SELECT * FROM OwnerPet";

            try
            {
                // Llama al metodo Listar de la clase base para ejecutar la consulta y convertir los resultados en objetos Owner
                return Listar(query, reader => new Owner()
                {
                    id = Convert.ToInt32(reader["id"] ?? 0),
                    Nombres = reader["Nombres"]?.ToString() ?? string.Empty,
                    Apellidos = reader["Apellidos"]?.ToString() ?? string.Empty,
                    Telefono = reader["Telefono"]?.ToString() ?? string.Empty,
                    Direccion = reader["Direccion"]?.ToString() ?? string.Empty,
                    Identificacion = reader["Identificacion"]?.ToString() ?? string.Empty
                });
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepcion que ocurra
                Console.WriteLine($"Error al listar propietarios: {ex.Message}");
                return new List<Owner>();
            }
        }

        // Metodo para editar un propietario existente
        public bool EditOwner(Owner obj)
        {
            // Consulta SQL de actualizacion
            string query = "UPDATE OwnerPet SET Nombres = @nombres, Apellidos = @apellidos, " +
                           "Telefono = @telefono, Direccion = @direccion, Identificacion = @identificacion " +
                           "WHERE id = @id";
            // Parametros de la consulta
            SQLiteParameter[] parameters = 
            {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@nombres", obj.Nombres),
                new SQLiteParameter("@apellidos", obj.Apellidos),
                new SQLiteParameter("@telefono", obj.Telefono),
                new SQLiteParameter("@direccion", obj.Direccion),
                new SQLiteParameter("@identificacion", obj.Identificacion)
            };

            try
            {
                // Llama al método Edit de la clase base para ejecutar la consulta
                return Edit(obj, query, parameters);
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepción que ocurra
                Console.WriteLine($"Error al editar el propietario con id {obj.id}: {ex.Message}");
                return false;
            }
        }


        /*public bool DeleteOwner(Owner obj)
        {
            string query = "DELETE FROM OwnerPet WHERE id = @id";

            try
            {
                return Delete(obj.id, query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar el propietario con id {obj.id}: {ex.Message}");
                return false;
            }
        }*/

        // Metodo para buscar un propietario por su identificacion (Cedula)
        // Este metodo no se encuentra en la clase Base
        public int SearchOwner(string identificacion)
        {
            int ownerId = -1;

            try
            {
                // Crear una nueva conexión SQLite usando la cadena de conexión
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    // Abrir la conexion a la base de datos
                    conexion.Open();

                    // Consulta SQL para seleccionar el ID del propietario por identificacion
                    string query = "SELECT id FROM OwnerPet WHERE Identificacion = @identificacion LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        // Agregar el parametro de identificacion al comando
                        cmd.Parameters.Add(new SQLiteParameter("@identificacion", identificacion));
                        cmd.CommandType = System.Data.CommandType.Text;

                        // Ejecutar la consulta y obtener el resultado
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            ownerId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepción que ocurra
                Console.WriteLine($"Error al buscar owner: {ex.Message}");
            }

            // Devolver el ID del propietario, -1 si no se encuentra
            return ownerId;
        }

        // Metodo para listar propietarios por su ID
        public List<Owner> ListarOwners(int ownerId)
        {
            // Consulta SQL para seleccionar propietarios por ID
            string query = "SELECT * FROM OwnerPet WHERE id = @ownerId";

            // Parametros de la consulta
            SQLiteParameter[] parameters = 
            {
                new SQLiteParameter("@ownerId", ownerId)
            };

            try
            {
                // Llama al metodo Listar de la clase base para ejecutar la consulta y convertir los resultados en objetos Owner
                return Listar(query, parameters, reader => new Owner()
                {
                    id = Convert.ToInt32(reader["id"] ?? 0),
                    Nombres = reader["Nombres"]?.ToString() ?? string.Empty,
                    Apellidos = reader["Apellidos"]?.ToString() ?? string.Empty,
                    Telefono = reader["Telefono"]?.ToString() ?? string.Empty,
                    Direccion = reader["Direccion"]?.ToString() ?? string.Empty,
                    Identificacion = reader["Identificacion"]?.ToString() ?? string.Empty
                });
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepción que ocurra
                Console.WriteLine($"Error al listar propietarios con id {ownerId}: {ex.Message}");
                return new List<Owner>();
            }
        }

        // Metodo para obtener un propietario por su ID
        // No se encuentra en la clase Base
        public Owner ObtenerOwnerPorId(int idOwner)
        {
            Owner? owner = null;

            // Consulta SQL para seleccionar un propietario por ID
            string query = "SELECT id, Nombres, Apellidos, Telefono, Direccion, Identificacion " +
                           "FROM OwnerPet " +
                           "WHERE id = @id";

            SQLiteParameter parameter = new SQLiteParameter("@id", idOwner);

            try
            {
                // Crear una nueva conexion SQLite usando la cadena de conexion
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    // Abrir la conexión a la base de datos
                    conexion.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        // Agregar el parametro del ID al comando
                        cmd.Parameters.Add(parameter);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            // Leer los datos del propietario
                            if (reader.Read())
                            {
                                owner = new Owner
                                {
                                    id = Convert.ToInt32(reader["id"] ?? 0),
                                    Nombres = reader["Nombres"]?.ToString() ?? string.Empty,
                                    Apellidos = reader["Apellidos"]?.ToString() ?? string.Empty,
                                    Telefono = reader["Telefono"]?.ToString() ?? string.Empty,
                                    Direccion = reader["Direccion"]?.ToString() ?? string.Empty,
                                    Identificacion = reader["Identificacion"]?.ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Captura y muestra cualquier excepcion que ocurra
                Console.WriteLine($"Error al obtener el propietario por ID: {ex.Message}");
            }

            // Devolver el propietario encontrado, o null si no se encuentra
            return owner;
        }

    }
}
