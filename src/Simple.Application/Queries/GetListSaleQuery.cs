using MediatR;

namespace Simple.Application
{
    public record GetListSaleQuery() : IRequest<List<SaleResponse>>;
}
