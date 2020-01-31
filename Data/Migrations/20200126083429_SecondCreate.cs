using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicahCustomerManager.Data.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    MobileNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    PostalAddress = table.Column<string>(nullable: true),
                    ProceduresPerformed = table.Column<string>(nullable: true),
                    ProcedureDescription = table.Column<string>(nullable: true),
                    ProcedureDate1 = table.Column<DateTime>(nullable: false),
                    ProcedureDate2 = table.Column<DateTime>(nullable: false),
                    AdditionalProceduresDates = table.Column<string>(nullable: true),
                    AllergiesNoted = table.Column<string>(nullable: true),
                    MedicalNotes = table.Column<string>(nullable: true),
                    PreviousMedicalComplications = table.Column<string>(nullable: true),
                    AntiobioticProcedureNeeded = table.Column<bool>(nullable: false),
                    ProcedureNotes = table.Column<string>(nullable: true),
                    ConsentGiven = table.Column<string>(nullable: true),
                    UnderEighteen = table.Column<bool>(nullable: false),
                    MarketingSubscribed = table.Column<bool>(nullable: false),
                    PregnantBreastfeeding = table.Column<bool>(nullable: false),
                    NotesOnCustomer = table.Column<string>(nullable: true),
                    ReferralInformation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
