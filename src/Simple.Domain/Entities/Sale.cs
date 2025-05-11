namespace Simple.Domain.Entities
{
    public class Sale : Entity
    {
    
        public List<SaleItem> Items { get; private set; } = new();
        public bool IsProcessed { get; private set; }

        public void MarkAsProcessed()
        {
            if (!Items.Any())
                throw new InvalidOperationException("It is not possible to process an order without items.");

            IsProcessed = true;
        }
    }
}
