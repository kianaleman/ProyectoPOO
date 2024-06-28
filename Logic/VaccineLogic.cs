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
            string query = "INSERT INTO VacunasPet(fecha, vacuna, idPet) " +
                           "VALUES (@fecha, @vacuna, @idPet)";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@fecha", obj.fecha),
                new SQLiteParameter("@vacuna", obj.vacuna),
                new SQLiteParameter("@idPet", obj.idPet)
            };
            return Save(obj, query, parameters);
        }

        public List<Vaccine> ListarVaccines()
        {
            string query = "SELECT * FROM VacunasPet";
            return Listar(query, reader => new Vaccine()
            {
                id = Convert.ToInt32(reader["id"] ?? 0),
                fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha")),
                vacuna = reader["Apellidos"]?.ToString() ?? string.Empty,
                idPet = Convert.ToInt32(reader["idPet"] ?? 0)
            });
        }

        public List<Vaccine> ListarVaccines(int idPet)
        {
            string query = "SELECT * FROM VacunasPet WHERE idPet = @idPet";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@idPet", idPet)
            };

            return Listar(query, parameters, reader => new Vaccine()
            {
                id = Convert.ToInt32(reader["id"] ?? 0),
                fecha = reader.IsDBNull(reader.GetOrdinal("fecha")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fecha")),
                vacuna = reader["Apellidos"]?.ToString() ?? string.Empty,
                idPet = Convert.ToInt32(reader["idPet"] ?? 0)
            });
        }

        public bool EditVaccine(Vaccine obj)
        {
            string query = "UPDATE VacunasPet SET fecha = @fecha, vacuna = @vacuna WHERE id = @id";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@fecha", obj.fecha),
                new SQLiteParameter("@vacuna", obj.vacuna),
                new SQLiteParameter("@idPet", obj.idPet)
            };
            return Edit(obj, query, parameters);
        }

        public bool DeleteVaccine(Vaccine obj)
        {
            string query = "DELETE FROM VacunasPet WHERE id = @id";
            return Delete(obj.id, query);
        }

    }
}
