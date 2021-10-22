using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFNetCore5AccessDataLibrairy.Migrations
{
    public partial class Ok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTineos");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Tineos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tineos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobFunction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tineos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTineos",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    TineosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTineos", x => new { x.ProjectId, x.TineosId });
                    table.ForeignKey(
                        name: "FK_ProjectTineos_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTineos_Tineos_TineosId",
                        column: x => x.TineosId,
                        principalTable: "Tineos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DeadLine", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2121, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(5157), "Buy Google", new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(3233) },
                    { 3, new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9194), "Be Happy", new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9189) },
                    { 2, new DateTime(2023, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9153), "Develop new Pied Pipper", new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9137) }
                });

            migrationBuilder.InsertData(
                table: "Tineos",
                columns: new[] { "Id", "FirstName", "JobFunction", "LastName", "Mail", "Password", "StartDate" },
                values: new object[,]
                {
                    { 1, "John", "Communication Expert", "DOE", "john.doe@mail.com", "6niXyt4vhoOWhG6N/Rje0e4wGrGndK0eSbahkJdu7kk=", new DateTime(2021, 5, 24, 21, 34, 17, 446, DateTimeKind.Local).AddTicks(510) },
                    { 2, "Jeny", "Big Boss", "ANDERSON", "jeny.anderson@mail.com", "6niXyt4vhoOWhG6N/Rje0e4wGrGndK0eSbahkJdu7kk=", new DateTime(2021, 5, 24, 21, 34, 17, 507, DateTimeKind.Local).AddTicks(5377) },
                    { 3, "Carl", "Lead Developer", "WICK", "carl.wick@mail.com", "6niXyt4vhoOWhG6N/Rje0e4wGrGndK0eSbahkJdu7kk=", new DateTime(2021, 5, 24, 21, 34, 17, 546, DateTimeKind.Local).AddTicks(3247) }
                });

            migrationBuilder.InsertData(
                table: "ProjectTineos",
                columns: new[] { "ProjectId", "TineosId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 1, 1 },
                    { 3, 2 },
                    { 1, 2 },
                    { 3, 3 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTineos_TineosId",
                table: "ProjectTineos",
                column: "TineosId");
        }
    }
}
