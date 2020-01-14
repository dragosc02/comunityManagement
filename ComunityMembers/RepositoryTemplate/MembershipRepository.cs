using CommunityMembersModels.Contracts;
using CommunityModels.MembershipModels;
using System;
using System.Collections.Generic;
using System.Text;
using CommunityRepository.DatabaseContext;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CommunityRepository
{
    /// <summary>
    /// Membership Repository.
    /// </summary>
    public class MembershipRepository : AbstractRepository<Membership>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public MembershipRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Membership based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(Membership item)
        {
            //await?
            Membership membership = await GetAsync(item.Id);
            _dataContext.Memberships.Remove(membership);
            await _dataContext.SaveChangesAsync();
        }

        //// <summary>
        /// This method gets asynchronously a Membership from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Membership based on the given id.</returns>
        protected override async Task<Membership> GetAsync(int id)
        {
            Membership membership = await _dataContext.Memberships.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            return membership;
        }

        /// <summary>
        /// This method gets asynchronously the list with Memberships from database.
        /// </summary>
        /// <returns>It returns a list with all Memberships from database.</returns>
        protected override async Task<IList<Membership>> GetAllAsync()
        {
            return await _dataContext.Memberships.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method insert asynchronously a Membership.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<Membership> InsertAsync(Membership item)
        {
            //item.Id = _dataContext.Memberships.Count() + 1;
            await _dataContext.Memberships.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Membership based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<Membership> UpdateAsync(Membership item)
        {
            Membership membership = await _dataContext.Memberships.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false); 

            membership.MemberId = item.MemberId;
            membership.EndMembership = item.EndMembership;
            membership.Mentions = item.Mentions;
            membership.RequestId = item.RequestId;
            membership.StartMembership = item.StartMembership;

            await _dataContext.SaveChangesAsync();

            return membership;
        }
    }
}
