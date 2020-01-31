using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using CommunityBusinessLogic.Contracts;

using CommunityMembersModels.Contracts;

using CommunityRepository;

namespace CommunityBusinessLogic.Common
{
    public class CrudOperationService<T>: ICrudOperationsService<T> where T:IModel
    {
        protected readonly IRepository<T> _repository;

        public CrudOperationService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T> SaveAsync(T item, int loggedUserId)
        {
            T result = await _repository.SaveAsync(item, loggedUserId).ConfigureAwait(false);

            return result;
        }

        public virtual async Task DeleteAsync(T item)
        {
            await _repository.DeleteAsync(item.Id);
        }

        public virtual async Task<T> Get(int id)
        {
            T result = await _repository.GetAsync(id).ConfigureAwait(false);

            return result;
        }

        public virtual async Task<IList<T>> Get()
        {
            IList<T> results = await _repository.GetAllAsync().ConfigureAwait(false);

            return results;
        }
    }
}
