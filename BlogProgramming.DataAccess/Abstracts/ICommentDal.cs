using BlogProgramming.Core.DataAccess.Abstract;
using BlogProgramming.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Abstract
{
    public interface ICommentDal:IEntityRepository<Comment>
    {

    }
}
