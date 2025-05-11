using Simple.Domain.Entities;

namespace Simple.Domain
{
    public interface IOrderProcessor
    {
        Task ProcessOrderAsync(Sale sale);
    }
}
