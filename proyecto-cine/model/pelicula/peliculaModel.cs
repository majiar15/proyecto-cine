using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.model.pelicula
{
    class peliculaModel 
    {

        public int  id;
        private string nombre;
        private string categoria;
        private string descripcion;
        private string duracion;
        private string imagen_nombre;
        private byte[] foto;
        conexiondb conexion = new conexiondb();
        SqlCommand comando;
        DataSet DS;
        DataRow DR;

        public peliculaModel(string nombre = "", string categoria = "", string descripcion = "", string duracion = "", string imagen_nombre = "", byte[] foto= null)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen_nombre = imagen_nombre;
            this.duracion = duracion;
            this.foto = foto;
        }

        

        public void crearPelicula() {
            try
            {
                conexion.abrir();
                string query = "INSERT INTO peliculas (nombre,categoria,descripcion,duracion,imagen_nombre,imagen) VALUES ('" + nombre + "','" + categoria + "','" + descripcion + "','" + duracion + "','" + imagen_nombre + "',@imagen);";
                comando = new SqlCommand(query, conexion.conexion);
                //comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("imagen", foto);
                comando.ExecuteNonQuery();
                MessageBox.Show("Guardado con exito");
                conexion.cerra();
                
            }
            catch (Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }

        }
        public void actualizarPelicula(int id)
        {
            try
            {
                conexion.abrir();
                
                string query = "UPDATE peliculas  SET nombre='" + nombre + "',categoria='" + categoria + "',descripcion='" + descripcion + "',duracion='" + duracion + "',imagen=@imagen) where id = "+id+";";
                comando = new SqlCommand(query, conexion.conexion);
                //comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("imagen", foto);
                comando.ExecuteNonQuery();
                MessageBox.Show("Guardado con exito");
                conexion.cerra();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }
        }
        public void eliminarPelicula(int id)
        {
            try
            {
                conexion.abrir();
                string query = "DELETE FROM peliculas WHERE id='" + id + "';";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                conexion.cerra();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se elimino la pelicula" + e.ToString());
            }
        }
        public DataTable consultarPelicula()
        {
            conexion.abrir();
            string query = "SELECT id,nombre, categoria, descripcion, duracion FROM peliculas;";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];

        }
        public DataTable buscar(string buscar)
        {
            
            string query = "select * from peliculas where nombre like '%" + buscar + "%'";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];
        }




        public void consultaImagen(PictureBox imagen)
        {
            conexion.abrir();
            string query = "SELECT imagen FROM peliculas WHERE nombre='"+nombre+"';";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "imagen");
            byte[] datos = new byte[0];
            DR = DS.Tables["imagen"].Rows[0];
            datos = (byte[])DR["imagen"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            imagen.Image = System.Drawing.Bitmap.FromStream(ms);
            conexion.cerra();
            

        }

    }
}
