using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrud.Data
{
    public class SqlConfig
    {
        private string cadenaConexion;

        public string CadenaConexion { get => cadenaConexion; }

        public SqlConfig(string Conexion)
        {
            cadenaConexion = Conexion;
        }

    }
}
