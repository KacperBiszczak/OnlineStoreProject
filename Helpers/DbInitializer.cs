using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using OnlineStoreZaliczenie.Models;

namespace OnlineStoreZaliczenie.Helpers
{
    public static class DbInitializer
    {
        public static void SeedRolesAndUsers(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // Add roles
            string[] roles = { "Admin", "User" };
            foreach (var role in roles)
            {
                if (!roleManager.RoleExistsAsync(role).Result)
                {
                    roleManager.CreateAsync(new IdentityRole(role)).Wait();
                }
            }

            // Add admin account
            var adminEmail = "admin@gmail.com";
            var adminPassword = "zaq1@WSX";
            if (userManager.FindByEmailAsync(adminEmail).Result == null)
            {
                var adminUser = new ApplicationUser { UserName = adminEmail, Email = adminEmail, FirstName = "Admin", LastName = "Admin" };
                var result = userManager.CreateAsync(adminUser, adminPassword).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(adminUser, "Admin").Wait();
                }
            }
        }
    }
}
