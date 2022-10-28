using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapstoneAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string? EmailId { get; set; }
        [ForeignKey("EmailId")]
        public virtual Register? Register { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }

        [Required]
        public DateOnly OrderDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int TotalPrice { get; set; }
        
        public string DeliveryStatus { get; set; }
        public bool ReturnStatus { get; set; }

    }
}
