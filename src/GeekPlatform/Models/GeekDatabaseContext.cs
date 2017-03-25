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
            modelBuilder.Entity<CourseThematics>()
                .HasKey(c => new { c.CourseId, c.WeekNumber });

            modelBuilder.Entity<CourseEnrollment>()
                .HasKey(c => new { c.ProfileId, c.CourseId });
        }
    }
}