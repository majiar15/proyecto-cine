using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class ElegirReservaPagar : Form
    {
        homeCajero homeCajeroParent;
        private DataSet ds;
        conexiondb conexion = new conexiondb();
        SqlCommand cmd;
        public int cedula_id;
        public string funcion_id;
        public ElegirReservaPagar(homeCajero homeCajero)
        {
            this.homeCajeroParent = homeCajero;
            InitializeComponent();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int precio = 0;
            string sillas = "";
            try
            {
                conexion.abrir();
                cmd = new SqlCommand("select a.posicion, f.valor_entrada from asientos a, funcion f where f.id = a.funcion_id and a.cliente_id = " + cedula_id+" ", conexion.conexion);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sillas +="-" + reader.GetValue(0).ToString();
                }
                precio = int.Parse(reader.GetValue(1).ToString());

                MessageBox.Show(sillas);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

            //imprimir 

            PrintDocument printer = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            //printer.PrinterSettings = ps;
            //printer.PrintPage += imprimir;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

            //Registrar compra

            funcion_id = dataGridView1.CurrentRow.Cells["funcion_id"].Value.ToString();
            try
            {
                DateTime fecha = DateTime.Today;
                conexion.abrir();
                cmd = new SqlCommand("Insert into ticket (funcion_id ,no_asientos, fecha, valor_total) values (" + funcion_id + " , " + sillas.Length + ", '" + fecha.ToString("yyyy-MM-dd") + "', " + (sillas.Length * precio) + ")", conexion.conexion);
                cmd.ExecuteNonQuery();
                conexion.cerra();


            }
            catch (Exception ex)
            {
                ErrorAlGuardar error = new ErrorAlGuardar();
                error.Show();
                MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
            }
        }

        
        private void PagarReservaButtom1_Click(object sender, EventArgs e)
        {
            ConfirmarPagarReserva pagarReservaForm = new ConfirmarPagarReserva(homeCajeroParent,"PAGAR RESERVA");
            pagarReservaForm.Show();
            homeCajeroParent.OpenFormInPanelCentral();
            this.Close();
        }

        private void ElegirReservaPagar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
