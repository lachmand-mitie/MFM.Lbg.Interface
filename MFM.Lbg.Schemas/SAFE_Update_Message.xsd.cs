namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0",@"SafeUpdate")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "VisitId", XPath = @"/*[local-name()='SafeUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0']/*[local-name()='VisitId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CustomerReference", XPath = @"/*[local-name()='SafeUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0']/*[local-name()='CustomerReference' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Business", XPath = @"/*[local-name()='SafeUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0']/*[local-name()='Business' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SafeUpdate"})]
    public sealed class SAFE_Update_Message : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SafeUpdate"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SafeUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0']/*[local-name()='VisitId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SafeUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0']/*[local-name()='CustomerReference' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SafeUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0']/*[local-name()='Business' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""VisitId"" type=""xs:string"" />
        <xs:element name=""CustomerReference"" type=""xs:string"" />
        <xs:element name=""ServiceType"" type=""xs:string"" />
        <xs:element name=""VisitStatus"" type=""xs:string"" />
        <xs:element name=""Deleted"" type=""xs:string"" />
        <xs:element name=""DateServiceStart"" type=""xs:dateTime"" />
        <xs:element name=""DateServiceEnd"" type=""xs:dateTime"" />
        <xs:element name=""Note"" type=""xs:string"" />
        <xs:element name=""ClientViewable"" type=""xs:string"" />
        <xs:element name=""Cardnumber"" type=""xs:string"" />
        <xs:element name=""Customer"" type=""xs:string"" />
        <xs:element name=""Contract"" type=""xs:string"" />
        <xs:element name=""Business"" type=""xs:string"" />
        <xs:element name=""WorkType"" type=""xs:string"" />
        <xs:element name=""OutboundUpdId"" type=""xs:string"" />
        <xs:element name=""OutboundUpdTs"" type=""xs:dateTime"" />
        <xs:element name=""LastModifiedTs"" type=""xs:dateTime"" />
        <xs:element name=""DateCalledIn"" type=""xs:string"" />
        <xs:element name=""DateConfirmed"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SAFE_Update_Message() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SafeUpdate";
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
