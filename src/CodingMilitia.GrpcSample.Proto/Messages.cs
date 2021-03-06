// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: servicedef/messages.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CodingMilitia.GrpcSample.Proto.Messages {

  /// <summary>Holder for reflection information generated from servicedef/messages.proto</summary>
  public static partial class MessagesReflection {

    #region Descriptor
    /// <summary>File descriptor for servicedef/messages.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlzZXJ2aWNlZGVmL21lc3NhZ2VzLnByb3RvEgpzZXJ2aWNlZGVmIiUKEElu",
            "Y3JlbWVudFJlcXVlc3QSEQoJcmVxdWVzdGVyGAEgASgJIiIKEUluY3JlbWVu",
            "dFJlc3BvbnNlEg0KBWNvdW50GAEgASgFQjNaB3NlcnZpY2WqAidDb2RpbmdN",
            "aWxpdGlhLkdycGNTYW1wbGUuUHJvdG8uTWVzc2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CodingMilitia.GrpcSample.Proto.Messages.IncrementRequest), global::CodingMilitia.GrpcSample.Proto.Messages.IncrementRequest.Parser, new[]{ "Requester" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CodingMilitia.GrpcSample.Proto.Messages.IncrementResponse), global::CodingMilitia.GrpcSample.Proto.Messages.IncrementResponse.Parser, new[]{ "Count" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IncrementRequest : pb::IMessage<IncrementRequest> {
    private static readonly pb::MessageParser<IncrementRequest> _parser = new pb::MessageParser<IncrementRequest>(() => new IncrementRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IncrementRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CodingMilitia.GrpcSample.Proto.Messages.MessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncrementRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncrementRequest(IncrementRequest other) : this() {
      requester_ = other.requester_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncrementRequest Clone() {
      return new IncrementRequest(this);
    }

    /// <summary>Field number for the "requester" field.</summary>
    public const int RequesterFieldNumber = 1;
    private string requester_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Requester {
      get { return requester_; }
      set {
        requester_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IncrementRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IncrementRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Requester != other.Requester) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Requester.Length != 0) hash ^= Requester.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Requester.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Requester);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Requester.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Requester);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IncrementRequest other) {
      if (other == null) {
        return;
      }
      if (other.Requester.Length != 0) {
        Requester = other.Requester;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Requester = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class IncrementResponse : pb::IMessage<IncrementResponse> {
    private static readonly pb::MessageParser<IncrementResponse> _parser = new pb::MessageParser<IncrementResponse>(() => new IncrementResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IncrementResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CodingMilitia.GrpcSample.Proto.Messages.MessagesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncrementResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncrementResponse(IncrementResponse other) : this() {
      count_ = other.count_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncrementResponse Clone() {
      return new IncrementResponse(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 1;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IncrementResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IncrementResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0) hash ^= Count.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Count != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Count);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IncrementResponse other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Count = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
