﻿using CompanyManagement.Dtos.Account;

namespace CompanyManagement.Business.AutoMapper
{
    public class EntityMapper : Profile
    {
        public EntityMapper() 
        {
            CreateMap<CustomerCreateDto, Customer>().ReverseMap();
            CreateMap<CustomerUpdateDto, Customer>().ReverseMap();
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<CustomerProjectCreateDto, CustomerProject>().ReverseMap();
            CreateMap<CustomerProjectUpdateDto, CustomerProject>().ReverseMap();
            CreateMap<CustomerProjectDto, CustomerProject>().ReverseMap();
            CreateMap<ProductCreateDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<ProjectCreateDto, Project>().ReverseMap();
            CreateMap<ProjectUpdateDto, Project>().ReverseMap();
            CreateMap<ProjectDto, Project>().ReverseMap();
            CreateMap<ProjectProductCreateDto, ProjectProduct>().ReverseMap();
            CreateMap<ProjectProductUpdateDto, ProjectProduct>().ReverseMap();
            CreateMap<ProjectProductDto, ProjectProduct>().ReverseMap();
            CreateMap<SupplierCreateDto, Supplier>().ReverseMap();
            CreateMap<SupplierUpdateDto, Supplier>().ReverseMap();
            CreateMap<SupplierDto, Supplier>().ReverseMap();
            CreateMap<UserCreateDto, UserEntity>().ReverseMap();
            CreateMap<UserUpdateDto, UserEntity>().ReverseMap();
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<LoginDto, UserEntity>().ReverseMap();
        }
    }
}
