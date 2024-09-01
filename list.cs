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


namespace BankApp
{
    public partial class list : Form
    {
        public list()
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
        private void list_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from users", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
