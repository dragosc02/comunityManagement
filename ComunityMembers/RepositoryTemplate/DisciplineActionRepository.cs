using CommunityModels.MembershipModels;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class DisciplineActionRepository : AbstractRepository<DisciplineAction>
    {
        public DisciplineActionRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(DisciplineAction item)
        {
            DisciplineAction disciplineAction = await GetAsync(item.Id);
            _dataContext.DisciplineActions.Remove(disciplineAction);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<IList<DisciplineAction>> GetAllAsync()
        {
            return await _dataContext.DisciplineActions.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<DisciplineAction> GetAsync(int id)
        {
            return await _dataContext.DisciplineActions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        protected override async Task<DisciplineAction> InsertAsync(DisciplineAction item)
        {
            await _dataContext.DisciplineActions.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        protected override async Task<DisciplineAction> UpdateAsync(DisciplineAction item)
        {
            DisciplineAction disciplineAction = await GetAsync(item.Id);
            disciplineAction.EndDate = item.EndDate;
            disciplineAction.MembershipId = item.MembershipId;
            disciplineAction.Observation = item.Observation;
            disciplineAction.Reason = item.Reason;
            disciplineAction.StartDate = item.StartDate;

            await _dataContext.SaveChangesAsync();
            return disciplineAction;
        }
    }
}
