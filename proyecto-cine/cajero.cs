using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace proyecto_cine
{
    class cajero
    {
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexiondb conexion = new conexiondb();
            conexion.abrir();
            SqlCommand cmd = new SqlCommand("select * from empleados", conexion.conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.cerra();
            return ds.Tables["tabla"];
        }

        public void crearCajero()
        {
                
       
           
        }

        public void modificar()
        {

        }

        public void eliminar()
        {

        }

        public void mostrar()
        {

        }
    }
}
