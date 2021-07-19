using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services.IServices
{
    public interface IBaseService: IDisposable
    {
        ResponseDTO responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
