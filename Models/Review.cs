using BookSawNew.Models.Base;

namespace BookSawNew.Models
{
    public class Review : BaseEntity
    {
        public string Comment { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
