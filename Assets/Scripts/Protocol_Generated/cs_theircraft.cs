//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protocol/cs_theircraft.proto
namespace protocol.cs_theircraft
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVector2Int")]
  public partial class CSVector2Int : global::ProtoBuf.IExtensible
  {
    public CSVector2Int() {}
    
    private int _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVector3")]
  public partial class CSVector3 : global::ProtoBuf.IExtensible
  {
    public CSVector3() {}
    
    private float _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float x
    {
      get { return _x; }
      set { _x = value; }
    }
    private float _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float y
    {
      get { return _y; }
      set { _y = value; }
    }
    private float _z;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSVector3Int")]
  public partial class CSVector3Int : global::ProtoBuf.IExtensible
  {
    public CSVector3Int() {}
    
    private int _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int x
    {
      get { return _x; }
      set { _x = value; }
    }
    private int _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int y
    {
      get { return _y; }
      set { _y = value; }
    }
    private int _z;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSBlock")]
  public partial class CSBlock : global::ProtoBuf.IExtensible
  {
    public CSBlock() {}
    
    private CSVector3Int _position;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSVector3Int position
    {
      get { return _position; }
      set { _position = value; }
    }
    private CSBlockType _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public CSBlockType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSChunk")]
  public partial class CSChunk : global::ProtoBuf.IExtensible
  {
    public CSChunk() {}
    
    private CSVector2Int _Position;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSVector2Int Position
    {
      get { return _Position; }
      set { _Position = value; }
    }
    private readonly global::System.Collections.Generic.List<CSBlock> _Blocks = new global::System.Collections.Generic.List<CSBlock>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Blocks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSBlock> Blocks
    {
      get { return _Blocks; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSLoginReq")]
  public partial class CSLoginReq : global::ProtoBuf.IExtensible
  {
    public CSLoginReq() {}
    
    private string _Name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSLoginRes")]
  public partial class CSLoginRes : global::ProtoBuf.IExtensible
  {
    public CSLoginRes() {}
    
    private int _RetCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RetCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RetCode
    {
      get { return _RetCode; }
      set { _RetCode = value; }
    }
    private CSVector3 _Position = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CSVector3 Position
    {
      get { return _Position; }
      set { _Position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSSendMessageReq")]
  public partial class CSSendMessageReq : global::ProtoBuf.IExtensible
  {
    public CSSendMessageReq() {}
    
    private string _Content;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Content
    {
      get { return _Content; }
      set { _Content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSSendMessageRes")]
  public partial class CSSendMessageRes : global::ProtoBuf.IExtensible
  {
    public CSSendMessageRes() {}
    
    private int _RetCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RetCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RetCode
    {
      get { return _RetCode; }
      set { _RetCode = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSMessageNotify")]
  public partial class CSMessageNotify : global::ProtoBuf.IExtensible
  {
    public CSMessageNotify() {}
    
    private string _Name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private string _Content;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Content
    {
      get { return _Content; }
      set { _Content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSChunksEnterLeaveViewReq")]
  public partial class CSChunksEnterLeaveViewReq : global::ProtoBuf.IExtensible
  {
    public CSChunksEnterLeaveViewReq() {}
    
    private readonly global::System.Collections.Generic.List<CSVector2Int> _EnterViewChunks = new global::System.Collections.Generic.List<CSVector2Int>();
    [global::ProtoBuf.ProtoMember(1, Name=@"EnterViewChunks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVector2Int> EnterViewChunks
    {
      get { return _EnterViewChunks; }
    }
  
    private readonly global::System.Collections.Generic.List<CSVector2Int> _LeaveViewChunks = new global::System.Collections.Generic.List<CSVector2Int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"LeaveViewChunks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVector2Int> LeaveViewChunks
    {
      get { return _LeaveViewChunks; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSChunksEnterLeaveViewRes")]
  public partial class CSChunksEnterLeaveViewRes : global::ProtoBuf.IExtensible
  {
    public CSChunksEnterLeaveViewRes() {}
    
    private int _RetCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RetCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RetCode
    {
      get { return _RetCode; }
      set { _RetCode = value; }
    }
    private readonly global::System.Collections.Generic.List<CSChunk> _EnterViewChunks = new global::System.Collections.Generic.List<CSChunk>();
    [global::ProtoBuf.ProtoMember(2, Name=@"EnterViewChunks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSChunk> EnterViewChunks
    {
      get { return _EnterViewChunks; }
    }
  
    private readonly global::System.Collections.Generic.List<CSVector2Int> _LeaveViewChunks = new global::System.Collections.Generic.List<CSVector2Int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"LeaveViewChunks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CSVector2Int> LeaveViewChunks
    {
      get { return _LeaveViewChunks; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSAddBlockReq")]
  public partial class CSAddBlockReq : global::ProtoBuf.IExtensible
  {
    public CSAddBlockReq() {}
    
    private CSBlock _block;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"block", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSBlock block
    {
      get { return _block; }
      set { _block = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSAddBlockRes")]
  public partial class CSAddBlockRes : global::ProtoBuf.IExtensible
  {
    public CSAddBlockRes() {}
    
    private int _RetCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RetCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RetCode
    {
      get { return _RetCode; }
      set { _RetCode = value; }
    }
    private CSBlock _block;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"block", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSBlock block
    {
      get { return _block; }
      set { _block = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSAddBlockNotify")]
  public partial class CSAddBlockNotify : global::ProtoBuf.IExtensible
  {
    public CSAddBlockNotify() {}
    
    private CSBlock _block;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"block", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSBlock block
    {
      get { return _block; }
      set { _block = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSDeleteBlockReq")]
  public partial class CSDeleteBlockReq : global::ProtoBuf.IExtensible
  {
    public CSDeleteBlockReq() {}
    
    private CSVector3Int _position;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSVector3Int position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSDeleteBlockRes")]
  public partial class CSDeleteBlockRes : global::ProtoBuf.IExtensible
  {
    public CSDeleteBlockRes() {}
    
    private int _RetCode;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RetCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int RetCode
    {
      get { return _RetCode; }
      set { _RetCode = value; }
    }
    private CSVector3Int _position;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSVector3Int position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSDeleteBlockNotify")]
  public partial class CSDeleteBlockNotify : global::ProtoBuf.IExtensible
  {
    public CSDeleteBlockNotify() {}
    
    private CSVector3Int _position;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public CSVector3Int position
    {
      get { return _position; }
      set { _position = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CSBlockType")]
    public enum CSBlockType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"None", Value=0)]
      None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Dirt", Value=1)]
      Dirt = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Grass", Value=2)]
      Grass = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Tnt", Value=3)]
      Tnt = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Brick", Value=4)]
      Brick = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Furnace", Value=5)]
      Furnace = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"HayBlock", Value=6)]
      HayBlock = 6
    }
  
}