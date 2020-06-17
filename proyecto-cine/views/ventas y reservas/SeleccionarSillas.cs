using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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

        public SeleccionarSillas(homeCajero parent)
        {
            FormParent = parent;
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            conexiondb conexion = new conexiondb();
            SqlCommand cmd;

            sillasSeleccinadadas = list.ToArray();
            for (int i = 0; i < sillasSeleccinadadas.Length; i++)
            {
                MessageBox.Show(sillasSeleccinadadas[i]);


                try
                {
                    conexion.abrir();
                    cmd = new SqlCommand("Insert into asientos (funcion_id,estado,posicion) values (1 , 'vendido', '" + sillasSeleccinadadas[i] + "')", conexion.conexion);
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


        }

        public bool consultarSillas(PictureBox picture, string posicion)
        {
            conexiondb conexion = new conexiondb();
            try
            {
                conexion.abrir();
                SqlCommand cmd = new SqlCommand("select * from asientos where funcion_id = '1' and posicion = '" + posicion + "'", conexion.conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    picture.Image = proyecto_cine.Properties.Resources.Silla_negra;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            conexion.cerra();
        }

        public void EscogerSilla(PictureBox picture, string posicion)
        {
            if (consultarSillas(picture, posicion) == false)
            {
                picture.Image = proyecto_cine.Properties.Resources.Silla_roja1;
                list.Add(posicion);
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
            consultarSillas(pictureBox8, "L2");
            consultarSillas(pictureBox7, "L3");
            consultarSillas(pictureBox6, "L4");
            consultarSillas(pictureBox15, "K0");
            consultarSillas(pictureBox14, "K1");
            consultarSillas(pictureBox13, "K2");
            consultarSillas(pictureBox12, "K3");
            consultarSillas(pictureBox11, "K4");
            consultarSillas(pictureBox20, "j0");
            consultarSillas(pictureBox19, "j1");
            consultarSillas(pictureBox18, "j2");
            consultarSillas(pictureBox17, "j3");
            consultarSillas(pictureBox16, "j4");
            consultarSillas(pictureBox25, "I0");
            consultarSillas(pictureBox24, "I1");
            consultarSillas(pictureBox23, "I2");
            consultarSillas(pictureBox22, "I3");
            consultarSillas(pictureBox21, "I4");
            consultarSillas(pictureBox30, "H0");
            consultarSillas(pictureBox29, "H1");
            consultarSillas(pictureBox28, "H2");
            consultarSillas(pictureBox27, "H3");
            consultarSillas(pictureBox26, "H4");
            consultarSillas(pictureBox35, "G0");
            consultarSillas(pictureBox34, "G1");
            consultarSillas(pictureBox33, "G2");
            consultarSillas(pictureBox32, "G3");
            consultarSillas(pictureBox31, "G4");
            consultarSillas(pictureBox40, "F0");
            consultarSillas(pictureBox39, "F1");
            consultarSillas(pictureBox38, "F2");
            consultarSillas(pictureBox37, "F3");
            consultarSillas(pictureBox36, "F4");
            consultarSillas(pictureBox45, "E0");
            consultarSillas(pictureBox44, "E1");
            consultarSillas(pictureBox43, "E2");
            consultarSillas(pictureBox42, "E3");
            consultarSillas(pictureBox41, "E4");
            consultarSillas(pictureBox50, "D0");
            consultarSillas(pictureBox49, "D1");
            consultarSillas(pictureBox48, "D2");
            consultarSillas(pictureBox47, "D3");
            consultarSillas(pictureBox46, "D4");
            consultarSillas(pictureBox55, "C0");
            consultarSillas(pictureBox54, "C1");
            consultarSillas(pictureBox53, "C2");
            consultarSillas(pictureBox52, "C3");
            consultarSillas(pictureBox51, "C4");
            consultarSillas(pictureBox60, "B0");
            consultarSillas(pictureBox59, "B1");
            consultarSillas(pictureBox58, "B2");
            consultarSillas(pictureBox57, "B3");
            consultarSillas(pictureBox56, "B4");
            consultarSillas(pictureBox65, "A0");
            consultarSillas(pictureBox64, "A1");
            consultarSillas(pictureBox63, "A2");
            consultarSillas(pictureBox62, "A3");
            consultarSillas(pictureBox61, "A4");
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox1, "M0");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormParent.OpenFormInPanelCentral(new SeleccionarSillas(FormParent));
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
            EscogerSilla(pictureBox8, "L2");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox7, "L3");
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
            EscogerSilla(pictureBox12, "k2");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox13, "k3");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            EscogerSilla(pictureBox11, "k4");
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
    } 
}
