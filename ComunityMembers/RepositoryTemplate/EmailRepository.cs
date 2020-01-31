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
    /// Email Repository.
    /// </summary>
    public class EmailRepository : AbstractRepository<Email>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public EmailRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Email based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(Email item)
        {
            Email email = await GetAsync(item.Id);
            _dataContext.EmailAddresses.Remove(email);
            await _dataContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets asynchronously the list with Emails from database.
        /// </summary>
        /// <returns>It returns a list with all Emails from database.</returns>
        public override async Task<IList<Email>> GetAllAsync()
        {
            return await _dataContext.EmailAddresses.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method gets asynchronously a Email from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Email based on the given id.</returns>
        public override async Task<Email> GetAsync(int id)
        {
            return await _dataContext.EmailAddresses.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        /// <summary>
        /// This method inserts asynchronously a Email.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<Email> InsertAsync(Email item)
        {
            await _dataContext.EmailAddresses.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Email based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<Email> UpdateAsync(Email item)
        {
            Email email = await _dataContext.EmailAddresses.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
            email.EmailAddress = item.EmailAddress;
            email.Id = item.Id;
            email.IsMain = item.IsMain;

            await _dataContext.SaveChangesAsync();
            return email;
        }
    }
}
