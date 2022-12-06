using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Successful { get; set; }
        public string Error { get; set; }

        public static ServiceResponse<T> Success(T Value) => new ServiceResponse<T> { Successful = true, Data = Value };
        public static ServiceResponse<T> Failure(string error) => new ServiceResponse<T> { Successful = false, Error = error };
    }
}
