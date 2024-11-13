using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje_Vozizila2
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            var vozilo = new Vozilo
            {
                Marka1 = textBox1.Text,
                Model1 = textBox2.Text,
                GodinaProizvodnje1 = int.Parse(textBox3.Text),
                Kilometraza1 = int.Parse(textBox4.Text)


            };
            vozila.Add(vozilo);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kriteriji = comboBox1.SelectedItem.ToString();

            if (kriteriji == "marka") textBoxSort.Text 
        }
    }
}
