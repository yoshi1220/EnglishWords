using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishWords.Data.Models
{
    [Table("Translations")]
    public class Translation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Chapter { get; set; }

        [Required]
        public string OriginalSentence { get; set; }

        [Required]
        public string TranslatedSentence { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
