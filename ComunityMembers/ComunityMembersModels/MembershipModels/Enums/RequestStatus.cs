namespace CommunityModels.MembershipModels.Enums
{
    /// <summary>The request for membership status. The Status should ideally be forward only.</summary>
    public enum RequestStatus
    {
        /// <summary>The request was submitted.</summary>
        Submitted,

        /// <summary>The request was passed to leadership and waiting for having the discussion, and complete the request.</summary>
        InProcess,

        /// <summary>The request was approved and is waiting for retrieving references from the church on which the person was member.</summary>
        WaitingForReference,

        /// <summary>The request is accepted, the person is an active member.</summary>
        Accepted,

        /// <summary>The request is rejected.</summary>
        Rejected
    }
}