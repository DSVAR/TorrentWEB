#pragma checksum "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d59bc7758b468bde21fcac90a80b326692b36aac"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\пробы\blazor\TorrentWEB\TorrentWEB\Pages\Counter.razor"
       
    private int currentCount = 0;

    private async Task IncrementCount()
    {
        currentCount++;
        await _session.SetItemAsync("currentCount", currentCount);
    }
    

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
      //  var sw = tor.GetFiles();
        if(firstRender){
            var cure=  await _session.GetItemAsStringAsync("currentCount");
            if (cure == null)
            {
                currentCount = 0;
            }
            else
            {
                currentCount=await _session.GetItemAsync<int>("currentCount");
            }
            StateHasChanged();

        }
        //return base.OnAfterRenderAsync(firstRender);
    }
    
 


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService _session { get; set; }
    }
}
#pragma warning restore 1591
