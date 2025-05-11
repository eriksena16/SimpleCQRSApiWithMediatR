using MediatR;
using Simple.Domain;

namespace Simple.Application
{
    public class GetListSaleQueryHandler : IRequestHandler<GetListSaleQuery,List<SaleResponse>>
    {
        private readonly ISaleRepository _repository;

        public GetListSaleQueryHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<SaleResponse>> Handle(GetListSaleQuery request, CancellationToken cancellationToken)
        {
            var sales = await _repository.GetAllAsync();

            var salesList = sales
             .Select(sale => new SaleResponse(sale.Id, sale.IsProcessed, sale.Items.Count))
             .ToList();

            return salesList;
        }
    }
}
