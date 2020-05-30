using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_cine.Model.usuario
{
    class CajeroModel : EmpleadoModel
    {
        string cargo;

        public CajeroModel(string nombre , string apellidos, string email, string contraseña, int telefono, string cargo)
        {
            
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.Contraseña = contraseña;
            this.Telefono = telefono;
            this.cargo = cargo;
        }

        private void crearCajero() {
            this.conexion.Open();
             string insert = "INSERT INTO empleado VALUE('"+Nombre+"', '"+ Email + "')";
            
        
        }
        private void eliminarCajero() { }
        private void actualizarCajero() { }
        private void consultarCajero() { }
        private void CrearCajeros() { }

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
