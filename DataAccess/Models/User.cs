using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public required string Username { get; set; }

        [MaxLength(72)]
        public required string PasswordHash { get; set; }

        [MaxLength(80)]
        [EmailAddress]
        public required string Email { get; set; }

        [MaxLength(40)]
        public string? Name { get; set; }

        public DateTime? Created { get; set; } = DateTime.Now;

        public virtual IEnumerable<Role> Roles { get; set; }
    }
}
