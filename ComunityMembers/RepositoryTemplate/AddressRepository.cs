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
    /// Address Repository.
    /// </summary>
    public class AddressRepository : AbstractRepository<Address>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public AddressRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Address based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(Address item)
        {
            Address address = await GetAsync(item.Id);
            _dataContext.Addresses.Remove(address);
            await _dataContext.SaveChangesAsync();
        }
        /// <summary>
        /// This method gets asynchronously a Address from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Address based on the given id.</returns>
        public override async Task<Address> GetAsync(int id)
        {
            Address address = await _dataContext.Addresses.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            return  address;
        }

        /// <summary>
        /// This method gets asynchronously the list with Addresses from database.
        /// </summary>
        /// <returns>It returns a list with all Addresses from database.</returns>
        public override async Task<IList<Address>> GetAllAsync()
        {
            return await _dataContext.Addresses.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method inserts asynchronously a Address.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<Address> InsertAsync(Address item)
        {
            await _dataContext.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Address based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<Address> UpdateAsync(Address item)
        {
            Address address = await _dataContext.Addresses.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
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
