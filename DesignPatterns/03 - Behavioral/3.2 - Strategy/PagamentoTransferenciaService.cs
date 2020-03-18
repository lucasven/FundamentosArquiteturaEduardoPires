using DesignPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade pagamentoTransferenciaFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransferenciaFacade)
        {
            this.pagamentoTransferenciaFacade = pagamentoTransferenciaFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(c => c.Valor);
            Console.WriteLine("Iniciando Pagamento via Transferencia - Valor R$ " + pagamento.Valor);

            pagamento.LinhaDigitavelBoleto = pagamentoTransferenciaFacade.RealizarTransferencia();
            pagamento.Status = "Aguardando Pagamento";
            return pagamento;
        }
    }
}
