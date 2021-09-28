namespace Bominos.Services
{
    using Bominos.Data.Models;

    using System.Threading.Tasks;

    public interface IDataService<TEntity> where TEntity : class
    {
        Task MarkMessageAsPublished(int id);

        Task Save(TEntity entity, params Message[] messages);
    }
}