using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GeekPlatform.Migrations
{
    public partial class DataAnnoations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Enrollment_ToCourse",
                table: "Course_Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Enrollment_ToProfile",
                table: "Course_Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_ToCourse",
                table: "Course_News");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Thematics_ToCourse",
                table: "Course_Thematics");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Upload_ToProfile",
                table: "Homework_Upload");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Upload_ToCourse_Thematics",
                table: "Homework_Upload");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Competency_ToCompetency",
                table: "Member_Competency");

            migrationBuilder.DropForeignKey(
                name: "FK_Member_Competency_ToProfile",
                table: "Member_Competency");

            migrationBuilder.DropForeignKey(
                name: "FK_Thematics_Attachment_ToCourse_Thematics",
                table: "Thematics_Attachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Thematics_Attachment",
                table: "Thematics_Attachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Member_Competency",
                table: "Member_Competency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homework_Upload",
                table: "Homework_Upload");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Thematics",
                table: "Course_Thematics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_News",
                table: "Course_News");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Course_E__0570CB1F2160B5CA",
                table: "Course_Enrollment");

            migrationBuilder.DropColumn(
                name: "Uni_Start",
                table: "Profile");

            migrationBuilder.RenameTable(
                name: "Thematics_Attachment",
                newName: "ThematicsAttachment");

            migrationBuilder.RenameTable(
                name: "Member_Competency",
                newName: "MemberCompetency");

            migrationBuilder.RenameTable(
                name: "Homework_Upload",
                newName: "HomeworkUpload");

            migrationBuilder.RenameTable(
                name: "Course_Thematics",
                newName: "CourseThematics");

            migrationBuilder.RenameTable(
                name: "Course_News",
                newName: "CourseNews");

            migrationBuilder.RenameTable(
                name: "Course_Enrollment",
                newName: "CourseEnrollment");

            migrationBuilder.RenameColumn(
                name: "Week_Number",
                table: "ThematicsAttachment",
                newName: "WeekNumber");

            migrationBuilder.RenameColumn(
                name: "Is_Homework",
                table: "ThematicsAttachment",
                newName: "IsHomework");

            migrationBuilder.RenameColumn(
                name: "Is_Active",
                table: "ThematicsAttachment",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "ThematicsAttachment",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Attachment_FileName",
                table: "ThematicsAttachment",
                newName: "AttachmentFileName");

            migrationBuilder.RenameColumn(
                name: "Thematics_Attachment_Id",
                table: "ThematicsAttachment",
                newName: "ThematicsAttachmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Thematics_Attachment_Course_Id_Week_Number",
                table: "ThematicsAttachment",
                newName: "IX_ThematicsAttachment_CourseId_WeekNumber");

            migrationBuilder.RenameColumn(
                name: "Team_Member",
                table: "Profile",
                newName: "TeamMember");

            migrationBuilder.RenameColumn(
                name: "Pic_FileName",
                table: "Profile",
                newName: "PicFileName");

            migrationBuilder.RenameColumn(
                name: "Membership_Start",
                table: "Profile",
                newName: "MembershipStart");

            migrationBuilder.RenameColumn(
                name: "Is_Admin",
                table: "Profile",
                newName: "IsAdmin");

            migrationBuilder.RenameColumn(
                name: "Is_Active",
                table: "Profile",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Profile_Id",
                table: "Profile",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "Profile_Id",
                table: "MemberCompetency",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "Competency_Lvl",
                table: "MemberCompetency",
                newName: "CompetencyLvl");

            migrationBuilder.RenameColumn(
                name: "Competency_Id",
                table: "MemberCompetency",
                newName: "CompetencyId");

            migrationBuilder.RenameColumn(
                name: "Competency_Comment",
                table: "MemberCompetency",
                newName: "CompetencyComment");

            migrationBuilder.RenameColumn(
                name: "Member_Competency_Id",
                table: "MemberCompetency",
                newName: "MemberCompetencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Member_Competency_Profile_Id",
                table: "MemberCompetency",
                newName: "IX_MemberCompetency_ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Member_Competency_Competency_Id",
                table: "MemberCompetency",
                newName: "IX_MemberCompetency_CompetencyId");

            migrationBuilder.RenameColumn(
                name: "Week_Number",
                table: "HomeworkUpload",
                newName: "WeekNumber");

            migrationBuilder.RenameColumn(
                name: "Upload_FileName",
                table: "HomeworkUpload",
                newName: "UploadFileName");

            migrationBuilder.RenameColumn(
                name: "Upload_DateTime",
                table: "HomeworkUpload",
                newName: "UploadDateTime");

            migrationBuilder.RenameColumn(
                name: "Profile_Id",
                table: "HomeworkUpload",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "Is_Active",
                table: "HomeworkUpload",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "HomeworkUpload",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Homework_Upload_Id",
                table: "HomeworkUpload",
                newName: "HomeworkUploadId");

            migrationBuilder.RenameIndex(
                name: "IX_Homework_Upload_Course_Id_Week_Number",
                table: "HomeworkUpload",
                newName: "IX_HomeworkUpload_CourseId_WeekNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Homework_Upload_Profile_Id",
                table: "HomeworkUpload",
                newName: "IX_HomeworkUpload_ProfileId");

            migrationBuilder.RenameColumn(
                name: "Homework_Description",
                table: "CourseThematics",
                newName: "HomeworkDescription");

            migrationBuilder.RenameColumn(
                name: "Actual_Date",
                table: "CourseThematics",
                newName: "ActualDate");

            migrationBuilder.RenameColumn(
                name: "Week_Number",
                table: "CourseThematics",
                newName: "WeekNumber");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "CourseThematics",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "CourseNews",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Course_News_Id",
                table: "CourseNews",
                newName: "CourseNewsId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_News_Course_Id",
                table: "CourseNews",
                newName: "IX_CourseNews_CourseId");

            migrationBuilder.RenameColumn(
                name: "Is_Instructor",
                table: "CourseEnrollment",
                newName: "IsInstructor");

            migrationBuilder.RenameColumn(
                name: "Is_Finished",
                table: "CourseEnrollment",
                newName: "IsFinished");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "CourseEnrollment",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Profile_Id",
                table: "CourseEnrollment",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_Enrollment_Course_Id",
                table: "CourseEnrollment",
                newName: "IX_CourseEnrollment_CourseId");

            migrationBuilder.RenameColumn(
                name: "SignUp_Deadline",
                table: "Course",
                newName: "SignUpDeadline");

            migrationBuilder.RenameColumn(
                name: "Is_Workshop",
                table: "Course",
                newName: "IsWorkshop");

            migrationBuilder.RenameColumn(
                name: "Is_Running",
                table: "Course",
                newName: "IsRunning");

            migrationBuilder.RenameColumn(
                name: "Is_Active",
                table: "Course",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Icon_FileName",
                table: "Course",
                newName: "IconFileName");

            migrationBuilder.RenameColumn(
                name: "Description_Short",
                table: "Course",
                newName: "DescriptionShort");

            migrationBuilder.RenameColumn(
                name: "Description_Long",
                table: "Course",
                newName: "DescriptionLong");

            migrationBuilder.RenameColumn(
                name: "Course_Name",
                table: "Course",
                newName: "CourseName");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Course",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Competency_Name",
                table: "Competency",
                newName: "CompetencyName");

            migrationBuilder.RenameColumn(
                name: "Competency_Id",
                table: "Competency",
                newName: "CompetencyId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ThematicsAttachment",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AttachmentFileName",
                table: "ThematicsAttachment",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Workplace",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TeamMember",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slack",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Skype",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PicFileName",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 16,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MembershipStart",
                table: "Profile",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Major",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Profile",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UniStartYear",
                table: "Profile",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CompetencyLvl",
                table: "MemberCompetency",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignUpDeadline",
                table: "Course",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionShort",
                table: "Course",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThematicsAttachment",
                table: "ThematicsAttachment",
                column: "ThematicsAttachmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberCompetency",
                table: "MemberCompetency",
                column: "MemberCompetencyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkUpload",
                table: "HomeworkUpload",
                column: "HomeworkUploadId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseThematics",
                table: "CourseThematics",
                columns: new[] { "CourseId", "WeekNumber" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseNews",
                table: "CourseNews",
                column: "CourseNewsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseEnrollment",
                table: "CourseEnrollment",
                columns: new[] { "ProfileId", "CourseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEnrollment_Course_CourseId",
                table: "CourseEnrollment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEnrollment_Profile_ProfileId",
                table: "CourseEnrollment",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseNews_Course_CourseId",
                table: "CourseNews",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseThematics_Course_CourseId",
                table: "CourseThematics",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkUpload_Profile_ProfileId",
                table: "HomeworkUpload",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkUpload_CourseThematics_CourseId_WeekNumber",
                table: "HomeworkUpload",
                columns: new[] { "CourseId", "WeekNumber" },
                principalTable: "CourseThematics",
                principalColumns: new[] { "CourseId", "WeekNumber" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCompetency_Competency_CompetencyId",
                table: "MemberCompetency",
                column: "CompetencyId",
                principalTable: "Competency",
                principalColumn: "CompetencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCompetency_Profile_ProfileId",
                table: "MemberCompetency",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ThematicsAttachment_CourseThematics_CourseId_WeekNumber",
                table: "ThematicsAttachment",
                columns: new[] { "CourseId", "WeekNumber" },
                principalTable: "CourseThematics",
                principalColumns: new[] { "CourseId", "WeekNumber" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseEnrollment_Course_CourseId",
                table: "CourseEnrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseEnrollment_Profile_ProfileId",
                table: "CourseEnrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseNews_Course_CourseId",
                table: "CourseNews");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseThematics_Course_CourseId",
                table: "CourseThematics");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkUpload_Profile_ProfileId",
                table: "HomeworkUpload");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkUpload_CourseThematics_CourseId_WeekNumber",
                table: "HomeworkUpload");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberCompetency_Competency_CompetencyId",
                table: "MemberCompetency");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberCompetency_Profile_ProfileId",
                table: "MemberCompetency");

            migrationBuilder.DropForeignKey(
                name: "FK_ThematicsAttachment_CourseThematics_CourseId_WeekNumber",
                table: "ThematicsAttachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThematicsAttachment",
                table: "ThematicsAttachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberCompetency",
                table: "MemberCompetency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkUpload",
                table: "HomeworkUpload");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseThematics",
                table: "CourseThematics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseNews",
                table: "CourseNews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseEnrollment",
                table: "CourseEnrollment");

            migrationBuilder.DropColumn(
                name: "UniStartYear",
                table: "Profile");

            migrationBuilder.RenameTable(
                name: "ThematicsAttachment",
                newName: "Thematics_Attachment");

            migrationBuilder.RenameTable(
                name: "MemberCompetency",
                newName: "Member_Competency");

            migrationBuilder.RenameTable(
                name: "HomeworkUpload",
                newName: "Homework_Upload");

            migrationBuilder.RenameTable(
                name: "CourseThematics",
                newName: "Course_Thematics");

            migrationBuilder.RenameTable(
                name: "CourseNews",
                newName: "Course_News");

            migrationBuilder.RenameTable(
                name: "CourseEnrollment",
                newName: "Course_Enrollment");

            migrationBuilder.RenameColumn(
                name: "WeekNumber",
                table: "Thematics_Attachment",
                newName: "Week_Number");

            migrationBuilder.RenameColumn(
                name: "IsHomework",
                table: "Thematics_Attachment",
                newName: "Is_Homework");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Thematics_Attachment",
                newName: "Is_Active");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Thematics_Attachment",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "AttachmentFileName",
                table: "Thematics_Attachment",
                newName: "Attachment_FileName");

            migrationBuilder.RenameColumn(
                name: "ThematicsAttachmentId",
                table: "Thematics_Attachment",
                newName: "Thematics_Attachment_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ThematicsAttachment_CourseId_WeekNumber",
                table: "Thematics_Attachment",
                newName: "IX_Thematics_Attachment_Course_Id_Week_Number");

            migrationBuilder.RenameColumn(
                name: "TeamMember",
                table: "Profile",
                newName: "Team_Member");

            migrationBuilder.RenameColumn(
                name: "PicFileName",
                table: "Profile",
                newName: "Pic_FileName");

            migrationBuilder.RenameColumn(
                name: "MembershipStart",
                table: "Profile",
                newName: "Membership_Start");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Profile",
                newName: "Is_Admin");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Profile",
                newName: "Is_Active");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Profile",
                newName: "Profile_Id");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Member_Competency",
                newName: "Profile_Id");

            migrationBuilder.RenameColumn(
                name: "CompetencyLvl",
                table: "Member_Competency",
                newName: "Competency_Lvl");

            migrationBuilder.RenameColumn(
                name: "CompetencyId",
                table: "Member_Competency",
                newName: "Competency_Id");

            migrationBuilder.RenameColumn(
                name: "CompetencyComment",
                table: "Member_Competency",
                newName: "Competency_Comment");

            migrationBuilder.RenameColumn(
                name: "MemberCompetencyId",
                table: "Member_Competency",
                newName: "Member_Competency_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MemberCompetency_ProfileId",
                table: "Member_Competency",
                newName: "IX_Member_Competency_Profile_Id");

            migrationBuilder.RenameIndex(
                name: "IX_MemberCompetency_CompetencyId",
                table: "Member_Competency",
                newName: "IX_Member_Competency_Competency_Id");

            migrationBuilder.RenameColumn(
                name: "WeekNumber",
                table: "Homework_Upload",
                newName: "Week_Number");

            migrationBuilder.RenameColumn(
                name: "UploadFileName",
                table: "Homework_Upload",
                newName: "Upload_FileName");

            migrationBuilder.RenameColumn(
                name: "UploadDateTime",
                table: "Homework_Upload",
                newName: "Upload_DateTime");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Homework_Upload",
                newName: "Profile_Id");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Homework_Upload",
                newName: "Is_Active");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Homework_Upload",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "HomeworkUploadId",
                table: "Homework_Upload",
                newName: "Homework_Upload_Id");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkUpload_CourseId_WeekNumber",
                table: "Homework_Upload",
                newName: "IX_Homework_Upload_Course_Id_Week_Number");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkUpload_ProfileId",
                table: "Homework_Upload",
                newName: "IX_Homework_Upload_Profile_Id");

            migrationBuilder.RenameColumn(
                name: "HomeworkDescription",
                table: "Course_Thematics",
                newName: "Homework_Description");

            migrationBuilder.RenameColumn(
                name: "ActualDate",
                table: "Course_Thematics",
                newName: "Actual_Date");

            migrationBuilder.RenameColumn(
                name: "WeekNumber",
                table: "Course_Thematics",
                newName: "Week_Number");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course_Thematics",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course_News",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "CourseNewsId",
                table: "Course_News",
                newName: "Course_News_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CourseNews_CourseId",
                table: "Course_News",
                newName: "IX_Course_News_Course_Id");

            migrationBuilder.RenameColumn(
                name: "IsInstructor",
                table: "Course_Enrollment",
                newName: "Is_Instructor");

            migrationBuilder.RenameColumn(
                name: "IsFinished",
                table: "Course_Enrollment",
                newName: "Is_Finished");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course_Enrollment",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Course_Enrollment",
                newName: "Profile_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CourseEnrollment_CourseId",
                table: "Course_Enrollment",
                newName: "IX_Course_Enrollment_Course_Id");

            migrationBuilder.RenameColumn(
                name: "SignUpDeadline",
                table: "Course",
                newName: "SignUp_Deadline");

            migrationBuilder.RenameColumn(
                name: "IsWorkshop",
                table: "Course",
                newName: "Is_Workshop");

            migrationBuilder.RenameColumn(
                name: "IsRunning",
                table: "Course",
                newName: "Is_Running");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Course",
                newName: "Is_Active");

            migrationBuilder.RenameColumn(
                name: "IconFileName",
                table: "Course",
                newName: "Icon_FileName");

            migrationBuilder.RenameColumn(
                name: "DescriptionShort",
                table: "Course",
                newName: "Description_Short");

            migrationBuilder.RenameColumn(
                name: "DescriptionLong",
                table: "Course",
                newName: "Description_Long");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Course",
                newName: "Course_Name");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "CompetencyName",
                table: "Competency",
                newName: "Competency_Name");

            migrationBuilder.RenameColumn(
                name: "CompetencyId",
                table: "Competency",
                newName: "Competency_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Thematics_Attachment",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Attachment_FileName",
                table: "Thematics_Attachment",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Workplace",
                table: "Profile",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Team_Member",
                table: "Profile",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slack",
                table: "Profile",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Skype",
                table: "Profile",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Pic_FileName",
                table: "Profile",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Profile",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Profile",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Membership_Start",
                table: "Profile",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Major",
                table: "Profile",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Profile",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Profile",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Uni_Start",
                table: "Profile",
                type: "date",
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Competency_Lvl",
                table: "Member_Competency",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignUp_Deadline",
                table: "Course",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Description_Short",
                table: "Course",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Thematics_Attachment",
                table: "Thematics_Attachment",
                column: "Thematics_Attachment_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Member_Competency",
                table: "Member_Competency",
                column: "Member_Competency_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homework_Upload",
                table: "Homework_Upload",
                column: "Homework_Upload_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Thematics",
                table: "Course_Thematics",
                columns: new[] { "Course_Id", "Week_Number" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_News",
                table: "Course_News",
                column: "Course_News_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Course_E__0570CB1F2160B5CA",
                table: "Course_Enrollment",
                columns: new[] { "Profile_Id", "Course_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Enrollment_ToCourse",
                table: "Course_Enrollment",
                column: "Course_Id",
                principalTable: "Course",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Enrollment_ToProfile",
                table: "Course_Enrollment",
                column: "Profile_Id",
                principalTable: "Profile",
                principalColumn: "Profile_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_ToCourse",
                table: "Course_News",
                column: "Course_Id",
                principalTable: "Course",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Thematics_ToCourse",
                table: "Course_Thematics",
                column: "Course_Id",
                principalTable: "Course",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Upload_ToProfile",
                table: "Homework_Upload",
                column: "Profile_Id",
                principalTable: "Profile",
                principalColumn: "Profile_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Upload_ToCourse_Thematics",
                table: "Homework_Upload",
                columns: new[] { "Course_Id", "Week_Number" },
                principalTable: "Course_Thematics",
                principalColumns: new[] { "Course_Id", "Week_Number" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Competency_ToCompetency",
                table: "Member_Competency",
                column: "Competency_Id",
                principalTable: "Competency",
                principalColumn: "Competency_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Competency_ToProfile",
                table: "Member_Competency",
                column: "Profile_Id",
                principalTable: "Profile",
                principalColumn: "Profile_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thematics_Attachment_ToCourse_Thematics",
                table: "Thematics_Attachment",
                columns: new[] { "Course_Id", "Week_Number" },
                principalTable: "Course_Thematics",
                principalColumns: new[] { "Course_Id", "Week_Number" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
