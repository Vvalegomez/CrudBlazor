using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrud.Data;

namespace SimpleCrud.Interfaces
{
    interface IClientesServices
    {
        Task<bool> GuardarCliente(Cliente cliente);

        Task<IEnumerable<Cliente>> DameTodosLosClientes();

        Task<Cliente> DameDatosClientes(int id);
    }
}
