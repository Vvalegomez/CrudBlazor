// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SimpleCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using SimpleCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\_Imports.razor"
using SimpleCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
using Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
using Repositorio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ListaClientes")]
    public partial class ListaClientes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
       

    private IEnumerable<Cliente> clientes;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            clientes = await ClientesServicio.DameTodosLosClientes();
        }
        catch
        {

            throw;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClientesServices ClientesServicio { get; set; }
    }
}
#pragma warning restore 1591