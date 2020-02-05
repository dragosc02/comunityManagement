using System;

using CommunityMembersModels.Contracts;

namespace CommunityModels.MembershipModels.Details
{
    /// <summary>Model for managing the address information.</summary>
    public class Address : IModel
    {
        /// <summary>Gets or sets the address details.</summary>
        public string AddressDetails { get; set; }

        /// <summary>Gets or sets the city.</summary>
        public string City { get; set; }

        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets if it is the main address.</summary>
        public bool IsMain { get; set; }

        /// <summary>The principal, parent entity. The <see cref="Member"/> who has this specific address.</summary>
        public virtual Member Member { get; set; }

        /// <summary>The foreign key to the <see cref="Member"/> entity.</summary>
        public int MemberId { get; set; }

        /// <summary>Gets or sets mentions.</summary>
        public string Mention { get; set; }

        /// <summary>Gets or sets the state.</summary>
        public string State { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}