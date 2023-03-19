using BlogProgramming.Core.Entities.Abstract;
using BlogProgramming.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Entities.Dtos.Articles
{
    public class ArticleListDto : DtoGetBase
    {
        public IList<Article> Articles { get; set; }
    }
}
