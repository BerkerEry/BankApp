using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "12345")
            {
                Form1 anasayfa = new Form1();
                this.Hide();
                anasayfa.Show();
                
            }
            else
            {
                MessageBox.Show("Username or Password is wrong", "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
                
            }
        }
    }
}
