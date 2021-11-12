using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAS.Models;

namespace PAS.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetEmployee();
         Task<Employee> GetEmployee(int id);
    }
}