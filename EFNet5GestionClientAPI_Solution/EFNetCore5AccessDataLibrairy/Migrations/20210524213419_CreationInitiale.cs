using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFNetCore5AccessDataLibrairy.Migrations
{
    public partial class CreationInitiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dle_utilisateurBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    JobFunction = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pseudo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dle_utilisateurBase", x => x.Id);
                });

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
                name: "dle_clientBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    FullName = table.Column<string>(type: "nvarchar(405)", maxLength: 405, nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Prenoms = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Sexe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dle_clientBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dle_clientBase_dle_utilisateurBase_UserId",
                        column: x => x.UserId,
                        principalTable: "dle_utilisateurBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "dle_adresseBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    State = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StreetAdress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dle_adresseBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dle_adresseBase_dle_clientBase_ClientId",
                        column: x => x.ClientId,
                        principalTable: "dle_clientBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "dle_adresseEmailBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    EmailAdress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dle_adresseEmailBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dle_adresseEmailBase_dle_clientBase_ClientId",
                        column: x => x.ClientId,
                        principalTable: "dle_clientBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_dle_adresseBase_ClientId",
                table: "dle_adresseBase",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_dle_adresseEmailBase_ClientId",
                table: "dle_adresseEmailBase",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_dle_clientBase_UserId",
                table: "dle_clientBase",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTineos_TineosId",
                table: "ProjectTineos",
                column: "TineosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dle_adresseBase");

            migrationBuilder.DropTable(
                name: "dle_adresseEmailBase");

            migrationBuilder.DropTable(
                name: "ProjectTineos");

            migrationBuilder.DropTable(
                name: "dle_clientBase");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Tineos");

            migrationBuilder.DropTable(
                name: "dle_utilisateurBase");
        }
    }
}
