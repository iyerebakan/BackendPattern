using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result
{
    public class ErrorReponse<T> : DataResponse<T>
    {
        public ErrorReponse(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
