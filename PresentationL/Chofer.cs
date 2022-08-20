using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegociosL;
using EntityL;

namespace PresentationL
{
    public partial class Chofer : Form
    {
        E_Chofer objEntindad = new E_Chofer();
        N_Chofer objNeg = new N_Chofer();

        private string IDPeople;
        private bool Edit = false;

        public Chofer()
        {
            InitializeComponent();
        }


        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal Home = new Principal();
            Home.Show();
        }


        private void Searchbtn_Click(object sender, EventArgs e)
        {
            N_Chofer objNegocio = new N_Chofer();
            dataGridView1.DataSource = objNegocio;
        }

        public void Buscar(string buscar)
        {
            N_Chofer objNegocio = new N_Chofer();
            dataGridView1.DataSource = objNegocio.ListarChofer(buscar);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AllPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Buscar(SearchBox.Text);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                Edit = true;
                objEntindad.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                NameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                BirthDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DNABox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            else
            {

                MessageBox.Show("Selecciona una fila");
            }
        }

    

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (Edit == false)
            {
                try
                {

                    objEntindad.Nombre = NameBox.Text.ToUpper();
                    objEntindad.Apellido = LName.Text.ToUpper();
                    objEntindad.BirthFecha = BirthDate.Text.ToUpper();
                    objEntindad.Cedula = DNABox.Text.ToUpper();

                    objNeg.insert(objEntindad);

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

                    objEntindad.Nombre = NameBox.Text.ToUpper();
                    objEntindad.Apellido = LName.Text.ToUpper();
                    objEntindad.BirthFecha = BirthDate.Text.ToUpper();
                    objEntindad.Cedula = DNABox.Text.ToUpper();

                    objNeg.Update(objEntindad);

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

        private void DNABox_TextChanged(object sender, EventArgs e)
        {
        }

        private void DNABox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
           
        }

        public void limpiar()
        {
            NameBox.Text = "";
            LName.Text = "";
            BirthDate.Text = "";
            DNABox.Text = "";

        }

        private void BirthDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BirthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objEntindad.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                NameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                BirthDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                DNABox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                objNeg.Delete(objEntindad);
                MessageBox.Show("Registro eliminado");
                limpiar();
                objNeg.Showlist();
            }
        }

        private void Chofer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

