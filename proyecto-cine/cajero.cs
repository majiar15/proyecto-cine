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
        public homeCajero FormParent;

        public cajero(homeCajero formParent)
        {
            FormParent = formParent;
        }

        public DataTable MostrarDatos()
        {
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("select * from empleados", conexion.conexion);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "tabla");
                conexion.cerra();
                return ds.Tables["tabla"];
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return ds.Tables["tabla"];
            }
            
        }


        

        public DataTable Buscar(string id)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return ds.Tables["tabla"];
            }
        }

        public void crearCajero(int id, int cargo, string nombre, string apellido, string telefono, string email, string contraseña)

        {
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("Insert into empleados (id,cargo_id,nombre,apellidos,telefono,email,contraseña) values (" + id + ","+cargo+",'" + nombre+"', '"+ apellido + "', "+telefono+",'"+email+"','"+contraseña+ "')" , conexion.conexion);
                cmd.ExecuteNonQuery();
                GuardadoConExito guardado = new GuardadoConExito(FormParent,"cajero");
                guardado.Show();
            }
            catch (Exception e)
            {
                ErrorAlGuardar error = new ErrorAlGuardar();
                error.Show();
                Console.WriteLine("No se pudo insertar los datos, error: " + e.ToString()); ;
            }
       
           
        }

        public void modificar(int id, int cargo, String nombres, String apellidos, int telefono, String email, String contraseña)
        {
            try
            {
                conexiondb conexion = new conexiondb();
                conexion.abrir();
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE empleados set id = " + id + ", cargo_id = " + cargo + ", nombre = '" + nombres + "',apellidos = '" + apellidos + "',telefono = " + telefono + ",email = '" + email + "',contraseña= '" + contraseña + "' where id = " + id + ""), conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();
                GuardadoConExito guardado = new GuardadoConExito(FormParent,"cajero");
                guardado.Show();
            }
            catch (Exception e)
            {
                ErrorAlGuardar error = new ErrorAlGuardar();
                error.Show();
                Console.WriteLine("No se pudo actualizar la informacion, error: " + e);
            }
            
        }

        public bool Eliminar(string id)
        {
            try
            {
                conexiondb conexion = new conexiondb();
                conexion.abrir();
                SqlCommand cmd = new SqlCommand(string.Format("delete from empleados where id = {0}", id), conexion.conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.cerra();
                if (filasafectadas > 0) return true;
                else return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
