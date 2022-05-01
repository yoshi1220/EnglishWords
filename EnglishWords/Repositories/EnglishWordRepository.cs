using EnglishWords.Data;
using EnglishWords.Data.Models;

namespace EnglishWords.Repositories
{

    public class EnglishWordRepository : MasterRepository<EnglishWord>, IEnglishWordRepository
    {
        public EnglishWordRepository(EnglishWordsDbContext context, ILogger<EnglishWordRepository> logger)
            : base(context, logger)
        {

        }

        public EnglishWordsDbContext EnglishWordsDbContext
        {
            get { return _context as EnglishWordsDbContext; }
        }


    }
}
