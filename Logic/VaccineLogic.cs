using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaProyecto.Modelo;
using System.Data.SQLite;

namespace VeterinariaProyecto.Logic
{
    public class VaccineLogic : DataAccess<Vaccine>
    {
        private static VaccineLogic? _instancia = null;

        private VaccineLogic() { }

        public static VaccineLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new VaccineLogic();
                }
                return _instancia;
            }
        }

        public bool SaveVaccine(Vaccine obj)
        {
            string query = "INSERT INTO VacunasPet(fecha, tipoVacuna, idPet) " +
                           "VALUES (@fecha, @tipoVacuna, @idPet)";
            SQLiteParameter[] parameters = 
            [
                new SQLiteParameter("@fecha", obj.fecha),
                new SQLiteParameter("@tipoVacuna", obj.tipoVacuna),
                new SQLiteParameter("@idPet", obj.idPet)
            ];

            try
            {
                return Save(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la vacuna: {ex.Message}");
                return false;
            }
        }


        public List<Vaccine> ListarVaccinesConNombreMascota()
        {
            string query = @"
                SELECT V.*, P.nombre AS nombreMascota
                FROM VacunasPet V
                INNER JOIN Pet P ON V.idPet = P.id";

            try
            {
                return Listar(query, reader => new Vaccine()
                {
                    id = Convert.ToInt32(reader["id"] ?? 0),
                    fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha")),
                    tipoVacuna = reader["tipoVacuna"]?.ToString() ?? string.Empty,
                    idPet = Convert.ToInt32(reader["idPet"] ?? 0),
                    nombreMascota = reader["nombreMascota"]?.ToString() ?? string.Empty
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar vacunas con nombre de mascota: {ex.Message}");
                return new List<Vaccine>();
            }
        }




        public List<Vaccine> ListarVaccines(int idPet)
        {
            string query = "SELECT * FROM VacunasPet WHERE idPet = @idPet";
            SQLiteParameter[] parameters =
            {
                new SQLiteParameter("@idPet", idPet)
            };

            try
            {
                return Listar(query, parameters, reader => new Vaccine()
                {
                    id = Convert.ToInt32(reader["id"] ?? 0),
                    fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha")),
                    tipoVacuna = reader["tipoVacuna"]?.ToString() ?? string.Empty,
                    idPet = Convert.ToInt32(reader["idPet"] ?? 0)
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar vacunas para el idPet {idPet}: {ex.Message}");
                return new List<Vaccine>(); 
            }
        }


        public bool EditVaccine(Vaccine obj)
        {
            string query = "UPDATE VacunasPet SET fecha = @fecha, tipoVacuna = @tipoVacuna WHERE id = @id";
            SQLiteParameter[] parameters = 
            {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@fecha", obj.fecha),
                new SQLiteParameter("@tipoVacuna", obj.tipoVacuna)
            };

            try
            {
                return Edit(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar la vacuna con id {obj.id}: {ex.Message}");
                return false;
            }
        }


        public bool DeleteVaccine(Vaccine obj)
        {
            string query = "DELETE FROM VacunasPet WHERE id = @id";

            try
            {
                return Delete(obj.id, query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la vacuna con id {obj.id}: {ex.Message}");
                return false; 
            }
        }


    }
}
