using BlogProgramming.Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgramming.Entities.Concretes;

namespace BlogProgramming.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
    }
}
