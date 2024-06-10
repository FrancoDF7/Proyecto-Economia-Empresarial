using AccesoDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaSoporte.Cache;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace CapaLogica.Usuarios
{
    public class ClaseUsuario : ConexionSQL
    {
        private SqlCommand Command;
        private SqlDataReader Reader;
        private DataTable dataTable;

        private string NombreColumna;

        //Metodo para editar el perfil del usuario que se logee en ese momento
        public void EditarMiPerfil(string NombreUsuario, string ActualContrasena, string NuevaContrasena, string Nombre, string Apellido, string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //PROCEDURE PA_EditarUsuario

                    command.Connection = connection;

                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@ActualContrasena", ActualContrasena);
                    command.Parameters.AddWithValue("@NuevaContrasena", NuevaContrasena);
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@Email", Email);

                    command.CommandText = "EXEC PA_EditarUsuario @NombreUsuario, @ActualContrasena, @NuevaContrasena, @Nombre, @Apellido, @Email";
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                }

            }
        }

        //Metodo para crear un usuario y guardarlo en base de datos
        public void CrearUsuario(int DNI, string NombreUsuario, string Contrasena, string Nombre, string Apellido, string TipoUsuario, string Email, string EstadoUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    //PROCEDURE PA_CrearUsuario

                    command.Parameters.AddWithValue("@DNI",DNI);
                    command.Parameters.AddWithValue("@NombreUsuario",NombreUsuario);
                    command.Parameters.AddWithValue("@Contrasena",Contrasena);
                    command.Parameters.AddWithValue("@Nombre",Nombre);
                    command.Parameters.AddWithValue("@Apellido",Apellido);
                    command.Parameters.AddWithValue("@TipoUsuario",TipoUsuario);
                    command.Parameters.AddWithValue("@Email",Email);
                    command.Parameters.AddWithValue("@EstadoUsuario",EstadoUsuario);

                    command.CommandType = CommandType.Text;
                    command.CommandText = "EXEC PA_CrearUsuario @DNI, @NombreUsuario, @Contrasena, @Nombre, @Apellido, @TipoUsuario, @Email, @EstadoUsuario";

                    command.ExecuteNonQuery();

                }
            }
        }


        public void ActualizarUsuario(int DNI, string NombreUsuario, string NuevaContrasena, string Nombre, string Apellido, string TipoUsuario, string Email, string EstadoUsuario, RadioButton rbSi, RadioButton rbNo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@DNI", DNI);

                    if (rbSi.Checked)
                    {
                        command.Parameters.AddWithValue("@NuevaContrasena", NuevaContrasena);
                    }

                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Apellido", Apellido);
                    command.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@EstadoUsuario", EstadoUsuario);

                    command.CommandType = CommandType.Text;

                    //Si actualiza la contraseña
                    if (rbSi.Checked)
                    {
                        //PROCEDURE PA_ActualizarUsuario_AC

                        command.CommandText = "EXEC PA_ActualizarUsuario_AC @NombreUsuario, @DNI, @NuevaContrasena, @Nombre, @Apellido, @TipoUsuario, @Email, @EstadoUsuario";
                    }

                    //No actualiza la contraseña
                    if (rbNo.Checked)
                    {
                        //PROCEDURE PA_ActualizarUsuario_NAC

                        command.CommandText = "EXEC PA_ActualizarUsuario_NAC @NombreUsuario, @DNI, @Nombre, @Apellido, @TipoUsuario, @Email, @EstadoUsuario";
                    }

                    command.ExecuteNonQuery();

                }
            }


        }

        public void CambiarContrasena(string NuevaContrasena)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@NombreUsuario", ClaseUsuarioCache.NombreUsuario_Cache);
                    command.Parameters.AddWithValue("@NuevaContrasena", NuevaContrasena);
                    command.CommandType = CommandType.Text;

                    command.CommandText = "EXEC PA_CambiarContrasena @NombreUsuario, @NuevaContrasena";
                    command.ExecuteNonQuery();

                }
            }
        }


        public DataTable BuscarUsuario_DataGridView(string Columna, string Valor)
        {
            try
            {
                if (Columna == "DNI") { NombreColumna = "DNI"; }
                else if (Columna == "Nombre de Usuario") { NombreColumna = "NombreUsuario"; }
                else if (Columna == "Nombre") { NombreColumna = "Nombre"; }
                else if (Columna == "Apellido") { NombreColumna = "Apellido"; }
                else if (Columna == "Tipo de Usuario") { NombreColumna = "TipoUsuario"; }
                else if (Columna == "Correo Electrónico") { NombreColumna = "Email"; }
                else if (Columna == "Estado de Usuario") { NombreColumna = "EstadoUsuario"; }

                var connection = GetConnection();
                connection.Open();

                dataTable = new DataTable();

                Command = new SqlCommand("SELECT DNI, NombreUsuario , Nombre, Apellido, TipoUsuario , Email , EstadoUsuario " +
                    "FROM Usuario WHERE " + NombreColumna + " = @Valor", connection);

                Command.Parameters.Add(new SqlParameter("@Valor", Valor));
                Reader = Command.ExecuteReader();
                dataTable.Load(Reader);

                connection.Close();

                return dataTable;
            }
            catch (Exception)
            {
                dataTable = null;
                return null;
            }
        }

        
        public AutoCompleteStringCollection CargaTextBox_Usuario(string Opcion)  //Cargar TextBox con datos de autocompletado
        {
            if (Opcion == "DNI") { NombreColumna = "DNI"; }
            else if (Opcion == "Nombre de Usuario") { NombreColumna = "NombreUsuario"; }
            else if (Opcion == "Nombre") { NombreColumna = "Nombre"; }
            else if (Opcion == "Apellido") { NombreColumna = "Apellido"; }
            else if (Opcion == "Tipo de Usuario") { NombreColumna = "TipoUsuario"; }
            else if (Opcion == "Correo Electrónico") { NombreColumna = "Email"; }
            else if (Opcion == "Estado de Usuario") { NombreColumna = "EstadoUsuario"; }

            DataTable datos = new DataTable();

            var connection = GetConnection();

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            var adapter = new SqlDataAdapter("SELECT DNI, NombreUsuario , Nombre, Apellido, TipoUsuario , Email , EstadoUsuario FROM Usuario", connection);

            // Establecer el tipo de comando en StoredProcedure
            adapter.SelectCommand.CommandType = CommandType.Text;

            adapter.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i][NombreColumna].ToString());
            }

            return lista;
        }

        public DataTable CargaDTG_ActualizarUsuario()
        {
            var connection = GetConnection();
            connection.Open();

            dataTable = new DataTable();
            Command = new SqlCommand("SELECT DNI, NombreUsuario AS 'Nombre de Usuario', Nombre, Apellido, TipoUsuario AS 'Tipo de Usuario', Email AS 'Correo Electrónico', EstadoUsuario AS 'Estado de Usuario' FROM Usuario", connection);
            Reader = Command.ExecuteReader();
            dataTable.Load(Reader);

            connection.Close();

            return dataTable;

        }

        #region Verificaciones de la base de datos
        //Validaciones para verificar si existen los mismos datos en la base de datos

        public bool Valida_ContrasenaActual(TextBox TextBox_ContraActual, ErrorProvider errorProvider)
        {
            errorProvider.Clear();

            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@Contra", TextBox_ContraActual.Text);
                    string contra = command.CommandText = "SELECT Contrasena FROM Usuario WHERE Contrasena = @Contra";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true; //La contraseña ingresada es correcta
                    }
                    else
                    {
                        errorProvider.SetError(TextBox_ContraActual, "Contraseña Incorrecta");
                        return false;
                    }
                }
            }
        }

        public bool Verifica_Si_Existe_DNI_Usuario(string DNI)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@DNI", DNI);
                    string dni = command.CommandText = "SELECT DNI FROM Usuario WHERE DNI = @DNI";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true; //El DNI existe
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool Verifica_Si_Existe_Email(string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@Email", Email);
                    string email = command.CommandText = "SELECT Email FROM Usuario WHERE Email = @Email";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true; //El Email existe
                    }
                    else
                    {
                        return false;
                    }

                    
                }
            }
        }
        public bool Verifica_Si_Existe_NombreUsuario(TextBox TextBox_NombreUsuario)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@NombreUsuario", TextBox_NombreUsuario.Text);
                    string nombreusuario = command.CommandText = "SELECT NombreUsuario FROM Usuario WHERE NombreUsuario = @NombreUsuario";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true; //El Nombre de Usuario existente
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        #endregion Verificaciones de la base de datos



    }
}
