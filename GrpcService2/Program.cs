using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService2
{
    public class Program
    {
        public static int _port1 = 5005;
        public static int _port2 = 5006;

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // Additional configuration is required to successfully run gRPC on macOS.
        // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();


                    webBuilder.UseUrls().UseKestrel((host, options) =>
                    {

                        //swagger文档接口
                        options.ListenAnyIP(_port1, o => o.Protocols = HttpProtocols.Http1);
                        //设置gRPC监听端口，也可以不设置,使用默认配置端口
                        options.ListenAnyIP(_port2, o => o.Protocols = HttpProtocols.Http2);
                  

                    });
                });
    }
}
