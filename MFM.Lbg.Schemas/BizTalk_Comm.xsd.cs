namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.BizTalk_Comm",@"Biz_comm")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "L12", XPath = @"/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L12' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "L1", XPath = @"/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L1' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "L3", XPath = @"/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L3' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "L4", XPath = @"/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L4' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "L10", XPath = @"/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L10' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Biz_comm"})]
    public sealed class BizTalk_Comm : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.BizTalk_Comm"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.BizTalk_Comm"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Biz_comm"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L12' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L1' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L3' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L4' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Biz_comm' and namespace-uri()='http://MFM.Lbg.Schemas.BizTalk_Comm']/*[local-name()='L10' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L1"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L2"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L3"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L4"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L5"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L6"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L7"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L8"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L10"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L11"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""L12"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BizTalk_Comm() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Biz_comm";
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
