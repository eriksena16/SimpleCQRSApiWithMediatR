using MediatR;

namespace Simple.Application
{
    public record CreateSaleCommand(CreateSaleRequest Request) : IRequest<Guid>;

}
