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
        public string id;
        public string opcion;
        public string nombre;
        public string duracion;
        public string categoria;
        public string descripcion;
        public string imaage;
        string[] sql;
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
            
             nombre = NameTextBox.Text;
             duracion = DuracionTextBox.Text;
             categoria = CategoriaTextBox.Text;
             descripcion = DescripcionTextBox.Text;
             imaage = ImageNameTextBox.Text;
            


            if (opcion == "crear") {
                MemoryStream ms = new MemoryStream();
                pictureBox.Image.Save(ms, ImageFormat.Jpeg);
                byte[] foto = ms.ToArray();

                PeliculaController controller = new PeliculaController(formParent);
                controller.crear(nombre,categoria,descripcion,duracion, imaage,foto);

            }
            else
            {
                PeliculaController controller = new PeliculaController(formParent);
                controller.modificar(id,nombre, categoria, descripcion, duracion);
            }

            formParent.OpenFormInPanelCentral(new Peliculas(formParent));                      
            this.Close();
        }
        private void ModificarPelicula_Load(object sender, EventArgs e)
        {
            if(opcion == "modificar")
            {
                PeliculaController controller = new PeliculaController(formParent);
                sql = controller.getPeliculaPorId(int.Parse(id));

                NameTextBox.Text  = sql[1];
                DuracionTextBox.Text = sql[2];
                CategoriaTextBox.Text = sql[3];
                DescripcionTextBox.Text = sql[4];
            }
        }
    }
}
