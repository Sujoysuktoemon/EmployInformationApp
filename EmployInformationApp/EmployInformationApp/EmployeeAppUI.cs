using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployInformationApp.BLL;

namespace EmployInformationApp
{
    public partial class EmployeeAppUI : Form
    {
        public EmployeeAppUI()
        {
            InitializeComponent();
        }
        Employee aEmployee = new Employee();
        private void showButton_Click(object sender, EventArgs e)
        {
            aEmployee.id = idTextBox.Text;
            aEmployee.name = NameTextBox.Text;
            aEmployee.salary = SalaryTextBox.Text;
            EmployeeBLL aEmployeeBll=new EmployeeBLL();
            string msg= aEmployeeBll.Save(aEmployee);

            ClearTxtbox();
            MessageBox.Show("Employee Information...." + "\nId:" + aEmployee.id + "\nName:" + aEmployee.name +
                            "\nSalary:" + aEmployee.salary+"\n"+ "\n"+ msg);
        }

        private void ClearTxtbox()
        {
            idTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            SalaryTextBox.Text = string.Empty;
        }

        private void RetriveButton_Click(object sender, EventArgs e)
        {
            RetriveInfo();
        }

        private void RetriveInfo()
        {
            idTextBox.Text = aEmployee.id;
            NameTextBox.Text = aEmployee.name;
            SalaryTextBox.Text = aEmployee.salary;
        }
    }
}
