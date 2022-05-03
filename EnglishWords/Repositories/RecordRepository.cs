using EnglishWords.Data;
using EnglishWords.Data.Models;

namespace EnglishWords.Repositories
{

    public class RecordRepository : MasterRepository<Record>, IRecordRepository
    {
        public RecordRepository(EnglishWordsDbContext context, ILogger<RecordRepository> logger)
            : base(context, logger)
        {

        }

        public EnglishWordsDbContext EnglishWordsDbContext
        {
            get { return _context as EnglishWordsDbContext; }
        }
    }
}
