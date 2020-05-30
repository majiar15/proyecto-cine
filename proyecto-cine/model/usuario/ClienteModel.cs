using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_cine.Model.usuario
{
    class ClienteModel : UsuarioModel
    {
        string direccion;
        int descuento;
        public ClienteModel(string nombre, string apellidos, string email, string direccion, int descuento) {

            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.direccion = direccion;
            this.descuento = descuento;

        }


        public void crearCliente() { }
        public void emilinarCliente() { }
        public void actualizarCliente() { }
        public void consultarCliente() { }
        

    }
}
