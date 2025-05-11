namespace Simple.Application
{
    public class CreateSaleRequest
    {
        public List<SaleItemRequest> Items { get; set; } = new();
    }
}
