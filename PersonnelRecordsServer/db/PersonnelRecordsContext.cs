using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PersonnelRecordsServer.db
{
    public partial class PersonnelRecordsContext : DbContext
    {
        public PersonnelRecordsContext()
        {
        }

        public PersonnelRecordsContext(DbContextOptions<PersonnelRecordsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<ImpactType> ImpactTypes { get; set; }
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Staffing> Staffings { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HP-SURFACE\\SQLEXPRESS;Database=PersonnelRecords;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Archive>(entity =>
            {
                entity.ToTable("Archive");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateRecord).HasColumnType("date");

                entity.Property(e => e.EightArchive).HasMaxLength(100);

                entity.Property(e => e.FiveRecord).HasMaxLength(100);

                entity.Property(e => e.FourRecord).HasMaxLength(100);

                entity.Property(e => e.NineRecord).HasMaxLength(100);

                entity.Property(e => e.OneRecord).HasMaxLength(100);

                entity.Property(e => e.SevenRecord).HasMaxLength(100);

                entity.Property(e => e.SixRemuved).HasMaxLength(100);

                entity.Property(e => e.TenRecord).HasMaxLength(100);

                entity.Property(e => e.ThreeRecord).HasMaxLength(100);

                entity.Property(e => e.TwoRecord).HasMaxLength(100);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.IsRemuved).HasColumnName("isRemuved");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("Education");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EducationalPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("educationalPlace");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("expirationDate");

                entity.Property(e => e.IsRemuved).HasColumnName("isRemuved");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnType("date")
                    .HasColumnName("receiptDate");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("speciality");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsRemuved).HasColumnName("isRemuved");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("positionName");

                entity.Property(e => e.WorkPeriod).HasColumnName("workPeriod");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK_Experience_Worker");
            });

            modelBuilder.Entity<ImpactType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Passport>(entity =>
            {
                entity.ToTable("Passport");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DivisionСode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("divisionСode");

                entity.Property(e => e.IsRemuved).HasColumnName("isRemuved");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("issuedBy");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Registration)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("registration");

                entity.Property(e => e.Series).HasColumnName("series");

                entity.Property(e => e.Sex)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sex");

                entity.Property(e => e.ВateOfIssue)
                    .HasColumnType("date")
                    .HasColumnName("вateOfIssue");
            });

            modelBuilder.Entity<Staffing>(entity =>
            {
                entity.ToTable("Staffing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("companyID");

                entity.Property(e => e.IsRemuved).HasColumnName("isRemuved");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.Property(e => e.WorkerId).HasColumnName("workerID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Staffings)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Staffing_Company1");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Staffings)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK_Staffing_Worker1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.TypeUser)
                    .HasMaxLength(25)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EducationId).HasColumnName("educationID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IsRemuved).HasColumnName("isRemuved");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PassportId).HasColumnName("passportID");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("patronymic");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("surname");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_Worker_Education1");

                entity.HasOne(d => d.Passport)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.PassportId)
                    .HasConstraintName("FK_Worker_Passport1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
