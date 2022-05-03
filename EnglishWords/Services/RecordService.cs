using EnglishWords.Data.Models;
using EnglishWords.Repositories;

namespace EnglishWords.Services
{
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _RecordRepository;

        public RecordService(IRecordRepository RecordRepository)
        {
            _RecordRepository = RecordRepository;
        }

        public void Add(Record entity)
        {
            _RecordRepository.Add(entity);
        }

        public Record Get(int id)
        {
            return _RecordRepository.Get(id);
        }

        /// <summary>
        /// ユーザーデータを全件取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Record> GetAll()
        {
            return _RecordRepository.GetAll();
        }

        public void Remove(int id)
        {
            _RecordRepository.Remove(id);
        }

        public void Update(Record entity, int id)
        {
            _RecordRepository.Update(entity, id);
        }

    }
}
