using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoInfrastructure.Data
{
    public class ConnectionFactory
    {
        private readonly IConfiguration _configuration;
        private static string _connectionString;
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString()
        {
            if (_connectionString != null)
            {
                return _connectionString;
            }


            var connectionString1 = _configuration.GetConnectionString("ConexaoDBSQL01");
            var connectionString2 = _configuration.GetConnectionString("ConexaoDBSQL02");
            using (var connection = new SqlConnection(connectionString1))
            {
                try
                {
                    connection.Open();
                    _connectionString = connectionString1;
                    return connectionString1;
                }
                catch
                {
                    _connectionString = connectionString2;
                    return connectionString2;
                }
            }

            return _connectionString;

        }
    }
}
