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
        string dataConexion = "Data Source=DESKTOP-FVDIRBH;Initial Catalog=cine; Integrated security=true";
        SqlConnection conexion;

        

        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.dataConexion);
            return conexion;
        }
        
        
        public bool ejecutarComando(string strComando)
        {
            try
            {
                
                SqlCommand comando = new SqlCommand();
                comando.CommandText = strComando;
                comando.Connection = this.EstablecerConexion();
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public DataSet consultarCliente(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            try
            {
                SqlCommand comando = new SqlCommand();
                comando = sqlComando;
                comando.Connection = EstablecerConexion();
                Adaptador.SelectCommand = comando;
                conexion.Open();
                Adaptador.Fill(DS);
                conexion.Close();
                return DS;
            }
            catch
            {
                return DS;
            }
            
        }

    }
}
