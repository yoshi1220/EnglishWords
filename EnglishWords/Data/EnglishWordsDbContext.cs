using EnglishWords.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EnglishWords.Data
{
    public class EnglishWordsDbContext : DbContext
    {
        public DbSet<EnglishWord> EnglishWords { get; set; }

        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Record> Records { get; set; }

        public DbSet<Translation> Translations { get; set; }

        public EnglishWordsDbContext(DbContextOptions<EnglishWordsDbContext> options) : base(options)
        {
        }
    }
}

