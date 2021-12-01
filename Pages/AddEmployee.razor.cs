using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAS.Models;
using PAS.Services;
using Microsoft.AspNetCore.Components;

namespace PAS.Pages
{
    public partial class AddEmployee
    {
        private object obj;

        public Employee Employee { get; set; } = new Employee();
       
        [Inject]
        
        public IEmployeeService  EmployeeService { get; set; }

        [Inject]
        public  IDepartmentService DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string  Id { get; set; }

        protected async override  Task OnInitializedAsync()
        {
            
             Departments = (await DepartmentService.GetAll()).ToList();
          }
         protected async Task HandleValidSubmit(){
             Employee.PhotoPath ="images/nophoto.jpg";
             Employee result = await EmployeeService.Add(Employee);
            NavigationManager.NavigateTo("employeepage");
         }
    }
    }
 