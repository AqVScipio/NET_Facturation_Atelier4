// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Facturation.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Facturation.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\_Imports.razor"
using Facturation.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Factures.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factures")]
    public partial class Factures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Factures.razor"
       
    private Facture[] factures;

    protected override async Task OnInitializedAsync()
    {
        factures = await Http.GetFromJsonAsync<Facture[]>("api/factures");
    }

    private int NbDaysRemaining(DateTime date)
    {
        return (int)Math.Truncate((date - DateTime.Now).TotalDays);
    }

    private void InspectFacture(string reference)
    {
        fRef.FReference = reference;
        nav.NavigateTo("facture");
    }

    private string previousElement = E_FactureSortBy.DateReglement;
    private string orderBy = E_FactureSortBy.ASC;
    private async Task SortBy(string element)
    {
        if(element == previousElement)
            orderBy = orderBy == E_FactureSortBy.ASC ? E_FactureSortBy.DESC : E_FactureSortBy.ASC;
        else
            orderBy = E_FactureSortBy.ASC;
        factures = await Http.GetFromJsonAsync<Facture[]>($"api/factures/{element}/{orderBy}");
        StateHasChanged();
        previousElement = element;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FactureRef fRef { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
