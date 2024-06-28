using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaProyecto.Modelo;

namespace VeterinariaProyecto.Logic
{
    public class PetLogic : DataAccess<Pet>
    {
        private static PetLogic? _instancia = null;

        private PetLogic() { }

        public static PetLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PetLogic();
                }
                return _instancia;
            }
        }

        public bool savePet(Pet obj)
        {
            string query = "insert into Pet(nombre, especie, raza, edad, peso, genero, " +
                           "fechaNacimiento, color, esterilizado, fechaRegistro, idOwner, notas) " +
                           "values(@nombre, @especie, @raza, @edad, @peso, @genero, @fechaNacimiento, " +
                           "@color, @esterilizado, @fechaRegistro, @idOwner, @notas)";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@nombre", obj.nombre),
                new SQLiteParameter("@especie", obj.especie),
                new SQLiteParameter("@raza", obj.raza),
                new SQLiteParameter("@edad", obj.edad),
                new SQLiteParameter("@peso", obj.peso),
                new SQLiteParameter("@genero", obj.genero),
                new SQLiteParameter("@fechaNacimiento", obj.fechaNacimiento),
                new SQLiteParameter("@color", obj.color),
                new SQLiteParameter("@esterilizado", obj.esterilizado),
                new SQLiteParameter("@fechaRegistro", obj.fechaRegistro),
                new SQLiteParameter("@idOwner", obj.idOwner),
                new SQLiteParameter("@notas", obj.notas)
            };
            return Save(obj, query, parameters);
        }

        public List<Pet> ListarPets()
        {
            string query = "SELECT * FROM Pet";
            return Listar(query, reader => new Pet()
            {
                //id = Convert.ToInt32(reader["id"] ?? 0),
                nombre = reader["nombre"]?.ToString() ?? string.Empty,
                especie = reader["especie"]?.ToString() ?? string.Empty,
                raza = reader["raza"]?.ToString() ?? string.Empty,
                edad = Convert.ToInt32(reader["edad"] ?? 0),
                peso = Convert.ToSingle(reader["peso"] ?? 0f),
                genero = reader["genero"]?.ToString() ?? string.Empty,
                fechaNacimiento = reader["fechaNacimiento"]?.ToString() ?? string.Empty,
                color = reader["color"]?.ToString() ?? string.Empty,
                esterilizado = reader["esterilizado"]?.ToString() ?? string.Empty,
                fechaRegistro = reader.IsDBNull(reader.GetOrdinal("fechaRegistro")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fechaRegistro")),
                //idOwner = Convert.ToInt32(reader["idOwner"] ?? 0),
                notas = reader["notas"]?.ToString() ?? string.Empty
            });
        }

        public List<Pet> ListarPets(int idOwner)
        {
            string query = "SELECT * FROM Pet WHERE idOwner = @idOwner";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@idOwner", idOwner)
            };

            return Listar(query, parameters, reader => new Pet()
            {
                id = Convert.ToInt32(reader["id"] ?? 0),
                nombre = reader["nombre"]?.ToString() ?? string.Empty,
                especie = reader["especie"]?.ToString() ?? string.Empty,
                raza = reader["raza"]?.ToString() ?? string.Empty,
                edad = Convert.ToInt32(reader["edad"] ?? 0),
                peso = Convert.ToSingle(reader["peso"] ?? 0f),
                genero = reader["genero"]?.ToString() ?? string.Empty,
                fechaNacimiento = reader["fechaNacimiento"]?.ToString() ?? string.Empty,
                color = reader["color"]?.ToString() ?? string.Empty,
                esterilizado = reader["esterilizado"]?.ToString() ?? string.Empty,
                fechaRegistro = reader.IsDBNull(reader.GetOrdinal("fechaRegistro")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("fechaRegistro")),
                idOwner = Convert.ToInt32(reader["idOwner"] ?? 0),
                notas = reader["notas"]?.ToString() ?? string.Empty
            });
        }


        public bool EditPet(Pet obj)
        {
            string query = "UPDATE Pet SET nombre = @nombre, especie = @especie, raza = @raza, " +
                           "edad = @edad, peso = @peso, genero = @genero, fechaNacimiento = @fechaNacimiento, " +
                           "color = @color, esterilizado = @esterilizado, fechaRegistro = @fechaRegistro, " +
                           "notas = @notas WHERE id = @id";
            SQLiteParameter[] parameters = {
                new SQLiteParameter("@id", obj.id),
                new SQLiteParameter("@nombre", obj.nombre),
                new SQLiteParameter("@especie", obj.especie),
                new SQLiteParameter("@raza", obj.raza),
                new SQLiteParameter("@edad", obj.edad),
                new SQLiteParameter("@peso", obj.peso),
                new SQLiteParameter("@genero", obj.genero),
                new SQLiteParameter("@fechaNacimiento", obj.fechaNacimiento),
                new SQLiteParameter("@color", obj.color),
                new SQLiteParameter("@esterilizado", obj.esterilizado),
                new SQLiteParameter("@fechaRegistro", obj.fechaRegistro),
                new SQLiteParameter("@notas", obj.notas)
            };
            return Edit(obj, query, parameters);
        }

        public bool DeletePet(Pet obj)
        {
            string query = "DELETE FROM Pet WHERE id = @id";
            return Delete(obj.id, query);
        }
    }
}
