using System;

using CommunityMembersModels.Contracts;

using CommunityModels.MembershipModels.Enums;

namespace CommunityModels.MembershipModels
{
    /// <summary>Encapsulates the membership request.</summary>
    public class MembershipRequest : IModel
    {
        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the registration number.</summary>
        public int RegistrationNumber { get; set; }

        /// <summary>Gets or sets the request date.</summary>
        public int RequestDate { get; set; }

        /// <summary>Gets or sets the request status.</summary>
        public RequestStatus RequestStatus { get; set; }

        /// <summary>Gets or sets the resolution.</summary>
        public string Resolution { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}