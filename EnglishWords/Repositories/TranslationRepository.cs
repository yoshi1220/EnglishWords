using EnglishWords.Data;
using EnglishWords.Data.Models;

namespace EnglishWords.Repositories
{

    public class TranslationRepository : MasterRepository<Translation>, ITranslationRepository
    {
        public TranslationRepository(EnglishWordsDbContext context, ILogger<TranslationRepository> logger)
            : base(context, logger)
        {

        }

        public EnglishWordsDbContext EnglishWordsDbContext
        {
            get { return _context as EnglishWordsDbContext; }
        }


    }
}
