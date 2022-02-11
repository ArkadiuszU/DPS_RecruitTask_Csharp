using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractorCRUDapp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContractorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NipNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContractorTypeId = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contractors_ContractorTypes_ContractorTypeId",
                        column: x => x.ContractorTypeId,
                        principalTable: "ContractorTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_ContractorTypeId",
                table: "Contractors",
                column: "ContractorTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "ContractorTypes");
        }
    }
}
