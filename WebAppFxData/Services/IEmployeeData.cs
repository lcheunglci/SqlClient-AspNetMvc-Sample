using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppFxData.Models;

namespace WebAppFxData.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAll();
    }
}
