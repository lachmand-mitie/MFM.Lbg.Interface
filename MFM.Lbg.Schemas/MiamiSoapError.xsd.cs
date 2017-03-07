namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"MFM.Lbg.Schemas/Soap/Erros/Miami/1_1",@"MiamiSoapErorr_1_1")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "faultString", XPath = @"/*[local-name()='MiamiSoapErorr_1_1' and namespace-uri()='MFM.Lbg.Schemas/Soap/Erros/Miami/1_1']/*[local-name()='faultString' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MiamiSoapErorr_1_1"})]
    public sealed class MiamiSoapError : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""MFM.Lbg.Schemas/Soap/Erros/Miami/1_1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""MFM.Lbg.Schemas/Soap/Erros/Miami/1_1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MiamiSoapErorr_1_1"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiamiSoapErorr_1_1' and namespace-uri()='MFM.Lbg.Schemas/Soap/Erros/Miami/1_1']/*[local-name()='faultString' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""faultString"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MiamiSoapError() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MiamiSoapErorr_1_1";
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
