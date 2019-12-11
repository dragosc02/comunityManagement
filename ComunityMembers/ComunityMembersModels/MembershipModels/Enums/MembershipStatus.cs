namespace CommunityModels.MembershipModels.Enums
{
    /// <summary>Membership status.</summary>
    public enum MembershipStatus
    {
        /// <summary>Represents a person that participate to church meetings regularly but is not yet a member.</summary>
        Attendee,

        /// <summary>Represents a person that requested membership .</summary>
        Requested,

        /// <summary>Represents a full member, that is active.</summary>
        Active,

        /// <summary>Represents a member that is under church discipline.</summary>
        UnderDiscipline,

        /// <summary>Represents a member that was excluded.</summary>
        Excluded,

        /// <summary>Represents a member that ended his membership.</summary>
        Ended
    }
}