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

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Sort : TBase
  {
    private string _dimension;
    private string _metric;
    private OrderingType _ordering;

    public string Dimension
    {
      get
      {
        return _dimension;
      }
      set
      {
        __isset.dimension = true;
        this._dimension = value;
      }
    }

    public string Metric
    {
      get
      {
        return _metric;
      }
      set
      {
        __isset.metric = true;
        this._metric = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="OrderingType"/>
    /// </summary>
    public OrderingType Ordering
    {
      get
      {
        return _ordering;
      }
      set
      {
        __isset.ordering = true;
        this._ordering = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool dimension;
      public bool metric;
      public bool ordering;
    }

    public Sort() {
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
              Dimension = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Metric = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Ordering = (OrderingType)iprot.ReadI32();
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
      TStruct struc = new TStruct("Sort");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Dimension != null && __isset.dimension) {
        field.Name = "dimension";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Dimension);
        oprot.WriteFieldEnd();
      }
      if (Metric != null && __isset.metric) {
        field.Name = "metric";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Metric);
        oprot.WriteFieldEnd();
      }
      if (__isset.ordering) {
        field.Name = "ordering";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Ordering);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("Sort(");
      bool __first = true;
      if (Dimension != null && __isset.dimension) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dimension: ");
        __sb.Append(Dimension);
      }
      if (Metric != null && __isset.metric) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Metric: ");
        __sb.Append(Metric);
      }
      if (__isset.ordering) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ordering: ");
        __sb.Append(Ordering);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
