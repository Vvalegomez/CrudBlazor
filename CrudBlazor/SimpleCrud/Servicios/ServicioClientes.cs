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
            if (cliente.id == 0)
                return clientesRepositorio.GuardarCliente(cliente);
            else
                return clientesRepositorio.ModificarCliente(cliente);
        }

        public Task<IEnumerable<Cliente>> DameTodosLosClientes()
        {
            return clientesRepositorio.DameTodosLosClientes();
        }

        public Task<Cliente> DameDatosCliente(int id)
        {
            return clientesRepositorio.DameDatosCliente(id);
        }

        public Task<bool> BorrarCliente (int id)
        {
            return clientesRepositorio.BorrarCliente(id);
        }

        public Task<IEnumerable<Cliente>> DameTodosLosClientes(string busqueda)
        {
            return clientesRepositorio.DameTodosLosClientes(busqueda);
        }

        //public Task<bool> ModificarCliente(Cliente cliente)
        //{
        //    return clientesRepositorio.ModificarCliente(cliente);
        //}
    }
}
