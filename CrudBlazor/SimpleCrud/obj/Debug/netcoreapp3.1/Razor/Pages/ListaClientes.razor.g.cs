#pragma checksum "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d746d06c00147185db14051a7de1762185b39fb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>ListaClientes</h3>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
 if (clientes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "        ");
            __builder.AddMarkupContent(2, "<p> <em>Cargando..</em></p>\r\n");
#nullable restore
#line 12 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Nombre</th>\r\n                <th>Email</th>\r\n                <th>Telefono</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 24 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
             foreach (Cliente c in clientes)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
                     c.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
                     c.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
                     c.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 31 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 34 "C:\Users\Joaquin Auce\source\repos\CrudBlazor\SimpleCrud\Pages\ListaClientes.razor"
}

#line default
#line hidden
#nullable disable
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
