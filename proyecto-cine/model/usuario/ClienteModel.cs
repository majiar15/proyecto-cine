using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace proyecto_cine.Model.usuario
{
    class ClienteModel : UsuarioModel
    {
        string direccion;
        int descuento;
        conexiondb conexion;
        SqlCommand comando;
        DataSet DS;
      
        public ClienteModel(int cedula, string nombre, string apellidos, string email, string direccion, int descuento) {
            this.Id = cedula;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Email = email;
            this.direccion = direccion;
            this.descuento = descuento;
            conexion = new conexiondb();
            

        }


        public void crearCliente() {
            try
            {
                conexion.abrir();
                string query = "insert into cliente values (" + Id + ",'" + Nombre + "','" + Apellidos + "','" + Email + "'," + descuento + ",'" + direccion + "');";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                conexion.cerra();
            }
            catch(Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }
            



        }
        public void eliminarCliente() {
            try
            {
                conexion.abrir();
                string query = "DELETE FROM cliente WHERE id='"+Id+"';";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                conexion.cerra();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se elimino el datos" + e.ToString());
            }
        }
        public void actualizarCliente() {
            try
            {
                conexion.abrir();
                string query = "UPDATE cliente  SET nombre='"+Nombre+"', apellidos='"+Apellidos+"',descuento='"+descuento+"',direccion='"+direccion+"',email='"+Email+"' WHERE id='"+Id+"';";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                conexion.cerra();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }
        }
        public DataTable consultarCliente() {
            conexion.abrir();
            string query = "SELECT * FROM cliente;";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["tabla"];

        }
        public DataTable buscar()
        {
            string query = "select * from cliente where id like '%" + Id + "%'";
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

