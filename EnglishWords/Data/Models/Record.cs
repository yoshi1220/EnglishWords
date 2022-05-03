using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EnglishWords.Data.Models
{
    [Table("Records")]
    public class Record
    {
        [Key]
        public int Id { get; set; }

        public int Count { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }

    }
}
