namespace CompanyManagement.Business.AutoMapper
{
    public class EntityMapper : Profile
    {
        public EntityMapper() 
        {
            CreateMap<CustomerCreateDto, Customer>().ReverseMap();
            CreateMap<CustomerUpdateDto, Customer>().ReverseMap();
            CreateMap<CustomerProjectCreateDto, CustomerProject>().ReverseMap();
            CreateMap<CustomerProjectUpdateDto, CustomerProject>().ReverseMap();
            CreateMap<ProductCreateDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProjectCreateDto, Project>().ReverseMap();
            CreateMap<ProjectUpdateDto, Project>().ReverseMap();
            CreateMap<ProjectProductCreateDto, ProjectProduct>().ReverseMap();
            CreateMap<ProjectProductUpdateDto, ProjectProduct>().ReverseMap();
            CreateMap<SupplierCreateDto, Supplier>().ReverseMap();
            CreateMap<SupplierUpdateDto, Supplier>().ReverseMap();
        }
    }
}
