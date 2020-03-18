using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
