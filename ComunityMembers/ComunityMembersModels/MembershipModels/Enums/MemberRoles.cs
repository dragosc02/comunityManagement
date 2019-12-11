namespace CommunityModels.MembershipModels.Enums
{
    /// <summary>Member roles enums.</summary>
    public enum MemberRoles
    {
        /// <summary>The leadership role reserved for pastors or elders, will have admin rights.</summary>
        Leader,

        /// <summary>The secretary role, should have admin role.</summary>
        Secretary,

        /// <summary>The deacon role.</summary>
        Deacon,

        /// <summary>The member role corresponds to a church member that does not have a specific role.</summary>
        Member
    }
}