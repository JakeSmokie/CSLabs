// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: maths.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using grpc = global::Grpc.Core;

namespace Labs
{
    public static partial class MathsProccessor
  {
        private static readonly string __ServiceName = "labs.MathsProccessor";
        private static readonly grpc::Marshaller<global::Labs.Arguments> __Marshaller_Arguments = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Labs.Arguments.Parser.ParseFrom);
        private static readonly grpc::Marshaller<global::Labs.Result> __Marshaller_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Labs.Result.Parser.ParseFrom);
        private static readonly grpc::Method<global::Labs.Arguments, global::Labs.Result> __Method_Set = new grpc::Method<global::Labs.Arguments, global::Labs.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Set",
        __Marshaller_Arguments,
        __Marshaller_Result);
        private static readonly grpc::Method<global::Labs.Arguments, global::Labs.Result> __Method_Jmp = new grpc::Method<global::Labs.Arguments, global::Labs.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Jmp",
        __Marshaller_Arguments,
        __Marshaller_Result);
        private static readonly grpc::Method<global::Labs.Arguments, global::Labs.Result> __Method_Add = new grpc::Method<global::Labs.Arguments, global::Labs.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_Arguments,
        __Marshaller_Result);
        private static readonly grpc::Method<global::Labs.Arguments, global::Labs.Result> __Method_Sub = new grpc::Method<global::Labs.Arguments, global::Labs.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Sub",
        __Marshaller_Arguments,
        __Marshaller_Result);
        private static readonly grpc::Method<global::Labs.Arguments, global::Labs.Result> __Method_Mul = new grpc::Method<global::Labs.Arguments, global::Labs.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Mul",
        __Marshaller_Arguments,
        __Marshaller_Result);
        private static readonly grpc::Method<global::Labs.Arguments, global::Labs.Result> __Method_Div = new grpc::Method<global::Labs.Arguments, global::Labs.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Div",
        __Marshaller_Arguments,
        __Marshaller_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Labs.MathsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MathsProccessor</summary>
    public abstract partial class MathsProccessorBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Labs.Result> Set(global::Labs.Arguments request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Labs.Result> Jump(global::Labs.Arguments request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Labs.Result> Add(global::Labs.Arguments request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Labs.Result> Sub(global::Labs.Arguments request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Labs.Result> Mul(global::Labs.Arguments request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Labs.Result> Div(global::Labs.Arguments request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MathsProccessor</summary>
    public partial class MathsProccessorClient : grpc::ClientBase<MathsProccessorClient>
    {
      /// <summary>Creates a new client for MathsProccessor</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MathsProccessorClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MathsProccessor that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MathsProccessorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MathsProccessorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MathsProccessorClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Labs.Result Set(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Set(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Labs.Result Set(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Set, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> SetAsync(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> SetAsync(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Set, null, options, request);
      }
      public virtual global::Labs.Result Jmp(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Jmp(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Labs.Result Jmp(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Jmp, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> JmpAsync(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return JmpAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> JmpAsync(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Jmp, null, options, request);
      }
      public virtual global::Labs.Result Add(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Add(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Labs.Result Add(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Add, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> AddAsync(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> AddAsync(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Add, null, options, request);
      }
      public virtual global::Labs.Result Sub(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Sub(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Labs.Result Sub(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Sub, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> SubAsync(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SubAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> SubAsync(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Sub, null, options, request);
      }
      public virtual global::Labs.Result Mul(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Mul(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Labs.Result Mul(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Mul, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> MulAsync(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return MulAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> MulAsync(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Mul, null, options, request);
      }
      public virtual global::Labs.Result Div(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Div(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Labs.Result Div(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Div, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> DivAsync(global::Labs.Arguments request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DivAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Labs.Result> DivAsync(global::Labs.Arguments request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Div, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MathsProccessorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MathsProccessorClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MathsProccessorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Set, serviceImpl.Set)
          .AddMethod(__Method_Jmp, serviceImpl.Jump)
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Sub, serviceImpl.Sub)
          .AddMethod(__Method_Mul, serviceImpl.Mul)
          .AddMethod(__Method_Div, serviceImpl.Div).Build();
    }

  }
}
#endregion
