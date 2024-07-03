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

        public bool SavePet(Pet obj)
        {
            string query = "INSERT INTO Pet(nombre, especie, raza, edad, peso, genero, " +
                           "fechaNacimiento, color, esterilizado, fechaRegistro, idOwner, notas) " +
                           "VALUES(@nombre, @especie, @raza, @edad, @peso, @genero, @fechaNacimiento, " +
                           "@color, @esterilizado, @fechaRegistro, @idOwner, @notas)";
            SQLiteParameter[] parameters = 
            {
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

            try
            {
                return Save(obj, query, parameters);
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, loguearla)
                Console.WriteLine($"Error al guardar la Mascota: {ex.Message}");
                return false;
            }
        }


        public List<Pet> ListarPets()
        {
            string query = "SELECT * FROM Pet";

            try
            {
                return Listar(query, reader => new Pet()
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar las Mascotas: {ex.Message}");
                return new List<Pet>();
            }
        }

        public int SearchPet(string nombre)
        {
            int petId = -1;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT id FROM Pet WHERE nombre = @nombre LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SQLiteParameter("@nombre", nombre));
                        cmd.CommandType = System.Data.CommandType.Text;
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            petId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar Pet: {ex.Message}");
            }

            return petId;
        }


        public List<Pet> ListarPets(int idOwner)
        {
            string query = "SELECT * FROM Pet WHERE idOwner = @idOwner";
            SQLiteParameter[] parameters = 
            {
                new SQLiteParameter("@idOwner", idOwner)
            };

            try
            {
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar las Mascotas: {ex.Message}");
                return new List<Pet>();
            }
        }


        public Pet ObtenerPetPorId(int idPet)
        {
            Pet? pet = null;
            string query = "SELECT id, nombre, especie, raza, edad, peso, genero, fechaNacimiento, color, esterilizado," +
                "fechaRegistro, notas FROM Pet WHERE id = @id";

            SQLiteParameter parameter = new SQLiteParameter("@id", idPet);

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
                                pet = new Pet
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
                                    notas = reader["notas"]?.ToString() ?? string.Empty
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la Mascota por ID: {ex.Message}");
            }

            // Devuelve pet, que puede ser null si no se encontró ninguna mascota con el id especificado
            return pet;

        }


        public bool EditPet(Pet obj)
        {
            string query = "UPDATE Pet SET nombre = @nombre, especie = @especie, raza = @raza, " +
                           "edad = @edad, peso = @peso, genero = @genero, fechaNacimiento = @fechaNacimiento, " +
                           "color = @color, esterilizado = @esterilizado, fechaRegistro = @fechaRegistro, " +
                           "notas = @notas WHERE id = @id";

            SQLiteParameter[] parameters = 
            {
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

            try
            {
                return Edit(obj, query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar la Mascota: {ex.Message}");
                return false;
            }
        }


        public bool DeletePet(Pet obj)
        {
            string query = "DELETE FROM Pet WHERE id = @id";

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
