﻿using BlogProgramming.Core.DataAccess.Abstract;
using BlogProgramming.Core.DataAccess.Concretes.EntityFramework;
using BlogProgramming.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}