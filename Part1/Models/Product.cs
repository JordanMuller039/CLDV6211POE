using System.ComponentModel.DataAnnotations;

namespace Part1.Models
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Category { get; set; }
        public string Availability { get; set; }
    }
}
