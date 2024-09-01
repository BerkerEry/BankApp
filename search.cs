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

namespace BankApp
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            this.Close();
            mainmenu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from users where name like '%'+@p1+'%'",connection);
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        SqlConnection connection = new SqlConnection("Data Source=BERKER\\SQLEXPRESS;Initial Catalog=bankapp;Integrated Security=True;Encrypt=False");

        private void search_Load(object sender, EventArgs e)
        {
            Listed();
        }

        private void Listed()
        {
            SqlCommand command = new SqlCommand("select * from users", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
