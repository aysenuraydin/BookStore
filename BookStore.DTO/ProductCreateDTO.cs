namespace BookStore.DTO
{
    public class ProductCreateDTO
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Details { get; set; } = null!;
        public byte StockAmount { get; set; }
        public bool Enabled { get; set; }
        public int CategoryId { get; set; }

    }
}
