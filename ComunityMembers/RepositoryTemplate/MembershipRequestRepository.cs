using CommunityModels.MembershipModels;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunityRepository
{
    public class MembershipRequestRepository : AbstractRepository<MembershipRequest>
    {
        public MembershipRequestRepository(FullDbContext fullContext) : base(fullContext)
        {
        }

        protected override async Task DeleteAsync(MembershipRequest item)
        {
            MembershipRequest membershipRequest = await GetAsync(item.Id);
            _dataContext.MembershipRequests.Remove(membershipRequest);
            await _dataContext.SaveChangesAsync();
        }

        protected override async Task<IList<MembershipRequest>> GetAllAsync()
        {
            return await _dataContext.MembershipRequests.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        protected override async Task<MembershipRequest> GetAsync(int id)
        {
            return await _dataContext.MembershipRequests.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        protected override async Task<MembershipRequest> InsertAsync(MembershipRequest item)
        {
            await _dataContext.MembershipRequests.AddAsync(item);
            await _dataContext.SaveChangesAsync();
            return item;
        }

        protected override async Task<MembershipRequest> UpdateAsync(MembershipRequest item)
        {
            MembershipRequest membershipRequest = await GetAsync(item.Id);
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
