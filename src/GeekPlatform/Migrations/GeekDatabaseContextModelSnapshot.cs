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

            modelBuilder.Entity("GeekPlatform.Models.GalleryAlbum", b =>
                {
                    b.Property<int>("GalleryAlbumId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int?>("CreatorId");

                    b.Property<string>("Name");

                    b.HasKey("GalleryAlbumId");

                    b.HasIndex("CreatorId");

                    b.ToTable("GalleryAlbum");
                });

            modelBuilder.Entity("GeekPlatform.Models.GalleryPicture", b =>
                {
                    b.Property<int>("GalleryPictureId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption");

                    b.Property<string>("Filename");

                    b.Property<int>("GalleryAlbumId");

                    b.Property<DateTime>("UploadedAt");

                    b.Property<int?>("UploaderId");

                    b.HasKey("GalleryPictureId");

                    b.HasIndex("GalleryAlbumId");

                    b.HasIndex("UploaderId");

                    b.ToTable("GalleryPicture");
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Major");

                    b.Property<DateTime>("MembershipStart");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PicFileName");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Skype");

                    b.Property<string>("Slack");

                    b.Property<string>("TeamMember");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("UniStartYear");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("Workplace");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
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

            modelBuilder.Entity("GeekPlatform.Models.GalleryAlbum", b =>
                {
                    b.HasOne("GeekPlatform.Models.Profile", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("GeekPlatform.Models.GalleryPicture", b =>
                {
                    b.HasOne("GeekPlatform.Models.GalleryAlbum", "Album")
                        .WithMany("GalleryPicture")
                        .HasForeignKey("GalleryAlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeekPlatform.Models.Profile", "Uploader")
                        .WithMany()
                        .HasForeignKey("UploaderId");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<int>")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GeekPlatform.Models.Profile")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GeekPlatform.Models.Profile")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole<int>")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GeekPlatform.Models.Profile")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
