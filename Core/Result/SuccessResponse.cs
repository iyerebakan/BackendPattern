using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result
{
    public class SuccessResponse<T> : DataResponse<T>
    {
        public SuccessResponse(T data)
        {
            Success = true;
            Data = data;
        }
    }
}
