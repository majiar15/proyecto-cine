using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using proyecto_cine.Models;


namespace proyecto_cine
{
    class conexiondb
    {

        string dataConexion = "Data Source=DESKTOP-43N4I97;Initial Catalog=cine; Integrated security=true";

        public SqlConnection conexion = new SqlConnection();

        public conexiondb()
        {
            conexion.ConnectionString = dataConexion;
        }

        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Abrir la DB" + ex.Message);
            }
        }
        public void cerra()
        {
            conexion.Close();
        }
    }
}
