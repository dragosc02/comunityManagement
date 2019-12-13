using System;

using CommunityMembersModels.Contracts;
using CommunityModels.MembershipModels.Details;
using CommunityModels.MembershipModels.Enums;

namespace CommunityModels.MembershipModels
{
    /// <summary>Encapsulates the membership request.</summary>
    public class MembershipRequest : IModel
    {
        /// <summary>Gets or sets the address details.</summary>
        public string AddressDetails { get; set; }

        /// <summary>Gets or sets the birth day.</summary>
        public DateTime BirthDay { get; set; }

        /// <summary>Gets or sets the place of birth.</summary>
        public string BirthPlace { get; set; }

        /// <summary>Gets or sets the list of children.</summary>
        public string Children { get; set; }

        /// <summary>Gets or sets the address details of the place of baptism.</summary>
        public string ChurchAddress { get; set; }

        /// <summary>Gets or sets the church name of baptism.</summary>
        public string ChurchNameOfBaptism { get; set; }

        /// <summary>Gets or sets the city of origin.</summary>
        public string CityOfOrigin { get; set; }

        /// <summary>Gets or sets the company name where the person works.</summary>
        public string CompanyName { get; set; }

        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the date of baptism.</summary>
        public DateTime DateOfBaptism { get; set; }

        /// <summary>Gets or sets the e-mail address.</summary>
        public string EmailAddress { get; set; }

        /// <summary>Gets or sets the field of service where the person want to serve.</summary>
        public string FieldOfService { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>Check if the person is married.</summary>
        public bool IsMarried { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }

        /// <summary>Gets or sets mentions for church confession of faith.</summary>
        public string MentionsForChurchConfessionOfFaith { get; set; }

        /// <summary>Gets or sets the phone numbers.</summary>
        public string PhoneNumbers { get; set; }

        /// <summary>Gets or sets the place of baptism.</summary>
        public string PlaceOfBaptism { get; set; }

        /// <summary>Gets or sets the profesion.</summary>
        public string Profesion { get; set; }

        /// <summary>Gets or sets the registration number.</summary>
        public int RegistrationNumber { get; set; }

        /// <summary>Gets or sets the request date.</summary>
        public int RequestDate { get; set; }

        /// <summary>Gets or sets the request status.</summary>
        public RequestStatus RequestStatus { get; set; }

        /// <summary>Gets or sets the resolution.</summary>
        public string Resolution { get; set; }

        /// <summary>Gets or sets the spouse name.</summary>
        public string SpouseName { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }

        /// <summary>Gets or sets the year of conversion to christianity.</summary>
        public int YearOfConversion { get; set; }

    }
}