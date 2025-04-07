using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaApi.Models
{
    [Table("Mensagens de Contatos")]
    public enum MessageStatus
    {
        New,
        InProgress,
        Resolved,
        Spam
    }

    public class ContactMessage
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

        [Phone]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        public MessageStatus Status { get; set; } = MessageStatus.New;

        public string IpAddress { get; set; }
        public string UserAgent { get; set; }

        public bool Responded { get; set; }
        public DateTime? ResponseDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}