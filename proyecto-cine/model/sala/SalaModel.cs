using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine.model.sala
{
    class SalaModel
    {
        private  string nombre;
        private  int sede_id;

        conexiondb conexion = new conexiondb();
        SqlCommand comando;
        DataSet DS;
        DataRow DR;
        public SalaModel(string nombre ="" , int sede_id = 0) {
            this.nombre = nombre;
            this.sede_id = sede_id;

        }

        public void crearSala()
        {
            try
            {
                conexion.abrir();
                string query = "INSERT INTO sala (nombre,sede_id) VALUES ('" + nombre + "'," + sede_id + ");";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();

                conexion.cerra();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }
        }
        public void actualizarSala(int id)
        {
            try
            {
                conexion.abrir();

                string query = "UPDATE sala  SET nombre='" + nombre + "',sede_id= " + sede_id +" where id ="+id+";";
                comando = new SqlCommand(query, conexion.conexion);
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
                string query = "DELETE FROM sala WHERE id='" + id + "';";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                conexion.cerra();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se elimino la pelicula" + e.ToString());
            }
        }



        public DataTable consultarSalas()
        {
            conexion.abrir();
            string query = "SELECT id,nombre, sede_id FROM sala;";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];

        }


        public DataTable buscar(int busqueda)
        {

            conexion.abrir();
            string query = "select id,nombre, sede_id from sala where id like '%" + busqueda+ "%'";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];
        }



    }
}
