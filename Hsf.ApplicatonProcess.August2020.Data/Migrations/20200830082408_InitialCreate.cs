using Microsoft.EntityFrameworkCore.Migrations;

namespace Hsf.ApplicatonProcess.August2020.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FamilyName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CountryOfOrigin = table.Column<string>(nullable: true),
                    EMailAdress = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Hired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "ID", "Address", "Age", "CountryOfOrigin", "EMailAdress", "FamilyName", "Hired", "Name" },
                values: new object[] { 1, "Kalinowa 26", 24, "Poland", "bartekbednarek@gmail.com", "Bednarek", false, "Bartosz" });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "ID", "Address", "Age", "CountryOfOrigin", "EMailAdress", "FamilyName", "Hired", "Name" },
                values: new object[] { 2, "Kwiatowa 22", 40, "Poland", "mariuszpudzianowski@gmail.com", "Pudzianowski", true, "Mariusz" });

            migrationBuilder.InsertData(
                table: "Applicants",
                columns: new[] { "ID", "Address", "Age", "CountryOfOrigin", "EMailAdress", "FamilyName", "Hired", "Name" },
                values: new object[] { 3, "Wielka Krokwia 35", 39, "Poland", "adammalysz@gmail.com", "Malysz", true, "Adam" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicants");
        }
    }
}
