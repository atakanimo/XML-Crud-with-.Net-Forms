using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdvancoTask
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Users where Name=@user AND Password=@pass";
            string connectionString = ConfigurationManager.ConnectionStrings["AdvancoContext"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = new SqlCommand(querry, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@user", tbxUser.Text);
            sqlCommand.Parameters.AddWithValue("@pass", tbxPassword.Text);
            sqlConnection.Open();
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            sqlConnection.Close();
        }

    }
}
