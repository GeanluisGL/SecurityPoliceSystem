using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityL;
using NegociosL;


namespace PresentationL
{
    public partial class Ruta : Form
    {

        E_Route objEntindad = new E_Route();
        N_Ruta objNeg = new N_Ruta();

        private string IDPeople;
        private bool Edit = false;

        public Ruta()
        {
            InitializeComponent();
        }

        private void AllPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ruta_Load(object sender, EventArgs e)
        {

        }
        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            Edit = true;
            objEntindad.ID_Ruta = (int)dataGridView1.CurrentRow.Cells[0].Value;
            RutaBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DistBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void returnBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Principal Home = new Principal();
            Home.Show();
        }
        private void SearchBox_TextChanged_1(object sender, EventArgs e)
        {
            Buscar(SearchBox.Text);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            N_Ruta objNegocio = new N_Ruta();
            dataGridView1.DataSource = objNegocio;
        }

      
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Buscar(SearchBox.Text);
        }

        public void Buscar(string buscar)
        {
            N_Ruta objNegocio = new N_Ruta();
            dataGridView1.DataSource = objNegocio.ListRuta(buscar);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            objEntindad.ID_Ruta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            objNeg.DeleteR(objEntindad);
            MessageBox.Show("Registro eliminado");
            limpiar();
            objNeg.Showlist();
        }
        public void limpiar()
        {
            RutaBox.Text = "";
            DistBox.Text = "";

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {

                    objEntindad.RUTA = RutaBox.Text.ToUpper();
                    objEntindad.Distance = DistBox.Text.ToUpper();


                    objNeg.insertar(objEntindad);

                    MessageBox.Show("Registro guardado.");
                    limpiar();
                    Buscar("");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro. Verifique que no se repita el 'Chofer'" + ex);
                    limpiar();
                    Buscar("");

                }
            }
            if (Edit == true)
            {
                try
                {
                    objEntindad.RUTA = RutaBox.Text.ToUpper();
                    objEntindad.Distance = DistBox.Text.ToUpper();

                    objNeg.updateR(objEntindad);

                    MessageBox.Show("Registro guardado.");
                    objNeg.Showlist();
                    limpiar();
                    Edit = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro." + ex);
                }
            }
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            Edit = true;
            objEntindad.ID_Ruta = (int)dataGridView1.CurrentRow.Cells[0].Value;
            RutaBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DistBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
    } 
