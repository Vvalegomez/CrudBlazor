using SimpleCrud.Data;
using SimpleCrud.Interfaces;
using SimpleCrud.Repositorio;
using SimpleCrud.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Servicios
{
    public class ServicioClientes : IClientesServices
    {
        private IClientesRepositorio clientesRepositorio;
        private SqlConfig sqlConfig;

        public ServicioClientes(SqlConfig c)
        {
            sqlConfig = c;
            clientesRepositorio = new RepositorioClientes(sqlConfig.CadenaConexion);
        }

        public Task<bool>GuardarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
                return clientesRepositorio.GuardarCliente(cliente);
            else
                return null;
        }

        public Task<IEnumerable<Cliente>> DameTodosLosClientes()
        {
            return clientesRepositorio.DameTodosLosClientes();
        }
    }
}
