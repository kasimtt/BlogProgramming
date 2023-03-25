using BlogProgramming.Core.Exceptions;
using BlogProgramming.Core.Utilities.Result.Abstract;
using BlogProgramming.Core.Utilities.Result.Concrete;
using BlogProgramming.DataAccess.Abstract;
using BlogProgramming.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.Rules
{
    public class ArticleBusinessRules
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleBusinessRules(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> CheckIfArticleIdExist(int id)
        {
            var IsExist = await _unitOfWork.Articles.AnyAsync(a => a.Id == id);
            if (!IsExist)
            {
                return new ErrorResult($"{id}'li makale bulunmamaktadır");
            }
            return new SuccessResult();
        }

    }
}
