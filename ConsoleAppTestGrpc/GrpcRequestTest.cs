using greeter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestGrpc
{
    /// <summary>
    /// gRPC请求测试
    /// </summary>
    public class GrpcRequestTest
    {
        private greetagvschdule.greetagvschduleClient _orderClient;
        public GrpcRequestTest(greetagvschdule.greetagvschduleClient orderClient)
        {
            _orderClient = orderClient;
        }
        public void send()
        {

            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();


            for (int i = 0; i < 10; i++)
            {
                stopwatch.Restart(); //  开始监视代码运行时间
                Google.Protobuf.WellKnownTypes.Empty GrpcEmptyRequest = new Google.Protobuf.WellKnownTypes.Empty();
                var rep = _orderClient.GetCurrentProjectName(GrpcEmptyRequest);
                stopwatch.Stop(); //  停止监视
                double seconds = stopwatch.Elapsed.TotalSeconds;  //  总秒数
                Console.WriteLine("依赖注入方式执行时间（S）：" + seconds);
                Console.WriteLine("say hi" + rep.Message);
            }



          
           
         
           // Console.ReadKey();
        }
    }
}
