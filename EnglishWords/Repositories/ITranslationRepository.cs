using EnglishWords.Data.Models;

namespace EnglishWords.Repositories
{
    /// <summary>
    /// マスターメンテ用Repositoryインターフェイス
    /// </summary>
    /// <typeparam name="TEntity">モデルを指定する</typeparam>
    public interface ITranslationRepository : IMasterRepository<Translation>
    {


    }
}