#pragma checksum "C:\Front\Tugas 6\Pages\DetailEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541171b81189c031f1155e13dfda8580b1ea09be"
// <auto-generated/>
#pragma warning disable 1591
namespace PAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Front\Tugas 6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Front\Tugas 6\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Front\Tugas 6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Front\Tugas 6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Front\Tugas 6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Front\Tugas 6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Front\Tugas 6\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Front\Tugas 6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Front\Tugas 6\_Imports.razor"
using PAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Front\Tugas 6\_Imports.razor"
using PAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{id}")]
    public partial class DetailEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
 if(Employee == null || Employee.Department==null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 4 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "h1");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
           Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                               Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body- test-center");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "card-img-top");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 12 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                                       Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                                                                          Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n      ");
            __builder.OpenElement(17, "h4");
            __builder.AddContent(18, 
#nullable restore
#line 13 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
           Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n      ");
            __builder.OpenElement(20, "h4");
            __builder.AddContent(21, "Employee ID: ");
            __builder.AddContent(22, 
#nullable restore
#line 14 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                        Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n      ");
            __builder.OpenElement(24, "h4");
            __builder.AddContent(25, "Email: ");
            __builder.AddContent(26, 
#nullable restore
#line 15 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                  Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n      ");
            __builder.OpenElement(28, "h4");
            __builder.AddContent(29, "Department: ");
            __builder.AddContent(30, 
#nullable restore
#line 16 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                       Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n       ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                                                   Button_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, 
#nullable restore
#line 19 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                                                                  ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n       ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 20 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
                                            CssClass

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.AddMarkupContent(39, "<a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n          ");
            __builder.AddMarkupContent(40, "<a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n           ");
            __builder.AddMarkupContent(41, "<a href=\"#\" class=\"btn btn-danger\">Delete</a>");
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Front\Tugas 6\Pages\DetailEmployee.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
