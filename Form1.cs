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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            list list = new list();
            this.Hide();
            list.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add add = new add();
            this.Hide();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delete delete = new delete();
            this.Hide(); 
            delete.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            update update = new update();
            this.Hide(); 
            update.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            search search = new search();
            this.Hide();
            search.Show();
        }
    }
}
