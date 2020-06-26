using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class SeleccionarSillas : Form
    {
        homeCajero FormParent;
        List<string> list = new List<string>();
        string[] sillasSeleccinadadas;
        public int idFuncion;
        public string pelicula;
        public string sala;
        public int precio;
        public long cedulaCliente;
        public DateTime fechaFuncion;
        int contadorSillas;
        public string opcion;

        public SeleccionarSillas(homeCajero parent)
        {
            FormParent = parent;
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (contadorSillas != 0)
            {
                conexiondb conexion = new conexiondb();
                SqlCommand cmd;

                sillasSeleccinadadas = list.ToArray();
                for (int i = 0; i < sillasSeleccinadadas.Length; i++)
                {
                    //MessageBox.Show(sillasSeleccinadadas[i]);


                    try
                    {
                        DateTime fecha = DateTime.Today;
                        conexion.abrir();
                        cmd = new SqlCommand("Insert into asientos (funcion_id,estado,posicion) values (" + idFuncion + " , 'vendido', '" + sillasSeleccinadadas[i] + "')", conexion.conexion);
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
                //new ConfirmarPagarReserva(FormParent, "PAGAR BOLETOS").Show();
                //this.Close();


                //Imprimir

                PrintDocument printer = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printer.PrinterSettings = ps;
                printer.PrintPage += imprimir;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();

                

                //Registrar compra

                try
                {
                    DateTime fecha = DateTime.Today;
                    conexion.abrir();
                    cmd = new SqlCommand("Insert into ticket (funcion_id ,no_asientos, vendedor_id ,fecha, valor_total) values ("+idFuncion+" , "+sillasSeleccinadadas.Length+" ,"+FormParent.userLog+" , '" + fecha.ToString("yyyy-MM-dd") + "', "+(sillasSeleccinadadas.Length * precio)+")", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    conexion.cerra();


                }
                catch (Exception ex)
                {
                    ErrorAlGuardar error = new ErrorAlGuardar();
                    error.Show();
                    MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
                }

                MessageBox.Show("Compra realizada correctamente");
                FormParent.OpenFormInPanelCentral(new SeleccionPeliculas(FormParent));
            }
            else MessageBox.Show("Seleccione las sillas porfavor");
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (contadorSillas != 0)
            {
                conexiondb conexion = new conexiondb();
                SqlCommand cmd;

                sillasSeleccinadadas = list.ToArray();
                for (int i = 0; i < sillasSeleccinadadas.Length; i++)
                {
                    //MessageBox.Show(sillasSeleccinadadas[i]);


                    try
                    {
                        DateTime fecha = DateTime.Today;
                        conexion.abrir();
                        cmd = new SqlCommand("Insert into asientos (funcion_id,estado,posicion, cliente_id) values (" + idFuncion + " , 'Reservado', '" + sillasSeleccinadadas[i] + "', " + cedulaCliente + ")", conexion.conexion);
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

                //Imprimir

                PrintDocument printer = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printer.PrinterSettings = ps;
                printer.PrintPage += imprimir;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();

                //Registrar reserva
                Random rnd = new Random();
                int id = rnd.Next(1, 10000);
                try
                {
                    DateTime fecha = DateTime.Today;
                    conexion.abrir();
                    cmd = new SqlCommand("Insert into reserva (cliente_id, estado, funcion_id) values (" + cedulaCliente + ", 'SinPagar' , " + idFuncion + ")", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    conexion.cerra();


                }
                catch (Exception ex)
                {
                    ErrorAlGuardar error = new ErrorAlGuardar();
                    error.Show();
                    MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
                }


                //Registrar compra

                try
                {
                    DateTime fecha = DateTime.Today;
                    conexion.abrir();
                    cmd = new SqlCommand("Insert into ticket (funcion_id ,no_asientos, cliente_id,vendedor_id , fecha, valor_total) values (" + idFuncion + " , " + sillasSeleccinadadas.Length + ","+cedulaCliente+" , "+FormParent.userLog+",'" + fecha.ToString("yyyy-MM-dd") + "', " + (sillasSeleccinadadas.Length * precio) + ")", conexion.conexion);
                    cmd.ExecuteNonQuery();
                    conexion.cerra();


                }
                catch (Exception ex)
                {
                    ErrorAlGuardar error = new ErrorAlGuardar();
                    error.Show();
                    MessageBox.Show("No se pudo insertar los datos, error: " + ex.ToString()); ;
                }

                MessageBox.Show("Reserva realizada correctamente");
                FormParent.OpenFormInPanelCentral(new Reservas(FormParent));
            }
            else MessageBox.Show("Seleccione las sillas porfavor");
        }

        private void imprimir(object sender, PrintPageEventArgs printer)
        {
            string sillas = "";
            for (int i = 0; i < sillasSeleccinadadas.Length; i++)
            {
                sillas += "-" + sillasSeleccinadadas[i];
            }
            DateTime fecha = DateTime.Today;
            string hora = DateTime.Now.ToString("HH:mm:ss");
            Font font= new Font("Arial", 14);
            Font font2 = new Font("Arial", 10);
            int ancho = 300;
            int y = 20;

            sillas += "-";

            printer.Graphics.DrawString("CineProject", font2, Brushes.Black, new RectangleF(100, y += 20, ancho, 20));
            printer.Graphics.DrawString("NIT 890900085-1", font2, Brushes.Black, new RectangleF(90, y += 20, ancho, 20));
            printer.Graphics.DrawString("Cra 43 # 76 - 58", font2, Brushes.Black, new RectangleF(90, y += 20, ancho, 20));
            printer.Graphics.DrawString("Branquilla - Colombia", font2, Brushes.Black, new RectangleF(70, y += 20, ancho, 20));
            printer.Graphics.DrawString("Tel: 3016542389 - 3205142 ", font2, Brushes.Black, new RectangleF(55, y += 20, ancho, 20));
            printer.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Factura No:  2015214365 ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Boleto de entrada de cine", font, Brushes.Black, new RectangleF(30, y += 20, ancho, 20));
            printer.Graphics.DrawString("Pelicula: " + ""+pelicula+"", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Fecha función: " + ""+ fechaFuncion.ToString("dd-MM-yyyy") + "", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Sala: " + "" + sala + "", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Sillas: "+ sillas +"" , font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Valor Total: " + ""+precio * sillasSeleccinadadas.Length+"", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("Punto de venta:  ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString("CineProject Barranquilla ", font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
            printer.Graphics.DrawString("-------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            printer.Graphics.DrawString(""+ fecha.ToShortDateString()+" "+hora+" ", font2, Brushes.Black, new RectangleF(75, y += 20, ancho, 20));
            printer.Graphics.DrawString("www.cineproject.com.co", font2, Brushes.Black, new RectangleF(65, y += 20, ancho, 20));
            printer.Graphics.DrawString("Res. Dian No: 321024569870", font2, Brushes.Black, new RectangleF(50, y += 20, ancho, 20));
        }

        public bool consultarSillas(PictureBox picture, string posicion)
        {
            conexiondb conexion = new conexiondb();
            conexion.abrir();
            try
            {
                
                SqlCommand cmd = new SqlCommand("select * from asientos where funcion_id = "+idFuncion+" and posicion = '" + posicion + "'", conexion.conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    picture.Image = proyecto_cine.Properties.Resources.Silla_negra;
                    conexion.cerra();
                    return true;
                }
                conexion.cerra();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conexion.cerra();
                return false;
            }
            
        }

        bool repetida;
        public void EscogerSilla(PictureBox picture, string posicion)
        {
            
            if (consultarSillas(picture, posicion) == false)
            {
                picture.Image = proyecto_cine.Properties.Resources.Silla_roja1;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == posicion)
                        repetida = true;
                }
                if (repetida == false)
                {
                    list.Add(posicion);
                    contadorSillas += 1;
                }
            }
        }

        private void SeleccionarSillas_Load(object sender, EventArgs e)
        {
            consultarSillas(pictureBox1, "M0");
            consultarSillas(pictureBox2, "M1");
            consultarSillas(pictureBox3, "M2");
            consultarSillas(pictureBox4, "M3");
            consultarSillas(pictureBox5, "M4");
            consultarSillas(pictureBox10, "L0");
            consultarSillas(pictureBox9, "L1");
            consultarSillas(pictureBox7, "L2");
            consultarSillas(pictureBox8, "L3");
            consultarSillas(pictureBox6, "L4");
            consultarSillas(pictureBox15, "K0");
            consultarSillas(pictureBox14, "K1");
            consultarSillas(pictureBox12, "K2");
            consultarSillas(pictureBox13, "K3");
            consultarSillas(pictureBox11, "K4");
            consultarSillas(pictureBox20, "j0");
            consultarSillas(pictureBox19, "j1");
            consultarSillas(pictureBox17, "j2");
            consultarSillas(pictureBox18, "j3");
            consultarSillas(pictureBox16, "j4");
            consultarSillas(pictureBox25, "I0");
            consultarSillas(pictureBox24, "I1");
            consultarSillas(pictureBox22, "I2");
            consultarSillas(pictureBox23, "I3");
            consultarSillas(pictureBox21, "I4");
            consultarSillas(pictureBox30, "H0");
            consultarSillas(pictureBox29, "H1");
            consultarSillas(pictureBox27, "H2");
            consultarSillas(pictureBox28, "H3");
            consultarSillas(pictureBox26, "H4");
            consultarSillas(pictureBox35, "G0");
            consultarSillas(pictureBox34, "G1");
            consultarSillas(pictureBox32, "G2");
            consultarSillas(pictureBox33, "G3");
            consultarSillas(pictureBox31, "G4");
            consultarSillas(pictureBox40, "F0");
            consultarSillas(pictureBox39, "F1");
            consultarSillas(pictureBox37, "F2");
            consultarSillas(pictureBox38, "F3");
            consultarSillas(pictureBox36, "F4");
            consultarSillas(pictureBox45, "E0");
            consultarSillas(pictureBox44, "E1");
            consultarSillas(pictureBox42, "E2");
            consultarSillas(pictureBox43, "E3");
            consultarSillas(pictureBox41, "E4");
            consultarSillas(pictureBox50, "D0");
            consultarSillas(pictureBox49, "D1");
            consultarSillas(pictureBox47, "D2");
            consultarSillas(pictureBox48, "D3");
            consultarSillas(pictureBox46, "D4");
            consultarSillas(pictureBox55, "C0");
            consultarSillas(pictureBox54, "C1");
            consultarSillas(pictureBox52, "C2");
            consultarSillas(pictureBox53, "C3");
            consultarSillas(pictureBox51, "C4");
            consultarSillas(pictureBox60, "B0");
            consultarSillas(pictureBox59, "B1");
            consultarSillas(pictureBox57, "B2");
            consultarSillas(pictureBox58, "B3");
            consultarSillas(pictureBox56, "B4");
            consultarSillas(pictureBox65, "A0");
            consultarSillas(pictureBox64, "A1");
            consultarSillas(pictureBox62, "A2");
            consultarSillas(pictureBox63, "A3");
            consultarSillas(pictureBox61, "A4");
            consultarSillas(pictureBox70, "M5");
            consultarSillas(pictureBox69, "M6");
            consultarSillas(pictureBox68, "M7");
            consultarSillas(pictureBox67, "M8");
            consultarSillas(pictureBox66, "M9");
            consultarSillas(pictureBox75, "L5");
            consultarSillas(pictureBox74, "L6");
            consultarSillas(pictureBox73, "L7");
            consultarSillas(pictureBox72, "L8");
            consultarSillas(pictureBox71, "L9");
            consultarSillas(pictureBox80, "K5");
            consultarSillas(pictureBox79, "K6");
            consultarSillas(pictureBox78, "K7");
            consultarSillas(pictureBox77, "K8");
            consultarSillas(pictureBox76, "K9");
            consultarSillas(pictureBox85, "J5");
            consultarSillas(pictureBox84, "J6");
            consultarSillas(pictureBox83, "J7");
            consultarSillas(pictureBox82, "J8");
            consultarSillas(pictureBox81, "J9");
            consultarSillas(pictureBox90, "I5");
            consultarSillas(pictureBox89, "I6");
            consultarSillas(pictureBox88, "I7");
            consultarSillas(pictureBox87, "I8");
            consultarSillas(pictureBox86, "I9");
            consultarSillas(pictureBox95, "H5");
            consultarSillas(pictureBox94, "H6");
            consultarSillas(pictureBox93, "H7");
            consultarSillas(pictureBox92, "H8");
            consultarSillas(pictureBox91, "H9");
            consultarSillas(pictureBox100, "G5");
            consultarSillas(pictureBox99, "G6");
            consultarSillas(pictureBox98, "G7");
            consultarSillas(pictureBox97, "G8");
            consultarSillas(pictureBox96, "G9");
            consultarSillas(pictureBox105, "F5");
            consultarSillas(pictureBox104, "F6");
            consultarSillas(pictureBox103, "F7");
            consultarSillas(pictureBox102, "F8");
            consultarSillas(pictureBox101, "F9");
            consultarSillas(pictureBox110, "E5");
            consultarSillas(pictureBox109, "E6");
            consultarSillas(pictureBox108, "E7");
            consultarSillas(pictureBox107, "E8");
            consultarSillas(pictureBox106, "E9");
            consultarSillas(pictureBox115, "D5");
            consultarSillas(pictureBox114, "D6");
            consultarSillas(pictureBox113, "D7");
            consultarSillas(pictureBox112, "D8");
            consultarSillas(pictureBox111, "D9");
            consultarSillas(pictureBox120, "C5");
            consultarSillas(pictureBox119, "C6");
            consultarSillas(pictureBox118, "C7");
            consultarSillas(pictureBox117, "C8");
            consultarSillas(pictureBox116, "C9");
            consultarSillas(pictureBox125, "B5");
            consultarSillas(pictureBox124, "B6");
            consultarSillas(pictureBox123, "B7");
            consultarSillas(pictureBox122, "B8");
            consultarSillas(pictureBox121, "B9");
            consultarSillas(pictureBox130, "A5");
            consultarSillas(pictureBox129, "A6");
            consultarSillas(pictureBox128, "A7");
            consultarSillas(pictureBox127, "A8");
            consultarSillas(pictureBox126, "A9");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox1, "M0");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SeleccionarSillas CancelarSeleccion = new SeleccionarSillas(FormParent);
            CancelarSeleccion.idFuncion = idFuncion;
            FormParent.OpenFormInPanelCentral(CancelarSeleccion);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox2, "M1");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox3, "M2");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox4, "M3");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox5, "M4");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox10, "L0");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox9, "L1");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox8, "L3");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox7, "L2");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox6, "L4");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox15, "K0");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox14, "K1");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox12, "K2");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox13, "K3");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox11, "K4");
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox20, "J0");
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox19, "J1");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox17, "J2");
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox18, "J3");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox16, "J4");
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox25, "I0");
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox24, "I1");
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox22, "I2");
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox23, "I3");
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox21, "I4");
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox30, "H0");
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox29, "H1");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox27, "H2");
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox28, "H3");
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox26, "H4");
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox35, "G0");
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox34, "G1");
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox32, "G2");
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox33, "G3");
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox31, "G4");
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox40, "F0");
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox39, "F1");
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox37, "F2");
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox38, "F3");
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox36, "F4");
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox45, "E0");
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox44, "E1");
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox42, "E2");
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox43, "E3");
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox41, "E4");
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox50, "D0");
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox49, "D1");
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox47, "D2");
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox48, "D3");
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox46, "D4");
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox55, "C0");
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox54, "C1");
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox52, "C2");
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox53, "C3");
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox51, "C4");
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox60, "B0");
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox59, "B1");
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox57, "B2");
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox58, "B3");
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox56, "B4");
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox65, "A0");
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox64, "A1");
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox62, "A2");
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox63, "A3");
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox61, "A4");
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox70, "M5");
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox69, "M6");
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox68, "M7");
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox67, "M8");
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox66, "M9");
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox75, "L5");
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox74, "L6");
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox73, "L7");
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox72, "L8");
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox71, "L9");
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox80, "K5");
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox79, "K6");
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox78, "K7");
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox77, "K8");
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox76, "K9");
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox85, "J5");
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox84, "J6");
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox83, "J7");
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox82, "J8");
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox81, "J9");
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox90, "I5");
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox89, "I6");
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox88, "I7");
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox87, "I8");
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox86, "I9");
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox95, "H5");
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox94, "H6");
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox93, "H7");
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox92, "H8");
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox91, "H9");
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox100, "G5");
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox99, "G6");
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox98, "G7");
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox97, "G8");
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox96, "G9");
        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox105, "F5");
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox104, "F6");
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox103, "F7");
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox102, "F8");
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox101, "F9");
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox110, "E5");
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox109, "E6");
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox108, "E7");
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox107, "E8");
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox106, "E9");
        }

        private void pictureBox115_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox115, "D5");
        }

        private void pictureBox114_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox114, "D6");
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox113, "D7");
        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox112, "D8");
        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox111, "D9");
        }

        private void pictureBox120_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox120, "C5");
        }

        private void pictureBox119_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox119, "C6");
        }

        private void pictureBox118_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox118, "C7");
        }

        private void pictureBox117_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox117, "C8");
        }

        private void pictureBox116_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox116, "C9");
        }

        private void pictureBox125_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox125, "B5");
        }

        private void pictureBox124_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox124, "B6");
        }

        private void pictureBox123_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox123, "B7");
        }

        private void pictureBox122_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox122, "B8");
        }

        private void pictureBox121_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox121, "B9");
        }

        private void pictureBox130_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox130, "A5");
        }

        private void pictureBox129_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox129, "A6");
        }

        private void pictureBox128_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox128, "A7");
        }

        private void pictureBox127_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox127, "A8");
        }

        private void pictureBox126_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox126, "A9");
        }

        

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

    } 
}
