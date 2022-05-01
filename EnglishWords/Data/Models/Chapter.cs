using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EnglishWords.Data.Models
{
    [Table("Chapters")]
    public class Chapter
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "チャプター名は必須です")]
        public string ChapterName { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

    }
}
