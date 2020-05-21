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

        public Clientedb()
        {
            conexion = new conexiondb();
        }

        
        public bool Agregar(Cliente nclientes)
        {
                                                                                                             
            return conexion.ejecutarComando("INSERT INTO cliente (id,nombre,apellidos,email,direccion) VALUES('"+nclientes.cedula+ "','" + nclientes.nombre + "','" + nclientes.apellidos + "','" + nclientes.email + "','" + nclientes.direccion + "')");

        }
        public DataSet MostrarClientes()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM cliente");
            return conexion.consultarCliente(sentencia);
        }

        public DataSet Buscar(Clientes nCliente)
        {
            SqlCommand sentencias = new SqlCommand("SELECT * FROM cliente WHERE ID like('" + nCliente.id + "%')");
            return conexion.consultarCliente(sentencias);
        }
    }


}
