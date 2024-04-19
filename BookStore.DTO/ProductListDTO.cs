namespace BookStore.DTO
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Details { get; set; } = null!;
        public byte StockAmount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool Enabled { get; set; } = false;
        public int CategoryId { get; set; }
        public int ProductImageCount { get; set; }
        public int ProductCommentCount { get; set; }
    }
}
