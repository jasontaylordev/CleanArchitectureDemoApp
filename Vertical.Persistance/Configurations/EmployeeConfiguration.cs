using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vertical.Domain.Entities;

namespace Vertical.Persistance.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("tblEmployee");

            builder.Property(e => e.Address)
                .IsUnicode(false);

            builder.Property(e => e.Contact)
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Email)
                .IsUnicode(false);

            builder.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .HasMaxLength(800)
                .IsUnicode(false);

            // This is not right - know the conventions - this will happen automatically.
            //builder.Property(e => e.IsActive)
            //    .HasColumnType("(bit)");
            
            //many to one relationship

            // This is not valid, EF Core complains when trying to apply the migration.
            //builder.HasOne(x => x.Department)
            //    .WithMany(x => x.Employees)
            //    .IsRequired()
            //    .HasForeignKey(x => x.DeptId)
            //    .OnDelete(DeleteBehavior.SetNull);
        }
    }
}