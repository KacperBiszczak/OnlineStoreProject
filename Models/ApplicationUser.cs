using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreZaliczenie.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName = "varchar(100)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Country { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? City { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Address { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
