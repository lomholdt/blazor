#pragma checksum "/Users/jonas/code/Blazor/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab2f25955f17a8bba9e55caae984f2b7381bdde"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using Blazor;
    using Blazor.Shared;
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenComponent<Blazor.Shared.NavMenu>(3);
            builder.CloseComponent();
            builder.AddMarkupContent(4, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(5, "\r\n\r\n");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "main");
            builder.AddMarkupContent(8, "\r\n    ");
            builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "content px-4");
            builder.AddMarkupContent(12, "\r\n        ");
            builder.AddContent(13, Body);
            builder.AddMarkupContent(14, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
