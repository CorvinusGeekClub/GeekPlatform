using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GeekPlatform.Models
{
    public partial class GeekDatabaseContext : DbContext
    {
        public virtual DbSet<Competency> Competency { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseEnrollment> CourseEnrollment { get; set; }
        public virtual DbSet<CourseNews> CourseNews { get; set; }
        public virtual DbSet<CourseThematics> CourseThematics { get; set; }
        public virtual DbSet<HomeworkUpload> HomeworkUpload { get; set; }
        public virtual DbSet<MemberCompetency> MemberCompetency { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ThematicsAttachment> ThematicsAttachment { get; set; }

        public GeekDatabaseContext(DbContextOptions options)
            :base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competency>(entity =>
            {
                entity.Property(e => e.CompetencyId).HasColumnName("Competency_Id");

                entity.Property(e => e.CompetencyName)
                    .IsRequired()
                    .HasColumnName("Competency_Name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasColumnName("Course_Name");

                entity.Property(e => e.DescriptionLong)
                    .IsRequired()
                    .HasColumnName("Description_Long");

                entity.Property(e => e.DescriptionShort)
                    .IsRequired()
                    .HasColumnName("Description_Short")
                    .HasMaxLength(200);

                entity.Property(e => e.IconFileName)
                    .IsRequired()
                    .HasColumnName("Icon_FileName");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsRunning).HasColumnName("Is_Running");

                entity.Property(e => e.IsWorkshop).HasColumnName("Is_Workshop");

                entity.Property(e => e.SignUpDeadline)
                    .HasColumnName("SignUp_Deadline")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<CourseEnrollment>(entity =>
            {
                entity.HasKey(e => new { e.ProfileId, e.CourseId })
                    .HasName("PK__Course_E__0570CB1F2160B5CA");

                entity.ToTable("Course_Enrollment");

                entity.Property(e => e.ProfileId).HasColumnName("Profile_Id");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.IsFinished).HasColumnName("Is_Finished");

                entity.Property(e => e.IsInstructor).HasColumnName("Is_Instructor");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseEnrollment)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Course_Enrollment_ToCourse");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.CourseEnrollment)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Course_Enrollment_ToProfile");
            });

            modelBuilder.Entity<CourseNews>(entity =>
            {
                entity.ToTable("Course_News");

                entity.Property(e => e.CourseNewsId).HasColumnName("Course_News_Id");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseNews)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Table_ToCourse");
            });

            modelBuilder.Entity<CourseThematics>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.WeekNumber })
                    .HasName("PK_Course_Thematics");

                entity.ToTable("Course_Thematics");

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.WeekNumber).HasColumnName("Week_Number");

                entity.Property(e => e.ActualDate)
                    .HasColumnName("Actual_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.HomeworkDescription).HasColumnName("Homework_Description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseThematics)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Course_Thematics_ToCourse");
            });

            modelBuilder.Entity<HomeworkUpload>(entity =>
            {
                entity.ToTable("Homework_Upload");

                entity.Property(e => e.HomeworkUploadId).HasColumnName("Homework_Upload_Id");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.ProfileId).HasColumnName("Profile_Id");

                entity.Property(e => e.UploadDateTime).HasColumnName("Upload_DateTime");

                entity.Property(e => e.UploadFileName)
                    .IsRequired()
                    .HasColumnName("Upload_FileName")
                    .HasMaxLength(128);

                entity.Property(e => e.WeekNumber).HasColumnName("Week_Number");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.HomeworkUpload)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Homework_Upload_ToProfile");

                entity.HasOne(d => d.CourseThematics)
                    .WithMany(p => p.HomeworkUpload)
                    .HasForeignKey(d => new { d.CourseId, d.WeekNumber })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Homework_Upload_ToCourse_Thematics");
            });

            modelBuilder.Entity<MemberCompetency>(entity =>
            {
                entity.ToTable("Member_Competency");

                entity.Property(e => e.MemberCompetencyId).HasColumnName("Member_Competency_Id");

                entity.Property(e => e.CompetencyComment)
                    .IsRequired()
                    .HasColumnName("Competency_Comment");

                entity.Property(e => e.CompetencyId).HasColumnName("Competency_Id");

                entity.Property(e => e.CompetencyLvl).HasColumnName("Competency_Lvl");

                entity.Property(e => e.ProfileId).HasColumnName("Profile_Id");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.MemberCompetency)
                    .HasForeignKey(d => d.CompetencyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Member_Competency_ToCompetency");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MemberCompetency)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Member_Competency_ToProfile");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.ProfileId).HasColumnName("Profile_Id");

                entity.Property(e => e.Address).HasMaxLength(64);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(64);

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsAdmin).HasColumnName("Is_Admin");

                entity.Property(e => e.Major).HasMaxLength(64);

                entity.Property(e => e.MembershipStart)
                    .HasColumnName("Membership_Start")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.PicFileName)
                    .HasColumnName("Pic_FileName")
                    .HasMaxLength(128);

                entity.Property(e => e.Skype).HasMaxLength(64);

                entity.Property(e => e.Slack).HasMaxLength(64);

                entity.Property(e => e.TeamMember)
                    .HasColumnName("Team_Member")
                    .HasMaxLength(20);

                entity.Property(e => e.UniStart)
                    .HasColumnName("Uni_Start")
                    .HasColumnType("date");

                entity.Property(e => e.Workplace).HasMaxLength(64);
            });

            modelBuilder.Entity<ThematicsAttachment>(entity =>
            {
                entity.ToTable("Thematics_Attachment");

                entity.Property(e => e.ThematicsAttachmentId).HasColumnName("Thematics_Attachment_Id");

                entity.Property(e => e.AttachmentFileName)
                    .IsRequired()
                    .HasColumnName("Attachment_FileName")
                    .HasMaxLength(128);

                entity.Property(e => e.CourseId).HasColumnName("Course_Id");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsHomework).HasColumnName("Is_Homework");

                entity.Property(e => e.WeekNumber).HasColumnName("Week_Number");

                entity.HasOne(d => d.CourseThematics)
                    .WithMany(p => p.ThematicsAttachment)
                    .HasForeignKey(d => new { d.CourseId, d.WeekNumber })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Thematics_Attachment_ToCourse_Thematics");
            });
        }
    }
}