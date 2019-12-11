// ------------------------------------------------------------------------------
//     <copyright file="Email.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System;

using CommunityMembersModels.Contracts;

namespace CommunityModels.MembershipModels.Details
{
    /// <summary>Encapsulate email information.</summary>
    public class Email : IModel
    {
        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the email Address.</summary>
        public string EmailAddress { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets if it is the main email address.</summary>
        public bool IsMain { get; set; }

        /// <summary>The principal, parent entity. The <see cref="Member"/> who has this specific email.</summary>
        public Member Member { get; set; }

        /// <summary>The foreign key to the <see cref="Member"/> entity.</summary>
        public int MemberId { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}