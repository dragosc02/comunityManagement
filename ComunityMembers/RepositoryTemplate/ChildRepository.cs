using CommunityModels.MembershipModels.Details;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class ChildRepository : AbstractRepository<Child>
    {
        public ChildRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(Child item)
        {
            Child child = await GetAsync(item.Id);
            _dataContext.Children.Remove(child);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<IList<Child>> GetAllAsync()
        {
            return await _dataContext.Children.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<Child> GetAsync(int id)
        {
            return await _dataContext.Children.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        protected override async Task<Child> InsertAsync(Child item)
        {
            await _dataContext.Children.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        protected override async Task<Child> UpdateAsync(Child item)
        {
            Child child = await GetAsync(item.Id);
            child.BirthDate = item.BirthDate;
            child.BirthPlace = item.BirthPlace;
            child.FirstName = item.FirstName;
            child.Id = item.Id;
            child.LastName = item.LastName;
            child.MemberId = item.MemberId;
            child.Mentions = item.Mentions;

            await _dataContext.SaveChangesAsync();
            return child;
        }
    }
}
