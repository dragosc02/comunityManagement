using CommunityModels.MembershipModels;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    /// <summary>
    /// Member Repository.
    /// </summary>
    public class MemberRepository : AbstractRepository<Member>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public MemberRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Member based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(Member item)
        {
            Member member = await GetAsync(item.Id);
            _dataContext.Members.Remove(member);
            await _dataContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets asynchronously the list with Members from database.
        /// </summary>
        /// <returns>It returns a list with all Members from database.</returns>
        protected override async Task<IList<Member>> GetAllAsync()
        {
            return await _dataContext.Members.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method gets asynchronously a Member from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Member based on the given id.</returns>
        protected override async Task<Member> GetAsync(int id)
        {
            Member member = await _dataContext.Members.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
            return member;
        }

        /// <summary>
        /// This method inserts asynchronously a Member.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<Member> InsertAsync(Member item)
        {
            
            await _dataContext.Members.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Member based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<Member> UpdateAsync(Member item)
        {
            Member member = await _dataContext.Members.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
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
