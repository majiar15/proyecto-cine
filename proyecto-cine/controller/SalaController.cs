using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_cine.model.sala;
using System.Windows.Forms;
using proyecto_cine.views.salas;
using System.Data;

namespace proyecto_cine.controller
{
    class SalaController
    {

        homeCajero formParent;
        public SalaController(homeCajero formParent)
        {
            this.formParent = formParent;
        }

        public void crear(string nombre = "", int sala_id = 0)
        {
            //validamos si se los datos son correctos
            if (nombre.Length != 0)
            {
                //instanciamos modelo con datos del textBox
                SalaModel modelo = new SalaModel(nombre, sala_id);
                modelo.crearSala();

                GuardadoConExito succes = new GuardadoConExito(formParent, "sala");
                succes.Show();

            }
            else
            {
                ErrorAlGuardar err = new ErrorAlGuardar();
                err.Show();
            }

        }


        public void modificar(int id, string nombre, int sala_id)
        {
            if (nombre.Length != 0 )
            {
                //instanciamos modelo con datos del textBox
                SalaModel modelo = new SalaModel(nombre,sala_id);
                modelo.actualizarSala(id);

                ModificacionExitosa succes = new ModificacionExitosa(formParent, "modificarSala");
                succes.Show();

            }
            else
            {
                ErrorAlGuardar err = new ErrorAlGuardar();
                err.Show();
            }

        }



        public void confirmarEliminacion(int id)
        {

            new Confirmacion(formParent, id, "eliminarSala").Show();

        }

        public void eliminar(int id)
        {
            SalaModel modelo = new SalaModel();
            modelo.eliminarPelicula(id);
            formParent.OpenFormInPanelCentral(new Salas(formParent));
        }


        public DataTable mostrarTabla()
        {
            SalaModel modelo = new SalaModel();
            return modelo.consultarSalas();
        }


        public DataTable buscarSala(string buscar)
        {

            SalaModel modelo = new SalaModel();

            
            
            return modelo.buscar(int.Parse(buscar));

        }


    }
}
