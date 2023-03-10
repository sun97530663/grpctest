// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greetsysagv.proto
// </auto-generated>
// Original file comments:
// agv调度上位侧对主服务和其他服务的接口文件()
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Sysagv {
  public static partial class GreeterSysAgv
  {
    static readonly string __ServiceName = "sysagv.GreeterSysAgv";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.MoveParam> __Marshaller_sysagv_MoveParam = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.MoveParam.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.MoveStatus> __Marshaller_sysagv_MoveStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.MoveStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.SlamParam> __Marshaller_sysagv_SlamParam = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.SlamParam.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.SlamInfo> __Marshaller_sysagv_SlamInfo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.SlamInfo.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.TaskInfo> __Marshaller_sysagv_TaskInfo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.TaskInfo.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.TaskStatus> __Marshaller_sysagv_TaskStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.TaskStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.DispatchStatus> __Marshaller_sysagv_DispatchStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.DispatchStatus.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Sysagv.AgvStatus> __Marshaller_sysagv_AgvStatus = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Sysagv.AgvStatus.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Sysagv.MoveParam, global::Sysagv.MoveStatus> __Method_MovePointToPoint = new grpc::Method<global::Sysagv.MoveParam, global::Sysagv.MoveStatus>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MovePointToPoint",
        __Marshaller_sysagv_MoveParam,
        __Marshaller_sysagv_MoveStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Sysagv.SlamParam, global::Sysagv.SlamInfo> __Method_GetSlamMap = new grpc::Method<global::Sysagv.SlamParam, global::Sysagv.SlamInfo>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetSlamMap",
        __Marshaller_sysagv_SlamParam,
        __Marshaller_sysagv_SlamInfo);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Sysagv.TaskInfo, global::Sysagv.TaskStatus> __Method_SendTask = new grpc::Method<global::Sysagv.TaskInfo, global::Sysagv.TaskStatus>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "SendTask",
        __Marshaller_sysagv_TaskInfo,
        __Marshaller_sysagv_TaskStatus);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Sysagv.DispatchStatus, global::Sysagv.AgvStatus> __Method_ChangeStatus = new grpc::Method<global::Sysagv.DispatchStatus, global::Sysagv.AgvStatus>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ChangeStatus",
        __Marshaller_sysagv_DispatchStatus,
        __Marshaller_sysagv_AgvStatus);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sysagv.GreetsysagvReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GreeterSysAgv</summary>
    [grpc::BindServiceMethod(typeof(GreeterSysAgv), "BindService")]
    public abstract partial class GreeterSysAgvBase
    {
      /// <summary>
      ///※注意：发送和返回只能有一个参数
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Sysagv.MoveStatus> MovePointToPoint(global::Sysagv.MoveParam request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetSlamMap(global::Sysagv.SlamParam request, grpc::IServerStreamWriter<global::Sysagv.SlamInfo> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Sysagv.TaskStatus> SendTask(grpc::IAsyncStreamReader<global::Sysagv.TaskInfo> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ChangeStatus(grpc::IAsyncStreamReader<global::Sysagv.DispatchStatus> requestStream, grpc::IServerStreamWriter<global::Sysagv.AgvStatus> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GreeterSysAgv</summary>
    public partial class GreeterSysAgvClient : grpc::ClientBase<GreeterSysAgvClient>
    {
      /// <summary>Creates a new client for GreeterSysAgv</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GreeterSysAgvClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GreeterSysAgv that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public GreeterSysAgvClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GreeterSysAgvClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected GreeterSysAgvClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///※注意：发送和返回只能有一个参数
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Sysagv.MoveStatus MovePointToPoint(global::Sysagv.MoveParam request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MovePointToPoint(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///※注意：发送和返回只能有一个参数
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Sysagv.MoveStatus MovePointToPoint(global::Sysagv.MoveParam request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MovePointToPoint, null, options, request);
      }
      /// <summary>
      ///※注意：发送和返回只能有一个参数
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Sysagv.MoveStatus> MovePointToPointAsync(global::Sysagv.MoveParam request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MovePointToPointAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///※注意：发送和返回只能有一个参数
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Sysagv.MoveStatus> MovePointToPointAsync(global::Sysagv.MoveParam request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MovePointToPoint, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Sysagv.SlamInfo> GetSlamMap(global::Sysagv.SlamParam request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSlamMap(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Sysagv.SlamInfo> GetSlamMap(global::Sysagv.SlamParam request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetSlamMap, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Sysagv.TaskInfo, global::Sysagv.TaskStatus> SendTask(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendTask(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Sysagv.TaskInfo, global::Sysagv.TaskStatus> SendTask(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_SendTask, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Sysagv.DispatchStatus, global::Sysagv.AgvStatus> ChangeStatus(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ChangeStatus(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Sysagv.DispatchStatus, global::Sysagv.AgvStatus> ChangeStatus(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ChangeStatus, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override GreeterSysAgvClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterSysAgvClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GreeterSysAgvBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MovePointToPoint, serviceImpl.MovePointToPoint)
          .AddMethod(__Method_GetSlamMap, serviceImpl.GetSlamMap)
          .AddMethod(__Method_SendTask, serviceImpl.SendTask)
          .AddMethod(__Method_ChangeStatus, serviceImpl.ChangeStatus).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterSysAgvBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MovePointToPoint, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Sysagv.MoveParam, global::Sysagv.MoveStatus>(serviceImpl.MovePointToPoint));
      serviceBinder.AddMethod(__Method_GetSlamMap, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Sysagv.SlamParam, global::Sysagv.SlamInfo>(serviceImpl.GetSlamMap));
      serviceBinder.AddMethod(__Method_SendTask, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Sysagv.TaskInfo, global::Sysagv.TaskStatus>(serviceImpl.SendTask));
      serviceBinder.AddMethod(__Method_ChangeStatus, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Sysagv.DispatchStatus, global::Sysagv.AgvStatus>(serviceImpl.ChangeStatus));
    }

  }
}
#endregion
