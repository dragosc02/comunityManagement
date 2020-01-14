﻿// <auto-generated />
using System;
using CommunityRepository.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommunityRepository.Migrations
{
    [DbContext(typeof(FullDbContext))]
    partial class FullDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressDetails");

                    b.Property<string>("City");

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsMain");

                    b.Property<int>("MemberId");

                    b.Property<string>("Mention");

                    b.Property<string>("State");

                    b.Property<int>("UserCreated");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("BirthPlace");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("MemberId");

                    b.Property<string>("Mentions");

                    b.Property<int>("UserCreated");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EmailAddress");

                    b.Property<bool>("IsMain");

                    b.Property<int>("MemberId");

                    b.Property<int>("UserCreated");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("EmailAddresses");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<int>("MemberId");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("PhoneType");

                    b.Property<int>("UserCreated");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.DisciplineAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime?>("EndDate");

                    b.Property<int>("MembershipId");

                    b.Property<string>("Observation");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UserCreated");

                    b.HasKey("Id");

                    b.HasIndex("MembershipId");

                    b.ToTable("DisciplineActions");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("DateOfBaptism");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Observation");

                    b.Property<string>("PlaceOfBaptism");

                    b.Property<string>("SpouseName");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserUpdated");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime?>("EndMembership");

                    b.Property<int>("MemberId");

                    b.Property<int?>("MembershipRequestId");

                    b.Property<int>("MembershipStatus");

                    b.Property<string>("Mentions");

                    b.Property<int>("RequestId");

                    b.Property<DateTime>("StartMembership");

                    b.Property<int>("UserCreated");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("MembershipRequestId");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.MembershipRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressDetails");

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("BirthPlace");

                    b.Property<string>("Children");

                    b.Property<string>("ChurchAddress");

                    b.Property<string>("ChurchNameOfBaptism");

                    b.Property<string>("CityOfOrigin");

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("CreationDate");

                    b.Property<DateTime>("DateOfBaptism");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FieldOfService");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsMarried");

                    b.Property<string>("LastName");

                    b.Property<string>("MentionsForChurchConfessionOfFaith");

                    b.Property<string>("PhoneNumbers");

                    b.Property<string>("PlaceOfBaptism");

                    b.Property<string>("Profesion");

                    b.Property<int>("RegistrationNumber");

                    b.Property<int>("RequestDate");

                    b.Property<int>("RequestStatus");

                    b.Property<string>("Resolution");

                    b.Property<string>("SpouseName");

                    b.Property<int>("UserCreated");

                    b.Property<int>("YearOfConversion");

                    b.HasKey("Id");

                    b.ToTable("MembershipRequests");
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Address", b =>
                {
                    b.HasOne("CommunityModels.MembershipModels.Member", "Member")
                        .WithMany("Addresses")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Child", b =>
                {
                    b.HasOne("CommunityModels.MembershipModels.Member", "Member")
                        .WithMany("Children")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Email", b =>
                {
                    b.HasOne("CommunityModels.MembershipModels.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Details.Phone", b =>
                {
                    b.HasOne("CommunityModels.MembershipModels.Member", "Member")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.DisciplineAction", b =>
                {
                    b.HasOne("CommunityModels.MembershipModels.Membership", "Membership")
                        .WithMany("DisciplineActions")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CommunityModels.MembershipModels.Membership", b =>
                {
                    b.HasOne("CommunityModels.MembershipModels.Member", "Member")
                        .WithMany("Memberships")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CommunityModels.MembershipModels.MembershipRequest", "MembershipRequest")
                        .WithMany()
                        .HasForeignKey("MembershipRequestId");
                });
#pragma warning restore 612, 618
        }
    }
}
