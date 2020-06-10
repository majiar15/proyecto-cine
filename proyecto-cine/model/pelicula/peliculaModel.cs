using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.model.pelicula
{
    class peliculaModel 
    {
        private string nombre;
        private string categoria;
        private string descripcion;
        private string duracion;
        private string imagen_nombre;
        conexiondb conexion = new conexiondb();
        SqlCommand comando;

        public peliculaModel(string nombre, string categoria, string descripcion, string duracion, string imagen_nombre)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen_nombre = imagen_nombre;
            this.duracion = duracion;
        }

        public void crearPelicula() {
            try
            {
                conexion.abrir();
                string query = "insert into pelicula (id,nombre,categoria,descripcion,duracion,imagen_nombre) values (NULL,'" + nombre + "','" + categoria+ "','" + descripcion + "'," + duracion + "'" +"'," + imagen_nombre+"');";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                conexion.cerra();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }

        }
        public void actualizarPelicula()
        {

        }
        public void eliminarPelicula()
        {

        }
        public void consultarPeliculas()
        {

        }



    }
}
