// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Students.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPC_Server {
  public static partial class Students
  {
    static readonly string __ServiceName = "Students";

    static readonly grpc::Marshaller<global::gRPC_Server.StudentsLookupModel> __Marshaller_StudentsLookupModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Server.StudentsLookupModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Server.StudentsModel> __Marshaller_StudentsModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Server.StudentsModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Server.StudentLookup> __Marshaller_StudentLookup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Server.StudentLookup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPC_Server.Result> __Marshaller_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPC_Server.Result.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPC_Server.StudentsLookupModel, global::gRPC_Server.StudentsModel> __Method_GetStudentsInfo = new grpc::Method<global::gRPC_Server.StudentsLookupModel, global::gRPC_Server.StudentsModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudentsInfo",
        __Marshaller_StudentsLookupModel,
        __Marshaller_StudentsModel);

    static readonly grpc::Method<global::gRPC_Server.StudentLookup, global::gRPC_Server.StudentsModel> __Method_GetAllStudentsInfo = new grpc::Method<global::gRPC_Server.StudentLookup, global::gRPC_Server.StudentsModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllStudentsInfo",
        __Marshaller_StudentLookup,
        __Marshaller_StudentsModel);

    static readonly grpc::Method<global::gRPC_Server.StudentsLookupModel, global::gRPC_Server.StudentsModel> __Method_DeleteAStudent = new grpc::Method<global::gRPC_Server.StudentsLookupModel, global::gRPC_Server.StudentsModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "DeleteAStudent",
        __Marshaller_StudentsLookupModel,
        __Marshaller_StudentsModel);

    static readonly grpc::Method<global::gRPC_Server.StudentsModel, global::gRPC_Server.Result> __Method_AddStudent = new grpc::Method<global::gRPC_Server.StudentsModel, global::gRPC_Server.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddStudent",
        __Marshaller_StudentsModel,
        __Marshaller_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPC_Server.StudentsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Students</summary>
    [grpc::BindServiceMethod(typeof(Students), "BindService")]
    public abstract partial class StudentsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::gRPC_Server.StudentsModel> GetStudentsInfo(global::gRPC_Server.StudentsLookupModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllStudentsInfo(global::gRPC_Server.StudentLookup request, grpc::IServerStreamWriter<global::gRPC_Server.StudentsModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task DeleteAStudent(global::gRPC_Server.StudentsLookupModel request, grpc::IServerStreamWriter<global::gRPC_Server.StudentsModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPC_Server.Result> AddStudent(global::gRPC_Server.StudentsModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Students</summary>
    public partial class StudentsClient : grpc::ClientBase<StudentsClient>
    {
      /// <summary>Creates a new client for Students</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StudentsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Students that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StudentsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StudentsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StudentsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::gRPC_Server.StudentsModel GetStudentsInfo(global::gRPC_Server.StudentsLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentsInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::gRPC_Server.StudentsModel GetStudentsInfo(global::gRPC_Server.StudentsLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStudentsInfo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.StudentsModel> GetStudentsInfoAsync(global::gRPC_Server.StudentsLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStudentsInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.StudentsModel> GetStudentsInfoAsync(global::gRPC_Server.StudentsLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStudentsInfo, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::gRPC_Server.StudentsModel> GetAllStudentsInfo(global::gRPC_Server.StudentLookup request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllStudentsInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::gRPC_Server.StudentsModel> GetAllStudentsInfo(global::gRPC_Server.StudentLookup request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllStudentsInfo, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::gRPC_Server.StudentsModel> DeleteAStudent(global::gRPC_Server.StudentsLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAStudent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::gRPC_Server.StudentsModel> DeleteAStudent(global::gRPC_Server.StudentsLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_DeleteAStudent, null, options, request);
      }
      public virtual global::gRPC_Server.Result AddStudent(global::gRPC_Server.StudentsModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddStudent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::gRPC_Server.Result AddStudent(global::gRPC_Server.StudentsModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddStudent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Result> AddStudentAsync(global::gRPC_Server.StudentsModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddStudentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::gRPC_Server.Result> AddStudentAsync(global::gRPC_Server.StudentsModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddStudent, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StudentsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StudentsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StudentsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStudentsInfo, serviceImpl.GetStudentsInfo)
          .AddMethod(__Method_GetAllStudentsInfo, serviceImpl.GetAllStudentsInfo)
          .AddMethod(__Method_DeleteAStudent, serviceImpl.DeleteAStudent)
          .AddMethod(__Method_AddStudent, serviceImpl.AddStudent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StudentsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStudentsInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Server.StudentsLookupModel, global::gRPC_Server.StudentsModel>(serviceImpl.GetStudentsInfo));
      serviceBinder.AddMethod(__Method_GetAllStudentsInfo, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::gRPC_Server.StudentLookup, global::gRPC_Server.StudentsModel>(serviceImpl.GetAllStudentsInfo));
      serviceBinder.AddMethod(__Method_DeleteAStudent, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::gRPC_Server.StudentsLookupModel, global::gRPC_Server.StudentsModel>(serviceImpl.DeleteAStudent));
      serviceBinder.AddMethod(__Method_AddStudent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPC_Server.StudentsModel, global::gRPC_Server.Result>(serviceImpl.AddStudent));
    }

  }
}
#endregion