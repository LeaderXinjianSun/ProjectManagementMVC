using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<string>(nullable: false),
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
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Assembler", "AssemblerScore", "Count", "Designer", "DesignerScore", "Engineer", "EngineerScore", "Name", "Programmer", "ProgrammerScore", "ProjectID" },
                values: new object[] { 1, "邱伟", 10.0, 24, "范杰", 10.0, "邬海欣", 10.0, "收放板共用机（LDR-D5X-SF)   VPP D53_撕膜电测", "孙鑫建", 10.0, "SZ-20191228-01" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Assembler", "AssemblerScore", "Count", "Designer", "DesignerScore", "Engineer", "EngineerScore", "Name", "Programmer", "ProgrammerScore", "ProjectID" },
                values: new object[] { 2, "李晓锁", 10.0, 13, "范杰", 10.0, "李明昌", 10.0, "X1023自动上下料机", "孙鑫建", 10.0, "LDR-SJ-0220" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
