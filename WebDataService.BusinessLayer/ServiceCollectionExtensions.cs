using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebDataService.BusinessLayer.Service;
using WebDataService.DataLayer.Managers.API;
using WebDataService.DataLayer.Repositorys;
using WebDataService.DataLayer.Repositorys.DataSet;
using WebDataService.DataLayer.UnitOfWork;
using WebDataService.Domain.Entities;
using WebDataService.Domain.Interfaces;
using WebDataService.Domain.Interfaces.API;
using WebDataService.Domain.Interfaces.Common;
using WebDataService.Domain.Interfaces.DataSet;
using WebDataService.Domain.Interfaces.Service;
using WebDataService.Shared.Common;

namespace WebDataService.BusinessLayer
{
    //https://dotblogs.com.tw/shadow/2019/01/16/105615
    //https://blog.johnwu.cc/article/ironman-day04-asp-net-core-dependency-injection.html
    //https://stackoverflow.com/questions/54671253/registering-iunitofwork-as-service-in-net-core
    //https://blog.darkthread.net/blog/aspnet-core-di-notes/
    //Singleton 物件實例 一但實例化，就會一直存在於 DI 容器中。不管 Requset 多少次，都會是同一個。
    //Scoped 物件實例 每次 Request 就會產生新的實例在 DI 容器中，讓同 Request 週期的使用方，拿到同一個實例。在同一個 Requset 中，不論是在哪邊被注入，都是同樣的實例。
    //Transient 物件實例 只要跟 DI 容器請求這個類型，就會取得新的實例。每次注入都是不一樣的實例。
    //兩個介面共用一個 Instance
    //var dataService = new DataService();
    //services.AddSingleton<IDataService>(dataService);
    //services.AddSingleton<ISomeInterface>(dataService);
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region DI Repository
            services.AddScoped<DbContext, DataSetContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IResult, Result>();

            services.AddScoped<ICodeAreaRepository, CodeAreaRepository>();
            services.AddScoped<ICodeLocationRepository, CodeLocationRepository>();
            services.AddScoped<ICodeLocationRepository, CodeLocationRepository>();
            services.AddScoped<IWeatherMainRepository, WeatherMainRepository>();
            services.AddScoped<IWeatherDetailRepository, WeatherDetailRepository>();
            services.AddScoped<IMetroFlowNumberRepository, MetroFlowNumberRepository>();
            #endregion

            #region Service
            services.AddScoped<IWeatherDataService, WeatherDataService>();
            services.AddScoped<IMetroService, MetroService>();
            #endregion

            #region DI Function
            services.AddScoped<IDTF, DTF>();
            services.AddScoped<IApiManagers, ApiManagers>();
            #endregion
            return services;
        }
    }
}
