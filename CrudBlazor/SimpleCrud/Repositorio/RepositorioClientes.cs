using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SimpleCrud.Data;


namespace SimpleCrud.Repositorio
{
    public class RepositorioClientes : IClientesRepositorio
    {
        private string CadenaConexion;

        public RepositorioClientes(string cadenaConexion)
        {
            CadenaConexion = cadenaConexion;
        }

        private SqlConnection conexion()
        {
            return new SqlConnection(CadenaConexion);
        }

        public async Task<bool> GuardarCliente(Cliente cliente)
        {
            Boolean clienteCreado = false;
            SqlConnection sqlConexion = conexion();
            SqlCommand cmd = null;
            try
            {
                sqlConexion.Open();
                cmd = sqlConexion.CreateCommand();
                cmd.CommandText = "dbo.UsuariosAlta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = cliente.Nombre;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = cliente.Email;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 50).Value = cliente.Telefono;
                cmd.Parameters.Add("@FechaAlta", SqlDbType.DateTime).Value = DateTime.Now;

                await cmd.ExecuteNonQueryAsync();
                clienteCreado = true;
            }
            catch (SqlException ex)
            {

                throw new Exception("Error al guardar " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return clienteCreado;

        }

        public async Task<IEnumerable<Cliente>> DameTodosLosClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection sqlConexion = conexion();
            SqlCommand cmd = null;
            try
            {
                sqlConexion.Open();
                cmd = sqlConexion.CreateCommand();
                cmd.CommandText = "dbo.UsuariosLista";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.id = Convert.ToInt32(reader["Id"]);
                    c.Nombre = reader["Nombre"].ToString();
                    c.Email = reader["Email"].ToString();
                    c.Telefono = reader["Telefono"].ToString();
                    lista.Add(c);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {

                throw new Exception("error " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return lista;
        }

        public async Task<bool> ModificarCliente(Cliente cliente)
        {
            Boolean clienteModificado = false;
            SqlConnection sqlConexion = conexion();
            SqlCommand cmd = null;

            try
            {
                sqlConexion.Open();
                cmd = sqlConexion.CreateCommand();
                cmd.CommandText = "dbo.UsuariosAlta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = cliente.Nombre;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = cliente.Email;
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar, 50).Value = cliente.Telefono;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cliente.id;

                if (cliente.Nombre != null && cliente.Email != null && cliente.Telefono != null)
                    await cmd.ExecuteNonQueryAsync();
                clienteModificado = true;
            }
            catch (SqlException ex)
            {

                throw new Exception("Error al guardar " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return clienteModificado;
        }

        public async Task<Cliente> DameDatosCliente(int id)
        {
            Cliente c = new Cliente();
            SqlConnection sqlConexion = conexion();
            SqlCommand cmd = null;
            try
            {
                sqlConexion.Open();
                cmd.CommandText = "dbo.UsuariosLista";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader reader = await cmd.ExecuteReaderAsync();
                if (reader.Read())
                {
                    c.id = Convert.ToInt32(reader["id"]);
                    c.Nombre = reader["Nombre"].ToString();
                    c.Email = reader["Email"].ToString();
                    c.Telefono = reader["Telefono"].ToString();
                }
                reader.Close();
            }
            catch (SqlException ex)
            {

                throw new Exception("Error al guardar " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return c;
        }

        public async Task<bool> BorrarCliente(int id)
        {
            Boolean clienteBorrado = false;
            SqlConnection sqlConexion = conexion();
            SqlCommand cmd = null;
            try
            {
                sqlConexion.Open();
                cmd = sqlConexion.CreateCommand();
                cmd.CommandText = "dbo.UsuariosBaja";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                if(id>0)
                    await cmd.ExecuteNonQueryAsync();

                clienteBorrado = true;
                
            }
            catch (SqlException ex)
            {
                throw new Exception("error: " + ex.Message);
            }
            finally
            {
                cmd.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }
            return clienteBorrado;
        }
    }
}
