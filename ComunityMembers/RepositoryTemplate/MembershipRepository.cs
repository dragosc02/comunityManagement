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
    public class MembershipRepository : AbstractRepository<Membership>
    {
        public MembershipRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(Membership item)
        {
            //await?
            Membership membership = await GetAsync(item.Id);
            _dataContext.Memberships.Remove(membership);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<Membership> GetAsync(int id)
        {
            Membership membership = await _dataContext.Memberships.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            return membership;
        }

        protected override async Task<IList<Membership>> GetAllAsync()
        {
            return await _dataContext.Memberships.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<Membership> InsertAsync(Membership item)
        {
            //item.Id = _dataContext.Memberships.Count() + 1;
            await _dataContext.Memberships.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }
        
        protected override async Task<Membership> UpdateAsync(Membership item)
        {
            Membership membership =  _dataContext.Memberships.First(x => x.Id == item.Id); 

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
