using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            string strNombreArchivo = CargarImagen();
            if (strNombreArchivo != null)
                MostrarImagen(strNombreArchivo);
        }
        private string CargarImagen()
        {
            string strNombreArchivo = null;
            // Declaración de variable para seleccionar el archivo
            OpenFileDialog miArchivoFoto = new OpenFileDialog();
            miArchivoFoto.Title = "Seleccione la imagen que desea cargar";
            miArchivoFoto.Filter = "Archivos JPEG (*.jpg) | *.jpg";
            miArchivoFoto.InitialDirectory = "Mis documentos";
            if (miArchivoFoto.ShowDialog() == DialogResult.OK)
            {
                strNombreArchivo = miArchivoFoto.FileName;
                return (strNombreArchivo);
            }
            else return (null);
        }
        private void MostrarImagen(string strNombreArchivo)
        {
            Bitmap miImagen = new Bitmap(strNombreArchivo);
            picLogoFup.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogoFup.Image = (Image)miImagen;
            picLogoFup.Refresh();
        }
    }
}
