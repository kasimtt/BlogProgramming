using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Core.Utilities.Result.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) // işlemin doğruluğunu burada işliyoruz
        {
        }

        public SuccessResult() : base(true) //mesaj istenmediği durumunda kullanılır
        {

        }
    }
}
