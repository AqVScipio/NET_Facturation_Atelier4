#pragma checksum "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1f89d55e991b4a386955540477aa94924c39a3"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/facture")]
    public partial class Detail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Detail</h3>");
#nullable restore
#line 12 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
 if (fac != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                      fac

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                           HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "<thead><tr><th>Numéro</th>\r\n                    <th>Client</th>\r\n                    <th>Echeance</th>\r\n                    <th>Total</th></tr></thead>\r\n            ");
                __builder2.OpenElement(8, "tbody");
                __builder2.OpenElement(9, "tr");
                __builder2.OpenElement(10, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                fac.Numero

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.Numero = __value, fac.Numero))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fac.Numero));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                fac.Client

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.Client = __value, fac.Client))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fac.Client));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                     if (Facture.NbDaysRemaining(fac.DateReglement) <= Facture.DEADLINE_ALERT)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "td");
                __Blazor.Facturation.Client.Pages.Detail.TypeInference.CreateInputDate_0(__builder2, 22, 23, 
#nullable restore
#line 32 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                             fac.DateReglement

#line default
#line hidden
#nullable disable
                , 24, 
#nullable restore
#line 32 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                    fac.DateReglement

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.DateReglement = __value, fac.DateReglement)), 26, () => fac.DateReglement);
                __builder2.AddContent(27, " - ");
                __builder2.OpenElement(28, "span");
                __builder2.AddAttribute(29, "style", "color:red;");
                __builder2.AddContent(30, 
#nullable restore
#line 32 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                                                                               DeadlineToNbDaysRemaining(fac.DateReglement)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 33 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                    }
                    else if (Facture.NbDaysRemaining(fac.DateReglement) <= Facture.DEADLINE_WARNING)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "td");
                __Blazor.Facturation.Client.Pages.Detail.TypeInference.CreateInputDate_1(__builder2, 32, 33, 
#nullable restore
#line 36 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                             DateTime.Now.ToInputDate()

#line default
#line hidden
#nullable disable
                , 34, 
#nullable restore
#line 36 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                    fac.DateReglement

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.DateReglement = __value, fac.DateReglement)), 36, () => fac.DateReglement);
                __builder2.AddContent(37, " - ");
                __builder2.OpenElement(38, "span");
                __builder2.AddAttribute(39, "style", "color:orange;");
                __builder2.AddContent(40, 
#nullable restore
#line 36 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                                                                                           DeadlineToNbDaysRemaining(fac.DateReglement)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 37 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(41, "td");
                __Blazor.Facturation.Client.Pages.Detail.TypeInference.CreateInputDate_2(__builder2, 42, 43, 
#nullable restore
#line 40 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                             DateTime.Now.ToInputDate()

#line default
#line hidden
#nullable disable
                , 44, 
#nullable restore
#line 40 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                    fac.DateReglement

#line default
#line hidden
#nullable disable
                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.DateReglement = __value, fac.DateReglement)), 46, () => fac.DateReglement);
                __builder2.AddContent(47, " - ");
                __builder2.OpenElement(48, "span");
                __builder2.AddContent(49, 
#nullable restore
#line 40 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                                                                     DeadlineToNbDaysRemaining(fac.DateReglement)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 41 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(50, "td");
                __Blazor.Facturation.Client.Pages.Detail.TypeInference.CreateInputNumber_3(__builder2, 51, 52, 
#nullable restore
#line 43 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                  fac.MontantRegle

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.MontantRegle = __value, fac.MontantRegle)), 54, () => fac.MontantRegle);
                __builder2.AddContent(55, " / ");
                __Blazor.Facturation.Client.Pages.Detail.TypeInference.CreateInputNumber_4(__builder2, 56, 57, 
#nullable restore
#line 43 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                                                   fac.Montant

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fac.Montant = __value, fac.Montant)), 59, () => fac.Montant);
                __builder2.AddMarkupContent(60, " € (");
                __builder2.AddContent(61, 
#nullable restore
#line 43 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
                                                                                                                        fac.Montant - fac.MontantRegle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(62, " € restant dû)");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.AddMarkupContent(64, "<button type=\"submit\">Sauver les modifications</button>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(65);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(67);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 51 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\sandd\source\repos\Factu_Atelier4\Facturation\Facturation\Client\Pages\Detail.razor"
       
    private Facture fac = null;

    protected override async Task OnInitializedAsync()
    {
        fac = await http.GetFromJsonAsync<Facture>("api/factures/" + fRef.FReference);
    }

    private string DeadlineToNbDaysRemaining(DateTime date)
    {
        return (int)Math.Truncate((date - DateTime.Now).TotalDays) + " jours restants.";
    }

    private async Task HandleSubmit()
    {
        var response = await http.PostAsJsonAsync("api/factures/edit", fac);
        nav.NavigateTo("factures");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FactureRef fRef { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Facturation.Client.Pages.Detail
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
