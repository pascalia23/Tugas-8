using System.Runtime.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using PAS.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PAS.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService (HttpClient httpClient)
        {
            _httpClient = httpClient;
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

        public async Task<Employee> Update(int id, Employee employee)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Employees/{id}",employee);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else {
                throw new Exception("Gagal Update Employee");
            }
        }
        public async Task<Employee> Add(Employee obj){
            var response = await _httpClient.PostAsJsonAsync($"api/Employees",obj);
          if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else {
                throw new Exception("Gagal Add Employee");
            }
        }

        public Task<Employee> Add(Employee employee, object obj)
        {
            throw new NotImplementedException();
        }
    }
}