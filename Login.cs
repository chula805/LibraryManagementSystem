using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "Data Source=DESKTOP-JUF5HQI\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            Command.CommandText = "Select * From Login Where Username='" + UsernameText.Text + "' and Password='" + PasswordText.Text + "' COLLATE Latin1_General_CS_AS";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            if (Data.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Home_Page HP = new Home_Page();
                HP.Show();
            }
            else
            {
                MessageBox.Show("Username or Password Wrong", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}