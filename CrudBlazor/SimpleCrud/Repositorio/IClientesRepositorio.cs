using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCrud.Data;

namespace SimpleCrud.Repositorio
{
    interface IClientesRepositorio
    {
        Task<bool> GuardarCliente(Cliente cliente);

        Task<IEnumerable<Cliente>> DameTodosLosClientes();

        Task<Cliente> DameDatosCliente(int id);

        Task<bool> ModificarCliente(Cliente cliente);

        Task<bool> BorrarCliente(int id);

        Task<IEnumerable<Cliente>> DameTodosLosClientes(String busqueda);
    }
}
