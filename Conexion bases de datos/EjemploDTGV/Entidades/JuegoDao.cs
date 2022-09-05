using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JuegoDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static JuegoDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }


        public static void Eliminar(int codigoJuego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"delete from JUEGOS where CODIGO_JUEGO = @ID";
                comando.Parameters.AddWithValue("@ID", codigoJuego);
                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"Update JUEGOS Set NOMBRE = @NOMBRE, PRECIO = @PRECIO, GENERO = @GENERO  where CODIGO_JUEGO = @CODIGO_JUEGO";
                comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre);
                comando.Parameters.AddWithValue("@GENERO", juego.Genero);
                comando.Parameters.AddWithValue("@CODIGO_JUEGO", juego.CodigoJuego);
                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"Insert into JUEGOS (NOMBRE,PRECIO,GENERO,CODIGO_USUARIO) values ( @NOMBRE , @PRECIO , @GENERO , @CODIGO )";
                comando.Parameters.AddWithValue("@NOMBRE", juego.Nombre);
                comando.Parameters.AddWithValue("@PRECIO", juego.Precio);
                comando.Parameters.AddWithValue("@GENERO", juego.Genero);
                comando.Parameters.AddWithValue("@CODIGO", juego.CodigoUsuario);

                int rows = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public static List<Bibloteca> Leer()
        {
            List<Bibloteca> listaDeJuegos = new List<Bibloteca>();

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO AS codigoJuego, USUARIOS.USERNAME AS usuario FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Bibloteca bibloteca= new Bibloteca(dataReader["usuario"].ToString(),
                                                dataReader["genero"].ToString(),
                                                dataReader["juego"].ToString(),
                                                Convert.ToInt32(dataReader["codigoJuego"]));
                        listaDeJuegos.Add(bibloteca);
                    }
                }
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return listaDeJuegos;
        }

        public static Juego LeerID(int id)
        {
            Juego juego = null;

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS where CODIGO_JUEGO = @CODIGO";
                comando.Parameters.AddWithValue("@CODIGO", id);
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        juego = new Juego(dataReader["NOMBRE"].ToString(),
                                                Convert.ToDouble(dataReader["PRECIO"]),
                                                dataReader["GENERO"].ToString(),
                                                Convert.ToInt32(dataReader["CODIGO_JUEGO"]),
                                                Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
                    }
                }
                return juego;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
