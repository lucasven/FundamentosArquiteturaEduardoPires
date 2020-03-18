using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public interface IPayPalGateway
    {
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
        string GetCardHashKey(string serviceKey, string cartaoCredito);
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
    }
}
