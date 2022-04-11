using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultOjb)
        {
            IsSuccessed = true;
            ResultObj = resultOjb;
        }

        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}
