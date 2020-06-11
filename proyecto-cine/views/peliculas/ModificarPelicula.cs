using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_cine.controller;

namespace proyecto_cine
{
    public partial class ModificarPelicula : Form
    {
        homeCajero formParent;
        string opcion;
        string nombre;
        string duracion;
        string categoria;
        string descripcion;
        string imaage;
        public ModificarPelicula(homeCajero parent, string opcion)
        {
            this.formParent = parent;
            this.opcion = opcion;
            InitializeComponent();
        }

        private void examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.PNG;*.GIF;*.JPG;*.JPEG)|*.PNG;*.GIF;*.JPG;*.JPEG;|All files (*.*)|*.*";
            open.Title = "Seleccionar imagen";
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (open.ShowDialog() == DialogResult.OK) {
                ImageNameTextBox.Text = open.FileName;
                try
                {
                    pictureBox.Image = Image.FromFile(open.FileName);
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
            MemoryStream ms = new MemoryStream(); 
            pictureBox.Image.Save(ms, ImageFormat.Jpeg);
            byte[] foto = ms.ToArray();
            nombre = NameTextBox.Text;
             duracion = DuracionTextBox.Text;
             categoria = CategoriaTextBox.Text;
             descripcion = DescripcionTextBox.Text;
             imaage = ImageNameTextBox.Text;
            


            if (opcion == "crear") {
                PeliculaController controller = new PeliculaController(formParent);
                controller.crear(nombre,categoria,descripcion,duracion, imaage,foto);

            }
            else
            {
                PeliculaController controller = new PeliculaController(formParent);
                controller.modificar(nombre, categoria, descripcion, duracion, imaage, foto);
            }

            formParent.OpenFormInPanelCentral(new Peliculas(formParent));                      
            this.Close();
        }
        private void ModificarPelicula_Load(object sender, EventArgs e)
        {

        }
    }
}
