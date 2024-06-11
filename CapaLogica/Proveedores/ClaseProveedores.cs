using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDB;

namespace CapaLogica.Proveedores
{
    public class ClaseProveedores : ConexionSQL
    {
        private SqlCommand Command;
        private SqlDataReader Reader;
        private DataTable dataTable;

        //Metodo para crear nuevo proveedor
        public void CrearProveedor(string CUIT, string NombreProveedor, string Domicilio, string Email, string Telefono, ComboBox cmbCondicionIVA, RadioButton rbFisica, RadioButton rbJuridica)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;

                    command.Parameters.AddWithValue("@CUIT", CUIT);
                    command.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
                    command.Parameters.AddWithValue("@Domicilio", Domicilio);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Telefono", Telefono);

                    byte CodIVA = 0;              
                    if (cmbCondicionIVA.Text == "Consumidor Final")
                    {
                        CodIVA = 1;
                    }
                    else if(cmbCondicionIVA.Text == "Monotributista")
                    {
                        CodIVA = 2;
                    }
                    else if(cmbCondicionIVA.Text == "Responsable Inscripto")
                    {
                        CodIVA = 3;
                    }
                    command.Parameters.AddWithValue("@CodIVA", CodIVA);

                    byte CodTipoPersona = 0;

                    if (rbFisica.Checked)
                    {
                        CodTipoPersona = 1;
                    }

                    if (rbJuridica.Checked)
                    {
                        CodTipoPersona = 2;
                    }

                    command.Parameters.AddWithValue("@CodTipoPersona", CodTipoPersona);

                    command.CommandText = "EXEC PA_CrearProveedor @CUIT, @NombreProveedor, @Domicilio, @Email, @Telefono, @CodIVA, @CodTipoPersona";

                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                }
            }
        }


        public void ActualizarProveedor(string CUIT, string NombreProveedor, string Domicilio, string Email, string Telefono, RadioButton rbFisica, RadioButton rbJuridica)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;

                    command.Parameters.AddWithValue("@CUIT", CUIT);
                    command.Parameters.AddWithValue("@NombreProveedor", NombreProveedor);
                    command.Parameters.AddWithValue("@Domicilio", Domicilio);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Telefono", Telefono);

                    if (rbFisica.Checked)
                    {
                        command.CommandText = "EXEC PA_ActualizarProveedor @CUIT, @NombreProveedor, @Domicilio, @Email, @Telefono, 1";
                    }

                    if (rbJuridica.Checked)
                    {
                        command.CommandText = "EXEC PA_ActualizarProveedor @CUIT, @NombreProveedor, @Domicilio, @Email, @Telefono, 2";
                    }

                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                }
            }
        }

        public void BorrarProveedor(string CUIT)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    #region Procedimiento Borrar Proveedor
                    //CREATE PROCEDURE PA_BorrarProveedor
                    //@CUIT NVARCHAR(13)
                    // AS
                    //DELETE FROM Proveedores WHERE CUIT = @CUIT;
                    #endregion

                    command.Connection = connection;

                    command.Parameters.AddWithValue("@CUIT", CUIT);

                    command.CommandText = "EXEC PA_BorrarProveedor @CUIT";

                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarProveedor_DataGridView(string Columna, string Valor)
        {
            if (Columna == "CUIT") { NombreColumna = "CUIT"; }
            else if (Columna == "Nombre Proveedor") { NombreColumna = "NombreProveedor"; }
            else if (Columna == "Correo Electrónico") { NombreColumna = "Email"; }
            else if (Columna == "Domicilio") { NombreColumna = "Domicilio"; }
            else if (Columna == "Teléfono") { NombreColumna = "Telefono"; }

            var connection = GetConnection();
            connection.Open();

            dataTable = new DataTable();

            Command = new SqlCommand("SELECT P.CUIT, P.NombreProveedor as 'Nombre Proveedor', P.Domicilio, P.Email as 'Correo Electrónico', P.Telefono as 'Teléfono', P.CodTipoPersona FROM Proveedores AS P WHERE " + NombreColumna + " = @Valor", connection);
            Command.Parameters.AddWithValue("@Valor", Valor);
            Reader = Command.ExecuteReader();
            dataTable.Load(Reader);

            connection.Close();

            return dataTable;
        }

        string NombreColumna;
        public AutoCompleteStringCollection CargaTextBox_Proveedor(string Opcion)  //Cargar TextBox con datos de autocompletado
        {
            if (Opcion == "CUIT") { NombreColumna = "CUIT"; }
            else if (Opcion == "Nombre Proveedor") { NombreColumna = "NombreProveedor"; }
            else if (Opcion == "Correo Electrónico") { NombreColumna = "Email"; }
            else if (Opcion == "Domicilio") { NombreColumna = "Domicilio"; }
            else if (Opcion == "Teléfono") { NombreColumna = "Telefono"; }

            DataTable datos = new DataTable();

            var connection = GetConnection();

            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            var adapter = new SqlDataAdapter("SELECT * from Proveedores", connection);

            // Establecer el tipo de comando en StoredProcedure
            adapter.SelectCommand.CommandType = CommandType.Text;

            adapter.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i][NombreColumna].ToString());
            }

            return lista;
        }

        public DataTable CargaDTG_Proveedores()
        {
            var connection = GetConnection();
            connection.Open();

            dataTable = new DataTable();
            Command = new SqlCommand("SELECT P.CUIT, P.NombreProveedor as 'Nombre Proveedor', P.Domicilio, P.Email as 'Correo Electrónico', P.Telefono as 'Teléfono', P.CodTipoPersona FROM Proveedores AS P", connection);
            Reader = Command.ExecuteReader();
            dataTable.Load(Reader);

            connection.Close();
            return dataTable;
        }
        //
        public bool Valida_Si_Existe_CUIT(string CUIT)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@CUIT", CUIT);
                    string cuit = command.CommandText = "SELECT CUIT FROM Proveedores WHERE CUIT = @CUIT";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true; //El CUIT ya existe
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}
