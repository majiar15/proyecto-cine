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
        homeCajero formParent;
        public CajeroController(homeCajero formParent)
        {
            this.formParent = formParent;
        }

        public void crearCajero(long id, int cargo, string nombre, string apellido, long telefono, string email, string contraseña) {
            CajeroModel cajeroModel = new CajeroModel(id, cargo ,nombre, apellido, telefono, email, contraseña);

            cajeroModel.conexion.Open();

            cajeroModel.crearCajero();
            GuardadoConExito guardado = new GuardadoConExito(formParent, "cajero");
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

        public void EliminarCajero(int id)
        {
            CajeroModel modelo = new CajeroModel();
            modelo.eliminarCajero(id);
            
        }

        public void Actualizar(long id, int cargo, string nombre, string apellido, long telefono, string email, string contraseña)
        {
            CajeroModel cajero = new CajeroModel(id, cargo, nombre, apellido, telefono, email, contraseña);
            cajero.actualizarCajero();

            ModificacionExitosa modificar = new ModificacionExitosa(formParent, "Cajeros");
            modificar.Show();

        }

        public void confirmarEliminacion(int id)
        {
            new Confirmacion(formParent, id, "eliminarCajero").Show();
        }

    }
}
