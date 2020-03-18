using DesignPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ExecucaoStrategy
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto{ Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto{ Nome = "Tenis Adidas", Valor = new Random().Next(500)},
                new Produto{ Nome = "Tenis Adidas", Valor = new Random().Next(500)},
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var meioPagamentoCredito = new Pagamento
            {
                MeioPagamento = MeioPagamento.CartaoCredito,
                CartaoCredito = "5555 2222 5555 9999"
            };

            var meioPagamentoBoleto = new Pagamento
            {
                MeioPagamento = MeioPagamento.Boleto,
            };

            var meioPagamentoTransferencia = new Pagamento
            {
                MeioPagamento = MeioPagamento.TransferenciaBancaria,
                CartaoCredito = "5555 2222 5555 9999"
            };

            var pedidoCredito = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoCredito.MeioPagamento));
            var pagamentoCredito = pedidoCredito.RealizarPagamento(pedido, meioPagamentoCredito);
            Console.WriteLine(pagamentoCredito.Status);

            Console.WriteLine("-----------------------------------------------------------------");

            var pedidoBoleto = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoBoleto.MeioPagamento));
            var pagamentoBoleto = pedidoBoleto.RealizarPagamento(pedido, meioPagamentoBoleto);
            Console.WriteLine(pagamentoBoleto.Status);

            Console.WriteLine("-----------------------------------------------------------------");

            var pedidoTransferencia = new PedidoService(PagamentoFactory.CreatePagamento(meioPagamentoTransferencia.MeioPagamento));
            var pagamentoTransferencia = pedidoTransferencia.RealizarPagamento(pedido, meioPagamentoTransferencia);
            Console.WriteLine(pagamentoTransferencia.Status);

            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
