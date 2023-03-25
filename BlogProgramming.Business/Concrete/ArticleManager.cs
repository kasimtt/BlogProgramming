using AutoMapper;
using BlogProgramming.Business.Abstract;
using BlogProgramming.Business.Rules;
using BlogProgramming.Core.Utilities.Business;
using BlogProgramming.Core.Utilities.Result.Abstract;
using BlogProgramming.Core.Utilities.Result.ComplexType;
using BlogProgramming.Core.Utilities.Result.Concrete;
using BlogProgramming.DataAccess.Abstract;
using BlogProgramming.DataAccess.Abstracts;
using BlogProgramming.Entities.Concretes;
using BlogProgramming.Entities.Dtos.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CategoryBusinessRules _categoryBusinessRules;
        private readonly IMapper _mapper;
        private readonly ArticleBusinessRules _articleBusinessRules;
        public ArticleManager(IUnitOfWork unitOfWork, CategoryBusinessRules categoryBusinessRules, IMapper mapper) 
        { 
            _unitOfWork = unitOfWork;
            _categoryBusinessRules = categoryBusinessRules;
            _mapper = mapper;   
        }
        public async Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            var article = _mapper.Map<Article>(articleAddDto);
            article.CreatedByName = createdByName;
            article.ModifiedByName = createdByName;
            article.ModifiedDate = DateTime.Now;
            article.UserId = 1; // refactoring yapılacak panpa
            await _unitOfWork.Articles.AddAsync(article).ContinueWith(t=> _unitOfWork.SaveAsync());
            return new SuccessResult($"{article.Title} başlıklı makale eklendi");
        }

        public async Task<IResult> Delete(int id, string modifiedByName)
        {
            
            var result = BusinessRules.Run(await _articleBusinessRules.CheckIfArticleIdExist(id));
            if(result != null)
            {
                return result;
            }
            var article = await _unitOfWork.Articles.GetAsync(a=>a.Id == id);
            article.IsDeleted = true;
            article.ModifiedByName= modifiedByName;
            article.ModifiedDate = DateTime.Now;
            await _unitOfWork.Articles.UpdateAsync(article).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult( $"{article.Title} başlıklı makale başarıyla silinmiştir");

        }

        public async Task<IDataResult<ArticleDto>> Get(int id)
        {
            var article = await  _unitOfWork.Articles.GetAsync(a => a.Id == id, a => a.User, a => a.Category);
            if(article!=null)
            {
                return new SuccessDataResult<ArticleDto>( new ArticleDto
                {
                    ResultStatus = ResultStatus.Success,
                    Article = article
                });
            }
            return new ErrorDataResult<ArticleDto>("Gerekli makale bulunamadı.");
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
          
           var articles = await _unitOfWork.Articles.GetAllAsync(null, a=>a.User , a=>a.Category);
           if(articles.Count>-1)
            {
                return new SuccessDataResult<ArticleListDto>( new ArticleListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Articles = articles
                });
            }
            return new ErrorDataResult<ArticleListDto>("şapşal burada hic makale yook");
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId)
        {
            var result = BusinessRules.Run(await _categoryBusinessRules.CheckIfCategoryIdExist(categoryId));
            
            if(result != null)
            {
                return (IDataResult<ArticleListDto>)result;
            }
          
            var articles = await _unitOfWork.Articles.GetAllAsync(a=>a.Id == categoryId && !a.IsDeleted && a.IsActive,a=>a.User, a=>a.Category);
            if(articles.Count>-1)
            {
                return new SuccessDataResult<ArticleListDto>( new ArticleListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Articles = articles
                });
            }
            return new ErrorDataResult<ArticleListDto>("ilgili kategoride makale bulunamadı");
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDelete()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted, a => a.User, a => a.Category);
            if(articles.Count>-1)
            {
                return new SuccessDataResult<ArticleListDto>( new ArticleListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Articles = articles
                });
            }
            return new ErrorDataResult<ArticleListDto>("ilgili makaleler bulunamadı");
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted && a.IsActive, a => a.User, a => a.Category);
            if(articles.Count>-1)
            {
                return new SuccessDataResult<ArticleListDto>(new ArticleListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Articles = articles
                });
            }
            return new ErrorDataResult<ArticleListDto>("ilgili makaleler bulunamadı");
        }

        public async Task<IResult> HardDelete(int id)
        {
           await _articleBusinessRules.CheckIfArticleIdExist(id);
            var article = await _unitOfWork.Articles.GetAsync(a => a.Id == id);
            await _unitOfWork.Articles.DeleteAsync(article).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new SuccessResult( $"{article.Title} veri tabanından silindi");
           
        }

        public async Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            var result = BusinessRules.Run(await _articleBusinessRules.CheckIfArticleIdExist(articleUpdateDto.Id));
            if(result != null)
            {
                return result;
            }
            var article = _mapper.Map<Article>(articleUpdateDto);
            article.ModifiedByName = modifiedByName;
            await _unitOfWork.Articles.UpdateAsync(article).ContinueWith(t=>_unitOfWork.SaveAsync());
            return new SuccessResult($"{article.Title} başarıyla güncellenmiştir");

        }



      

        
    }
}
