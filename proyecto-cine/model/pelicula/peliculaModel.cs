using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private byte[] foto;
        conexiondb conexion = new conexiondb();
        SqlCommand comando;
        DataSet DS;
        DataRow DR;

        public peliculaModel(string nombre = "", string categoria = "", string descripcion = "", string duracion = "", byte[] foto= null)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.descripcion = descripcion;
           
            this.duracion = duracion;
            this.foto = foto;
        }


        public Image getPeliculaPorId(int id) {
            this.id = id;
            conexion.abrir();
            string query = "SELECT * FROM peliculas WHERE id =" + id;
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter dp = new SqlDataAdapter(comando);
            DataSet ds = new DataSet("peliculas");
            byte[] misDatos = new byte[0];
            dp.Fill(ds, "peliculas");
            DataRow myRow = ds.Tables["peliculas"].Rows[0];
            misDatos = (byte[])myRow["imagen"];
            MemoryStream ms = new MemoryStream(misDatos);
            //SqlDataReader lector = comando.ExecuteReader();
            //string[] result = new string[6];
            //Console.WriteLine(lector.GetValue(0).ToString());
            //for (int i = 0; i < 7; i++) {
            //    result[i] = lector.GetValue(i).ToString();
            //}

            //conexion.cerra();
            return Image.FromStream(ms);
        }
        public void crearPelicula() {
            try
            {
                conexion.abrir();
                string query = "INSERT INTO peliculas (nombre,categoria,descripcion,duracion,imagen) VALUES ('" + nombre + "','" + categoria + "','" + descripcion + "','" + duracion + "',@imagen);";
                comando = new SqlCommand(query, conexion.conexion);
                //comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("imagen", foto);
                comando.ExecuteNonQuery();
                
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
                
                string query = "UPDATE peliculas  SET nombre='" + nombre + "',categoria='" + categoria + "',descripcion='" + descripcion + "',duracion='" + duracion + "',imagen=@imagen WHERE id = "+id+";";
                comando = new SqlCommand(query, conexion.conexion);
                //comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("imagen", foto);
                comando.ExecuteNonQuery();
                
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
            string query = "SELECT id,nombre, categoria, duracion, descripcion FROM peliculas;";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];

        }
        public DataTable buscar(int id)
        {
            this.id = id;
            string query = "select id,nombre, categoria, descripcion, duracion from peliculas where id like '%" + id + "%'";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];
        }




        //public void consultaImagen(PictureBox imagen)
        //{
        //    conexion.abrir();
        //    string query = "SELECT imagen FROM peliculas WHERE nombre='"+nombre+"';";
        //    comando = new SqlCommand(query, conexion.conexion);
        //    SqlDataAdapter Adaptar = new SqlDataAdapter();
        //    Adaptar.SelectCommand = comando;
        //    DS = new DataSet();
        //    Adaptar.Fill(DS, "imagen");
        //    byte[] datos = new byte[0];
        //    DR = DS.Tables["imagen"].Rows[0];
        //    datos = (byte[])DR["imagen"];
        //    System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
        //    imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        //    conexion.cerra();
            

        //}

    }
}
