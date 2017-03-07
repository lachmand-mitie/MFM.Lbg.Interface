namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0",@"Email")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "To", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='To' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "From", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='From' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Subject", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Subject' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Cc", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Cc' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Body", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Body' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Priority", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Priority' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Server", XPath = @"/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Server' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Email"})]
    public sealed class LBG_SAFE_EMAIL : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Email"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='To' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='From' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Subject' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Cc' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Body' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Priority' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Email' and namespace-uri()='http://MFM.Lbg.Schemas.LBG_SAFE_EMAIL/1/0']/*[local-name()='Server' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""To"" type=""xs:string"" />
        <xs:element name=""From"" type=""xs:string"" />
        <xs:element name=""Cc"" type=""xs:string"" />
        <xs:element name=""Subject"" type=""xs:string"" />
        <xs:element name=""Body"" type=""xs:string"" />
        <xs:element name=""Priority"" type=""xs:string"" />
        <xs:element name=""Server"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public LBG_SAFE_EMAIL() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Email";
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
