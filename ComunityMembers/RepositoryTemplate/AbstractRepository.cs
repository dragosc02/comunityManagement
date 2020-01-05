using CommunityMembersModels.Contracts;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public abstract class AbstractRepository<T> where T : IModel
    {
        public FullDbContext _dataContext { get; set; }

        public AbstractRepository(FullDbContext fullContext)
        {
            _dataContext = fullContext;
        }
        public void Delete(int Id)
        {
            Task<T> item = GetAsync(Id);
            if(item.Result != null)
            {
                DeleteAsync(item.Result);
            }
        }

        public int Count()
        {
            Task<IList<T>> allItems = GetAllAsync();
            return allItems.Result.Count;
        }

        public async Task<T> Save(T item, int loggedUserId)
        {
            T result;
            if(item.Id > 0)
            {
                // update
                result = await UpdateAsync(item);
            }
            else
            {
                // insert
                item.CreationDate = DateTime.Now;
                item.UserCreated = loggedUserId;
                result = await InsertAsync(item);
            }

            return result;
        }

        protected abstract Task<T> InsertAsync(T item);
        protected abstract Task<T> UpdateAsync(T item);
        protected abstract Task DeleteAsync(T item);
        protected abstract Task<T> GetAsync(int id);
        protected abstract Task<IList<T>> GetAllAsync();


    }
}
