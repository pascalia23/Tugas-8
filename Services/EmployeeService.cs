using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PAS.Models;
using System.Net.Http.Json;

namespace PAS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService (HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Employee> Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return result;
        }

        

        public async Task <IEnumerable<Employee>> GetEmployee()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return results;
        }

        public Task<Employee> Update(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}