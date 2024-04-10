
namespace BookStore.DTO
{
    public class ProductCommentDTO
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public byte StarCount { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ProductId { get; set; }

    }
}
