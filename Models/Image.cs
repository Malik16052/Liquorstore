using BookSawNew.Models.Base;

namespace BookSawNew.Models
{
    public class Image : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
