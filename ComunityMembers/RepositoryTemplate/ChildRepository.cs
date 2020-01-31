using CommunityModels.MembershipModels.Details;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    /// <summary>
    /// Child Repository.
    /// </summary>
    public class ChildRepository : AbstractRepository<Child>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public ChildRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Child based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(Child item)
        {
            Child child = await GetAsync(item.Id);
            _dataContext.Children.Remove(child);
            await _dataContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets asynchronously the list with Children from database.
        /// </summary>
        /// <returns>It returns a list with all Children from database.</returns>
        public override async Task<IList<Child>> GetAllAsync()
        {
            return await _dataContext.Children.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method gets asynchronously a Child from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Member based on the given id.</returns>
        public override async Task<Child> GetAsync(int id)
        {
            return await _dataContext.Children.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        /// <summary>
        /// This method inserts asynchronously a Child.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<Child> InsertAsync(Child item)
        {
            await _dataContext.Children.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Child based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<Child> UpdateAsync(Child item)
        {
            Child child = await _dataContext.Children.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
            child.BirthDate = item.BirthDate;
            child.BirthPlace = item.BirthPlace;
            child.FirstName = item.FirstName;
            child.Id = item.Id;
            child.LastName = item.LastName;
            child.MemberId = item.MemberId;
            child.Mentions = item.Mentions;

            await _dataContext.SaveChangesAsync();
            return child;
        }
    }
}
