using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaApi.Models
{
    [Table("Usuarios")]
    public enum UserRole
    {
        Admin,
        Editor,
        Viewer
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public UserRole Role { get; set; } = UserRole.Editor;

        [StringLength(2)]
        public string PreferredLanguage { get; set; } = "pt";

        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}