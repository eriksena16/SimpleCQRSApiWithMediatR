using MediatR;
using Simple.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Application
{
    public class GetSaleByIdQueryHandler : IRequestHandler<GetSaleByIdQuery, SaleResponse>
    {
        private readonly ISaleRepository _repository;

        public GetSaleByIdQueryHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<SaleResponse> Handle(GetSaleByIdQuery request, CancellationToken cancellationToken)
        {
            var sale = await _repository.GetByIdAsync(request.Id);
            if (sale == null)
                throw new KeyNotFoundException("Sale not found.");

            return new SaleResponse(sale.Id,sale.IsProcessed, sale.Items.Count);
        }
    }
}
