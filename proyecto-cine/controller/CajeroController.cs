using proyecto_cine.Model.usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proyecto_cine.controller
{
    class CajeroController
    {

        public CajeroController()
        {
        }

        public void crearCajero(long id, int cargo, string nombre, string apellido, long telefono, string email, string contraseña) {
            CajeroModel cajero = new CajeroModel(id, cargo ,nombre, apellido, telefono, email, contraseña);

            cajero.conexion.Open();

            cajero.crearCajero(id, cargo, nombre, apellido, telefono, email, contraseña);

        }

        public DataTable consultarCajero()
        {
            CajeroModel cajero = new CajeroModel(1,1,"nombre","apellido", 11, "","");
            return cajero.consultarCajero();
            
        }

        public DataTable BuscarCajero(string id)
        {
            CajeroModel cajeroBus = new CajeroModel(1, 1, "", "", 1, "", "");
            return cajeroBus.Buscar(id);
        }

        public bool EliminarCajero(string id)
        {
            CajeroModel eliminarCaje = new CajeroModel(1, 1, "", "", 1, "", "");
            return eliminarCaje.eliminarCajero(id);
        }
    }
}
