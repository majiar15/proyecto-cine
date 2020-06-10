using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ModificarPelicula(homeCajero parent,string opcion)
        {
            this.formParent = parent;
            this.opcion = opcion;
            InitializeComponent();
        }

        private void examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.PNG;*.GIF;*.JPEG)|*.PNG;*.GIF;*.JPEG;|All files (*.*)|*.*";
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
                PeliculaController controller = new PeliculaController(formParent);
                controller.crear(nombre,categoria,descripcion,duracion, imaage);
            }
            formParent.OpenFormInPanelCentral(new Peliculas(formParent));
            this.Close();
        }
        private void ModificarPelicula_Load(object sender, EventArgs e)
        {

        }
    }
}
