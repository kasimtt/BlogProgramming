using BlogProgramming.Business.Abstract;
using BlogProgramming.Core.Utilities.Results.Abstract;
using BlogProgramming.Core.Utilities.Results.ComplexType;
using BlogProgramming.Core.Utilities.Results.Concrete;
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
        public CategoryManager(IUnitOfWork unitOfWork ) { 
        
          _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            await _unitOfWork.Categories.AddAsync(new Category
            {
                Name = categoryAddDto.Name,
                Description = categoryAddDto.Description,
                Note = categoryAddDto.Note,
                IsActive = categoryAddDto.IsActive,
                CreateDate = DateTime.Now,
                CreatedByName = createdByName,
                IsDeleted = false,
                ModifiedByName = createdByName,
                ModifiedDate = DateTime.Now,


            }).ContinueWith(t => _unitOfWork.SaveAsync());
            
            return new Result(ResultStatus.Success,$"{categoryAddDto.Name} adlı kategory eklendi...");
        }

        public async Task<IResult> Delete(int id, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c=>c.Id == id);
            if(category != null)
            {
                category.IsDeleted = true;
                category.ModifiedDate = DateTime.Now;
                category.ModifiedByName = modifiedByName;
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{category.Name} adli kategori başarıyla silinmiştir ");
            }
            return new Result(ResultStatus.Error, $"{id} idli bir kategori bulanamadı");
            
        }

        public async Task<IDataResult<Category>> Get(int id)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == id, c => c.Articles);
            if(category!=null)
            {
                return new DataResult<Category>(ResultStatus.Success, category);
            }
            return  new DataResult<Category>(ResultStatus.Error, "Kategori bulunamadı");
        }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
           var categories = await _unitOfWork.Categories.GetAllAsync(null,c=>c.Articles);
           if(categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
           return new DataResult<IList<Category>>(ResultStatus.Error,"kategoriler bulunamadı");
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDelete(int id)
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c=>!c.IsDeleted,c=>c.Articles);
            if(categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "kategoriler bulunamadı");
        }

        public async Task<IResult> HardDelete(int id)
        {
           var category = await _unitOfWork.Categories.GetAsync(c=>c.Id == id);
            if(category != null)
            {
                await _unitOfWork.Categories.DeleteAsync(category).ContinueWith(t=>_unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success,$"{category.Name} adlı kategori veritabanından silindi");
            }
            return new Result(ResultStatus.Success, $"{id} idli kategori bulunamadı.");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c=>c.Id == categoryUpdateDto.Id);
            if(category != null)
            {
                category.Name = categoryUpdateDto.Name;
                category.Description = categoryUpdateDto.Description;
                category.Note = categoryUpdateDto.Note;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = categoryUpdateDto.IsDeleted;
                category.ModifiedByName = modifiedByName;
                category.ModifiedDate = DateTime.Now;
                
                await _unitOfWork.Categories.UpdateAsync(category).ContinueWith(t => _unitOfWork.SaveAsync());

                return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı kategory güncellendi...");
            }
            return new Result(ResultStatus.Error, $"{categoryUpdateDto.Name} adlı kategory bulunamadı");

        }
    }
}
