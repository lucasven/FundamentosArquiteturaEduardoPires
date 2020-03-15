using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Solucao
{
    public interface IClienteRepository
    {
        void AdicionarCliente(Cliente cliente);
    }
}
