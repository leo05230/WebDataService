using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebDataService.Domain.Interfaces.Common;
using WebDataService.Domain.Interfaces.Service;

namespace WebDataService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherDataService _IWeatherDataService;
        private readonly IDTF _IDTF;
        public WeatherController
        (
            ILogger<WeatherController> logger,
            IDTF IDTF,
            IWeatherDataService IWeatherDataService
        )
        {
            this._logger = logger;
            this._IDTF = IDTF;
            this._IWeatherDataService = IWeatherDataService;
        }
        // GET: /Weather
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var Result = await this._IWeatherDataService.Save("");
            return new string[] { "Value1","Value2"};
        }

        // GET: /Weather/F-D0047-061
        [HttpGet("{id}", Name = "WeatherGet")]
        public async Task<string> Get(string id)
        {
            var Result = await this._IWeatherDataService.Save(id);
            return JsonConvert.SerializeObject(Result);
        }

        // POST: api/Weather
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Weather/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
