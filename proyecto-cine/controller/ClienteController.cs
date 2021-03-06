﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.Model.usuario;


namespace proyecto_cine.controller
{
    class ClienteController
    {
        homeCajero formParent;
        public ClienteController(homeCajero formParent)
        {
            this.formParent = formParent;
        }

        public void crear( int id , string nombre, string apellidos, string email, string direccion, int descueento ) {
            //validamos si se los datos son correctos
            if (nombre.Length != 0 && apellidos.Length != 0 && email.Length != 0 && direccion.Length != 0)
            {
                //instanciamos modelo con datos del textBox
                ClienteModel modelo = new ClienteModel(id, nombre, apellidos, email, direccion, descueento);
                modelo.crearCliente();
                
                GuardadoConExito succes = new GuardadoConExito(formParent, "cliente");
                succes.Show();

            }
            else {
                ErrorAlGuardar err = new ErrorAlGuardar();
                err.Show();
            }

        }
        public void modificar(int id, string nombre, string apellidos, string email, string direccion, int descueento)
        {
            if (nombre.Length != 0 && apellidos.Length != 0 && email.Length != 0 && direccion.Length != 0)
            {
                //instanciamos modelo con datos del textBox
                ClienteModel modelo = new ClienteModel(id, nombre, apellidos, email, direccion, descueento);
                modelo.actualizarCliente();

                ModificacionExitosa succes = new ModificacionExitosa(formParent,"modificarCliente");
                succes.Show();

            }
            else
            {
                ErrorAlGuardar err = new ErrorAlGuardar();
                err.Show();
            }

        }



        public void confirmarEliminacion(int id) {

            new Confirmacion(formParent, id, "eliminarCliente").Show();

        }


        public void eliminar(int id) {
                ClienteModel modelo = new ClienteModel(id);
                modelo.eliminarCliente();
                formParent.OpenFormInPanelCentral(new Clientes(formParent));
        }


        public DataTable mostrarTabla()
        {
            ClienteModel modelo = new ClienteModel();
            return modelo.consultarCliente();
        }


        public DataTable buscarCliente(string buscar) {
            
               int id = int.Parse(buscar);
                ClienteModel modelo = new ClienteModel(id);
          
            
            return modelo.buscar();

        }

    }       
}

