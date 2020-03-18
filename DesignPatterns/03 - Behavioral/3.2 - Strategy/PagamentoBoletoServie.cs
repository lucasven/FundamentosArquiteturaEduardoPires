using DesignPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class PagamentoBoletoServie : IPagamento
    {
        private readonly IPagamentoBoletoFacade pagamentoBoletoFacade;

        public PagamentoBoletoServie(IPagamentoBoletoFacade pagamentoBoletoFacade)
        {
            this.pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(c => c.Valor);
            Console.WriteLine("Iniciando Pagamento via Boleto - Valor R$ " + pagamento.Valor);

            pagamento.LinhaDigitavelBoleto = pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando Pagamento";
            return pagamento;
        }
    }
}
