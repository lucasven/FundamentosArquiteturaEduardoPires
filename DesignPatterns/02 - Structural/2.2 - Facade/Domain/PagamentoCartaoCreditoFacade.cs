using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly IPayPalGateway payPalGateway;
        private readonly IConfigurationManager configManager;

        public PagamentoCartaoCreditoFacade(IPayPalGateway payPalGateway, IConfigurationManager configManager)
        {
            this.payPalGateway = payPalGateway;
            this.configManager = configManager;
        }

        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            var apiKey = configManager.GetValue("apiKey");
            var encriptionKey = configManager.GetValue("encriptionKey");

            var serviceKey = payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = payPalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            var pagamentoResult = payPalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Valor);

            return true;
        }
    }
}
