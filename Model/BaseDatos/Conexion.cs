using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Model
{
    public class Conexion
    {
        SqlConnection conectar;
        //string conexion = "Server = negociofarmacia.database.windows.net; database = farmacia; uid = administrador; pwd = Farmacia1";
        string cadConexion = "Server=tcp:negociofarmacia.database.windows.net,1433;Initial Catalog=farmacia;Persist Security Info=False;User ID=administrador;Password=Farmacia1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Conexion() {
            conectar = new SqlConnection(cadConexion);
        }

        public void conectarBD()
        {
            conectar.Open();
        }

        public void cerrarBD()
        {
            conectar.Close();
        }

        //public DataTable registro ()
        //{

        //    return ;
        //}

    }
}
