using System;
using System.Collections.Generic;
using MIS3033_LC_1206_BradenFisher.Models;
using Microsoft.EntityFrameworkCore;

namespace MIS3033_LC_1206_BradenFisher.Data;

public partial class StuDB2 : DbContext
{
    public StuDB2()
    {
    }

    public StuDB2(DbContextOptions<StuDB2> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=fish00901115db;Port=5432;Username=fish0090;Password=jFo9OvfVJ5QFHHspd1Au");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.Property(e => e.CourseId).HasDefaultValueSql("''::text");
            entity.Property(e => e.StudentId).HasDefaultValueSql("''::text");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.Property(e => e.StudentId).HasDefaultValueSql("''::text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
