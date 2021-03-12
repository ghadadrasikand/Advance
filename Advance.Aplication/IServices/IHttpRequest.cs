using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advance.Aplication.IServices
{
    public interface IHttpRequest
    {
        Task<string> Get(string url);
        Task<string> Post<T>(T model,string url)where T:class;
        
    }
}
