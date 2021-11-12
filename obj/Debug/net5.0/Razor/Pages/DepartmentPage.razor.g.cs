#pragma checksum "C:\Front\PAS\Pages\DepartmentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ee003d8a06f066d1e583505a5fc0ed286631178"
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
#line 1 "C:\Front\PAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Front\PAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Front\PAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Front\PAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Front\PAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Front\PAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Front\PAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Front\PAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Front\PAS\_Imports.razor"
using PAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Front\PAS\_Imports.razor"
using PAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/departmentpage")]
    public partial class DepartmentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>Daftar Department</b></h3>\r\n");
            __builder.AddMarkupContent(1, "<p>By : Pascalia Girsang</p>\r\n\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, "<thead><tr><th>Department Id</th>\r\n            <th>Department Name</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 15 "C:\Front\PAS\Pages\DepartmentPage.razor"
         foreach (var dept in Departments) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 17 "C:\Front\PAS\Pages\DepartmentPage.razor"
                     dept.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 18 "C:\Front\PAS\Pages\DepartmentPage.razor"
                     dept.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "href", 
#nullable restore
#line 19 "C:\Front\PAS\Pages\DepartmentPage.razor"
                                $"departmentdetail/{dept.DepartmentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddContent(17, " Detail");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Front\PAS\Pages\DepartmentPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
