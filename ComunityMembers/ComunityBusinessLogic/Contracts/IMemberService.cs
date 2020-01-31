using System.Collections.Generic;
using System.Threading.Tasks;

using CommunityModels.MembershipModels;
using CommunityModels.MembershipModels.Details;

namespace CommunityBusinessLogic.Contracts
{
    public interface IMemberService : ICrudOperationsService<Member>
    {
        Task SaveChildAsync(Member member, Child childToSave, int loggedUserId);

        Task SaveChildrenAsync(Member member, IList<Child> childrenToSave, int loggedUserId);
    }
}