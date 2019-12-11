using System;
using System.Collections.Generic;

using CommunityMembersModels.Contracts;

using CommunityModels.MembershipModels.Details;

namespace CommunityModels.MembershipModels
{
    /// <summary>Encapsulates member model.</summary>
    public class Member : IModel
    {
        /// <summary>Gets or sets the addresses list.</summary>
        public List<Address> Addresses { get; set; }

        /// <summary>Gets or sets the birth day.</summary>
        public DateTime BirthDay { get; set; }

        /// <summary>Gets or sets the list of children.</summary>
        public List<Child> Children { get; set; }

        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the date of baptism.</summary>
        public DateTime DateOfBaptism { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }

        /// <summary>Gets or sets the last update date.</summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>Gets or sets the memberships list.</summary>
        public List<Membership> Memberships { get; set; }

        /// <summary>Gets or sets observation.</summary>
        public string Observation { get; set; }

        /// <summary>Gets or sets the list of phone numbers.</summary>
        public List<Phone> PhoneNumbers { get; set; }

        /// <summary>Gets or sets the place of baptism.</summary>
        public string PlaceOfBaptism { get; set; }

        /// <summary>Gets or sets the spouse name.</summary>
        public string SpouseName { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }

        /// <summary>Gets or sets the id of the las user that updated the record.</summary>
        public int UserUpdated { get; set; }
    }
}