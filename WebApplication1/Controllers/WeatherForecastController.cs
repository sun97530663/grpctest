using greeter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;


        greetagvschdule.greetagvschduleClient _grpcclient;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, greetagvschdule.greetagvschduleClient grpcclient)
        {
            _logger = logger;
            _grpcclient = grpcclient;
    }
        [Route("/Agv_Manage/[controller]/[action]")]
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();

            for (int i = 0; i < 10; i++)
            {
                stopwatch.Restart(); //  开始监视代码运行时间
                Google.Protobuf.WellKnownTypes.Empty GrpcEmptyRequest = new Google.Protobuf.WellKnownTypes.Empty();
                var rep = _grpcclient.GetCurrentProjectName(GrpcEmptyRequest);
                stopwatch.Stop(); //  停止监视
                double seconds = stopwatch.Elapsed.TotalSeconds;  //  总秒数
                Console.WriteLine("依赖注入方式执行时间:" + seconds+ "（S）");
                Console.WriteLine("say hi" + rep.Message);
            }

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
