using CommunityModels.MembershipModels.Details;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class AddressRepository : AbstractRepository<Address>
    {
        public AddressRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(Address item)
        {
            Address address = await GetAsync(item.Id);
            _dataContext.Addresses.Remove(address);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<Address> GetAsync(int id)
        {
            Address address = await _dataContext.Addresses.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            return  address;
        }

        protected override async Task<IList<Address>> GetAllAsync()
        {
            return await _dataContext.Addresses.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<Address> InsertAsync(Address item)
        {
            await _dataContext.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        protected override async Task<Address> UpdateAsync(Address item)
        {
            Address address = await GetAsync(item.Id);
            address.IsMain = item.IsMain;
            address.MemberId = item.MemberId;
            address.Mention = item.Mention;
            address.State = item.State;
            address.AddressDetails = item.AddressDetails;
            address.City = item.City;

            await _dataContext.SaveChangesAsync();
            return address;
        }
    }
}
