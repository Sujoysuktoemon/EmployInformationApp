using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployInformationApp.DLL.Gateway
{
    class EmployeeGateway
    {
        public string save(Employee aEmployee)
        {
            string conn = @"server=SABBIRAHMEDEMON; database=Basis49;integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;

            connection.Open();

            string query = string.Format("INSERT INTO StdInfo VALUES('{0}','{1}','{2}')",
                aEmployee.id, aEmployee.name, aEmployee.salary);


            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();

            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
        }
    }
}
