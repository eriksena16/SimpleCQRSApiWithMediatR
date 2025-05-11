using MediatR;

namespace Simple.Application.Commands
{
    public record ProcessOrderCommand(Guid SaleId) : IRequest<SaleResponse>;
   
}
