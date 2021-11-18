


using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using PAS.Models;
using PAS.Services;

namespace PAS.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();
       
        [Inject]
        
        public IEmployeeService  EmployeeService { get; set; }

        [Parameter]
        public string  Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetById(int.Parse(Id));
        }

    }
    }
 