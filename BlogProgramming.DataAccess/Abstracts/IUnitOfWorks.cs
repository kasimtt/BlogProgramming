using BlogProgramming.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Abstracts
{
    public interface IUnitOfWork  : IAsyncDisposable
    {
        IArticleDal Articles { get; }
        ICategoryDal Categories { get; }
        ICommentDal Comments { get; }
        IRoleDal Roles { get; }
        IUserDal User { get; }
        Task<int> SaveAsync();


    }
}
