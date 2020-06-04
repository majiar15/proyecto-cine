using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.Model.usuario;


namespace proyecto_cine.controller
{
    class ClienteController
    {
        homeCajero formParent;
        public ClienteController(homeCajero formParent)
        {
            this.formParent = formParent;
        }

        public void crear( int id , string nombre, string apellidos, string email, string direccion, int descueento ) {
            //validamos si se los datos son correctos
            if (nombre.Length != 0 && apellidos.Length != 0 && email.Length != 0 && direccion.Length != 0)
            {
                //instanciamos modelo con datos del textBox
                ClienteModel cliente = new ClienteModel(id, nombre, apellidos, email, direccion, descueento);
                cliente.crearCliente();
                
                GuardadoConExito succes = new GuardadoConExito(formParent, "cliente");
                succes.Show();

            }
            else {
                ErrorAlGuardar err = new ErrorAlGuardar();
                err.Show();
            }




        }
    }
}
