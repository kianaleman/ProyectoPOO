using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Logic
{
    public abstract class DataAccess<T>
    {
        protected string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        public bool Save(T obj, string insertQuery, SQLiteParameter[] parameters)
        {
            bool resp = true;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    SQLiteCommand cmd = new SQLiteCommand(insertQuery, conexion);
                    cmd.Parameters.AddRange(parameters);
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        resp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar: {ex.Message}");
                resp = false;
            }
            return resp;
        }

        public List<T> Listar(string selectQuery, Func<SQLiteDataReader, T> createEntity)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[0];
            return Listar(selectQuery, parameters, createEntity);
        }

        public List<T> Listar(string selectQuery, SQLiteParameter[] parameters, Func<SQLiteDataReader, T> createEntity)
        {
            List<T> oLista = new List<T>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    SQLiteCommand cmd = new SQLiteCommand(selectQuery, conexion);
                    cmd.Parameters.AddRange(parameters);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oLista.Add(createEntity(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al listar: {ex.Message}");
            }
            return oLista;
        }

        public bool Edit(T obj, string updateQuery, SQLiteParameter[] parameters)
        {
            bool resp = true;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    SQLiteCommand cmd = new SQLiteCommand(updateQuery, conexion);
                    cmd.Parameters.AddRange(parameters);
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        resp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar: {ex.Message}");
                resp = false;
            }
            return resp;
        }

        public bool Delete(int id, string deleteQuery)
        {
            bool resp = true;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        resp = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar: {ex.Message}");
                resp = false;
            }
            return resp;
        }
    }
}
