using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Designer = table.Column<string>(nullable: true),
                    Engineer = table.Column<string>(nullable: true),
                    Programmer = table.Column<string>(nullable: true),
                    Assembler = table.Column<string>(nullable: true),
                    DesignerScore = table.Column<double>(nullable: false),
                    EngineerScore = table.Column<double>(nullable: false),
                    ProgrammerScore = table.Column<double>(nullable: false),
                    AssemblerScore = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
