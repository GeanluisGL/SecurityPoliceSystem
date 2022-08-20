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
    public partial class Bus : Form
    {

        private string IDPeople;
        private bool Edit = false;
        E_Bus objEntindad = new E_Bus();
        N_Bus objNeg = new N_Bus();

        public Bus()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal Home = new Principal();
            Home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Search

        public void Buscar(string buscar)
        {
            N_Bus objNegocio = new N_Bus();
            dataGridView1.DataSource = objNegocio.ListarBus(buscar);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Buscar(SearchBox.Text);
        }


        //Create

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {

                        objEntindad.PLACA = PlacaBox.Text.ToUpper();
                        objEntindad.MARCA = MarcaBox.Text.ToUpper();
                        objEntindad.MODELO = ModeloBox.Text.ToUpper();
                        objEntindad.COLOR = colorBox.Text.ToUpper();
                        objEntindad.YIAR = BirthDate.Text.ToUpper();

                        objNeg.insertusB(objEntindad);

                        MessageBox.Show("Registro guardado.");
                        limpiar();
                        Buscar("");

                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro." + ex);
                    limpiar();
                    Buscar("");

                }
            }
            if (Edit == true)
            {
                try
                {
                    objEntindad.PLACA = (string)dataGridView1.CurrentRow.Cells[0].Value;
                    objEntindad.MARCA = MarcaBox.Text.ToUpper();
                    objEntindad.MODELO = ModeloBox.Text.ToUpper();
                    objEntindad.COLOR = colorBox.Text.ToUpper();
                    objEntindad.YIAR = BirthDate.Text.ToUpper();

                    objNeg.updateB(objEntindad);

                    MessageBox.Show("Registro editado exitosamente.");
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

        private void BirthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        public void limpiar()
        {
            PlacaBox.Text = "";
            ModeloBox.Text = "";
            MarcaBox.Text = "";
            BirthDate.Text = "";
            colorBox.Text = "";

        }
       
        private void Bus_Load(object sender, EventArgs e)
        {
            objNeg.Showlist();
        }

        private void BirthDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                Edit = true;


                PlacaBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ModeloBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                MarcaBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                colorBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                BirthDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {

                MessageBox.Show("Selecciona una fila");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEntindad.PLACA = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objNeg.deleteB(objEntindad);
                MessageBox.Show("Registro eliminado");
                objNeg.Showlist();
            }
        }
    } 
}
