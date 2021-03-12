using Advance.API.DTOs;
using Advance.Aplication.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Advance.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallerController : ControllerBase
    {
        
        private readonly IHttpRequest _httpRequest;
        public CallerController(IHttpRequest httpRequest)
        {

            _httpRequest = httpRequest;
        }
        [HttpGet]
        public async Task<string> GetForcast()
        {
            return await _httpRequest.Get($"http://localhost:5100/Forecast");
        }
        [HttpGet("{id}")]
        public async Task<string> GetTempreture(int id)
        {
            return await _httpRequest.Get($"http://localhost:5100/Forecast/{id}");
            
        }
        [HttpPost]
        public async Task<string> Post(ForecastInsertDTO dto)
        {
            return await _httpRequest.Post(dto,$"http://localhost:5100/Forecast/");
        }
    }
}
