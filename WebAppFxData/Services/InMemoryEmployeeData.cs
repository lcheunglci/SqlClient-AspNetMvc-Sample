using System.Collections.Generic;
using System.Linq;
using WebAppFxData.Models;

namespace WebAppFxData.Services
{
    public class InMemoryEmployeeData : IEmployeeData
    {
        List<Employee> _employees;
        public InMemoryEmployeeData()
        {
            _employees = new List<Employee>()
            {
                new Employee { Id =1, FirstName= "Bob", LastName="Doe", Title="Software Developer" },
                new Employee { Id =2, FirstName= "Edmond", LastName="Honda", Title="Chef" },
                new Employee { Id =3, FirstName= "Ken", LastName="Masters", Title="CEO" },

            };
        }
        public IEnumerable<Employee> GetAll()
        {
            return _employees.OrderBy(f => f.FirstName);
        }
    }
}
