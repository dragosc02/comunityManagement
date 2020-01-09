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
    /// Phone Repository.
    /// </summary>
    public class PhoneRepository : AbstractRepository<Phone>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public PhoneRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Phone Number based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(Phone item)
        {
            Phone phone = await GetAsync(item.Id);
            _dataContext.PhoneNumbers.Remove(phone);
            await _dataContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets asynchronously the list with Phone Numbers from database.
        /// </summary>
        /// <returns>It returns a list with all Phone Numbers from database.</returns>
        protected override async Task<IList<Phone>> GetAllAsync()
        {
            return await _dataContext.PhoneNumbers.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method gets asynchronously a Phone Number from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Phone Number based on the given id.</returns>
        protected override async Task<Phone> GetAsync(int id)
        {
            return await _dataContext.PhoneNumbers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        /// <summary>
        /// This method inserts asynchronously a Phone Number.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<Phone> InsertAsync(Phone item)
        {
            await _dataContext.PhoneNumbers.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Phone Number based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<Phone> UpdateAsync(Phone item)
        {
            Phone phone = await _dataContext.PhoneNumbers.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
            phone.Description = item.Description;
            phone.IsMain = item.IsMain;

            await _dataContext.SaveChangesAsync();
            return phone;
        }

        
    }
}
