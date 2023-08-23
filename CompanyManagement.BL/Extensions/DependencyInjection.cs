using CompanyManagement.Business.Concrete;
using Microsoft.AspNetCore.Identity;

namespace CompanyManagement.Business.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerProjectService, CustomerProjectManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProjectProductService, ProjectProductManager>();
            services.AddScoped<IProjectService, ProjectManager>();
            services.AddScoped<ISupplierService, SupplierManager>();
            services.AddScoped<ISupplierProductService, SupplierProductManager>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IUserRoleService, UserRoleManager>();
            return services;
        }
    }
}
