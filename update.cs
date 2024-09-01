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
    public partial class update : Form
    {
        public update()
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


        private void update_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update users set name=@p1, surname=@p2, age=@p3, identitynumber=@p4, job=@p5, balance=@p6 where id=@p7", connection);
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox3.Text));
            command.Parameters.AddWithValue("@p4", textBox4.Text);
            command.Parameters.AddWithValue("@p5", textBox5.Text);
            command.Parameters.AddWithValue("@p6", Convert.ToInt32(textBox6.Text));
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            command.Parameters.AddWithValue("@p7", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            Listed();

        }
    }
}
