using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class Afegirpersonatges : Form
    {
        List<Personajes> personajes = new List<Personajes>();
        Personajes personaje1 = new Personajes();

        public Afegirpersonatges(List<Personajes> personajes)
        {
            InitializeComponent();

            this.personajes = personajes;
        }
         
        private void buttonsortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se abra ventana seleccionar fichero
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Arxiu de imatge|*.*";
           
            BuscarImagen.InitialDirectory = "\\ABP\\WindowsFormsApp1";

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                //textBoximatge.Text = BuscarImagen.FileName;
                File.Copy(BuscarImagen.FileName, @"..\..\..\imagen\" + BuscarImagen.SafeFileName);

                pictureBox1.ImageLocation = @"..\..\..\imagen\" + BuscarImagen.SafeFileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }

            // C:\dada\pepe.png
            //Copiar este fichero a la ruta de las imagenes
            //pictureBox1.ImageLocation = ;
            //d:\datos\imagenes\pepe.png
            //Picture imagelocation l

            // pictureBox1.ImageLocation = ""
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            string str;
            string str2;
            Form1 Form1 = new Form1();
            

            if (textBoxpersonatgenou.Text == null || textBoxintervalpunts.Text == null ||textBoxintervalpunts2.Text == null || pictureBox1.ImageLocation == null ||radioButtoncas== null && radioButtoncat==null && radioButtoneng==null)
            {

                MessageBox.Show("Omple totes les dades del formulari", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (radioButtoncat.Checked)
            {
                personaje1.nom = textBoxpersonatgenou.Text;
                personaje1.imagen = pictureBox1.ImageLocation;
                str = textBoxintervalpunts.Text;
                str2 = textBoxintervalpunts2.Text;

                personaje1.puntmin = Int32.Parse(str);
                personaje1.puntmax = Int32.Parse(str2);

                personajes.Add(personaje1);

                JArray jArraypersonatges = (JArray)JToken.FromObject(personajes);
                StreamWriter arxiuescriptura = File.CreateText(@"..\..\Catala_pers.json");
                JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                jArraypersonatges.WriteTo(escriurearxiu);

                escriurearxiu.Close();

                MessageBox.Show("El personatge s'ha guardat correctament", "Informacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxpersonatgenou.Clear();
                textBoxintervalpunts.Clear();
                textBoxintervalpunts2.Clear();
                pictureBox1.Image = null;
                radioButtoncat.Checked = false;
                radioButtoncas.Checked = false;
                radioButtoneng.Checked = false;
            }
            else if (radioButtoncas.Checked)
            {
                personaje1.nom = textBoxpersonatgenou.Text;
                personaje1.imagen = pictureBox1.ImageLocation;
                str = textBoxintervalpunts.Text;
                str2 = textBoxintervalpunts2.Text;

                personaje1.puntmin = Int32.Parse(str);
                personaje1.puntmax = Int32.Parse(str2);

                personajes.Add(personaje1);

                JArray jArraypersonatges = (JArray)JToken.FromObject(personajes);
       
                StreamWriter arxiuescriptura = File.CreateText(@"..\..\Castellano_pers.json");
                JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                jArraypersonatges.WriteTo(escriurearxiu);

                escriurearxiu.Close();

                MessageBox.Show("El personaje se ha guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxpersonatgenou.Clear();
                textBoxintervalpunts.Clear();
                textBoxintervalpunts2.Clear();
                pictureBox1.Image = null;
                radioButtoncat.Checked = false;
                radioButtoncas.Checked = false;
                radioButtoneng.Checked = false;
            }
            else if (radioButtoneng.Checked)
            {
                personaje1.nom = textBoxpersonatgenou.Text;
                personaje1.imagen = pictureBox1.ImageLocation;
                str = textBoxintervalpunts.Text;
                str2 = textBoxintervalpunts2.Text;

                personaje1.puntmin = Int32.Parse(str);
                personaje1.puntmax = Int32.Parse(str2);

                personajes.Add(personaje1);

                JArray jArraypersonatges = (JArray)JToken.FromObject(personajes);
                StreamWriter arxiuescriptura = File.CreateText(@"..\..\English_pers.json");
                JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                jArraypersonatges.WriteTo(escriurearxiu);

                escriurearxiu.Close();

                MessageBox.Show("The character has been saved correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxpersonatgenou.Clear();
                textBoxintervalpunts.Clear();
                textBoxintervalpunts2.Clear();
                pictureBox1.Image = null;
                radioButtoncat.Checked = false;
                radioButtoncas.Checked = false;
                radioButtoneng.Checked = false;
            }
        }

       
    }
}
