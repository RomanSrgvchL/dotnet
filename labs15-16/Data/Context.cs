using labs15_16.Models;
using Microsoft.EntityFrameworkCore;

namespace labs15_16.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Конфигурация для Department
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .HasColumnName("id")
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                      .HasColumnName("name")
                      .HasMaxLength(255)
                      .IsRequired();

                entity.Property(e => e.Location)
                      .HasColumnName("location")
                      .HasMaxLength(200)
                      .IsRequired();

                entity.Property(e => e.Budget)
                      .HasColumnName("budget")
                      .IsRequired();

                entity.Property(e => e.DepartmentType)
                      .HasColumnName("department_type")
                      .HasConversion<string>()
                      .HasMaxLength(15)
                      .IsRequired();
            });

            // Конфигурация для Employee
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                      .HasColumnName("id")
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.FullName)
                      .HasColumnName("full_name")
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Position)
                      .HasColumnName("position")
                      .HasMaxLength(50)
                      .IsRequired();

                entity.Property(e => e.Photo)
                      .IsRequired(false)
                      .HasColumnName("photo")
                      .HasColumnType("bytea");

                entity.Property(e => e.DepartmentId)
                      .HasColumnName("department_id");

                // Связь с Department
                entity.HasOne(e => e.Department)
                      .WithMany(d => d.Employees)
                      .HasForeignKey(e => e.DepartmentId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}