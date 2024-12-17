using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoConexionesWF1
{
    public partial class Form1 : Form
    {

        public static SqlConnection connection = null;
        static string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            authenticate();
        }

        private void authenticate()
        {

            var username = txtusername.Text;
            var password = txtpassword.Text;

            try
            {
                connection = new SqlConnection(connectionString);

                string sqlSentence = $"SELECT count(1) FROM t_usuarios WHERE login = '{username}' AND password = '{password}'";
                var sqlCommand = new SqlCommand(sqlSentence, connection);

                connection.Open();

                int sqlResult = Convert.ToInt32(sqlCommand.ExecuteScalar());

                connection.Close();

                if(sqlResult > 0)
                {
                    MessageBox.Show("Usuario correcto. Conectado");
                    this.Hide();

                    var mainScreen = new MainScreen();
                    mainScreen.Show();
                } else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }


            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var createUserForm = new UserForm();

            createUserForm.Show();
        }
    }
}
