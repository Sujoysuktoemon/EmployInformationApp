using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployInformationApp.DLL.Gateway;

namespace EmployInformationApp.BLL
{
    class EmployeeBLL
    {
        EmployeeGateway aEmployeeGateway=new EmployeeGateway();
        public string Save(Employee aEmployee)
        {
            if (aEmployee.id==String.Empty ||aEmployee.name==String.Empty || aEmployee.salary==string.Empty)
            {
                return "plz be insert";
            }
            else
            {
                return aEmployeeGateway.save(aEmployee);
            }
        }
    }
}
