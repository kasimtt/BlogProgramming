using BlogProgramming.Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Core.Utilities.Business
{
    
        public static class BusinessRules
        {
            public static IResult Run(params IResult[] logics)
            {
                foreach (var logic in logics)
                {
                    if (!logic.Success)
                    {
                        return logic;
                    }
                }
                return null;
            }
        }
  
    
}
