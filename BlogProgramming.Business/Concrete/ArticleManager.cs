using BlogProgramming.Business.Abstract;
using BlogProgramming.Core.Utilities.Results.Abstract;
using BlogProgramming.Core.Utilities.Results.ComplexType;
using BlogProgramming.Core.Utilities.Results.Concrete;
using BlogProgramming.DataAccess.Abstract;
using BlogProgramming.DataAccess.Abstracts;
using BlogProgramming.Entities.Dtos.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ArticleManager(IUnitOfWork unitOfWork) 
        { 
            _unitOfWork = unitOfWork;
        }
        public Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int id, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ArticleDto>> Get(int id)
        {
            var article = await  _unitOfWork.Articles.GetAsync(a => a.Id == id, a => a.User, a => a.Category);
            if(article!=null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    ResultStatus = ResultStatus.Success,
                    Article = article
                });
            }
            return new DataResult<ArticleDto>(ResultStatus.Error,"Gerekli makale bulunamadı.");
        }

        public Task<IDataResult<ArticleListDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ArticleListDto>> GetAllByNonDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
