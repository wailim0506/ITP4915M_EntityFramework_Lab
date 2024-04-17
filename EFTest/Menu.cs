using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTest
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1 lab1 = new Lab1();
            lab1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 lab2 = new Form2();
            lab2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab3 lab3 = new Lab3();
            lab3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 lab4 = new Form4();
            lab4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 lab5 = new Form5();
            lab5.ShowDialog();
        }
    }
}
