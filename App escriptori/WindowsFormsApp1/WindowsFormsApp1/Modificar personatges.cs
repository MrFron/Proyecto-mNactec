using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Modificar_personatges : Form
    {
        public Modificar_personatges()
        {
            InitializeComponent();
        }

        private void buttonsortir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonimatge_Click(object sender, EventArgs e)
        {
            OpenFileDialog Modificarimagen = new OpenFileDialog();
            Modificarimagen.Filter = "Arxiu de imatge|*.*";
            Modificarimagen.InitialDirectory = "\\ABP\\WindowsFormsApp1";

            if (Modificarimagen.ShowDialog()== DialogResult.OK)
            {
                File.Copy(Modificarimagen.FileName, @"..\..\..\imagen\" + Modificarimagen.SafeFileName);

                pictureBox1.ImageLocation = @"\..\..\..\imagen\" + Modificarimagen.SafeFileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
