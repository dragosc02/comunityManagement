using System.Collections.Generic;
using System.Threading.Tasks;

using CommunityBusinessLogic.Common;
using CommunityBusinessLogic.Contracts;

using CommunityModels.MembershipModels;
using CommunityModels.MembershipModels.Details;

using CommunityRepository;

namespace CommunityBusinessLogic.Services
{
    public class MemberService : CrudOperationService<Member>, IMemberService
    {
        private readonly IChildService _childService;

        public MemberService(IRepository<Member> repository, IChildService childService) : base(repository)
        {
            _childService = childService;
        }

        public async Task SaveChildAsync(Child childToSave, int loggedUserId)
        {
            await _childService.SaveAsync(childToSave, loggedUserId).ConfigureAwait(false);
        }

        public async Task SaveChildrenAsync(IList<Child> childrenToSave, int loggedUserId)
        {
            await _childService.SaveChildrenAsync(childrenToSave, loggedUserId).ConfigureAwait(false);
        }
    }
}