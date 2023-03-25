using AutoMapper;
using BlogProgramming.Entities.Concretes;
using BlogProgramming.Entities.Dtos.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.AutoMapper.Profiles
{
    public class ArticleProfile: Profile
    {
      
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest=>dest.ModifiedDate,opt=>opt.MapFrom(src => DateTime.Now));
        }
    }
}
