using proyecto_cine.Model.usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.controller
{
    class CajeroController
    {
        public CajeroController()
        {
            
        }

        public void crearCajero(long id, int cargo, string nombre, string apellido, long telefono, string email, string contraseña) {
            CajeroModel cajeroModel = new CajeroModel(id, cargo ,nombre, apellido, telefono, email, contraseña);

            cajeroModel.conexion.Open();

            cajeroModel.crearCajero();
            GuardadoConExito guardado = new GuardadoConExito(new homeCajero(), "cajero");
            guardado.Show();

        }

        public DataTable consultarCajero()
        {
            CajeroModel cajero = new CajeroModel();
            return cajero.consultarCajero();
            
        }

        public DataTable BuscarCajero(string id)
        {
            CajeroModel cajeroBus = new CajeroModel();
            return cajeroBus.Buscar(id);
        }

        public bool EliminarCajero(string id)
        {
            CajeroModel eliminarCaje = new CajeroModel();
            return eliminarCaje.eliminarCajero(id);
        }

        public void Actualizar(long id, int cargo, string nombre, string apellido, long telefono, string email, string contraseña)
        {
            CajeroModel cajero = new CajeroModel(id, cargo, nombre, apellido, telefono, email, contraseña);
            cajero.actualizarCajero();
        }
    }
}
