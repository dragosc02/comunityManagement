using System.Collections.Generic;
using System.Threading.Tasks;

using CommunityModels.MembershipModels.Details;

namespace CommunityBusinessLogic.Contracts
{
    public interface IChildService : ICrudOperationsService<Child>
    {
        Task SaveChildrenAsync(IList<Child> childrenToSave, int loggedUserId);
    }
}