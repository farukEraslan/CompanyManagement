using CompanyManagement.Business.Concrete;
using CompanyManagement.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace CompanyManagement.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

            builder.Services.AddEFCoreServices().AddBusinessServices();

            // Database
            builder.Services.AddDbContext<CompanyManagementDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Db"));
            });

            //Automapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // HttpContextAccessor
            builder.Services.AddHttpContextAccessor();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<DbContext, CompanyManagementDbContext>();
            builder.Services.AddTransient<UserRoleManager>();


            // Identity
            builder.Services.AddDefaultIdentity<UserEntity>(options =>
            {

            }).AddRoles<RoleEntity>().AddEntityFrameworkStores<CompanyManagementDbContext>();

            // Login 
            builder.Services.ConfigureApplicationCookie(config =>
            {
                //Login Path
                config.LoginPath = new PathString("/api/Account/Login");
                config.AccessDeniedPath = new PathString("/api/Account/AccesDenied");
                config.Cookie.HttpOnly = true;
                config.SlidingExpiration = true;
            });

            // CORS policy için frontend ekibinin host numaralarýnýn ekleneceði yer
            var myOrigins = "_myOrigins";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: myOrigins,
                    policy =>
                    {
                        policy.WithOrigins("*")
                        .WithMethods("GET", "POST", "PUT", "HEAD", "DELETE", "CONNECT", "OPTIONS", "PATCH", "SEARCH")
                        .AllowAnyHeader();
                    });
            });

            var app = builder.Build();

            // CORS policy aktif edildiði yer
            app.UseCors(myOrigins);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}