using BlogProgramming.DataAccess.Abstract;
using BlogProgramming.DataAccess.Abstracts;
using BlogProgramming.DataAccess.Concretes.EntityFramework.Contexts;
using BlogProgramming.DataAccess.Concretes.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogProgrammingContext _context;

        public UnitOfWork(BlogProgrammingContext context)
        {
            _context = context;
        }

        private EfArticleDal articleDal;
        private EfCategoryDal categoryDal;    // şimdilik böyle yapıldı ama fluent IoC ile buralar refactor edilecek.
        private EfCommentDal commentDal;
        private EfRoleDal roleDal;
        private EfUserDal userDal;

        


        public IArticleDal Articles => articleDal ?? new EfArticleDal();

        public ICategoryDal Categories =>categoryDal ?? new EfCategoryDal();

        public ICommentDal Comments => commentDal ?? new EfCommentDal();

        public IRoleDal Roles => roleDal ?? new EfRoleDal();

        public IUserDal User => userDal ?? new EfUserDal();


        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
             await _context.DisposeAsync(); 
        }
    }
}
