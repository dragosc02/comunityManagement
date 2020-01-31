using System;

using CommunityMembersModels.Contracts;

namespace CommunityModels.MembershipModels.Details
{
    public class Child : IModel
    {
        /// <summary>Gets or sets the date of birth.</summary>
        public DateTime BirthDate { get; set; }

        /// <summary>Gets or sets the place of birth.</summary>
        public string BirthPlace { get; set; }

        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }

        /// <summary>The principal, parent entity. The <see cref="Member"/> who has this specific address.</summary>
        public virtual Member Member { get; set; }

        /// <summary>The foreign key to the <see cref="Member"/> entity.</summary>
        public int MemberId { get; set; }

        /// <summary>Gets or sets mentions.</summary>
        public string Mentions { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}