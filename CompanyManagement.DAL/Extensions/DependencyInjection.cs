namespace CompanyManagement.DataAccess.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddEFCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerProjectRepository, CustomerProjectRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProjectProductRepository, ProjectProductRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ISupplierProductRepository, SupplierProductRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            return services;
        }
    }
}
