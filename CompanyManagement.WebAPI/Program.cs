using CompanyManagement.Entities.Concrete;

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

            builder.Services.AddDbContext<CompanyManagementDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Db"));
            });

            //Automapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<DbContext, CompanyManagementDbContext>();

            // Identity
            builder.Services.AddDefaultIdentity<UserEntity>(options =>
            {

            }).AddRoles<RoleEntity>().AddEntityFrameworkStores<CompanyManagementDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Area Explanation
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //      name: "areas",
            //      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            //    );
            //});

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}