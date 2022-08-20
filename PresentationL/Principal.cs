using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationL
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }



       
        private void ChofeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chofer ChoferW = new Chofer();
            ChoferW.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus bus = new Bus();
            bus.Show();

        }

        private void RutaB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ruta ruta = new Ruta();
            ruta.Show();
        }

        private void AsignaA_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asignar asignar = new Asignar();
            asignar.Show();
        }
    }
}
