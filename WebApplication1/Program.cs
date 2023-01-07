using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Program
    {
        public static int _port1 = 5001;
        public static int _port2 = 5002;
        private static NLog.Logger nlogger = LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            //nlogger.Trace("²âÊÔtest");
            //nlogger.Debug("²âÊÔtest");
            //nlogger.Info("²âÊÔtest");
            //nlogger.Warn("²âÊÔtest");
            //nlogger.Error("²âÊÔtest");
            //nlogger.Fatal("²âÊÔtest");
         
            CreateHostBuilder(args).Build().Run();
      
        }
       
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.ConfigureLogging(logging =>
                    //{
                    //    logging.ClearProviders();
                    //    logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
                    //});
                    webBuilder.UseNLog();
                    webBuilder.UseUrls().UseKestrel((host, options) =>
                    {
                        //ÉèÖÃgRPC¼àÌý¶Ë¿Ú£¬Ò²¿ÉÒÔ²»ÉèÖÃ,Ê¹ÓÃÄ¬ÈÏÅäÖÃ¶Ë¿Ú
                        options.ListenAnyIP(_port1, o => o.Protocols = HttpProtocols.Http1);
                        options.ListenAnyIP(_port2, o => o.Protocols = HttpProtocols.Http2);
                  
                    });
                });
    }
}
