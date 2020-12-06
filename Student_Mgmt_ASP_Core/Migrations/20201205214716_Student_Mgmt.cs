using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_Mgmt_ASP_Core.Migrations
{
    public partial class Student_Mgmt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    course_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    course_duration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.course_ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    student_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_ID = table.Column<int>(type: "int", nullable: false),
                    Course_objcourse_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.student_ID);
                    table.ForeignKey(
                        name: "FK_Student_Course_Course_objcourse_ID",
                        column: x => x.Course_objcourse_ID,
                        principalTable: "Course",
                        principalColumn: "course_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_objcourse_ID",
                table: "Student",
                column: "Course_objcourse_ID");

            var sqlFile = Path.Combine(".\\DatabaseScript", @"data.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
