using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public interface IConfigurationManager
    {
        string GetValue(string chave);
    }
}
