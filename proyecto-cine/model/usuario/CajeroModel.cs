using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace proyecto_cine.Model.usuario
{
    class CajeroModel : EmpleadoModel
    {
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;
        int Cargo;

        public CajeroModel(long id, int cargo, string nombre , string apellidos, long telefono, string email, string contraseña)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.Contraseña = contraseña;
            this.Telefono = telefono;
            this.Cargo = cargo;
        }
        public CajeroModel()
        {

        }

        public void crearCajero(long id, int cargo, string nombre, string apellido, long telefono, string email, string contraseña) {
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("Insert into empleados (id,cargo_id,nombre,apellidos,telefono,email,contraseña) values (" + id + "," + cargo + ",'" + nombre + "', '" + apellido + "', " + telefono + ",'" + email + "','" + contraseña + "')", conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();

                GuardadoConExito guardado = new GuardadoConExito(new homeCajero(), "cajero");
                guardado.Show();
            }
            catch (Exception e)
            {
                ErrorAlGuardar error = new ErrorAlGuardar();
                error.Show();
                Console.WriteLine("No se pudo insertar los datos, error: " + e.ToString()); ;
            }

        }


        public bool eliminarCajero(string id)
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
            catch (Exception)
            {
                return false;
            }
        }


        public void actualizarCajero(long id, int cargo, string nombres, string apellidos, long telefono, string email, string contraseña)
        {
            try
            {
                conexiondb conexion = new conexiondb();
                conexion.abrir();
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE empleados set id = " + id + ", cargo_id = " + cargo + ", nombre = '" + nombres + "',apellidos = '" + apellidos + "',telefono = " + telefono + ",email = '" + email + "',contraseña= '" + contraseña + "' where id = " + id + ""), conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();
            }
            catch (Exception e)
            {
                ErrorAlGuardar error = new ErrorAlGuardar();
                error.Show();
                Console.WriteLine("No se pudo actualizar la informacion, error: " + e);
            }
        }


        public DataTable consultarCajero() 
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


        protected override void ConsultarCartelera()
        {
          
        }

        protected override void isAdmin()
        {
    
        }

        protected override void Login()
        {
       
        }

        protected override void Loguot()
        {
          
        }

        protected override void Rervar()
        {
           
        }

        protected override void Vender()
        {
        
        }

    }
}
