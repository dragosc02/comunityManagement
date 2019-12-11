// ------------------------------------------------------------------------------
//     <copyright file="AuditEntry.cs" company="BlackLine">
//         Copyright (C) BlackLine. All rights reserved.
//     </copyright>
// ------------------------------------------------------------------------------

using System;

namespace CommunityMembersModels.Audit
{
    public class AuditEntry
    {
        public AuditEntity AuditEntity { get; set; }

        public DateTime DateAudited { get; set; }

        public int Id { get; set; }

        public string NewValue { get; set; }

        public string OldValue { get; set; }

        public AuditOperations Operation { get; set; }

        public int UserId { get; set; }

        public int EntityId { get; set; }
    }
}