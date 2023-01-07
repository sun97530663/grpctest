using greeter;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;


namespace ConsoleAppTestGrpc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Hello, World!");

            IServiceCollection services = new ServiceCollection();
            services.AddTransient<GrpcRequestTest>();

            #region gRPC Client注册
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            services.AddGrpcClient<greetagvschdule.greetagvschduleClient>(options =>
            {
                options.Address = new Uri("http://localhost:5006");
            }).ConfigureChannel(grpcOptions =>
            {
                //可以完成各种配置，比如token
            });
            #endregion

            //构建容器
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            //解析grpc请求测试
            var grpcRequestTest = serviceProvider.GetService<GrpcRequestTest>();

    

            grpcRequestTest.send();

            try
            {
                Channel channel = new Channel("127.0.0.1:5006", ChannelCredentials.Insecure);
                var clientpart = new greetagvschdule.greetagvschduleClient(channel);

                System.Diagnostics.Stopwatch stopwatch = new Stopwatch();

                for (int i = 0; i < 10; i++)
                {
                    stopwatch.Restart(); //  开始监视代码运行时间
                    Google.Protobuf.WellKnownTypes.Empty GrpcEmptyRequest = new Google.Protobuf.WellKnownTypes.Empty();
                    var rep = clientpart.GetCurrentProjectName(GrpcEmptyRequest);
                    Console.WriteLine("say hi" + rep.Message);
                    stopwatch.Stop(); //  停止监视
                    double seconds = stopwatch.Elapsed.TotalSeconds;  //  总秒数
                    Console.WriteLine("New方式执行时间（S）：" + seconds);
                    Console.WriteLine("say hi" + rep.Message);
                }

              
            }
            catch (RpcException e)
            {
                if (e.StatusCode.Equals("DeadlineExceeded"))
                {

                }
                Console.WriteLine(e.ToString());
            }

        }
    }
}
