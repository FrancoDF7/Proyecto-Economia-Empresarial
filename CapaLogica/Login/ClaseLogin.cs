using AccesoDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSoporte.Cache;


namespace CapaLogica.Login
{
    public class ClaseLogin : ConexionSQL
    {
        public bool LoginUsuario(string usuarioNombre, string contrasena)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;

                        command.Parameters.AddWithValue("@NombreUsuario", usuarioNombre);
                        command.Parameters.AddWithValue("@Contrasena", contrasena);

                        //COLLATE es para que la consulta distinga entre Mayusculas y Minusculas
                        command.CommandText = "SELECT * FROM Usuario WHERE NombreUsuario=@NombreUsuario COLLATE SQL_Latin1_General_CP1_CS_AS AND Contrasena=@Contrasena COLLATE SQL_Latin1_General_CP1_CS_AS";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows) //Si la consulta devuelve un registro existente en la base de datos el metodo LoginUsuario devuelva TRUE
                        {
                            while (reader.Read())
                            {
                                // Se obtiene la información del usuario que inicio sesion,
                                // los numeros en la sección de parametros representa la ubicación de los datos
                                // en la tabla Usuario de la base de datos.

                                ClaseUsuarioCache.ID_Usuario_Cache = reader.GetInt32(0);  //Se envian los datos del usuario, a la Clase "ClaseUsuarioCache" de la CapaSoporte
                                ClaseUsuarioCache.DNI_Cache = reader.GetInt32(1);
                                ClaseUsuarioCache.NombreUsuario_Cache = reader.GetString(2);
                                ClaseUsuarioCache.Contrasena_Cache = reader.GetString(3);
                                ClaseUsuarioCache.Nombre_Cache = reader.GetString(4);
                                ClaseUsuarioCache.Apellido_Cache = reader.GetString(5);
                                ClaseUsuarioCache.TipoUsuario_Cache = reader.GetString(6);
                                ClaseUsuarioCache.Email_Cache = reader.GetString(7);
                                ClaseUsuarioCache.EstadoUsuario_Cache = reader.GetString(8);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
