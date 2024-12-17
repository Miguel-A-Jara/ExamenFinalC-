using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

enum UserFormMode
{
    CREATING,
    EDITING,
};

namespace ProyectoConexionesWF1
{
    public partial class UserForm : Form
    {
        static string active;
        static int accountId;


        public UserForm()
        {
            InitializeComponent();
        }

        private void loadUserIdButton_Click(object sender, EventArgs e)
        {
            resetFormFields();
            createUserButton.Enabled = true;

            var lastUserId = getLastUserId();
            var newUserId = lastUserId + 1;

            txtId.Text = newUserId.ToString();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            var isValid = validateForm();
            if (!isValid) return;

            createNewUser();
            resetFormFields();
        }

        private void resetFormFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRepeatPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private int getLastUserId()
        {
            var sqlSentence = "SELECT COALESCE(MAX(Id_usuario),0) FROM t_usuarios";
            var sqlCommand = new SqlCommand(sqlSentence, DbManager.DbConnection);

            var maxUserId = sqlCommand.ExecuteScalar();
            return Convert.ToInt32(maxUserId);
        }

        private bool validateForm()
        {

            bool isValid = true;

            if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                isValid = false;
            }

            return isValid;
        }

        private void createNewUser()
        {
            int userId = Convert.ToInt32(txtId.Text);

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            string activeStatus = isActive.Checked
                ? "V"
                : "F";


            string sqlQuery = "INSERT INTO t_usuarios (id_usuario, login, password, mail, activo) " +
                  "VALUES (@userId, @username, @password, @mail, @activeStatus)";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, DbManager.DbConnection);

            sqlCommand.Parameters.AddWithValue("@userId", userId);
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@password", password);
            sqlCommand.Parameters.AddWithValue("@mail", email);
            sqlCommand.Parameters.AddWithValue("@activeStatus", activeStatus);


            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void showUser()
        {
            var selection = $"SELECT * FROM t_usuarios WHERE Id_usuario = {accountId}";
            var sqlCommand = new SqlCommand(selection, DbManager.DbConnection);

            var dbReader = sqlCommand.ExecuteReader();
            if (dbReader.Read())
            {
                editUserButton.Enabled = true;
                txtUsername.Text = dbReader["login"].ToString();
                txtEmail.Text = dbReader["mail"].ToString();
                if (dbReader["activo"].ToString() == "V")
                {
                    isActive.Checked = true;
                }
                else
                {
                    isInactive.Checked = true;
                }


            }
            else
            {
                MessageBox.Show("No hay registros para mostrar");
            }

            dbReader.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                accountId = 0;
                accountId += 1;
                txtId.Text = Convert.ToString(accountId);
            }
            else
            {
                accountId = Convert.ToInt32(txtId.Text);
                accountId += 1;
                txtId.Text = Convert.ToString(accountId);
            }

            showUser();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {

            if (txtId.Text == "")
            {
                accountId = 0;
                txtId.Text = "0";
            }

            accountId = Convert.ToInt32(txtId.Text);

            if (accountId > 1)
            {
                accountId = Convert.ToInt32(txtId.Text) - 1;
                txtId.Text = Convert.ToString(accountId);
            }

            showUser();
        }

        private void searchUserIdButton_Click(object sender, EventArgs e)
        {
            accountId = Convert.ToInt32(txtId.Text.Trim());
            showUser();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conexionADODataSet.t_usuarios' table. You can move, or remove it, as needed.
            this.t_usuariosTableAdapter.Fill(this.conexionADODataSet.t_usuarios);
            toolTip1.SetToolTip(previousButton, "Registro Anterior");
            toolTip1.SetToolTip(nextButton, "Registro Siguiente");
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            var lastUserId = getLastUserId();
            accountId = lastUserId;
            txtId.Text = Convert.ToString(accountId);

            showUser();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            var isValid = validateForm();
            if (!isValid) return;

            updateUser();
            resetFormFields();
        }

        private void updateUser()
        {

            int userId = Convert.ToInt32(txtId.Text);

            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string activeStatus = isActive.Checked
                ? "V"
                : "F";

            string sqlQuery = "UPDATE t_usuarios SET login=@username, password=@password, mail=@mail, activo=@activeStatus WHERE Id_usuario=@userId";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, DbManager.DbConnection);

            sqlCommand.Parameters.AddWithValue("mail", email);
            sqlCommand.Parameters.AddWithValue("userId", userId);
            sqlCommand.Parameters.AddWithValue("username", username);
            sqlCommand.Parameters.AddWithValue("password", password);
            sqlCommand.Parameters.AddWithValue("activeStatus", activeStatus);

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Usuario Actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
 
        private void loadTableData(SqlCommand sqlCommand)
        {
            var table = new DataTable();

            var adapter = new SqlDataAdapter(sqlCommand);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = userStatusSelect.Text;
            var isActive = selectedValue == "Activo";

            var query = $"select * from t_usuarios as usuario where usuario.activo = @activo";
            var sqlCmd = new SqlCommand(query, DbManager.DbConnection);

            sqlCmd.Parameters.AddWithValue("@activo", isActive ? "V" : "F");
            loadTableData(sqlCmd);
        }

        private void usernameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedUserId = usernameSelect.SelectedValue;
            if(selectedUserId == null) return;

            var query = $"select * from t_usuarios as usuario where usuario.Id_usuario = @userId";

            var sqlCmd = new SqlCommand(query, DbManager.DbConnection);
            sqlCmd.Parameters.AddWithValue("@userId", selectedUserId);

            loadTableData(sqlCmd);
        }
    }
}
