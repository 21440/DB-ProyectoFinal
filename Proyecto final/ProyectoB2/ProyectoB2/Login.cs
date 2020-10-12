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
    public partial class Login : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-EQIKN8E\\SQLEXPRESS; database=ProyectoFinal; integrated security=true");

        public Login()
        {
            InitializeComponent();
        }
        public void login()
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM log_in WHERE Usuario='" + txtUsuario.Text + "' AND Contraseña='" + txtPass.Text + "'", conexion);
                SqlDataReader dreader = comando.ExecuteReader();

                if (dreader.Read())
                {
                    this.Hide();
                    Form menu = new Menu();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos.");
                    txtUsuario.Text = string.Empty;
                    txtPass.Text = string.Empty;
                }

                conexion.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form registro = new RegistroUsuario();
            registro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chPass.Checked == true)
            {
                if (txtPass.PasswordChar == '*')
                {
                    txtPass.PasswordChar = '\0';
                }
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
