using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GeekPlatform.Models;

namespace GeekPlatform.Migrations
{
    [DbContext(typeof(GeekDatabaseContext))]
    [Migration("20170325012939_DataAnnoations")]
    partial class DataAnnoations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GeekPlatform.Models.Competency", b =>
                {
                    b.Property<int>("CompetencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompetencyName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("CompetencyId");

                    b.ToTable("Competency");
                });

            modelBuilder.Entity("GeekPlatform.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseName")
                        .IsRequired();

                    b.Property<string>("DescriptionLong")
                        .IsRequired();

                    b.Property<string>("DescriptionShort")
                        .IsRequired();

                    b.Property<string>("IconFileName")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsRunning");

                    b.Property<bool>("IsWorkshop");

                    b.Property<DateTime>("SignUpDeadline");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseEnrollment", b =>
                {
                    b.Property<int>("ProfileId");

                    b.Property<int>("CourseId");

                    b.Property<bool>("IsFinished");

                    b.Property<bool>("IsInstructor");

                    b.HasKey("ProfileId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseEnrollment");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseNews", b =>
                {
                    b.Property<int>("CourseNewsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("PostTime");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("CourseNewsId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseNews");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseThematics", b =>
                {
                    b.Property<int>("CourseId");

                    b.Property<byte>("WeekNumber");

                    b.Property<DateTime>("ActualDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("HomeworkDescription");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("CourseId", "WeekNumber");

                    b.ToTable("CourseThematics");
                });

            modelBuilder.Entity("GeekPlatform.Models.HomeworkUpload", b =>
                {
                    b.Property<int>("HomeworkUploadId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<int>("CourseId");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ProfileId");

                    b.Property<DateTime>("UploadDateTime");

                    b.Property<string>("UploadFileName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<byte>("WeekNumber");

                    b.HasKey("HomeworkUploadId");

                    b.HasIndex("ProfileId");

                    b.HasIndex("CourseId", "WeekNumber");

                    b.ToTable("HomeworkUpload");
                });

            modelBuilder.Entity("GeekPlatform.Models.MemberCompetency", b =>
                {
                    b.Property<int>("MemberCompetencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompetencyComment")
                        .IsRequired();

                    b.Property<int>("CompetencyId");

                    b.Property<int>("CompetencyLvl");

                    b.Property<int>("ProfileId");

                    b.HasKey("MemberCompetencyId");

                    b.HasIndex("CompetencyId");

                    b.HasIndex("ProfileId");

                    b.ToTable("MemberCompetency");
                });

            modelBuilder.Entity("GeekPlatform.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Major");

                    b.Property<DateTime>("MembershipStart");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("PicFileName");

                    b.Property<string>("Skype");

                    b.Property<string>("Slack");

                    b.Property<string>("TeamMember");

                    b.Property<int>("UniStartYear");

                    b.Property<string>("Workplace");

                    b.HasKey("ProfileId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("GeekPlatform.Models.ThematicsAttachment", b =>
                {
                    b.Property<int>("ThematicsAttachmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AttachmentFileName")
                        .IsRequired();

                    b.Property<int>("CourseId");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsHomework");

                    b.Property<byte>("WeekNumber");

                    b.HasKey("ThematicsAttachmentId");

                    b.HasIndex("CourseId", "WeekNumber");

                    b.ToTable("ThematicsAttachment");
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseEnrollment", b =>
                {
                    b.HasOne("GeekPlatform.Models.Course", "Course")
                        .WithMany("CourseEnrollment")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeekPlatform.Models.Profile", "Profile")
                        .WithMany("CourseEnrollment")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseNews", b =>
                {
                    b.HasOne("GeekPlatform.Models.Course", "Course")
                        .WithMany("CourseNews")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GeekPlatform.Models.CourseThematics", b =>
                {
                    b.HasOne("GeekPlatform.Models.Course", "Course")
                        .WithMany("CourseThematics")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GeekPlatform.Models.HomeworkUpload", b =>
                {
                    b.HasOne("GeekPlatform.Models.Profile", "Profile")
                        .WithMany("HomeworkUpload")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeekPlatform.Models.CourseThematics", "CourseThematics")
                        .WithMany("HomeworkUpload")
                        .HasForeignKey("CourseId", "WeekNumber")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GeekPlatform.Models.MemberCompetency", b =>
                {
                    b.HasOne("GeekPlatform.Models.Competency", "Competency")
                        .WithMany("MemberCompetency")
                        .HasForeignKey("CompetencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeekPlatform.Models.Profile", "Profile")
                        .WithMany("MemberCompetency")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GeekPlatform.Models.ThematicsAttachment", b =>
                {
                    b.HasOne("GeekPlatform.Models.CourseThematics", "CourseThematics")
                        .WithMany("ThematicsAttachment")
                        .HasForeignKey("CourseId", "WeekNumber")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
