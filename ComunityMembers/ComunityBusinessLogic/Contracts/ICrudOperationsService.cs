using System.Collections.Generic;
using System.Threading.Tasks;

using CommunityMembersModels.Contracts;

namespace CommunityBusinessLogic.Contracts
{
    public interface ICrudOperationsService<T> where T:IModel
    {
        Task<T> SaveAsync(T item, int loggedUserId);

        Task DeleteAsync(T item);

        Task<T> Get(int id);

        Task<IList<T>> Get();
    }
}
