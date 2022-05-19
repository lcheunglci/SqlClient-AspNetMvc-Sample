using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppFxData.Models;

namespace WebAppFxData.Services
{
    public class SqlEmployeeData : IEmployeeData
    {
        List<Employee> _employees;
        public SqlEmployeeData()
        {
            _employees = new List<Employee>();
            
        }
        public IEnumerable<Employee> GetAll()
        {
            _employees.Clear();
            using (var connection = new SqlConnection("Data Source=.; Initial Catalog=Northwind; Integrated Security=SSPI; Encrypt=false"))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select EmployeeId, FirstName, LastName, Title from dbo.Employees";
                    cmd.Connection = connection;

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        _employees.Add(new Employee
                        {
                            Id = (int)reader[0],
                            FirstName = reader[1] as string,
                            LastName = reader[2] as string,
                            Title = reader[3] as string
                        });
                    }
                }
                System.Threading.Thread.Sleep(5000);
            }
            return _employees;
        }
    }
}
