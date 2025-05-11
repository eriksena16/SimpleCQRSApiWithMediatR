namespace Simple.Domain.Entities
{
    public class SaleItem : Entity
    {
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; } = null!;
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
