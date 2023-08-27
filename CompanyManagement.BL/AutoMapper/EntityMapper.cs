using CompanyManagement.Dtos.Account;

namespace CompanyManagement.Business.AutoMapper
{
    public class EntityMapper : Profile
    {
        public EntityMapper() 
        {
            CreateMap<CustomerCreateDto, Customer>();
            CreateMap<CustomerUpdateDto, Customer>().ReverseMap();
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<CustomerProjectCreateDto, CustomerProject>();
            CreateMap<CustomerProjectUpdateDto, CustomerProject>().ReverseMap();
            CreateMap<CustomerProjectDto, CustomerProject>().ReverseMap();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<ProductCreateDto, ProductQRCodeDto>();
            CreateMap<ProjectCreateDto, Project>();
            CreateMap<ProjectUpdateDto, Project>().ReverseMap();
            CreateMap<ProjectDto, Project>().ReverseMap();
            CreateMap<ProjectProductCreateDto, ProjectProduct>();
            CreateMap<ProjectProductUpdateDto, ProjectProduct>().ReverseMap();
            CreateMap<ProjectProductDto, ProjectProduct>().ReverseMap();
            CreateMap<SupplierCreateDto, Supplier>();
            CreateMap<SupplierUpdateDto, Supplier>().ReverseMap();
            CreateMap<SupplierDto, Supplier>().ReverseMap();
            CreateMap<UserCreateDto, UserEntity>();
            CreateMap<UserUpdateDto, UserEntity>().ReverseMap();
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<LoginDto, UserEntity>().ReverseMap();
        }
    }
}
