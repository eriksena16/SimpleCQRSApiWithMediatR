using Microsoft.AspNetCore.Mvc;
using Simple.Application;
using Simple.Application.Commands;
using MediatR;

namespace Simple.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var query = await _mediator.Send(new GetListSaleQuery());

            return Ok(query);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = await _mediator.Send(new GetSaleByIdQuery(id));

            return Ok(query);
        }

        [HttpPost("{id}/process")]
        public async Task<IActionResult> ProcessOrder(Guid id)
        {
            await _mediator.Send(new ProcessOrderCommand(id));

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSaleRequest dto)
        {

            var saleId = await _mediator.Send(new CreateSaleCommand(dto));

            var sale = await _mediator.Send(new GetSaleByIdQuery(saleId));

            return Ok(sale);
        }

    }
}
