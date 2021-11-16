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
    }
}
