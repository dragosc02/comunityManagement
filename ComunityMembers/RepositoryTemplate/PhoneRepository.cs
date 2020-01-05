using CommunityModels.MembershipModels.Details;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class PhoneRepository : AbstractRepository<Phone>
    {
        public PhoneRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(Phone item)
        {
            Phone phone = await GetAsync(item.Id);
            _dataContext.PhoneNumbers.Remove(phone);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<IList<Phone>> GetAllAsync()
        {
            return await _dataContext.PhoneNumbers.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<Phone> GetAsync(int id)
        {
            return await _dataContext.PhoneNumbers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        protected override async Task<Phone> InsertAsync(Phone item)
        {
            await _dataContext.PhoneNumbers.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        protected override async Task<Phone> UpdateAsync(Phone item)
        {
            Phone phone = await GetAsync(item.Id);
            phone.Description = item.Description;
            phone.IsMain = item.IsMain;

            await _dataContext.SaveChangesAsync();
            return phone;
        }
    }
}
