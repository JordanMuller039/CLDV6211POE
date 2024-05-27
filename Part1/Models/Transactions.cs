using System.ComponentModel.DataAnnotations;
namespace Part1.Models
{
    public class Transactions
    {
        [Key]
        public Guid transactionID { get; set; }
        public decimal transactionAmount { get; set; }  
        public string ProductName { get; set; }

    }
}
