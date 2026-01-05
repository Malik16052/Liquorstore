using BookSawNew.Models.Base;
using System.ComponentModel;

namespace BookSawNew.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public string Format { get; set; }
        public List<Category> Categories { get; set; }
        public List<Image> Images { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
