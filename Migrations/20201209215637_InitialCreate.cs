using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_5___Hootch.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateStarted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedFinishDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfWash = table.Column<int>(type: "int", nullable: false),
                    ExpectedWashPercent = table.Column<int>(type: "int", nullable: false),
                    ExpectedYield = table.Column<int>(type: "int", nullable: false),
                    ActualYield = table.Column<int>(type: "int", nullable: false),
                    PercentDiff = table.Column<double>(type: "float", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batch");
        }
    }
}
