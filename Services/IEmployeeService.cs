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
         Task<Employee> GetById(int id);
         Task<Employee> Update (int id, Employee employee);
        Task<Employee> Add(Employee employee);
    }   
}