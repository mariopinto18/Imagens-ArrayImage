using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        static int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // OpenFileDialog para filtrar as extensões de ficheiros a mostrar ao utilizador
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter =
"Images (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" + "All files (*.*)|*.*";
            openFileDialog1.Title = "Selecione Imagem";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // adiciona à imagelist
                imageList1.Images.Add(Image.FromFile(openFileDialog1.FileName));

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pos++;
            }
            openFileDialog1.Dispose();
            textBox1.Text = pos.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            imageList1.Images.RemoveAt(0);
        }
    }
}
