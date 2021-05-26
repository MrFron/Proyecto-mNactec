using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Modificarpreguntes : Form
    {
        public Modificarpreguntes()
        {
            InitializeComponent();
        }

        private void buttonsortir4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonafegir2_Click(object sender, EventArgs e)
        {
            string afegir = textBoxopcion2.Text;

            if (!listBoxopcions2.Items.Contains(afegir))
            {
                listBoxopcions2.Items.Add(afegir);
                textBoxopcion2.Clear();
            }
            else
            {
                MessageBox.Show("Aquesta opcio esta repetida.","INFORMACIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttoneliminar2_Click(object sender, EventArgs e)
        {
            listBoxopcions2.Items.Remove(listBoxopcions2.SelectedItem);  
        }
    }
}
