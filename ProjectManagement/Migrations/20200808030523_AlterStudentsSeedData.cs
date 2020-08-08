using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.Migrations
{
    public partial class AlterStudentsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Assembler", "AssemblerScore", "Count", "Designer", "DesignerScore", "Engineer", "EngineerScore", "Name", "Programmer", "ProgrammerScore" },
                values: new object[] { "SZ-20191228-01", "邱伟", 10.0, 24, "范杰", 10.0, "邬海欣", 10.0, "收放板共用机（LDR-D5X-SF)   VPP D53_撕膜电测", "孙鑫建", 10.0 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ID", "Assembler", "AssemblerScore", "Count", "Designer", "DesignerScore", "Engineer", "EngineerScore", "Name", "Programmer", "ProgrammerScore" },
                values: new object[] { "LDR-SJ-0220", "李晓锁", 10.0, 13, "范杰", 10.0, "李明昌", 10.0, "X1023自动上下料机", "孙鑫建", 10.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: "LDR-SJ-0220");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ID",
                keyValue: "SZ-20191228-01");
        }
    }
}
