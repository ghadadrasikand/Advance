using Advance._3party.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advance._3party.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpPost]
        public async Task<string> Post(WeatherInsertDTO dto)
        {
            await Task.CompletedTask;
            return $"The tempreture Saved";
        }
    }
}
