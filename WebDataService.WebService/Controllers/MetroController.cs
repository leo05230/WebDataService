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
	public class MetroController : ControllerBase
	{
		private readonly ILogger<MetroController> _logger;
		private readonly IMetroService _IMetroService;
		private readonly IDTF _IDTF;
		public MetroController
		(
			ILogger<MetroController> logger,
			IDTF IDTF,
			IMetroService IMetroService
		)
		{
			this._logger = logger;
			this._IDTF = IDTF;
			this._IMetroService = IMetroService;
		}
		// GET: /Metro
		[HttpGet]
		public async Task<string> Get()
		{
			var Result = await this._IMetroService.Save(DateTime.Now);
			return JsonConvert.SerializeObject(Result);
		}

		// GET: /Metro/2020-12-02
		[HttpGet("{id}", Name = "MetroGet")]
		public async Task<string> Get(DateTime id)
		{
			var Result = await this._IMetroService.Save(id);
			return JsonConvert.SerializeObject(Result);
		}

		// POST: api/Metro
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT: api/Metro/5
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
