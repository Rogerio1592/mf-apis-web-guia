using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaApi.Models
{
    [Table("Linguagens")]
    public class Language
    {
        [Key]
        [StringLength(2)]
        public string Code { get; set; } // "pt", "en", "es"

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public ICollection<Translation> Translations { get; set; }
    }

    public class Translation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        [StringLength(2)]
        public string LanguageCode { get; set; }

        [ForeignKey("LanguageCode")]
        public Language Language { get; set; }
    }
}
