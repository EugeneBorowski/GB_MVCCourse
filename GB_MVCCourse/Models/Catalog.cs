using GB_MVCCourse.Classes;

namespace GB_MVCCourse.Models
{
    public class Catalog
    {
        public ConcurrentList<Product> Products { get; set; } = new();
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
    }
}