using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebDataService.BusinessLayer;
using WebDataService.BusinessLayer.ConnectionStringProvider;
using WebDataService.Domain.Entities;
using WebDataService.Domain.Interfaces.ConnectionStringProvider;

namespace WebDataService
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			#region 加入使用 Cookie 認證需要的宣告
			services.Configure<CookiePolicyOptions>(options =>
			{
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
			});
			services.AddAuthentication(
				CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie();
			#endregion

			#region 加入會用到的服務宣告
			services.AddHttpContextAccessor();
			services.AddScoped<HttpContextAccessor>();
			services.AddHttpClient();
			services.AddScoped<HttpClient>();
			#endregion

			#region DI ConnectionString
			string ConnectionString = this.Configuration.GetValue<string>("ConnectionString");
			services.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>(_ => new ConnectionStringProvider(ConnectionString));
			services.AddDbContext<DataSetContext>(options => options.UseSqlServer(ConnectionString));
			#endregion

			#region DI 注入Service
			services.AddCustomServices(Configuration);
			#endregion

			#region 序列化問題
			//回傳的json開頭第一個字保持原大小寫
			services.AddMvc().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
			#endregion
			services.AddControllers();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
