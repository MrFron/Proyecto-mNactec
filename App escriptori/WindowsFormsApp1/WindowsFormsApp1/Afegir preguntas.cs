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
    public partial class Form2 : Form
    {
        List<string> opcions = new List<string>();
        List<Preguntes1> preguntes = new List<Preguntes1>();

        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxpreg_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoneliminaropcio_Click(object sender, EventArgs e)
        {
            string afegir = listBoxOpcions.SelectedItem.ToString();

           
            opcions.Remove(afegir);
            listBoxOpcions.DataSource = null;
            listBoxOpcions.DataSource = opcions;
            
        }

        private void buttonafegiropcio_Click(object sender, EventArgs e)
        {
            string afegir = textBoxopcio.Text;

            if(!opcions.Contains(afegir))
            {
                opcions.Add(afegir);
                listBoxOpcions.DataSource = null;
                listBoxOpcions.DataSource = opcions;
                textBoxopcio.Clear();
            }

        }

        private void buttonguardar3_Click(object sender, EventArgs e)
        {
            Preguntes1 preguntes2 = new Preguntes1();
            if (radioButtonCas == null && radioButtonCat == null && radioButtonEng == null || textBoxpreg == null || listBoxOpcions == null || textBoxresposta == null)
            {
                MessageBox.Show("Omple totes les dades del formulari", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (radioButtonCat.Checked)
            {


                if (radioButtonnivell1.Checked)
                {
                    preguntes2.nivell = 1;
                }
                else if (radioButtonnivell2.Checked)
                {
                    preguntes2.nivell = 2;
                }
                else if (radioButtonnivell3.Checked)
                {
                    preguntes2.nivell = 3;
                }
                preguntes2.pregunta = textBoxpreg.Text;
                preguntes2.opcio = opcions;
                preguntes2.resposta = textBoxresposta.Text;

                JArray jArraypreguntes = (JArray)JToken.FromObject(preguntes);
                StreamWriter arxiuescriptura = File.CreateText(@"..\..\Catala_preg.json");
                JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                jArraypreguntes.WriteTo(escriurearxiu);

                escriurearxiu.Close();
                MessageBox.Show("La pregunta s'ha guardat correctament", "Informacio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioButtonCas.Checked)
            {
                if (radioButtonnivell1.Checked)
                {
                    preguntes2.nivell = 1;
                }
                else if (radioButtonnivell2.Checked)
                {
                    preguntes2.nivell = 2;
                }
                else if (radioButtonnivell3.Checked)
                {
                    preguntes2.nivell = 3;
                }
                preguntes2.pregunta = textBoxpreg.Text;
                preguntes2.opcio = opcions;
                preguntes2.resposta = textBoxresposta.Text;

                JArray jArraypreguntes = (JArray)JToken.FromObject(preguntes);
                StreamWriter arxiuescriptura = File.CreateText(@"..\..\Castellano_preg.json");
                JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                jArraypreguntes.WriteTo(escriurearxiu);

                escriurearxiu.Close();
                MessageBox.Show("La pregunta se ha guardado correctamente", "Informacio", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioButtonEng.Checked)
            {
                if (radioButtonnivell1.Checked)
                {
                    preguntes2.nivell = 1;
                }
                else if (radioButtonnivell2.Checked)
                {
                    preguntes2.nivell = 2;
                }
                else if (radioButtonnivell3.Checked)
                {
                    preguntes2.nivell = 3;
                }
                preguntes2.pregunta = textBoxpreg.Text;
                preguntes2.opcio = opcions;
                preguntes2.resposta = textBoxresposta.Text;

                JArray jArraypreguntes = (JArray)JToken.FromObject(preguntes);
                StreamWriter arxiuescriptura = File.CreateText(@"..\..\English_preg.json");
                JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                jArraypreguntes.WriteTo(escriurearxiu);

                escriurearxiu.Close();
                MessageBox.Show("The question has been saved correctly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
