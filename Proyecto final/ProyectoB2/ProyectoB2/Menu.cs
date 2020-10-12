using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoB2
{
    public partial class Menu : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-EQIKN8E\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True");
        

        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form regmedicos = new RegMedicos();
            regmedicos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registros = new RegPacientes();
            registros.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registros = new RegHabitaciones();
            registros.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcCitas();
            procesos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcIngresos();
            procesos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form procesos = new ProcAltaMed();
            procesos.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultPacient();
            consultas.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultMedicos();
            consultas.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultHab();
            consultas.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultCitaM();
            consultas.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultIngresos();
            consultas.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form consultas = new ConsultAltaM();
            consultas.Show();
        }
    }

}
