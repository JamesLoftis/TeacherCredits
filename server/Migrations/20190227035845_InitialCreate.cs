using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TeachingCredits = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSemesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NumberRegularHoursTaught = table.Column<double>(nullable: false),
                    NumberClassesTaught = table.Column<int>(nullable: false),
                    NumberOfLongClasses = table.Column<int>(nullable: false),
                    IsTeachingDrama = table.Column<bool>(nullable: false),
                    IsResponsibleAdult = table.Column<bool>(nullable: false),
                    IsCoordinator = table.Column<bool>(nullable: false),
                    IsBoardMember = table.Column<bool>(nullable: false),
                    SemesterId = table.Column<Guid>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSemesters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSemesters_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserSemesters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSemesters_SemesterId",
                table: "UserSemesters",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSemesters_UserId",
                table: "UserSemesters",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSemesters");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
