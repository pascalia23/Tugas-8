



using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using PAS.Models;
using PAS.Services;

namespace PAS.Pages
{
    public partial class EmployeePage
    {
        public IEnumerable<Employee> Employees { get; set; } 

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployee()).ToList();
        }
    }
}