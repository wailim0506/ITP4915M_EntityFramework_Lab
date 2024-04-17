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
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Lab1_Load(object sender, EventArgs e)
        {
            using (var classicContext = new classicmodelsEntities())
            {
                //Select All
                var emp = (from list in classicContext.employees
                           select list);    // select * from employees

                foreach (var emp2 in emp.ToList())
                {
                    dgvLab1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                }

                //Select Filter
                var empQuery = from list in classicContext.employees
                               where list.lastName == "Bow"    //.Contains("Bow") 
                               select list;

                var empName = empQuery.FirstOrDefault<employees>();
                txtLab1.Text = empName.firstName;
            }
        }

        private void txtLab1_TextChanged(object sender, EventArgs e)
        {
            using (var classContext = new classicmodelsEntities())
            { //keyword search
                dgvLab1.Rows.Clear();
                string keyword = textBox1.Text;
                var resultSet = from list in classContext.employees
                                where list.lastName.Contains(keyword) //LIKE
                                select list;
                foreach (var emp2 in resultSet.ToList())
                {
                    dgvLab1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update Record
            using (var classicContext = new classicmodelsEntities())
            {
                var result = classicContext.employees.SingleOrDefault(employees => employees.lastName == "Bow");
                if (result != null)
                {
                    result.firstName = txtLab1.Text;
                    classicContext.SaveChanges();
                    //reload
                    dgvLab1.Rows.Clear();
                    string keyword = textBox1.Text;
                    var resultSet = from list in classicContext.employees
                                    where list.lastName.Contains(keyword) //LIKE
                                    select list;
                    foreach (var emp2 in resultSet.ToList())
                    {
                        dgvLab1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Insert Record
            using (var classicContext = new classicmodelsEntities())
            {
                employees emp = new employees();

                emp.employeeNumber = 5555;
                emp.lastName = "TestLastName";
                emp.firstName = "TestFirstName";
                emp.jobTitle = "TestJobTitle";
                emp.extension = "10char";
                emp.email = "TestEmail";
                emp.officeCode = "2";

                classicContext.employees.Add(emp);
                classicContext.SaveChanges();

                //reload
                dgvLab1.Rows.Clear();
                string keyword = textBox1.Text;
                var resultSet = from list in classicContext.employees
                                where list.lastName.Contains(keyword) //LIKE
                                select list;
                foreach (var emp2 in resultSet.ToList())
                {
                    dgvLab1.Rows.Add(emp2.employeeNumber, emp2.lastName, emp2.firstName, emp2.extension, emp2.email, emp2.officeCode, emp2.jobTitle);
                }
            }
        }
    }
}
