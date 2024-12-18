using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineStoreZaliczenie.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        [StringLength(150, ErrorMessage = "Max 150 characters.")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [StringLength(255, ErrorMessage = "Max 255 characters.")]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [DataType(DataType.Currency, ErrorMessage = "This must be a number.")]
        public decimal Price { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category{ get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();



    }
}
