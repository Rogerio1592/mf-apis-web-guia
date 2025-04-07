using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaApi.Models
{
    [Table("Contatos")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [Phone]
        public string WhatsApp { get; set; }

        public SocialMedia SocialMedia { get; set; }
        public SupportHours SupportHours { get; set; }
        public List<string> SupportSpecs { get; set; } = new List<string>();

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }

    [ComplexType]
    public class SocialMedia
    {
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }
    }

    [ComplexType]
    public class SupportHours
    {
        public string Weekdays { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
    }
}