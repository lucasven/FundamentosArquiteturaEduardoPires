using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Pedido
    {
        public List<Produto> Produtos { get; set; }
        public Guid Id { get; set; }
    }
}
