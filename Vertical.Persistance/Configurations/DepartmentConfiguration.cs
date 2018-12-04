using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vertical.Domain.Entities;

namespace Vertical.Persistance.Configurations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(e => e.DeptId);

            builder.ToTable("tblDepartment");

            builder.Property(e => e.DeptId)
                .ValueGeneratedNever();

            builder.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DeptName)
                .HasMaxLength(600)
                .IsUnicode(false);

            //one to many relationship like one department can have many employees
//            builder.HasMany(e => e.Employees)
//                .WithOne(d => d.Department);
        }
    }
}