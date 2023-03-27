using AutoMapper;
using BlogProgramming.Business.Abstract;
using BlogProgramming.Business.Rules;
using BlogProgramming.Core.Utilities.Business;
using BlogProgramming.Core.Utilities.Result.Abstract;
using BlogProgramming.Core.Utilities.Result.ComplexType;
using BlogProgramming.Core.Utilities.Result.Concrete;
using BlogProgramming.DataAccess.Abstracts;
using BlogProgramming.Entities.Concretes;
using BlogProgramming.Entities.Dtos.Categories;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CategoryBusinessRules _categoryBusinessRules;
        private readonly IMapper _mapper;

        public CategoryManager(IUnitOfWork unitOfWork, CategoryBusinessRules categoryBusinessRules, IMapper mapper ) { 
        
            _unitOfWork = unitOfWork;
            _categoryBusinessRules = categoryBusinessRules;
            _mapper = mapper;
           
        }
        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            var category = _mapper.Map<Category>(categoryAddDto);
            category.CreatedByName = createdByName;
            category.ModifiedByName = createdByName;
            category.ModifiedDate = DateTime.Now;
            await _unitOfWork.Categories.AddAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            
            return new SuccessResult($"{categoryAddDto.Name} adlı kategory eklendi...");
        }

        public async Task<IResult> Delete(int id, string modifiedByName)
        {
            var result = BusinessRules.Run( await _categoryBusinessRules.CheckIfCategoryIdExist(id));
            if(result != null)
            {
                return result;
            }
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == id);
            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;
            category.ModifiedByName = modifiedByName;
            await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
            return new SuccessResult($"{category.Name} adli kategori başarıyla silinmiştir ");

        }

        public async Task<IDataResult<CategoryDto>> Get(int id)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == id, c => c.Articles);
            if(category!=null)
            {
                return new SuccessDataResult<CategoryDto>(new CategoryDto
                {
                    Category = category,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return  new ErrorDataResult<CategoryDto>("Kategori bulunamadı");
        }

        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
           var categories = await _unitOfWork.Categories.GetAllAsync(null,c=>c.Articles);
           if(categories.Count>-1)
            {
                new SuccessDataResult<CategoryListDto>(new CategoryListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Categories = categories
                });
            }
           return new ErrorDataResult<CategoryListDto>("kategoriler bulunamadı");
        }

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeleted()
        {
            
            var categories = await _unitOfWork.Categories.GetAllAsync(c=>!c.IsDeleted,c=>c.Articles);
            if(categories.Count>-1)
            {
                return new SuccessDataResult<CategoryListDto>(new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return new ErrorDataResult<CategoryListDto>("kategoriler bulunamadı");
        }

   

        public async Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive()
        {
           var categories =await _unitOfWork.Categories.GetAllAsync(c=>!c.IsDeleted && c.IsActive,c=>c.Articles);
            if(categories.Count>-1)
            {
                return new SuccessDataResult<CategoryListDto>(new CategoryListDto
                {
                    Categories = categories,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new ErrorDataResult<CategoryListDto>("kategoriler bulunamadı");
        }

        public async Task<IResult> HardDelete(int id)
        {
           var category = await _unitOfWork.Categories.GetAsync(c=>c.Id == id);
            if(category != null)
            {
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t=>_unitOfWork.SaveAsync());
                return new SuccessResult($"{category.Name} adlı kategori veritabanından silindi");
            }
            return new ErrorResult($"{id} idli kategori bulunamadı.");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var result = BusinessRules.Run(await _categoryBusinessRules.CheckIfCategoryIdExist(categoryUpdateDto.Id));
            if(result != null)
            {
                return result;
            }
            var category = _mapper.Map<Category>(categoryUpdateDto);
            category.ModifiedByName = modifiedByName;
           
           await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
           return new SuccessResult($"{categoryUpdateDto.Name} adlı kategory güncellendi...");
            
           

        }
    }
}
