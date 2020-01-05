using CommunityModels.MembershipModels;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class MemberRepository : AbstractRepository<Member>
    {
        public MemberRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(Member item)
        {
            Member member = await GetAsync(item.Id);
            _dataContext.Members.Remove(member);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<IList<Member>> GetAllAsync()
        {
            return await _dataContext.Members.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<Member> GetAsync(int id)
        {
            Member member = await _dataContext.Members.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            return member;
        }

        protected override async Task<Member> InsertAsync(Member item)
        {
            try
            {
                //item.Id = _dataContext.Memberships.Count() + 1;
                await _dataContext.Members.AddAsync(item);
                await _dataContext.SaveChangesAsync();
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return item;
        }

        protected override async Task<Member> UpdateAsync(Member item)
        {
            Member member = await GetAsync(item.Id);
            member.LastName = item.LastName;
            member.LastUpdated = DateTime.Now;
            member.Observation = item.Observation;
            member.PlaceOfBaptism = item.PlaceOfBaptism;
            member.SpouseName = item.SpouseName;
            await _dataContext.SaveChangesAsync();
            return member;
        }
    }
}
