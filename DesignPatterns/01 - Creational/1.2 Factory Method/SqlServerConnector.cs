using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SQL...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
