using BlogProgramming.Core.Exceptions;
using BlogProgramming.Core.Utilities.Result.Abstract;
using BlogProgramming.Core.Utilities.Result.Concrete;
using BlogProgramming.DataAccess.Abstracts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.Rules
{
    public class CategoryBusinessRules
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryBusinessRules(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public  async Task<IResult> CheckIfCategoryIdExist(int id)
        {
            var isExist = await _unitOfWork.Categories.AnyAsync(c => c.Id == id);
            if (!isExist)
            {
                return new ErrorResult($"{id}'li kategori bulunamadı");
            }
            return new SuccessResult();
        }
    }
}
