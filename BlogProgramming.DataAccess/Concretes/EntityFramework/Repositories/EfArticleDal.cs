using BlogProgramming.Core.DataAccess.Concretes.EntityFramework;
using BlogProgramming.DataAccess.Abstract;
using BlogProgramming.DataAccess.Concretes.EntityFramework.Contexts;
using BlogProgramming.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Concretes.EntityFramework.Repositories
{
    public class EfArticleDal : EfEntityRepositoryBase<Article, BlogProgrammingContext>, IArticleDal
    {
    }
}
