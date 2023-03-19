using BlogProgramming.Core.Utilities.Results.Abstract;
using BlogProgramming.Entities.Concretes;
using BlogProgramming.Entities.Dtos.Articles;
using BlogProgramming.Entities.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int id);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDelete(int id);
        Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId);
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive();
        Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int id, string modifiedByName);
        Task<IResult> HardDelete(int id);
    }
}
