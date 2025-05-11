using MediatR;
using Simple.Domain;
using Simple.Domain.Entities;

namespace Simple.Application
{
    public class CreateSaleCommandHandler : IRequestHandler<CreateSaleCommand, Guid>
    {
        private readonly ISaleRepository _repository;

        public CreateSaleCommandHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
        {
            var sale = new Sale();

            foreach (var item in command.Request.Items)
            {
                if (item.Quantity > 0)
                {
                    sale.Items.Add(new SaleItem
                    {
                        ProductName = item.ProductName,
                        Quantity = item.Quantity
                    });

                }
            }

            await _repository.AddAsync(sale);

            return sale.Id;
        }
    }

}
