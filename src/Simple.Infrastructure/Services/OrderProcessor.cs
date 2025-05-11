using Simple.Domain;
using Simple.Domain.Entities;

namespace Simple.Infrastructure
{
    public class OrderProcessor : IOrderProcessor
    {
        public Task ProcessOrderAsync(Sale sale)
        {
            // Simula regras e lógica de negócio envolvendo serviços externos
            sale.MarkAsProcessed();
            return Task.CompletedTask;
        }
    }
 
}
