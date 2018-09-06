using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ExamenPrimerParcial
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> Imagen;

        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)

            {
                Imagen = new Image<Bgr, byte>(ofd.FileName);

                imageBox1.Image = Imagen;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to exit this program. Is this what you want?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                this.Close();
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Imagen == null)

            {
                return;
            }
            
            Image<Gray, byte> CannyImagen = new Image<Gray, byte>(Imagen.Width, Imagen.Height, new Gray(0));
            
            CannyImagen = Imagen.Canny(50, 30);

            imageBox1.Image = CannyImagen;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
