using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_cine
{
    public partial class ModificarPelicula : Form
    {
        homeCajero formParent;
        public ModificarPelicula(homeCajero parent)
        {
            this.formParent = parent;
            InitializeComponent();
        }

        private void examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.PNG;*.GIF;*.JPEG)|*.PNG;*.GIF;*.JPEG;|All files (*.*)|*.*";
            open.Title = "imagenes";
            if (open.ShowDialog() == DialogResult.OK) {
                ImageNameTextBox.Text = open.FileName;
                try
                {
                    pictureBox.Image = Image.FromFile(open.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch {
                    MessageBox.Show("elija un tipo de imagen valido");
                    open.ShowDialog();
                }
                
            }
            open.Dispose();
            
        }



        private void enviar_Click(object sender, EventArgs e)
        {
            formParent.OpenFormInPanelCentral(new Peliculas(formParent));
            this.Close();
        }
        private void ModificarPelicula_Load(object sender, EventArgs e)
        {

        }
    }
}
