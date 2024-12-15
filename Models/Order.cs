using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OnlineStoreZaliczenie.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser IdentityUser { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [Column(TypeName = "varchar(12)")]
        public OrderStatus Status { get; set; }

        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered,
            Cancelled
        }

        


        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    }
}
