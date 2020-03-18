using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class TransacaoService
    {
        private readonly ILogger logger;

        public TransacaoService(ILogger logger)
        {
            this.logger = logger;
        }

        public void RealizarTransacao()
        {
            // Transação
            logger.Log("Transação realizada");
        }
    }
}
