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
    public partial class Asignar : Form
    {
        E_Task objEntindad = new E_Task();
        N_Asignar objNeg = new N_Asignar();

        private string IDTravel;
        private bool Edit = false;
        int choferVal;
        string busVal;
        int rutaVal;

        public Asignar()
        {
            InitializeComponent();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

            if (Edit == false)
            {
                try
                {

                    objEntindad.CHOFER = choferVal;
                    objEntindad.ID_BUS = busVal;
                    objEntindad.RUTA= rutaVal;

                    objNeg.insertTV(objEntindad);

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
                    objEntindad.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    objEntindad.CHOFER = choferVal;
                    objEntindad.ID_BUS = busVal;
                    objEntindad.RUTA = rutaVal;

                    objNeg.updateTV(objEntindad);

                    MessageBox.Show("Registro guardado.");
                    objNeg.Showlist();
                    limpiar();
                    Edit = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro." + ex);
                    limpiar();
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                Edit = true;
                objEntindad.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                ChoferBox.SelectedIndex = (int)dataGridView1.CurrentRow.Cells[1].Value;
                BusBox.SelectedIndex = (int)dataGridView1.CurrentRow.Cells[2].Value;
                Rutabox.SelectedIndex = (int)dataGridView1.CurrentRow.Cells[3].Value;

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
                objEntindad.ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                objNeg.DeleteTV(objEntindad);
                MessageBox.Show("Registro eliminado");
                objNeg.Showlist();
            }
            else { 
            
                MessageBox.Show("Seleccione una tabla");
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal Home = new Principal();
            Home.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Buscar(SearchBox.Text);
        }

        public void limpiar()
        {
           ChoferBox.SelectedIndex = -1;
           BusBox.SelectedIndex = -1;
           Rutabox.SelectedIndex = -1;

        }


        public void Buscar(string buscar)
        {
            N_Asignar objNegocio = new N_Asignar();
            dataGridView1.DataSource = objNegocio.ListViajes(buscar);
        }

        private void Asignar_Load(object sender, EventArgs e)
        {
            ChoferBox.DataSource = objNeg.ChoferCom();
            ChoferBox.DisplayMember = "NOMBRE";
            ChoferBox.ValueMember = "ID";
            ChoferBox.SelectedIndex = -1;

            BusBox.DataSource = objNeg.BusCom();
            BusBox.DisplayMember = "MARCA";
            BusBox.ValueMember = "PLACA";
            BusBox.SelectedIndex = -1;

            Rutabox.DataSource = objNeg.RutarCom();
            Rutabox.DisplayMember = "Ruta";
            Rutabox.ValueMember = "ID";
            Rutabox.SelectedIndex = -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChoferBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            choferVal = ChoferBox.SelectedIndex;
            
        }

        private void BusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             busVal = BusBox.Text.ToString();
        }

        private void Rutabox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rutaVal = Rutabox.SelectedIndex;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
