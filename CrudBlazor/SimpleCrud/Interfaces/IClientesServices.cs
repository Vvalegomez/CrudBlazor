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

        Task<Cliente> DameDatosCliente(int id);

        Task<bool> BorrarCliente(int id);

        Task<IEnumerable<Cliente>> DameTodosLosClientes(string busqueda);
        //Task<bool> ModificarCliente(Cliente cliente);
    }
}
