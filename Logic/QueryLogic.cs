using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design.Behavior;
using VeterinariaProyecto.Modelo;

namespace VeterinariaProyecto.Logic
{
    public class QueryLogic : DataAccess<Query>
    {
        private static QueryLogic? _instancia = null;

        private QueryLogic() { }

        public static QueryLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new QueryLogic();
                }
                return _instancia;
            }
        }

        public bool saveQuery(Query obj)
        {
            string query = "INSERT INTO PetQuery(motivo, tratamiento, fecha, sintomas, examenFisico," +
                "observaciones, idPet)  VALUES (@motivo, @tratamiento, @fecha, @sintomas, @examenFisico," +
                "@observaciones, @idPet)"; 
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@motivo", obj.motivo),
                new SQLiteParameter("@tratamiento", obj.tratamiento),
                new SQLiteParameter("@fecha", obj.fecha),
                new SQLiteParameter("@sintomas", obj.sintomas),
                new SQLiteParameter("@examenFisico", obj.examenFisico),
                new SQLiteParameter("@observaciones", obj.observaciones),
                new SQLiteParameter("@idPet", obj.idPet)
            };

            try
            {
                return Save(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la Consulta: {ex.Message}");
                return false;
            }
        }

        public List<Query> ObtenerConsultasPorIdPet(int idPet)
        {
            List<Query> consultas = new List<Query>();

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=veterinaria.db;Version=3;"))
            {
                connection.Open();
                string query = "SELECT * FROM Consultas WHERE idPet = @idPet";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPet", idPet);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Query consulta = new Query
                            {
                                id = reader.GetInt32(0),
                                motivo = reader.GetString(1),
                                tratamiento = reader.GetString(2),
                                fecha = reader.GetDateTime(3),
                                sintomas = reader.GetString(4),
                                examenFisico = reader.GetString(5),
                                observaciones = reader.GetString(6),
                                idPet = reader.GetInt32(7)
                            };
                            consultas.Add(consulta);
                        }
                    }
                }
            }

            return consultas;
        }
    

    public List<Query> ListarQueryConNombreMascota()
        {
            string query = @"
                SELECT Q.*, P.nombre AS nombreMascota
                FROM PetQuery Q
                INNER JOIN Pet P ON Q.idPet = P.id";

            try
            {
                return Listar(query, reader => new Query()
                {
                    id = Convert.ToInt32(reader["id"] ?? 0),
                    motivo = reader["motivo"]?.ToString() ?? string.Empty,
                    tratamiento = reader["tratamiento"]?.ToString() ?? string.Empty,
                    fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha")),
                    sintomas = reader["sintomas"]?.ToString() ?? string.Empty,
                    examenFisico = reader["examenFisico"]?.ToString() ?? string.Empty,
                    observaciones = reader["observaciones"]?.ToString() ?? string.Empty,
                    idPet = Convert.ToInt32(reader["idPet"] ?? 0),
                    nombreMascota = reader["nombreMascota"]?.ToString() ?? string.Empty
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar las consultas con nombre de mascota: {ex.Message}");
                return new List<Query>();
            }
        }

        public List<Query> ListarQuery(int idPet)
        {
            string query = "SELECT * FROM PetQuery WHERE idPet = @idPet";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@idPet", idPet)
            };
            try
            {
                return Listar(query, parameters, reader => new Query()
                {
                    id = Convert.ToInt32(reader["id"] ?? 0),
                    motivo = reader["motivo"]?.ToString() ?? string.Empty,
                    tratamiento = reader["tratamiento"]?.ToString() ?? string.Empty,
                    fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? DateTime.MinValue
                    : reader.GetDateTime(reader.GetOrdinal("fecha")),
                    sintomas = reader["sintomas"]?.ToString() ?? string.Empty,
                    examenFisico = reader["examenFisico"]?.ToString() ?? string.Empty,
                    observaciones = reader["observaciones"]?.ToString() ?? string.Empty,
                    idPet = Convert.ToInt32(reader["idPet"] ?? 0)
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar las Consultas: {ex.Message}");
                return new List<Query>();
            }
        }

        public bool EditQuery(Query obj)
        {
            string query = "UPDATE PetQuery SET motivo = @motivo, tratamiento= @tratamiento, fecha = @fecha, " +
                           "sintomas= @sintomas, examenFisico= @examenFisico, observaciones= @observaciones " +
                           "WHERE id = @id";

            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@motivo", obj.motivo),
                new SQLiteParameter("@tratamiento", obj.tratamiento),
                new SQLiteParameter("@fecha", obj.fecha),
                new SQLiteParameter("@sintomas", obj.sintomas),
                new SQLiteParameter("@examenFisico", obj.examenFisico),
                new SQLiteParameter("@observaciones", obj.observaciones)
            };

            try
            {
                return Edit(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar la Consulta: {ex.Message}");
                return false;
            }
        }

        public bool DeleteQuery(Query obj)
        {
            string query = "DELETE FROM PetQuery WHERE id = @id";

            try
            {
                return Delete(obj.id, query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la Mascota: {ex.Message}");
                return false;
            }
        }

        
    }
}
