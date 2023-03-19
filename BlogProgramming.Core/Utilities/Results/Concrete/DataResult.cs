using BlogProgramming.Core.Utilities.Results.Abstract;
using BlogProgramming.Core.Utilities.Results.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgramming.Core.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }

        public DataResult(ResultStatus resultStatus,string message) 
        { 
           ResultStatus = resultStatus;
            Message = message;
        }
        public DataResult(ResultStatus resultStatus, T data) 
        { 
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data, Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
            Exception = exception;
        }





     
    }
}
