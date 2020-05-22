using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using proyecto_cine.controllers;


namespace proyecto_cine.Models
{
    class Clientedb
    {
        conexiondb conexion;
        SqlCommand comando;
        private DataSet DS;
        public Clientedb()
        {
            conexion = new conexiondb();
        }

        public void Agregar(Cliente nclientes,homeCajero formParent)
        {
            try
            {

                conexion.abrir();
                string query = "INSERT INTO cliente (id,nombre,apellidos,email,direccion) VALUES('" + nclientes.cedula + "','" + nclientes.nombre + "','" + nclientes.apellidos + "','" + nclientes.email + "','" + nclientes.direccion + "')";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                new GuardadoConExito(formParent,"cliente").Show();
                conexion.cerra();
            }
            catch (Exception e)
            {
                new ErrorAlGuardar().Show();
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }

        }
        public void Modificardb(Cliente nCliente, homeCajero formParent)
        {
            try
            {
                conexion.abrir();
                string query = "update cliente set nombre='" + nCliente.nombre + "',apellidos='" + nCliente.apellidos + "', direccion='" + nCliente.direccion + "', email='" + nCliente.email + "' where id='" + nCliente.cedula + "'";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                new ModificacionExitosa(formParent).Show();
                
            }
            catch 
            {
                new ErrorAlGuardar("modificar").Show();
                //MessageBox.Show("Cliente no se modifico" + e.ToString());
            }
        }

        public void Eliminar(int id, homeCajero formParent)
        {
            try
            {
                conexion.abrir();
                string query = "delete from cliente where id='" + id + "'";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                new EliminadoCorrectamente(formParent).Show();
            }
            catch 
            {
                new ErrorAlGuardar("eliminar").Show();
               // MessageBox.Show("Cliente no se elimino" + e.ToString());
            }
        }
        public DataTable MostrarConsulta()
        {
            conexion.abrir();
            string query = "SELECT * FROM cliente";
            comando = new SqlCommand(query, conexion.conexion);
            SqlDataAdapter Adaptar = new SqlDataAdapter();
            Adaptar.SelectCommand = comando;
            DS = new DataSet();
            Adaptar.Fill(DS, "tabla");
            conexion.cerra();
            return DS.Tables["Tabla"];

        }

        public DataTable Buscar(string nCliente)
        {
          
                string query = "select * from cliente where id like '%" + nCliente + "%'";
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
