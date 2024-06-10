using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDB
{
    public class ConexionSQL
    {
        private readonly string strConexion;

        public ConexionSQL()
        {
            strConexion = "Server=PAVILION_GTX\\FRANCOSQL; DataBase = DBNegocio; integrated security = true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(strConexion);
        }

    }
}
