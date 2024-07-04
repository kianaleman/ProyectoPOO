using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Logic
{
    // Uso de polimorfismo parametrico "<T>", indica que se puede trabajar con cualquier tipo de entidad
    public abstract class DataAccess<T>
    {
        // Cadena de conexion a la base de datos, la cual se guarda en el archivo "App.config"
        protected string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        // Guardar entidad de tipo T
        public bool Save(T obj, string insertQuery, SQLiteParameter[] parameters)
        {
            // Variable que indica si la operacion fue exitosa
            bool resp = true;
            try
            {
                // Crear una nueva conexion SQLite usando la Cadena de Conexion
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    // Abrir la conexion a la DB
                    conexion.Open();

                    // Crear un nuevo comando SQLite usando la consulta proporcionada "string insertQuery"
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conexion);

                    // Agregar los parametros proporcionados al comando
                    cmd.Parameters.AddRange(parameters);

                    // Ejecutar el comando como texto (Consulta SQL)
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Verificar si se afecto alguna fila
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        // Si no afecto ni una fila, fallo la operacion
                        resp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepcion que ocurra y mostrar el mensaje en consola
                Console.WriteLine($"Error al guardar: {ex.Message}");

                // Indicar fallo en la operacion
                resp = false;
            }

            // Devolver el resultado de la operacion (true == exito, false == fallo)
            return resp;
        }

        // "Fun<SQliteDataReader, T>" permite que el metodo transforme los datos leidos en objetos del tipo T
        // Esto permite que sea polimorfico ya que puede adaptarse a diferentes tipos de entidades "T" segun sea necesario
        public List<T> Listar(string selectQuery, Func<SQLiteDataReader, T> createEntity)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[0];
            return Listar(selectQuery, parameters, createEntity);
        }

        // Listar la entidad de tipo T
        public List<T> Listar(string selectQuery, SQLiteParameter[] parameters, Func<SQLiteDataReader, T> createEntity)
        {
            // Inicializar una lista vacia para almacenar los objetos del tipo T
            List<T> oLista = new List<T>();
            try
            {

                // Crear conexion usando la Cadena de conexion
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    // Abrir la conexion con la base de datos
                    conexion.Open();
                    SQLiteCommand cmd = new SQLiteCommand(selectQuery, conexion);
                    cmd.Parameters.AddRange(parameters);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Ejecutar el comando y obtener un DataReader (lector de datos) el cual lee los resultados
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras haya fila para leer en el lector de datos
                        while (reader.Read())
                        {
                            // Utiliza la función createEntity para transformar cada fila leída en un objeto del tipo T
                            // Agrega el objeto a la lista
                            oLista.Add(createEntity(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepcion que ocurra y mostrar el mensaje en consola
                Console.WriteLine($"Error al listar: {ex.Message}");
            }
            // Devolver la lista de objetos del tipo T
            return oLista;
        }

        // Editar la entidad de tipo T
        public bool Edit(T obj, string updateQuery, SQLiteParameter[] parameters)
        {
            // Variable que indica si la operacion fue exitosa
            bool resp = true;
            try
            {
                // Crear una nueva conexion SQLite usando la cadena de conexion
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    // Abrir la conexion a la DB
                    conexion.Open();

                    // Crear un nuevo comando SQLite usando la consulta proporcionada "string updateQuery"
                    SQLiteCommand cmd = new SQLiteCommand(updateQuery, conexion);

                    // Agregar los parametros proporcionados al comando
                    cmd.Parameters.AddRange(parameters);

                    // Convertir el comando en consulta Estandar SQL
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Verificar si no afecto ni una fila
                    // Si el numero de filas afectadas es menor que 1, establece la respuesta como falsa
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        resp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepcion que ocurra y mostrar un mensaje de error en la consola
                Console.WriteLine($"Error al editar: {ex.Message}");
                resp = false;
            }
            // Devolver resultado de la operacion
            return resp;
        }

        // Eliminar la entidad de tipo T 
        public bool Delete(int id, string deleteQuery)
        {
            // Variable que indica si la operacion fue exitosa
            bool resp = true;
            try
            {
                // Crear una nueva conexion SQLite usando la cadena de conexion
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    // Abrir la conexion a la DB
                    conexion.Open();

                    // Crear un nuevo comando SQLite usando la consulta proporcionada "string deleteQuery"
                    SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conexion);

                    // Agregar los parametros proporcionados al comando
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));

                    // Convertir el comando en consulta Estandar SQL
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Verificar si no afecto ni una fila
                    // Si el numero de filas afectadas es menor que 1, establece la respuesta como falsa
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        resp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier excepcion que ocurra y mostrar un mensaje de error en la consola
                Console.WriteLine($"Error al eliminar: {ex.Message}");
                resp = false;
            }

            // Devolver resultado de la operacion
            return resp;
        }
    }
}
