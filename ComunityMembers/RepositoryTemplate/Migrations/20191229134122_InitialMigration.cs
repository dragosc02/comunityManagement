using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CommunityRepository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DateOfBaptism = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    PlaceOfBaptism = table.Column<string>(nullable: true),
                    SpouseName = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    UserUpdated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MembershipRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressDetails = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    Children = table.Column<string>(nullable: true),
                    ChurchAddress = table.Column<string>(nullable: true),
                    ChurchNameOfBaptism = table.Column<string>(nullable: true),
                    CityOfOrigin = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DateOfBaptism = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FieldOfService = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    IsMarried = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    MentionsForChurchConfessionOfFaith = table.Column<string>(nullable: true),
                    PhoneNumbers = table.Column<string>(nullable: true),
                    PlaceOfBaptism = table.Column<string>(nullable: true),
                    Profesion = table.Column<string>(nullable: true),
                    RegistrationNumber = table.Column<int>(nullable: false),
                    RequestDate = table.Column<int>(nullable: false),
                    RequestStatus = table.Column<int>(nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    SpouseName = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false),
                    YearOfConversion = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressDetails = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    Mention = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    Mentions = table.Column<string>(nullable: true),
                    UserCreated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAddresses_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneType = table.Column<int>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    EndMembership = table.Column<DateTime>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    MembershipRequestId = table.Column<int>(nullable: true),
                    MembershipStatus = table.Column<int>(nullable: false),
                    Mentions = table.Column<string>(nullable: true),
                    RequestId = table.Column<int>(nullable: false),
                    StartMembership = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memberships_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Memberships_MembershipRequests_MembershipRequestId",
                        column: x => x.MembershipRequestId,
                        principalTable: "MembershipRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    MembershipId = table.Column<int>(nullable: false),
                    Observation = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    UserCreated = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplineActions_Memberships_MembershipId",
                        column: x => x.MembershipId,
                        principalTable: "Memberships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_MemberId",
                table: "Addresses",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_MemberId",
                table: "Children",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineActions_MembershipId",
                table: "DisciplineActions",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_MemberId",
                table: "EmailAddresses",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MemberId",
                table: "Memberships",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_MembershipRequestId",
                table: "Memberships",
                column: "MembershipRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_MemberId",
                table: "PhoneNumbers",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "DisciplineActions");

            migrationBuilder.DropTable(
                name: "EmailAddresses");

            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "MembershipRequests");
        }
    }
}
