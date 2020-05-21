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

        public void Agregar(Cliente nclientes)
        {
            try
            {

                conexion.abrir();
                string query = "INSERT INTO cliente (id,nombre,apellidos,email,direccion) VALUES('" + nclientes.cedula + "','" + nclientes.nombre + "','" + nclientes.apellidos + "','" + nclientes.email + "','" + nclientes.direccion + "')";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente registrado");
                conexion.cerra();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se inserto los datos" + e.ToString());
            }

        }
        public void Modificardb(Cliente nCliente)
        {
            try
            {
                conexion.abrir();
                string query = "update cliente set nombre='" + nCliente.nombre + "',apellidos='" + nCliente.apellidos + "', direccion='" + nCliente.direccion + "', email='" + nCliente.email + "' where id='" + nCliente.cedula + "'";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado");
            }
            catch (Exception e)
            {
                MessageBox.Show("Cliente no se modifico" + e.ToString());
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                conexion.abrir();
                string query = "delete from cliente where id='" + id + "'";
                comando = new SqlCommand(query, conexion.conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente se elimino");
            }
            catch (Exception e)
            {
                MessageBox.Show("Cliente no se elimino" + e.ToString());
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

        //public DataTable Buscar(Cliente nCliente)
        //{

        //    string query = "select * from empleados where id like '%" + nCliente.buscador + "%'";
        //    comando = new SqlCommand(query, conexion.conexion);
        //    SqlDataAdapter Adaptar = new SqlDataAdapter();
        //    Adaptar.SelectCommand = comando;
        //    DS = new DataSet();
        //    Adaptar.Fill(DS, "tabla");
        //    conexion.cerra();
        //    return DS.Tables["tabla"];
        //}
    }


}
