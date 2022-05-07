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

        [Required(ErrorMessage = "間違えた回数は必須です")]
        public int MistakenCount { get; set; }

        [Required(ErrorMessage = "間違えた回数のトータルは必須です")]
        public int TotalMistakenCount { get; set; }

        [Required(ErrorMessage = "学習回数は必須です")]
        public int StudyCount { get; set; }

        [Required(ErrorMessage = "回答済みは必須です")]
        public bool Answered { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
