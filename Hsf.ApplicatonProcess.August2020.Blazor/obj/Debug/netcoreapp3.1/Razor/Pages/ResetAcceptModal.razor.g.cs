#pragma checksum "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\Pages\ResetAcceptModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb4180ec0556eea8ef74863cc88d586d15efa41"
// <auto-generated/>
#pragma warning disable 1591
namespace Hsf.ApplicatonProcess.August2020.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Hsf.ApplicatonProcess.August2020.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Hsf.ApplicatonProcess.August2020.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class ResetAcceptModal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div>\r\n    <h3>Do You really want to reset input fields?</h3>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "center");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn custom-btn");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\Pages\ResetAcceptModal.razor"
                                             YesClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn custom-btn");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\Pages\ResetAcceptModal.razor"
                                             NoClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Bartek\source\repos\Hsf.ApplicatonProcess.Application\Hsf.ApplicatonProcess.August2020.Blazor\Pages\ResetAcceptModal.razor"
       
    [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

    void YesClick()
    {

    }

    void NoClick()
    {
        BlazoredModal.Close();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
