using CommunityModels.MembershipModels.Details;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class EmailRepository : AbstractRepository<Email>
    {
        public EmailRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(Email item)
        {
            Email email = await GetAsync(item.Id);
            _dataContext.EmailAddresses.Remove(email);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<IList<Email>> GetAllAsync()
        {
            return await _dataContext.EmailAddresses.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<Email> GetAsync(int id)
        {
            return await _dataContext.EmailAddresses.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        protected override async Task<Email> InsertAsync(Email item)
        {
            await _dataContext.EmailAddresses.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        protected override async Task<Email> UpdateAsync(Email item)
        {
            Email email = await GetAsync(item.Id);
            email.EmailAddress = item.EmailAddress;
            email.Id = item.Id;
            email.IsMain = item.IsMain;

            await _dataContext.SaveChangesAsync();
            return email;
        }
    }
}
