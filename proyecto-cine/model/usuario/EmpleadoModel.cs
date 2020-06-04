using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proyecto_cine.Model.usuario
{
    abstract class EmpleadoModel : UsuarioModel
        {
            long telefono;
            string contraseña;

            public long Telefono { get => telefono; set => telefono = value; }
            public string Contraseña { get => contraseña; set => contraseña = value; }

            protected abstract void Vender();
            protected abstract void Rervar();
            protected abstract void ConsultarCartelera();
            protected abstract void isAdmin();
            protected abstract void Login();
            protected abstract void Loguot();
    }
}
