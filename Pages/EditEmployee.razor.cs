
using System;
using Microsoft.AspNetCore.Components;
using PAS.Models;
using PAS.Services;
using System.Threading.Tasks;

namespace Tugas_7.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();
       
        [Inject]
        
        public IEmployeeService  EmployeeService { get; set; }

        [Parameter]
        public string  Id { get; set; }

        protected override Task  OnInitializedAsync()
        {
         override bae.OnInitilizedAsync();
        }

    }
    }
 