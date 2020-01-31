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
    /// Discipline Action Repository.
    /// </summary>
    public class DisciplineActionRepository : AbstractRepository<DisciplineAction>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public DisciplineActionRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Discipline Action based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(DisciplineAction item)
        {
            DisciplineAction disciplineAction = await GetAsync(item.Id);
            _dataContext.DisciplineActions.Remove(disciplineAction);
            await _dataContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets asynchronously the list with Discipline Actions from database.
        /// </summary>
        /// <returns>It returns a list with all Discipline Actions from database.</returns>
        public override async Task<IList<DisciplineAction>> GetAllAsync()
        {
            return await _dataContext.DisciplineActions.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method gets asynchronously a Discipline Action from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Discipline Action based on the given id.</returns>
        public override async Task<DisciplineAction> GetAsync(int id)
        {
            return await _dataContext.DisciplineActions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        /// <summary>
        /// This method inserts asynchronously a Discipline Action.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<DisciplineAction> InsertAsync(DisciplineAction item)
        {
            await _dataContext.DisciplineActions.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Discipline Action based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<DisciplineAction> UpdateAsync(DisciplineAction item)
        {
            DisciplineAction disciplineAction = await _dataContext.DisciplineActions.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
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
