using EnglishWords.Data.Models;
using EnglishWords.Repositories;

namespace EnglishWords.Services
{
    public class TranslationService : ITranslationService
    {
        private readonly ITranslationRepository _TranslationRepository;

        public TranslationService(ITranslationRepository TranslationRepository)
        {
            _TranslationRepository = TranslationRepository;
        }

        public void Add(Translation entity)
        {
            _TranslationRepository.Add(entity);
        }

        public Translation Get(int id)
        {
            return _TranslationRepository.Get(id);
        }

        public IEnumerable<Translation> GetAll()
        {
            return _TranslationRepository.GetAll();
        }

        public void Remove(int id)
        {
            _TranslationRepository.Remove(id);
        }

        public void Update(Translation entity, int id)
        {
            _TranslationRepository.Update(entity, id);
        }

    }
}
