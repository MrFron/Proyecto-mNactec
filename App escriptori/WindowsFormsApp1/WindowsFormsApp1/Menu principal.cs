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
    public partial class Form1 : Form
    {
        List<Personajes> personajes = new List<Personajes>();
        List<Preguntes1> preguntes = new List<Preguntes1>();
        string idioma = "";

        public Form1()
        {
            InitializeComponent();
  

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewpersonatges.AutoGenerateColumns = false;
        }

        private void buttonafegirper_Click(object sender, EventArgs e)
        {
            Afegirpersonatges ap = new Afegirpersonatges(personajes);
            ap.ShowDialog();
            //Muestra la lista en el datagrid
            dataGridViewpersonatges.DataSource = null;
            dataGridViewpersonatges.DataSource = personajes;

        }

        private void buttonmodificarper_Click(object sender, EventArgs e)
        {
            Modificar_personatges mp = new Modificar_personatges();
            mp.ShowDialog();
        }

        private void buttonafegirpreg_Click(object sender, EventArgs e)
        {
            Form2 apr = new Form2();
            apr.ShowDialog();

        }

        private void buttonmodificarpreg_Click(object sender, EventArgs e)
        {
            Modificarpreguntes mpr = new Modificarpreguntes();
            mpr.ShowDialog();
        }

        private void buttoneliminarper_Click(object sender, EventArgs e)
        {

            if (idioma == "cat")
            {


                if (this.dataGridViewpersonatges.SelectedRows.Count > 0)
                {
                   
                    JArray jArraypersonatges = (JArray)JToken.FromObject(personajes);

                    StreamWriter arxiuescriptura = File.CreateText(@"..\..\Catala_pers.json");
                    JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);
                    personajes.Remove((Personajes)dataGridViewpersonatges.SelectedRows[0].DataBoundItem);
                    dataGridViewpersonatges.DataSource = null;
                    dataGridViewpersonatges.DataSource = personajes;



                }
            }
            else if (idioma == "cas")
            {
                if (this.dataGridViewpersonatges.SelectedRows.Count > 0)
                {

                    JArray jArraypersonatges = (JArray)JToken.FromObject(personajes);

                    StreamWriter arxiuescriptura = File.CreateText(@"..\..\Castellano_pers.json");
                    JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                    personajes.Remove((Personajes)dataGridViewpersonatges.SelectedRows[0].DataBoundItem);
                    dataGridViewpersonatges.DataSource = null;
                    dataGridViewpersonatges.DataSource = personajes;


                }
            }
            else if (idioma=="eng")
            {
                if (this.dataGridViewpersonatges.SelectedRows.Count > 0)
                {

                    JArray jArraypersonatges = (JArray)JToken.FromObject(personajes);

                    StreamWriter arxiuescriptura = File.CreateText(@"..\..\English_pers.json");
                    JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                    personajes.Remove((Personajes)dataGridViewpersonatges.SelectedRows[0].DataBoundItem);
                    dataGridViewpersonatges.DataSource = null;
                    dataGridViewpersonatges.DataSource = personajes;


                }
            }
        }

        private void buttoneliminarpreg_Click(object sender, EventArgs e)
        {
            if (idioma == "cat")
            {
                if (this.dataGridViewpreguntes.SelectedRows.Count > 0)
                {

                    JArray jArraypreguntes = (JArray)JToken.FromObject(preguntes);

                    StreamWriter arxiuescriptura = File.CreateText(@"..\..\Catala_preg.json");
                    JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                    preguntes.Remove((Preguntes1)dataGridViewpreguntes.SelectedRows[0].DataBoundItem);
                    dataGridViewpreguntes.DataSource = null;
                    dataGridViewpreguntes.DataSource = preguntes;


                }
            }
            else if(idioma=="cas")
            {
                if (this.dataGridViewpreguntes.SelectedRows.Count > 0)
                {

                    JArray jArraypreguntes = (JArray)JToken.FromObject(preguntes);

                    StreamWriter arxiuescriptura = File.CreateText(@"..\..\Castellano_preg.json");
                    JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                    preguntes.Remove((Preguntes1)dataGridViewpreguntes.SelectedRows[0].DataBoundItem);
                    dataGridViewpreguntes.DataSource = null;
                    dataGridViewpreguntes.DataSource = preguntes;


                }
            }
            else if (idioma == "eng")
            {
                if (this.dataGridViewpreguntes.SelectedRows.Count > 0)
                {

                    JArray jArraypreguntes = (JArray)JToken.FromObject(preguntes);

                    StreamWriter arxiuescriptura = File.CreateText(@"..\..\English_preg.json");
                    JsonTextWriter escriurearxiu = new JsonTextWriter(arxiuescriptura);

                    preguntes.Remove((Preguntes1)dataGridViewpreguntes.SelectedRows[0].DataBoundItem);
                    dataGridViewpreguntes.DataSource = null;
                    dataGridViewpreguntes.DataSource = preguntes;


                }
            }
        }

        private void buttoncatala_Click(object sender, EventArgs e)
        {
            string catala_pers = @"..\..\Catala_pers.json";
            idioma = "cat";
            //Leer el JSON seleccionado y guardarlo en una lista de preguntas

            //    MessageBox.Show("No hi ha personatges al json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
                JArray jArrayPersonatges = JArray.Parse(File.ReadAllText(catala_pers));
                personajes = jArrayPersonatges.ToObject<List<Personajes>>();
            
            //Muestra la lista en el datagrid
            dataGridViewpersonatges.DataSource = personajes;

           
            string catala_preg = @"..\..\Catala_pre.json";
            //Leer ahora el fichero de preguntas de catala//
            JArray jArrayPreguntes = JArray.Parse(File.ReadAllText(catala_preg));
            preguntes = jArrayPreguntes.ToObject<List<Preguntes1>>();

            dataGridViewpreguntes.DataSource = preguntes;
        }

        private void buttonespaña_Click(object sender, EventArgs e)
        {
            string cas_pers = @"..\..\Castellano_pers.json";
            idioma = "cas";
            JArray jArrayPersonajes = JArray.Parse(File.ReadAllText(cas_pers));
            personajes = jArrayPersonajes.ToObject<List<Personajes>>();

            dataGridViewpersonatges.DataSource = personajes;

            string cas_preg = @"..\..\Castellano_preg.json";
            JArray jArraypreguntas = JArray.Parse(File.ReadAllText(cas_preg));
            preguntes = jArraypreguntas.ToObject<List<Preguntes1>>();

            dataGridViewpreguntes.DataSource = preguntes;
        }

        private void dataGridViewpersonatges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            string eng_pers = @"..\..\English_pers.json";
            idioma = "eng";
            JArray jArrayPersonajes = JArray.Parse(File.ReadAllText(eng_pers));
            personajes = jArrayPersonajes.ToObject<List<Personajes>>();

            dataGridViewpersonatges.DataSource = personajes;

            string eng_preg = @"..\..\English_pre.json";
            JArray jArraypreguntas = JArray.Parse(File.ReadAllText(eng_preg));
            preguntes = jArraypreguntas.ToObject<List<Preguntes1>>();

            dataGridViewpreguntes.DataSource = preguntes;
        }
    }
}
