using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_cine.Model.usuario
{
    abstract class UsuarioModel : conexiondb
    {
        private string nombre, apellidos, email;
        private long id;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public long Id { get => id; set => id = value; }
    }
}
