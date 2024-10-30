
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Udemy.Domain.Entity;
using Udemy.Repository.Context;
using  Udemy.Presentation.Extensions;

namespace Udemy.Core
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            #region Services

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            builder.Services.AddJWTAuthenticationSechma(builder.Configuration);
            #endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            #region Roles + Admin Seeding
            using (var Scope = app.Services.CreateScope())
            {
                var RoleManager = Scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                var Roles = new[] { "Admin" , "Instructor" , "Student" };

                foreach (var Role in Roles)
                {
                    if (!await RoleManager.RoleExistsAsync(Role))
                    {
                        await RoleManager.CreateAsync(new IdentityRole(Role));
                    }
                }


            }

            using (var Scope = app.Services.CreateScope())
            {
                var userManager = Scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                var Admin = await userManager.FindByEmailAsync("admin@udemy.com");

                if (Admin == null)
                {
                    var admin = new ApplicationUser()
                    {
                        Email = "admin@udemy.com" ,
                        UserName = "Admin" ,
                        FullName = "Admin"
                    };

                    var result = await userManager.CreateAsync(admin , "Udemyadmin@123");

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(admin , "Admin");
                    }
                }

                else
                {
                    if (!await userManager.IsInRoleAsync(Admin , "Admin"))
                    {
                        await userManager.AddToRoleAsync(Admin , "Admin");
                    }
                }


            }
            #endregion


            app.Run();
        }
    }
}
