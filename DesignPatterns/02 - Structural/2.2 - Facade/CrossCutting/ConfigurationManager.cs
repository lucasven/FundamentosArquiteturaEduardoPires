using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string chave)
        {
            return chave;
        }
    }
}
