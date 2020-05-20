using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace proyecto_cine
{
    class cajero
    {
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;
        public DataTable MostrarDatos()
        {
            
            conexion.abrir();
            cmd = new SqlCommand("select * from empleados", conexion.conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.cerra();
            return ds.Tables["tabla"];
        }


        

        public DataTable Buscar(string id)
        {
            conexiondb conexion = new conexiondb();
            conexion.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select * from empleados where id like '%{0}%'", id), conexion.conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.cerra();
            return ds.Tables["tabla"];
        }

        public void crearCajero(int id, int cargo, string nombre, string apellido, string telefono, string email, string contraseña)

        {
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("Insert into empleados (id,cargo_id,nombre,apellidos,telefono,email,contraseña) values (" + id + ","+cargo+",'" + nombre+"', '"+ apellido + "', "+telefono+",'"+email+"','"+contraseña+ "')" , conexion.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente registrado");
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo insertar los datos " + e.ToString()); ;
            }
       
           
        }

        public void modificar()
        {

        }

        public void eliminar()
        {

        }

        
    }
}
