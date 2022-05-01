using EnglishWords.Data.Models;
using EnglishWords.Repositories;

namespace EnglishWords.Services
{
    public class EnglishWordService : IEnglishWordService
    {
        private readonly IEnglishWordRepository _EnglishWordRepository;

        public EnglishWordService(IEnglishWordRepository EnglishWordRepository)
        {
            _EnglishWordRepository = EnglishWordRepository;
        }

        public void Add(EnglishWord entity)
        {
            _EnglishWordRepository.Add(entity);
        }

        public EnglishWord Get(int id)
        {
            return _EnglishWordRepository.Get(id);
        }

        /// <summary>
        /// ユーザーデータを全件取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EnglishWord> GetAll()
        {
            return _EnglishWordRepository.GetAll();
        }

        public void Remove(int id)
        {
            _EnglishWordRepository.Remove(id);
        }

        public void Update(EnglishWord entity, int id)
        {
            _EnglishWordRepository.Update(entity, id);
        }

    }
}
