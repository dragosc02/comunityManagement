using System.Collections.Generic;
using System.Linq;
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

        public async Task SaveChildAsync(Member member, Child childToSave, int loggedUserId)
        {
            childToSave.MemberId = member.Id;

            await _childService.SaveAsync(childToSave, loggedUserId).ConfigureAwait(false);

            var listChildren = new List<Child>
            {
                childToSave
            };
            AppendChildrenToMember(member, listChildren);
        }

        public async Task SaveChildrenAsync(Member member, IList<Child> childrenToSave, int loggedUserId)
        {
            foreach (Child child in childrenToSave)
            {
                child.MemberId = member.Id;
            }
            
            await _childService.SaveChildrenAsync(childrenToSave, loggedUserId).ConfigureAwait(false);

            AppendChildrenToMember(member, childrenToSave);
        }

        private void AppendChildrenToMember(Member member, IList<Child> children)
        {

            if (member.Children != null)
            {
                List<int> childrenIds = children.Select(x => x.Id).ToList();
                member.Children.RemoveAll(child => childrenIds.Contains(child.Id));
            }
            else
            {
                member.Children = new List<Child>();
            }

            member.Children.AddRange(children);
        }
    }
}