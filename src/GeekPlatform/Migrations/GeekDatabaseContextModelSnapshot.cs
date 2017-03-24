using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GeekPlatform.Models;

namespace GeekPlatform.Migrations
{
    [DbContext(typeof(GeekDatabaseContext))]
    partial class GeekDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GeekPlatform.Models.Competency", b =>
                {
                    b.Property<int>("CompetencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Competency_Id");

                    b.Property<string>("CompetencyName")
                        .IsRequired()
                        .HasColumnName("Competency_Name")
                        .HasMaxLength(20);

                    b.HasKey("CompetencyId");

                    b.ToTable("Competency");
                });

            modelBuilder.Entity("GeekPlatform.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Course_Id");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnName("Course_Name");

                    b.Property<string>("DescriptionLong")
                        .IsRequired()
                        .HasColumnName("Description_Long");

                    b.Property<string>("DescriptionShort")
                        .IsRequired()
                        .HasColumnName("Description_Short")
                        .HasMaxLength(200);

                    b.Property<string>("IconFileName")
                        .IsRequired()
                        .HasColumnName("Icon_FileName");

                    b.Property<bool>("IsActive")
                        .HasColumnName("Is_Active");

                    b.Property<bool>("IsRunning")
                        .HasColumnName("Is_Running");

                    b.Property<bool>("IsWorkshop")
                        .HasColumnName("Is_Workshop");

                    b.Property<DateTime>("SignUpDeadline")
                        .HasColumnName("SignUp_Deadline")
                        .HasColumnType("date");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseEnrollment", b =>
                {
                    b.Property<int>("ProfileId")
                        .HasColumnName("Profile_Id");

                    b.Property<int>("CourseId")
                        .HasColumnName("Course_Id");

                    b.Property<bool>("IsFinished")
                        .HasColumnName("Is_Finished");

                    b.Property<bool>("IsInstructor")
                        .HasColumnName("Is_Instructor");

                    b.HasKey("ProfileId", "CourseId")
                        .HasName("PK__Course_E__0570CB1F2160B5CA");

                    b.HasIndex("CourseId");

                    b.ToTable("Course_Enrollment");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseNews", b =>
                {
                    b.Property<int>("CourseNewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Course_News_Id");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("CourseId")
                        .HasColumnName("Course_Id");

                    b.Property<DateTime>("PostTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("CourseNewsId");

                    b.HasIndex("CourseId");

                    b.ToTable("Course_News");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseThematics", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnName("Course_Id");

                    b.Property<byte>("WeekNumber")
                        .HasColumnName("Week_Number");

                    b.Property<DateTime>("ActualDate")
                        .HasColumnName("Actual_Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("HomeworkDescription")
                        .HasColumnName("Homework_Description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("CourseId", "WeekNumber")
                        .HasName("PK_Course_Thematics");

                    b.ToTable("Course_Thematics");
                });

            modelBuilder.Entity("GeekPlatform.Models.HomeworkUpload", b =>
                {
                    b.Property<int>("HomeworkUploadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Homework_Upload_Id");

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<int>("CourseId")
                        .HasColumnName("Course_Id");

                    b.Property<bool>("IsActive")
                        .HasColumnName("Is_Active");

                    b.Property<int>("ProfileId")
                        .HasColumnName("Profile_Id");

                    b.Property<DateTime>("UploadDateTime")
                        .HasColumnName("Upload_DateTime");

                    b.Property<string>("UploadFileName")
                        .IsRequired()
                        .HasColumnName("Upload_FileName")
                        .HasMaxLength(128);

                    b.Property<byte>("WeekNumber")
                        .HasColumnName("Week_Number");

                    b.HasKey("HomeworkUploadId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("CourseId", "WeekNumber");

                    b.ToTable("Homework_Upload");
                });

            modelBuilder.Entity("GeekPlatform.Models.MemberCompetency", b =>
                {
                    b.Property<int>("MemberCompetencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Member_Competency_Id");

                    b.Property<string>("CompetencyComment")
                        .IsRequired()
                        .HasColumnName("Competency_Comment");

                    b.Property<int>("CompetencyId")
                        .HasColumnName("Competency_Id");

                    b.Property<byte>("CompetencyLvl")
                        .HasColumnName("Competency_Lvl");

                    b.Property<int>("ProfileId")
                        .HasColumnName("Profile_Id");

                    b.HasKey("MemberCompetencyId");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Member_Competency");
                });

            modelBuilder.Entity("GeekPlatform.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Profile_Id");

                    b.Property<bool>("ASDSDSD");

                    b.Property<string>("Address")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(64);

                    b.Property<bool>("IsActive")
                        .HasColumnName("Is_Active");

                    b.Property<bool>("IsAdmin")
                        .HasColumnName("Is_Admin");

                    b.Property<string>("Major")
                        .HasMaxLength(64);

                    b.Property<DateTime>("MembershipStart")
                        .HasColumnName("Membership_Start")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(16);

                    b.Property<string>("PicFileName")
                        .HasColumnName("Pic_FileName")
                        .HasMaxLength(128);

                    b.Property<string>("Skype")
                        .HasMaxLength(64);

                    b.Property<string>("Slack")
                        .HasMaxLength(64);

                    b.Property<string>("TeamMember")
                        .HasColumnName("Team_Member")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("UniStart")
                        .HasColumnName("Uni_Start")
                        .HasColumnType("date");

                    b.Property<string>("Workplace")
                        .HasMaxLength(64);

                    b.HasKey("ProfileId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("GeekPlatform.Models.ThematicsAttachment", b =>
                {
                    b.Property<int>("ThematicsAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Thematics_Attachment_Id");

                    b.Property<string>("AttachmentFileName")
                        .IsRequired()
                        .HasColumnName("Attachment_FileName")
                        .HasMaxLength(128);

                    b.Property<int>("CourseId")
                        .HasColumnName("Course_Id");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsActive")
                        .HasColumnName("Is_Active");

                    b.Property<bool>("IsHomework")
                        .HasColumnName("Is_Homework");

                    b.Property<byte>("WeekNumber")
                        .HasColumnName("Week_Number");

                    b.HasKey("ThematicsAttachmentId");

                    b.HasIndex("CourseId", "WeekNumber");

                    b.ToTable("Thematics_Attachment");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseEnrollment", b =>
                {
                    b.HasOne("GeekPlatform.Models.Course", "Course")
                        .WithMany("CourseEnrollment")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Course_Enrollment_ToCourse");

                    b.HasOne("GeekPlatform.Models.Profile", "Profile")
                        .WithMany("CourseEnrollment")
                        .HasForeignKey("ProfileId")
                        .HasConstraintName("FK_Course_Enrollment_ToProfile");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseNews", b =>
                {
                    b.HasOne("GeekPlatform.Models.Course", "Course")
                        .WithMany("CourseNews")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Table_ToCourse");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseThematics", b =>
                {
                    b.HasOne("GeekPlatform.Models.Course", "Course")
                        .WithMany("CourseThematics")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Course_Thematics_ToCourse");
                });

            modelBuilder.Entity("GeekPlatform.Models.HomeworkUpload", b =>
                {
                    b.HasOne("GeekPlatform.Models.Profile", "Profile")
                        .WithMany("HomeworkUpload")
                        .HasForeignKey("ProfileId")
                        .HasConstraintName("FK_Homework_Upload_ToProfile");

                    b.HasOne("GeekPlatform.Models.CourseThematics", "CourseThematics")
                        .WithMany("HomeworkUpload")
                        .HasForeignKey("CourseId", "WeekNumber")
                        .HasConstraintName("FK_Homework_Upload_ToCourse_Thematics");
                });

            modelBuilder.Entity("GeekPlatform.Models.MemberCompetency", b =>
                {
                    b.HasOne("GeekPlatform.Models.Competency", "Competency")
                        .WithMany("MemberCompetency")
                        .HasForeignKey("CompetencyId")
                        .HasConstraintName("FK_Member_Competency_ToCompetency");

                    b.HasOne("GeekPlatform.Models.Profile", "Profile")
                        .WithMany("MemberCompetency")
                        .HasForeignKey("ProfileId")
                        .HasConstraintName("FK_Member_Competency_ToProfile");
                });

            modelBuilder.Entity("GeekPlatform.Models.ThematicsAttachment", b =>
                {
                    b.HasOne("GeekPlatform.Models.CourseThematics", "CourseThematics")
                        .WithMany("ThematicsAttachment")
                        .HasForeignKey("CourseId", "WeekNumber")
                        .HasConstraintName("FK_Thematics_Attachment_ToCourse_Thematics");
                });
        }
    }
}
