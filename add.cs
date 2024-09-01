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
using System.Data.Common;

namespace BankApp
{
    public partial class add : Form
    {
        public add()
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

        
        private void add_Load(object sender, EventArgs e)
        {
            listed();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into users values(@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox3.Text));
            command.Parameters.AddWithValue("@p4", textBox4.Text);
            command.Parameters.AddWithValue("@p5", textBox5.Text);
            command.Parameters.AddWithValue("@p6", Convert.ToInt32(textBox6.Text));
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
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
    }
}
