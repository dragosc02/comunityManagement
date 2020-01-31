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
    /// Membership Request Repository.
    /// </summary>
    public class MembershipRequestRepository : AbstractRepository<MembershipRequest>
    {
        /// <summary>
        /// Constructor. It is necessary a parameter: DbContext type.
        /// </summary>
        /// <param name="fullContext"></param>
        public MembershipRequestRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        /// <summary>
        /// This method deletes asynchronously a Membership Request based on the given item.  
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Nothing.</returns>
        protected override async Task DeleteAsync(MembershipRequest item)
        {
            MembershipRequest membershipRequest = await GetAsync(item.Id);
            _dataContext.MembershipRequests.Remove(membershipRequest);
            await _dataContext.SaveChangesAsync();
        }

        /// <summary>
        /// This method gets asynchronously the list with Membership Requests from database.
        /// </summary>
        /// <returns>It returns a list with all Membership Requests from database.</returns>
        public override async Task<IList<MembershipRequest>> GetAllAsync()
        {
            return await _dataContext.MembershipRequests.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// This method gets asynchronously a Membership Request from database based on the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>It returns the Membership Request based on the given id.</returns>
        public override async Task<MembershipRequest> GetAsync(int id)
        {
            return await _dataContext.MembershipRequests.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        /// <summary>
        /// This method inserts asynchronously a Membership Request.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was inserted.</returns>
        protected override async Task<MembershipRequest> InsertAsync(MembershipRequest item)
        {
            await _dataContext.MembershipRequests.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// This method updates asynchronously a Membership Request based on the given item.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>It returns the item which was updated.</returns>
        protected override async Task<MembershipRequest> UpdateAsync(MembershipRequest item)
        {
            MembershipRequest membershipRequest = await _dataContext.MembershipRequests.FirstOrDefaultAsync(x => x.Id == item.Id).ConfigureAwait(false);
            membershipRequest.AddressDetails = item.AddressDetails;
            membershipRequest.BirthDay = item.BirthDay;
            membershipRequest.BirthPlace = item.BirthPlace;
            membershipRequest.ChurchAddress = item.ChurchAddress;
            membershipRequest.ChurchNameOfBaptism = item.ChurchNameOfBaptism;
            membershipRequest.CityOfOrigin = item.CityOfOrigin;
            membershipRequest.CompanyName = item.CompanyName;
            membershipRequest.DateOfBaptism = item.DateOfBaptism;
            membershipRequest.EmailAddress = item.EmailAddress;
            membershipRequest.FieldOfService = item.FieldOfService;
            membershipRequest.FirstName = item.FirstName;
            membershipRequest.IsMarried = item.IsMarried;
            membershipRequest.LastName = item.LastName;
            membershipRequest.MentionsForChurchConfessionOfFaith = item.MentionsForChurchConfessionOfFaith;
            membershipRequest.PhoneNumbers = item.PhoneNumbers;
            membershipRequest.PlaceOfBaptism = item.PlaceOfBaptism;
            membershipRequest.Profesion = item.Profesion;
            membershipRequest.RequestStatus = item.RequestStatus;
            membershipRequest.Resolution = item.Resolution;
            membershipRequest.SpouseName = item.SpouseName;
            membershipRequest.YearOfConversion = item.YearOfConversion;

            await _dataContext.SaveChangesAsync();
            return membershipRequest;
        }
    }
}
