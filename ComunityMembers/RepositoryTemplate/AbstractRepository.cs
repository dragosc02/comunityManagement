using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CommunityMembersModels.Contracts;

using CommunityRepository.DatabaseContext;

namespace CommunityRepository
{
    /// <summary>Abstract class which have the CRUD operations and is the base class for repositories.</summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractRepository<T> : IRepository<T> where T : IModel
    {
        /// <summary>Variable of FullDbContext type which helps to communicate with database.</summary>
        protected readonly FullDbContext _dataContext;

        /// <summary>Constructor. It is necessary a parameter: DbContext type.</summary>
        /// <param name="fullContext"></param>
        public AbstractRepository(FullDbContext fullContext)
        {
            _dataContext = fullContext;
        }

        /// <summary>This method gets the total number of records from a table.</summary>
        /// <returns>It returns total number of record from a table.</returns>
        public async Task<int> CountAsync()
        {
            IList<T> allItems = await GetAllAsync();
            return allItems.Count;
        }

        /// <summary>This method deletes asynchronously an item based on the given id.</summary>
        /// <param name="id"></param>
        /// <returns>Nothing.</returns>
        public async Task DeleteAsync(int id)
        {
            T item = await GetAsync(id);
            if (item != null)
            {
                await DeleteAsync(item);
            }
        }

        public abstract Task<IList<T>> GetAllAsync();

        public abstract Task<T> GetAsync(int id);

        /// <summary>This method saves (insert/update) asynchronously an item and the user number which called this method.</summary>
        /// <param name="item"></param>
        /// <param name="loggedUserId"></param>
        /// <returns>It returns the item which was saved.</returns>
        public async Task<T> SaveAsync(T item, int loggedUserId)
        {
            T result;
            if (item.Id > 0)
            {
                result = await UpdateAsync(item);
            }
            else
            {
                item.CreationDate = DateTime.Now;
                item.UserCreated = loggedUserId;
                result = await InsertAsync(item);
            }

            return result;
        }

        protected abstract Task DeleteAsync(T item);

        protected abstract Task<T> InsertAsync(T item);

        protected abstract Task<T> UpdateAsync(T item);
    }
}