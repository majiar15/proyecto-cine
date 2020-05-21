using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_cine.Models;

namespace proyecto_cine.controllers
{
    class Cliente
    {
        private Clientedb cliente = new Clientedb();
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int cedula { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

        public void modificar(string nombre, string apellido, int cedula, string email, string direccion)
        {
            cliente.Modificardb(nombre, apellido, Convert.ToInt32(cedula), email, direccion);
        }
    
    }
}
