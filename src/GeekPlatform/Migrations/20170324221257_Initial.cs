using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeekPlatform.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competency",
                columns: table => new
                {
                    Competency_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Competency_Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competency", x => x.Competency_Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Course_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Course_Name = table.Column<string>(nullable: false),
                    Description_Long = table.Column<string>(nullable: false),
                    Description_Short = table.Column<string>(maxLength: 200, nullable: false),
                    Icon_FileName = table.Column<string>(nullable: false),
                    Is_Active = table.Column<bool>(nullable: false),
                    Is_Running = table.Column<bool>(nullable: false),
                    Is_Workshop = table.Column<bool>(nullable: false),
                    SignUp_Deadline = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Course_Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Profile_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(maxLength: 64, nullable: true),
                    Birthday = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(maxLength: 64, nullable: true),
                    Is_Active = table.Column<bool>(nullable: false),
                    Is_Admin = table.Column<bool>(nullable: false),
                    Major = table.Column<string>(maxLength: 64, nullable: true),
                    Membership_Start = table.Column<DateTime>(type: "date", nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<string>(maxLength: 16, nullable: true),
                    Pic_FileName = table.Column<string>(maxLength: 128, nullable: true),
                    Skype = table.Column<string>(maxLength: 64, nullable: true),
                    Slack = table.Column<string>(maxLength: 64, nullable: true),
                    Team_Member = table.Column<string>(maxLength: 20, nullable: true),
                    Uni_Start = table.Column<DateTime>(type: "date", nullable: true),
                    Workplace = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Profile_Id);
                });

            migrationBuilder.CreateTable(
                name: "Course_News",
                columns: table => new
                {
                    Course_News_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: false),
                    Course_Id = table.Column<int>(nullable: false),
                    PostTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_News", x => x.Course_News_Id);
                    table.ForeignKey(
                        name: "FK_Table_ToCourse",
                        column: x => x.Course_Id,
                        principalTable: "Course",
                        principalColumn: "Course_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course_Thematics",
                columns: table => new
                {
                    Course_Id = table.Column<int>(nullable: false),
                    Week_Number = table.Column<byte>(nullable: false),
                    Actual_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Homework_Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Thematics", x => new { x.Course_Id, x.Week_Number });
                    table.ForeignKey(
                        name: "FK_Course_Thematics_ToCourse",
                        column: x => x.Course_Id,
                        principalTable: "Course",
                        principalColumn: "Course_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course_Enrollment",
                columns: table => new
                {
                    Profile_Id = table.Column<int>(nullable: false),
                    Course_Id = table.Column<int>(nullable: false),
                    Is_Finished = table.Column<bool>(nullable: false),
                    Is_Instructor = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Course_E__0570CB1F2160B5CA", x => new { x.Profile_Id, x.Course_Id });
                    table.ForeignKey(
                        name: "FK_Course_Enrollment_ToCourse",
                        column: x => x.Course_Id,
                        principalTable: "Course",
                        principalColumn: "Course_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_Enrollment_ToProfile",
                        column: x => x.Profile_Id,
                        principalTable: "Profile",
                        principalColumn: "Profile_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member_Competency",
                columns: table => new
                {
                    Member_Competency_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Competency_Comment = table.Column<string>(nullable: false),
                    Competency_Id = table.Column<int>(nullable: false),
                    Competency_Lvl = table.Column<byte>(nullable: false),
                    Profile_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member_Competency", x => x.Member_Competency_Id);
                    table.ForeignKey(
                        name: "FK_Member_Competency_ToCompetency",
                        column: x => x.Competency_Id,
                        principalTable: "Competency",
                        principalColumn: "Competency_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Competency_ToProfile",
                        column: x => x.Profile_Id,
                        principalTable: "Profile",
                        principalColumn: "Profile_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Homework_Upload",
                columns: table => new
                {
                    Homework_Upload_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: false),
                    Course_Id = table.Column<int>(nullable: false),
                    Is_Active = table.Column<bool>(nullable: false),
                    Profile_Id = table.Column<int>(nullable: false),
                    Upload_DateTime = table.Column<DateTime>(nullable: false),
                    Upload_FileName = table.Column<string>(maxLength: 128, nullable: false),
                    Week_Number = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homework_Upload", x => x.Homework_Upload_Id);
                    table.ForeignKey(
                        name: "FK_Homework_Upload_ToProfile",
                        column: x => x.Profile_Id,
                        principalTable: "Profile",
                        principalColumn: "Profile_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Homework_Upload_ToCourse_Thematics",
                        columns: x => new { x.Course_Id, x.Week_Number },
                        principalTable: "Course_Thematics",
                        principalColumns: new[] { "Course_Id", "Week_Number" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thematics_Attachment",
                columns: table => new
                {
                    Thematics_Attachment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attachment_FileName = table.Column<string>(maxLength: 128, nullable: false),
                    Course_Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Is_Active = table.Column<bool>(nullable: false),
                    Is_Homework = table.Column<bool>(nullable: false),
                    Week_Number = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thematics_Attachment", x => x.Thematics_Attachment_Id);
                    table.ForeignKey(
                        name: "FK_Thematics_Attachment_ToCourse_Thematics",
                        columns: x => new { x.Course_Id, x.Week_Number },
                        principalTable: "Course_Thematics",
                        principalColumns: new[] { "Course_Id", "Week_Number" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Enrollment_Course_Id",
                table: "Course_Enrollment",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_News_Course_Id",
                table: "Course_News",
                column: "Course_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Homework_Upload_Profile_Id",
                table: "Homework_Upload",
                column: "Profile_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Homework_Upload_Course_Id_Week_Number",
                table: "Homework_Upload",
                columns: new[] { "Course_Id", "Week_Number" });

            migrationBuilder.CreateIndex(
                name: "IX_Member_Competency_Competency_Id",
                table: "Member_Competency",
                column: "Competency_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Member_Competency_Profile_Id",
                table: "Member_Competency",
                column: "Profile_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Thematics_Attachment_Course_Id_Week_Number",
                table: "Thematics_Attachment",
                columns: new[] { "Course_Id", "Week_Number" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Enrollment");

            migrationBuilder.DropTable(
                name: "Course_News");

            migrationBuilder.DropTable(
                name: "Homework_Upload");

            migrationBuilder.DropTable(
                name: "Member_Competency");

            migrationBuilder.DropTable(
                name: "Thematics_Attachment");

            migrationBuilder.DropTable(
                name: "Competency");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "Course_Thematics");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
