using System;
using System.Collections.Generic;

using CommunityMembersModels.Contracts;

using CommunityModels.MembershipModels.Enums;

namespace CommunityModels.MembershipModels
{
    /// <summary>Encapsulates the membership model.</summary>
    public class Membership : IModel
    {
        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the discipline action list.</summary>
        public List<DisciplineAction> DisciplineActions { get; set; }

        /// <summary>Gets or sets the date when the membership ended.</summary>
        public DateTime? EndMembership { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>The principal, parent entity. The <see cref="Member"/> who has this specific address.</summary>
        public Member Member { get; set; }

        /// <summary>The foreign key to the <see cref="Member"/> entity.</summary>
        public int MemberId { get; set; }

        /// <summary>Gets or sets the membership request information.</summary>
        public MembershipRequest MembershipRequest { get; set; }

        /// <summary>Gets or sets the membership status.</summary>
        public MembershipStatus MembershipStatus { get; set; }

        /// <summary>Gets or sets mentions.</summary>
        public string Mentions { get; set; }

        /// <summary>Gets or sets the request id.</summary>
        public int RequestId { get; set; }

        /// <summary>Gets or sets the date when membership was started.</summary>
        public DateTime StartMembership { get; set; }

        /// <summary>Gets or sets the id of user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}