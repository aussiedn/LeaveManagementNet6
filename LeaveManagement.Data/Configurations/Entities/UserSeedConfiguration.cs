
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "84bcfa84-abc6-4b18-893f-3d8392435cb3",
                    Email = "peter@hotmail.com",
                    NormalizedEmail = "PETER@HOTMAIL.COM",
                    NormalizedUserName = "PETER@HOTMAIL.COM",
                    UserName = "peter@hotmail.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "~Vexed089~"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "3f4631bd-f907-4409-b416-ba356312e659",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "~Vexed089~"),
                    EmailConfirmed = true
                }
            );
        }
    }
}