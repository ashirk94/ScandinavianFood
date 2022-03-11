using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScandinavianFood.Models.DomainModels;
using System;
using System.Threading.Tasks;

namespace ScandinavianFood.Models.DataLayer
{
    public static class SeedData
    {
        // password hidden
        private const string USERNAME = "admin";
        private const string ROLE_NAME = "Admin";
        private const string ID1 = "A";
        private const string ID2 = "B";
        private const string ID3 = "C";

        public static async Task SeedAdminUser(IServiceProvider serviceProvider, string password)
        {
            //managers from serviceprovider
            UserManager<AppUser> userManager =
                serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();


            // if role doesn't exist, create it
            var adminRole = await roleManager.FindByNameAsync(ROLE_NAME);
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole(ROLE_NAME));
            }

            if (await userManager.FindByNameAsync(USERNAME) == null)
            {
                var user = new AppUser { UserName = USERNAME };
                var result = await userManager.CreateAsync(user, password);
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
                    ForumPostId = 1,
                    PosterId = ID1,
                    Text = "Hello World",
                    PostDate = DateTime.Parse("1/1/2022")
                },
                new
                {
                    ForumPostId = 2,
                    PosterId = ID2,
                    Text = "Seed Data",
                    PostDate = DateTime.Parse("6/4/2021")
                }
            );

        }
    }
}
