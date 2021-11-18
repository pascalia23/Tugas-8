using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAS.Models;
using PAS.Services;
using Microsoft.AspNetCore.Components;

namespace PAS.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();
       
        [Inject]
        
        public IEmployeeService  EmployeeService { get; set; }

        public  IDepartmentService DepartmentService { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();



        [Parameter]
        public string  Id { get; set; }

        protected async override  Task OnInitializedAsync()
        {
            
            Employee = await EmployeeService.GetById(int.Parse(Id));
            Departments = (await DepartmentService.GetAll()).ToList();
          }

    }
    }
 