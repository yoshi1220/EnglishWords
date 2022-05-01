using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnglishWords.Data.Models
{
    /// <summary>
    /// 英単語保存用クラス
    /// </summary>
    [Table("EnglishWords")]
    public class EnglishWord
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "チャプター名は必須です")]
        public string ChapterName { get; set; }

        [Required(ErrorMessage = "単語は必須です")]
        public string Word { get; set; }

        [Required(ErrorMessage = "意味は必須です")]
        public string Meaning { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
