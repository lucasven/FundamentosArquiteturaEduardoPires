using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
        public bool Opened { get; set; }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando Comando: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            Console.WriteLine("Conexão fechada");
        }
    }
}
