namespace E_Commerce_Website_Backend.Models
{
    public class Product
    {
     
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public int Stock { get; set; }
    }
    
}
