using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ScandinavianFood.Models;
using ScandinavianFood.Models.DataLayer;
using ScandinavianFood.Models.Repositories;

namespace ScandinavianFood
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //service injections
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //dbcontext
            services.AddDbContext<SiteDbContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("SiteDbContext")));

            //repositories
            services.AddTransient<IRepository<ForumPost>, PostRepo>();

            //httpcontext
            services.AddHttpContextAccessor();

            //identity
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<SiteDbContext>()
                .AddDefaultTokenProviders();

            //password options
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 5;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //authentication and authorization
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //seed admin
            SeedData.SeedAdminUser(app.ApplicationServices).Wait();
        }
    }
}
