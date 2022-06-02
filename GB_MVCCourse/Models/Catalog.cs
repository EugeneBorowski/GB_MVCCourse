namespace GB_MVCCourse.Models
{
    public class Catalog
    {
        public List<Product> Products { get; set; } = new();
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Image { get; set; }
    }
}