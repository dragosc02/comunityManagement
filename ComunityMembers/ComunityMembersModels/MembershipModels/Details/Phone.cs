using System;

using CommunityMembersModels.Contracts;

using CommunityModels.MembershipModels.Enums;

namespace CommunityModels.MembershipModels.Details
{
    /// <summary>Stores phone information</summary>
    public class Phone : IModel
    {
        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets description.</summary>
        public string Description { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets if is the main phone.</summary>
        public bool IsMain { get; set; }

        /// <summary>The principal, parent entity. The <see cref="Member"/> who has this specific address.</summary>
        public virtual Member Member { get; set; }

        /// <summary>The foreign key to the <see cref="Member"/> entity.</summary>
        public int MemberId { get; set; }

        /// <summary>Gets or sets the phone number.</summary>
        public string PhoneNumber { get; set; }

        /// <summary>Gets or sets the phone type.</summary>
        public PhoneType PhoneType { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}