namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.schUdttAssetPreLoadCheck",@"schUdttAssetPreLoadCheck")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"schUdttAssetPreLoadCheck"})]
    public sealed class schUdttAssetPreLoadCheck : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.schUdttAssetPreLoadCheck"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.schUdttAssetPreLoadCheck"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""schUdttAssetPreLoadCheck"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""LocationId"" type=""xs:string"" />
        <xs:element name=""SubTypeId"" type=""xs:string"" />
        <xs:element name=""BuildingId"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public schUdttAssetPreLoadCheck() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "schUdttAssetPreLoadCheck";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
