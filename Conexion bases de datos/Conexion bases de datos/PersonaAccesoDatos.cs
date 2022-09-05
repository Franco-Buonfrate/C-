using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_bases_de_datos
{
    public static class PersonaAccesoDatos
    {
        static string connectionString;
        static SqlConnection connection;
        static SqlCommand command;

        static PersonaAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=UTN;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static Persona LeerID(int id)
        {
            Persona persona = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM tabla_1 WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        persona = new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"]));
                    }
                }
                return persona;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(string nombre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"Insert into tabla_1 (Nombre) values ('{nombre}')";
                command.Parameters.AddWithValue("@Nombre", nombre);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(string nuevoNombre, int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"Update tabla_1 Set Nombre = '{nuevoNombre}' where ID = {id}";
                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"delete from tabla_1 where ID = {id}";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
