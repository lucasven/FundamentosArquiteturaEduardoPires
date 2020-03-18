using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
