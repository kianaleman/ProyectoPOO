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

    public class OwnerLogic : DataAccess<Owner>
    {
        private static OwnerLogic? _instancia = null;

        private OwnerLogic() { }

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

        public bool SaveOwner(Owner obj)
        {
            string query = "insert into OwnerPet(Nombres, Apellidos, Telefono, Direccion, Identificacion) " +
                           "values (@nombres, @apellidos, @telefono, @direccion, @identificacion)";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@nombres", obj.Nombres),
                new SQLiteParameter("@apellidos", obj.Apellidos),
                new SQLiteParameter("@telefono", obj.Telefono),
                new SQLiteParameter("@direccion", obj.Direccion),
                new SQLiteParameter("@identificacion", obj.Identificacion)
            };
            return Save(obj, query, parameters);
        }

        public List<Owner> ListarOwners()
        {
            string query = "SELECT * FROM OwnerPet";
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

        public bool EditOwner(Owner obj)
        {
            string query = "UPDATE OwnerPet SET Nombres = @nombres, Apellidos = @apellidos, " +
                           "Telefono = @telefono, Direccion = @direccion, Identificacion = @identificacion " +
                           "WHERE id = @id";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@nombres", obj.Nombres),
                new SQLiteParameter("@apellidos", obj.Apellidos),
                new SQLiteParameter("@telefono", obj.Telefono),
                new SQLiteParameter("@direccion", obj.Direccion),
                new SQLiteParameter("@identificacion", obj.Identificacion)
            };
            return Edit(obj, query, parameters);
        }

        public bool DeleteOwner(Owner obj)
        {
            string query = "DELETE FROM OwnerPet WHERE id = @id";
            return Delete(obj.id, query);
        }

        public int SearchOwner(string identificacion)
        {
            int ownerId = -1;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT id FROM OwnerPet WHERE Identificacion = @identificacion LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@identificacion", identificacion));
                        cmd.CommandType = System.Data.CommandType.Text;
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
                // Manejar la excepción (por ejemplo, loguearla)
                Console.WriteLine($"Error al buscar owner: {ex.Message}");
            }

            return ownerId;
        }

        public List<Owner> ListarOwners(int ownerId)
        {
            string query = "SELECT * FROM OwnerPet WHERE id = @ownerId";
            SQLiteParameter[] parameters = {
            new SQLiteParameter("@ownerId", ownerId)
        };

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

        public Owner ObtenerOwnerPorId(int idOwner)
        {
            Owner owner = null;
            string query = "SELECT id, Nombres, Apellidos, Telefono, Direccion, Identificacion " +
                           "FROM OwnerPet " +
                           "WHERE id = @id";

            SQLiteParameter parameter = new SQLiteParameter("@id", idOwner);

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.Add(parameter);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
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
                // Manejar la excepción (por ejemplo, loguearla)
                Console.WriteLine($"Error al obtener el propietario por ID: {ex.Message}");
            }

            return owner;
        }

    }
}
