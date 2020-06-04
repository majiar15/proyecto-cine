using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace proyecto_cine
{
    class conexiondb
    {

        string dataConexion = "Data Source=DESKTOP-FVDIRBH;Initial Catalog=cine; Integrated security=true";

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
                MessageBox.Show("test");
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("test : "+ ex.Message);
                Console.WriteLine("Error al Abrir la DB" + ex.Message);
            }
        }
        public void cerra()
        {
            conexion.Close();
        }
    }
}
