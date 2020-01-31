using CommunityModels.MembershipModels;
using CommunityModels.MembershipModels.Details;

using Microsoft.EntityFrameworkCore;

namespace CommunityRepository.DatabaseContext
{
    public class FullDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Child> Children { get; set; }

        public DbSet<DisciplineAction> DisciplineActions { get; set; }

        public DbSet<Email> EmailAddresses { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<MembershipRequest> MembershipRequests { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<Phone> PhoneNumbers { get; set; }

        public FullDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}