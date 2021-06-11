using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseFirstProject.Models
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=DESKTOP-1C1EU5R;Integrated security=true;Initial Catalog=dbCompany");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.AreaName)
                    .HasName("PK__Areas__B33A6E57FB0DA810");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("area_name");

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("zip_code")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("FK__Employees__area__286302EC");
            });

            modelBuilder.Entity<EmployeeSkill>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.SkillName })
                    .HasName("PK__Employee__121208221C906371");

                entity.ToTable("EmployeeSkill");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skill_name");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSkills)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeS__emplo__2F10007B");

                entity.HasOne(d => d.SkillNameNavigation)
                    .WithMany(p => p.EmployeeSkills)
                    .HasForeignKey(d => d.SkillName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeS__skill__300424B4");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.SkillName)
                    .HasName("PK__Skills__73C038ACCAD8C495");

                entity.Property(e => e.SkillName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("skill_name");

                entity.Property(e => e.SkillDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Skill_description");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
