/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace com.coveo.blitz.thrift
{
  public partial class AwesomeService {
    public interface Iface {
      /// <summary>
      /// Gets data from your service. The type and format of the requests are defined in the documentation.
      /// 
      /// </summary>
      /// <param name="request"></param>
      Response getData(Request request);
      #if SILVERLIGHT
      IAsyncResult Begin_getData(AsyncCallback callback, object state, Request request);
      Response End_getData(IAsyncResult asyncResult);
      #endif
      void reset();
      #if SILVERLIGHT
      IAsyncResult Begin_reset(AsyncCallback callback, object state);
      void End_reset(IAsyncResult asyncResult);
      #endif
      bool ping();
      #if SILVERLIGHT
      IAsyncResult Begin_ping(AsyncCallback callback, object state);
      bool End_ping(IAsyncResult asyncResult);
      #endif
      void handleMapReduceResult(string name, byte[] data);
      #if SILVERLIGHT
      IAsyncResult Begin_handleMapReduceResult(AsyncCallback callback, object state, string name, byte[] data);
      void End_handleMapReduceResult(IAsyncResult asyncResult);
      #endif
    }

    public class Client : IDisposable, Iface {
      public Client(TProtocol prot) : this(prot, prot)
      {
      }

      public Client(TProtocol iprot, TProtocol oprot)
      {
        iprot_ = iprot;
        oprot_ = oprot;
      }

      protected TProtocol iprot_;
      protected TProtocol oprot_;
      protected int seqid_;

      public TProtocol InputProtocol
      {
        get { return iprot_; }
      }
      public TProtocol OutputProtocol
      {
        get { return oprot_; }
      }


      #region " IDisposable Support "
      private bool _IsDisposed;

      // IDisposable
      public void Dispose()
      {
        Dispose(true);
      }
      

      protected virtual void Dispose(bool disposing)
      {
        if (!_IsDisposed)
        {
          if (disposing)
          {
            if (iprot_ != null)
            {
              ((IDisposable)iprot_).Dispose();
            }
            if (oprot_ != null)
            {
              ((IDisposable)oprot_).Dispose();
            }
          }
        }
        _IsDisposed = true;
      }
      #endregion


      
      #if SILVERLIGHT
      public IAsyncResult Begin_getData(AsyncCallback callback, object state, Request request)
      {
        return send_getData(callback, state, request);
      }

      public Response End_getData(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_getData();
      }

      #endif

      /// <summary>
      /// Gets data from your service. The type and format of the requests are defined in the documentation.
      /// 
      /// </summary>
      /// <param name="request"></param>
      public Response getData(Request request)
      {
        #if !SILVERLIGHT
        send_getData(request);
        return recv_getData();

        #else
        var asyncResult = Begin_getData(null, null, request);
        return End_getData(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_getData(AsyncCallback callback, object state, Request request)
      #else
      public void send_getData(Request request)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("getData", TMessageType.Call, seqid_));
        getData_args args = new getData_args();
        args.Request = request;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public Response recv_getData()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        getData_result result = new getData_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "getData failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_reset(AsyncCallback callback, object state)
      {
        return send_reset(callback, state);
      }

      public void End_reset(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        recv_reset();
      }

      #endif

      public void reset()
      {
        #if !SILVERLIGHT
        send_reset();
        recv_reset();

        #else
        var asyncResult = Begin_reset(null, null);
        End_reset(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_reset(AsyncCallback callback, object state)
      #else
      public void send_reset()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("reset", TMessageType.Call, seqid_));
        reset_args args = new reset_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public void recv_reset()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        reset_result result = new reset_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        return;
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_ping(AsyncCallback callback, object state)
      {
        return send_ping(callback, state);
      }

      public bool End_ping(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        return recv_ping();
      }

      #endif

      public bool ping()
      {
        #if !SILVERLIGHT
        send_ping();
        return recv_ping();

        #else
        var asyncResult = Begin_ping(null, null);
        return End_ping(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_ping(AsyncCallback callback, object state)
      #else
      public void send_ping()
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("ping", TMessageType.Call, seqid_));
        ping_args args = new ping_args();
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public bool recv_ping()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        ping_result result = new ping_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        if (result.__isset.success) {
          return result.Success;
        }
        throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "ping failed: unknown result");
      }

      
      #if SILVERLIGHT
      public IAsyncResult Begin_handleMapReduceResult(AsyncCallback callback, object state, string name, byte[] data)
      {
        return send_handleMapReduceResult(callback, state, name, data);
      }

      public void End_handleMapReduceResult(IAsyncResult asyncResult)
      {
        oprot_.Transport.EndFlush(asyncResult);
        recv_handleMapReduceResult();
      }

      #endif

      public void handleMapReduceResult(string name, byte[] data)
      {
        #if !SILVERLIGHT
        send_handleMapReduceResult(name, data);
        recv_handleMapReduceResult();

        #else
        var asyncResult = Begin_handleMapReduceResult(null, null, name, data);
        End_handleMapReduceResult(asyncResult);

        #endif
      }
      #if SILVERLIGHT
      public IAsyncResult send_handleMapReduceResult(AsyncCallback callback, object state, string name, byte[] data)
      #else
      public void send_handleMapReduceResult(string name, byte[] data)
      #endif
      {
        oprot_.WriteMessageBegin(new TMessage("handleMapReduceResult", TMessageType.Call, seqid_));
        handleMapReduceResult_args args = new handleMapReduceResult_args();
        args.Name = name;
        args.Data = data;
        args.Write(oprot_);
        oprot_.WriteMessageEnd();
        #if SILVERLIGHT
        return oprot_.Transport.BeginFlush(callback, state);
        #else
        oprot_.Transport.Flush();
        #endif
      }

      public void recv_handleMapReduceResult()
      {
        TMessage msg = iprot_.ReadMessageBegin();
        if (msg.Type == TMessageType.Exception) {
          TApplicationException x = TApplicationException.Read(iprot_);
          iprot_.ReadMessageEnd();
          throw x;
        }
        handleMapReduceResult_result result = new handleMapReduceResult_result();
        result.Read(iprot_);
        iprot_.ReadMessageEnd();
        return;
      }

    }
    public class Processor : TProcessor {
      public Processor(Iface iface)
      {
        iface_ = iface;
        processMap_["getData"] = getData_Process;
        processMap_["reset"] = reset_Process;
        processMap_["ping"] = ping_Process;
        processMap_["handleMapReduceResult"] = handleMapReduceResult_Process;
      }

      protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
      private Iface iface_;
      protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

      public bool Process(TProtocol iprot, TProtocol oprot)
      {
        try
        {
          TMessage msg = iprot.ReadMessageBegin();
          ProcessFunction fn;
          processMap_.TryGetValue(msg.Name, out fn);
          if (fn == null) {
            TProtocolUtil.Skip(iprot, TType.Struct);
            iprot.ReadMessageEnd();
            TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
            oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
            x.Write(oprot);
            oprot.WriteMessageEnd();
            oprot.Transport.Flush();
            return true;
          }
          fn(msg.SeqID, iprot, oprot);
        }
        catch (IOException)
        {
          return false;
        }
        return true;
      }

      public void getData_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        getData_args args = new getData_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        getData_result result = new getData_result();
        result.Success = iface_.getData(args.Request);
        oprot.WriteMessageBegin(new TMessage("getData", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void reset_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        reset_args args = new reset_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        reset_result result = new reset_result();
        iface_.reset();
        oprot.WriteMessageBegin(new TMessage("reset", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void ping_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        ping_args args = new ping_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        ping_result result = new ping_result();
        result.Success = iface_.ping();
        oprot.WriteMessageBegin(new TMessage("ping", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

      public void handleMapReduceResult_Process(int seqid, TProtocol iprot, TProtocol oprot)
      {
        handleMapReduceResult_args args = new handleMapReduceResult_args();
        args.Read(iprot);
        iprot.ReadMessageEnd();
        handleMapReduceResult_result result = new handleMapReduceResult_result();
        iface_.handleMapReduceResult(args.Name, args.Data);
        oprot.WriteMessageBegin(new TMessage("handleMapReduceResult", TMessageType.Reply, seqid)); 
        result.Write(oprot);
        oprot.WriteMessageEnd();
        oprot.Transport.Flush();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class getData_args : TBase
    {
      private Request _request;

      public Request Request
      {
        get
        {
          return _request;
        }
        set
        {
          __isset.request = true;
          this._request = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool request;
      }

      public getData_args() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct) {
                Request = new Request();
                Request.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("getData_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Request != null && __isset.request) {
          field.Name = "request";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Request.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("getData_args(");
        bool __first = true;
        if (Request != null && __isset.request) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Request: ");
          __sb.Append(Request== null ? "<null>" : Request.ToString());
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class getData_result : TBase
    {
      private Response _success;

      public Response Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public getData_result() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 0:
              if (field.Type == TType.Struct) {
                Success = new Response();
                Success.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("getData_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          if (Success != null) {
            field.Name = "Success";
            field.Type = TType.Struct;
            field.ID = 0;
            oprot.WriteFieldBegin(field);
            Success.Write(oprot);
            oprot.WriteFieldEnd();
          }
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("getData_result(");
        bool __first = true;
        if (Success != null && __isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success== null ? "<null>" : Success.ToString());
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class reset_args : TBase
    {

      public reset_args() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("reset_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("reset_args(");
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class reset_result : TBase
    {

      public reset_result() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("reset_result");
        oprot.WriteStructBegin(struc);

        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("reset_result(");
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class ping_args : TBase
    {

      public ping_args() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("ping_args");
        oprot.WriteStructBegin(struc);
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("ping_args(");
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class ping_result : TBase
    {
      private bool _success;

      public bool Success
      {
        get
        {
          return _success;
        }
        set
        {
          __isset.success = true;
          this._success = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool success;
      }

      public ping_result() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 0:
              if (field.Type == TType.Bool) {
                Success = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("ping_result");
        oprot.WriteStructBegin(struc);
        TField field = new TField();

        if (this.__isset.success) {
          field.Name = "Success";
          field.Type = TType.Bool;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Success);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("ping_result(");
        bool __first = true;
        if (__isset.success) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Success: ");
          __sb.Append(Success);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class handleMapReduceResult_args : TBase
    {
      private string _name;
      private byte[] _data;

      public string Name
      {
        get
        {
          return _name;
        }
        set
        {
          __isset.name = true;
          this._name = value;
        }
      }

      public byte[] Data
      {
        get
        {
          return _data;
        }
        set
        {
          __isset.data = true;
          this._data = value;
        }
      }


      public Isset __isset;
      #if !SILVERLIGHT
      [Serializable]
      #endif
      public struct Isset {
        public bool name;
        public bool data;
      }

      public handleMapReduceResult_args() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Name = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Data = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("handleMapReduceResult_args");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Name != null && __isset.name) {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Name);
          oprot.WriteFieldEnd();
        }
        if (Data != null && __isset.data) {
          field.Name = "data";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Data);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("handleMapReduceResult_args(");
        bool __first = true;
        if (Name != null && __isset.name) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Name: ");
          __sb.Append(Name);
        }
        if (Data != null && __isset.data) {
          if(!__first) { __sb.Append(", "); }
          __first = false;
          __sb.Append("Data: ");
          __sb.Append(Data);
        }
        __sb.Append(")");
        return __sb.ToString();
      }

    }


    #if !SILVERLIGHT
    [Serializable]
    #endif
    public partial class handleMapReduceResult_result : TBase
    {

      public handleMapReduceResult_result() {
      }

      public void Read (TProtocol iprot)
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }

      public void Write(TProtocol oprot) {
        TStruct struc = new TStruct("handleMapReduceResult_result");
        oprot.WriteStructBegin(struc);

        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }

      public override string ToString() {
        StringBuilder __sb = new StringBuilder("handleMapReduceResult_result(");
        __sb.Append(")");
        return __sb.ToString();
      }

    }

  }
}
