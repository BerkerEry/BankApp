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
using System.Security.Cryptography;

namespace BankApp
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            this.Close();
            mainmenu.Show();
        }

        SqlConnection connection = new SqlConnection("Data Source=BERKER\\SQLEXPRESS;Initial Catalog=bankapp;Integrated Security=True;Encrypt=False");

        private void delete_Load(object sender, EventArgs e)
        {
            listed();

        }

        private void listed()
        {
            SqlCommand command = new SqlCommand("select * from users", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            if (comboBox1.SelectedIndex == 0)
            {
                command = new SqlCommand("delete from users where name=@p1", connection);
                command.Parameters.AddWithValue("@p1", textBox1.Text);

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                command = new SqlCommand("delete from users where identitynumber=@p1", connection);
                command.Parameters.AddWithValue("@p1", textBox1.Text);
            }
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            listed();

            



        }
    }
}
