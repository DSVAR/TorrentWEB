#pragma checksum "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f52cf69218683d7b3ad5959f03880f7695a3c47"
// <auto-generated/>
#pragma warning disable 1591
namespace TorrentWEB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using TorrentWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\пробы\blazor\TorrentWEB\TorrentWEB\_Imports.razor"
using TorrentWEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Index.razor"
using TorrentWEB.Core.Parse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Index.razor"
using TorrentWEB.Core.Sites;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 10 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Index.razor"
     answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<TorrentWEB.Shared.SurveyPrompt>(4);
            __builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Index.razor"
 
    string answer = null;
    protected override void OnAfterRender(bool firstRender)
    {
        answer = _loader.GetHtmlByPage().Result;
       StateHasChanged();
        base.OnAfterRender(firstRender);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HtmlLoader _loader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService _storageService { get; set; }
    }
}
#pragma warning restore 1591