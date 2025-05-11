using MediatR;
using Simple.Application.Commands;
using Simple.Domain;

namespace Simple.Application.Handlers
{
    public class ProcessOrderCommandHandler : IRequestHandler<ProcessOrderCommand, SaleResponse>
    {
        private readonly ISaleRepository _repository;
        private readonly IOrderProcessor _processor;

        public ProcessOrderCommandHandler(ISaleRepository repository, IOrderProcessor processor)
        {
            _repository = repository;
            _processor = processor;
        }

        public async Task<SaleResponse> Handle(ProcessOrderCommand request, CancellationToken cancellationToken)
        {
            var sale = await _repository.GetByIdAsync(request.SaleId);
            if (sale == null)
                throw new KeyNotFoundException("Sale not found.");

            await _processor.ProcessOrderAsync(sale);

            await _repository.UpdateAsync(sale);
            return new SaleResponse(sale.Id, sale.IsProcessed, sale.Items.Count);
        }

    }
}
