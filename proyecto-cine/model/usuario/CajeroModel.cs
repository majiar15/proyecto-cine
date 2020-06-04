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
        private void eliminarCajero() { }
        private void actualizarCajero() { }
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
