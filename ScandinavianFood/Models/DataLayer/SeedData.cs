using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace ScandinavianFood.Models.DataLayer
{
    public static class SeedData
    {
        private const string ID1 = "A";
        private const string ID2 = "B";
        private const string ID3 = "C";

        public static async Task SeedAdminUser(IServiceProvider serviceProvider)
        {
            // TODO: hide credentials later
            const string USERNAME = "admin";
            const string PASSWORD = "sesame0";
            const string ROLE_NAME = "Admin";

            UserManager<AppUser> userManager =
                serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(ROLE_NAME) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(ROLE_NAME));
            }

            if (await userManager.FindByNameAsync(USERNAME) == null)
            {
                var user = new AppUser { UserName = USERNAME };
                var result = await userManager.CreateAsync(user, PASSWORD);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, ROLE_NAME);
                }
            }
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            // seed users
            var user1 = new AppUser()
            {
                Id = ID1,
                UserName = "AlanS"
            };
            var user2 = new AppUser()
            {
                Id = ID2,
                UserName = "SolaireA"
            };
            var user3 = new AppUser()
            {
                Id = ID3,
                UserName = "LautrecC"
            };

            modelBuilder.Entity<AppUser>().HasData(
                user1, user2, user3
            );

            // seed posts
            modelBuilder.Entity<ForumPost>().HasData(
                new
                {
                    Id = 1,
                    User = user1.UserName,
                    Text = "Hello World",
                    PostDate = DateTime.Parse("1/1/2022")
                },
                new
                {
                    Id = 2,
                    User = user2.UserName,
                    Text = "Seed Data",
                    PostDate = DateTime.Parse("6/4/2021")
                }
            );
        }
    }
}
