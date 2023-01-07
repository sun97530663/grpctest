


using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using greeter;

namespace GrpcService2
{
    /// <summary>
    /// ����������(ʹ�õ���ģʽ)
    /// </summary>
    public class MainService : greetagvschdule.greetagvschduleBase
    {
        private static object _lock = new();

        private readonly ILogger<MainService> _logger;
    
        //public static List<AgvClientInfoDto> AgvList = new();
        public MainService(ILogger<MainService> logger)
        {
            _logger = logger;
        }


        public override Task<greeter.HelloReply> StopRunningProject(Empty request, ServerCallContext context)
        {
           
            var data = new greeter.HelloReply
            {
                Message = "�����ɹ�"
            };

            return Task.FromResult(data);
        }
        /// <summary>
        /// ��ȡ��ǰ����
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<greeter.HelloReply> GetCurrentProjectName(Empty request, ServerCallContext context)
        {
          
            string mapName = "";
            try
            {
                mapName = "123";
            }
            catch { }
            var data = new greeter.HelloReply
            {
                Message = mapName
            };
            return Task.FromResult(data);
        }

        

    }
}
