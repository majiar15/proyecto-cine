using proyecto_cine.Model.usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proyecto_cine.controller
{
    class CajeroController
    {
        
        public CajeroController() {
        
        }

        public void crear(string nombre, string apellidos, string email, string contraseña, int telefono) {
            CajeroModel cajero = new CajeroModel(nombre, apellidos, email, contraseña, telefono, "cajero");

            cajero.conexion.Open();

            //cajero.crearCajero();

            homeCajero home = new homeCajero();
            home.Show();
        }
    }
}
