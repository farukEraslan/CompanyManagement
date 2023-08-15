using System.Configuration;

namespace CompanyManagement.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<CompanyManagementDbContext>( options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Db"));
            });

            // Identity
            builder.Services.AddDefaultIdentity<UserEntity>(options =>
            {

            }).AddRoles<RoleEntity>().AddEntityFrameworkStores<CompanyManagementDbContext>();

            // Login 
            builder.Services.ConfigureApplicationCookie(config =>
            {
                //Login Path
                config.LoginPath = new PathString("/user/login");
                config.AccessDeniedPath = new PathString("/user/access-denied");
                config.Cookie.HttpOnly = true;
                config.SlidingExpiration = true;
            });

            //Automapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}