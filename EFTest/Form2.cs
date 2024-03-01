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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var classicContext = new classicmodelsEntities())
            {
                var allEmpNum = from list in classicContext.employees
                                select list.employeeNumber; //select employeeNumber from employees
                                                            //var emp = classContext.employees.Select(i => i.employeeNumber);

                //new codes – filtering by Email and Employee Number
                var allEmpNum2 = classicContext.employees.Where(i => i.email.Contains("ab") || i.employeeNumber == 1501).Select(i => i.employeeNumber);


                foreach (var empno in allEmpNum2.ToList())
                {
                    listBox1.Items.Add(empno);
                }
            }
        }
    }
}
