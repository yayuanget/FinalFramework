//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: playercmd.proto
// Note: requires additional types generated from: player.proto
namespace FirSanguo
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreatePlayerAsk")]
  public partial class CreatePlayerAsk : global::ProtoBuf.IExtensible
  {
    public CreatePlayerAsk() {}
    
    private string _nickname;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private string _selectrole;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"selectrole", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string selectrole
    {
      get { return _selectrole; }
      set { _selectrole = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreatePlayerReply")]
  public partial class CreatePlayerReply : global::ProtoBuf.IExtensible
  {
    public CreatePlayerReply() {}
    
    private FirSanguo.PlayerCore _player;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public FirSanguo.PlayerCore player
    {
      get { return _player; }
      set { _player = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}