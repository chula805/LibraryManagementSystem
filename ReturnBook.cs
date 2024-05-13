using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Library_Management_System
{
    public partial class ReturnBook : UserControl
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "Data Source=DESKTOP-JUF5HQI\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            if (textBox1.Text != "")
            {
                Command.CommandText = "Select * From IssueBook Where UserID='" + textBox1.Text + "' and IsReturned='" + 0 + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    dataGridView1.DataSource = Data.Tables[0];
                }
                else
                {
                    dataGridView1.Columns.Clear();
                    MessageBox.Show("No Data Found for User About Issueing Book ", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        String User;
        String Book;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            button2.Enabled = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                User = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Book = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "Data Source=DESKTOP-JUF5HQI\\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Connection.Open();

            Command.CommandText = "SELECT IssueDate, ReturnDate FROM IssueBook WHERE UserID = @UserID AND ISBN = @ISBN";
            Command.Parameters.AddWithValue("@UserID", User);
            Command.Parameters.AddWithValue("@ISBN", Book);
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);

            if (Data.Rows.Count > 0)
            {
                DateTime issueDate = Convert.ToDateTime(Data.Rows[0]["IssueDate"]);
                DateTime returnDate = Convert.ToDateTime(Data.Rows[0]["ReturnDate"]);
                TimeSpan duration = returnDate - issueDate;
                int daysLate = (int)duration.TotalDays;

                // Assuming a fixed fine amount per day (e.g., $1 per day)
                int fineAmountPerDay = 1;
                int totalFine = fineAmountPerDay * daysLate;

                // Update the Fine column in the database
                Command.Parameters.Clear();
                Command.CommandText = "UPDATE IssueBook SET IsReturned = 1, Fine = @FineAmount WHERE UserID = @UserID AND ISBN = @ISBN";
                Command.Parameters.AddWithValue("@FineAmount", totalFine);
                Command.Parameters.AddWithValue("@UserID", User);
                Command.Parameters.AddWithValue("@ISBN", Book);
                Command.ExecuteNonQuery();

                // Update the quantity of the book in AddNewBook table
                Command.Parameters.Clear();
                Command.CommandText = "UPDATE AddNewBook SET Quantity = Quantity + 1 WHERE ISBN = @ISBN";
                Command.Parameters.AddWithValue("@ISBN", Book);
                Command.ExecuteNonQuery();

                MessageBox.Show("Book Returned Successfully !!", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error retrieving issue and return dates from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connection.Close();
        }
    }
}
