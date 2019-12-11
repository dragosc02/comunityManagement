using System;

namespace CommunityMembersModels.Contracts
{
    /// <summary>The model common content.</summary>
    public interface IModel
    {
        /// <summary>Gets or sets the date when the record was created.</summary>
        DateTime CreationDate { get; set; }

        /// <summary>Gets or sets the id of the record.</summary>
        int Id { get; set; }

        /// <summary>Gets or sets the id of the user that created the record.</summary>
        int UserCreated { get; set; }
    }
}