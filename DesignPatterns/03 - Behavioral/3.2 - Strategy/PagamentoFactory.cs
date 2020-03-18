using DesignPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch(meioPagamento)
            {
                case MeioPagamento.CartaoCredito:
                    return new PagamentoCartaoCreditoService(
                                new PagamentoCartaoCreditoFacade(
                                    new PayPalGateway(),
                                    new ConfigurationManager()));

                case MeioPagamento.Boleto:
                    return new PagamentoBoletoServie(new PagamentoBoletoFacade());

                case MeioPagamento.TransferenciaBancaria:
                    return new PagamentoTransferenciaService(new PagamentoTransferenciaFacade());

                default:
                    throw new ApplicationException("Meio de Pagamento não conhecido");
            }
        }
    }
}
