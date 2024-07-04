using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaProyecto.Modelo;

namespace VeterinariaProyecto.Logic
{
    // Clase para los datos de Inicio de Sesion
    // Misma logica que OwnerLogic
    public class UsuarioLogic : DataAccess<Usuario>
    {
        private static UsuarioLogic? _instancia = null;

        private UsuarioLogic() { }

        public static UsuarioLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UsuarioLogic();
                }
                return _instancia;
            }
        }

        public bool EditUsuario(Usuario obj)
        {
            string query = "UPDATE tbUser SET usuario = @usuario WHERE id = @id";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@usuario", obj.usuario)
            };

            try
            {
                return Edit(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar el Usuario con id {obj.id}: {ex.Message}");
                return false;
            }
        }

        public bool EditPassword(Usuario obj)
        {
            string query = "UPDATE tbUser SET password = @password WHERE id = @id";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@password", obj.password)
            };

            try
            {
                return Edit(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar La contrasña del usuario con id {obj.id}: {ex.Message}");
                return false;
            }
        }

        public int SearchUser(string usuario)
        {
            int userId = -1;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT id FROM tbUser WHERE usuario = @usuario LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@usuario", usuario));
                        cmd.CommandType = System.Data.CommandType.Text;
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar Usuario: {ex.Message}");
            }

            return userId;
        }

        public Usuario ObtenerUserPorId(int idUser)
        {
            Usuario usuario = null;
            string query = "SELECT id, usuario, password " +
                           "FROM tbUser " +
                           "WHERE id = @id";

            SQLiteParameter parameter = new SQLiteParameter("@id", idUser);

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
                                usuario = new Usuario
                                {
                                    id = Convert.ToInt32(reader["id"] ?? 0),
                                    usuario = reader["usuario"]?.ToString() ?? string.Empty,
                                    password = reader["password"]?.ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el Usuario por ID: {ex.Message}");
            }

            return usuario;
        }
    }
}
