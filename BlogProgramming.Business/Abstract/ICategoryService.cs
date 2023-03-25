
using BlogProgramming.Core.Utilities.Result.Abstract;
using BlogProgramming.Entities.Concretes;
using BlogProgramming.Entities.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogProgramming.Business.Abstract
{
    public interface ICategoryService
    {
      Task<IDataResult<CategoryDto>> Get(int id);
      Task<IDataResult<CategoryListDto>> GetAll();
      Task<IDataResult<CategoryListDto>> GetAllByNonDelete(int id);
      Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
      Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
      Task<IResult> Delete(int id, string modifiedByName);
      Task<IResult> HardDelete(int id);

    }
}
