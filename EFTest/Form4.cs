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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (var classicContext = new classicmodelsEntities())
            {
                var emp = (from list in classicContext.employees
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    dataGridView1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (var classContext = new classicmodelsEntities())
            { //keyword search
                dataGridView1.Rows.Clear();
                string keyword = txtSearch.Text;
                var resultSet = from list in classContext.employees
                                where list.email.Contains(keyword)
                                select list;
                foreach (var emp2 in resultSet.ToList())
                {
                    dataGridView1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                }
            }

        }
    }
}
