using AutoMapper;
using BlogProgramming.Entities.Concretes;
using BlogProgramming.Entities.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.AutoMapper.Profiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto,Category>().ForMember(dest=>dest.CreateDate, opt=>opt.MapFrom(src=>DateTime.Now));
            CreateMap<CategoryUpdateDto,Category>().ForMember(dest=>dest.ModifiedDate, opt=>opt.MapFrom(src=> DateTime.Now));   
        }
    }
}
