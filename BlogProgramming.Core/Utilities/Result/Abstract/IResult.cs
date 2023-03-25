using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Core.Utilities.Result.Abstract
{
    public interface IResult
    {
        //mesaj ve durumu dönmesini istiyoruz
        bool Success { get; }
        string Message { get; }
    }
}
