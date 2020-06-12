using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.model.pelicula;

namespace proyecto_cine.controller
{
    class PeliculaController
    {
        homeCajero formParent;

        public PeliculaController(homeCajero formParent)
        {
            this.formParent = formParent;
        }

        public string[] getPeliculaPorId(int id ) {
            peliculaModel model = new peliculaModel();
            return model.getPeliculaPorId(id);
        }

        public void crear(string nombre, string categoria, string descripcion, string duracion, string imagen_nombre, byte[] foto)
        {
            //validamos si se los datos son correctos
            if (nombre.Length != 0 && categoria.Length != 0 && descripcion.Length != 0 && duracion.Length != 0 && imagen_nombre.Length != 0 && foto.Length != 0)
            {
                //instanciamos modelo con datos del textBox
                peliculaModel modelo = new peliculaModel(nombre, categoria, descripcion, duracion, imagen_nombre, foto);

                modelo.crearPelicula();

                GuardadoConExito succes = new GuardadoConExito(formParent, "pelicula");
                succes.Show();

            }
            else
            {
                ErrorAlGuardar err = new ErrorAlGuardar();
                err.Show();
            }

        }
        public DataTable mostrarTabla()
        {
            peliculaModel modelo = new peliculaModel();
            return modelo.consultarPelicula();
        }
        public void modificar(string id,string nombre, string categoria, string descripcion, string duracion)
        {
            //validamos si se los datos son correctos
            if (nombre.Length != 0 && nombre.Length != 0 && categoria.Length != 0 && descripcion.Length != 0 && duracion.Length != 0)
            {
                //instanciamos modelo con datos del textBox
                peliculaModel modelo = new peliculaModel(nombre, categoria, descripcion, duracion);

                modelo.actualizarPelicula(int.Parse(id));

                GuardadoConExito succes = new GuardadoConExito(formParent, "pelicula");
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

            new Confirmacion(formParent, id, "eliminarPelicula").Show();

        }
        public void eliminar(int id) {

            peliculaModel modelo = new peliculaModel();
            modelo.eliminarPelicula(id);
            formParent.OpenFormInPanelCentral(new Peliculas(formParent));

        }
        public DataTable buscarPelicula(string buscar)
        {

            
            peliculaModel modelo = new peliculaModel();


            return modelo.buscar(buscar);

        }

    }
}

