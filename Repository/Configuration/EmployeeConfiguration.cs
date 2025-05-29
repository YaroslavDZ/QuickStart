using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
            (
                new Employee
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    FirstName = "Petro",
                    LastName = "Petrenko",
                    DateOfBirth = new DateTime(1995, 03, 31),
                    Position = "Junior",
                    Salary = 15000
                },
                new Employee
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    FirstName = "Yaroslav",
                    LastName = "Dzysiuk",
                    DateOfBirth = new DateTime(1997, 11, 15),
                    Position = "Middle",
                    Salary = 25000
                }
            );
        }
    }
}
