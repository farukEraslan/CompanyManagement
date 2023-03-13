using AutoMapper;
using CompanyManagement.Entities.Concrete;
using CompanyManagement.WebUI.Areas.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.AutoMapper
{
    public class EntityMapper : Profile
    {
        public EntityMapper() 
        {
            CreateMap<UserEntity, UserVM>();
        }
    }
}
