using System;

using CommunityMembersModels.Contracts;

namespace CommunityModels.MembershipModels
{
    /// <summary>Encapsulates the discipline action model.</summary>
    public class DisciplineAction : IModel
    {
        /// <summary>Gets or sets the date when the record was created.</summary>
        public DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the end date of the disciplinary action.</summary>
        public DateTime? EndDate { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        public int Id { get; set; }

        /// <summary>The principal, parent entity. The <see cref="Membership"/> who has this specific address.</summary>
        public virtual Membership Membership { get; set; }

        /// <summary>The foreign key to the <see cref="Membership"/> entity.</summary>
        public int MembershipId { get; set; }

        /// <summary>Gets or sets observation.</summary>
        public string Observation { get; set; }

        /// <summary>Gets or sets the disciplinary reason.</summary>
        public string Reason { get; set; }

        /// <summary>Gets or sets the start date of the disciplinary action.</summary>
        public DateTime StartDate { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        public int UserCreated { get; set; }
    }
}