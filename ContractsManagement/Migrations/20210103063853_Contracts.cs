using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractsManagement.Migrations
{
    public partial class Contracts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MiningContracts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedByUser = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ContractorsName = table.Column<string>(nullable: true),
                    ReferenceNumber = table.Column<string>(nullable: true),
                    TypeofContract = table.Column<string>(nullable: true),
                    DocumentStatus = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Addresss = table.Column<string>(nullable: true),
                    Accreditation = table.Column<string>(nullable: true),
                    Start = table.Column<string>(nullable: true),
                    Finish = table.Column<string>(nullable: true),
                    PaymentTerms = table.Column<string>(nullable: true),
                    Scope = table.Column<string>(nullable: true),
                    Rates = table.Column<string>(nullable: true),
                    Provisions = table.Column<string>(nullable: true),
                    WorkProgress = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Recommendation = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiningContracts", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MiningContracts");
        }
    }
}
