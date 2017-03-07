namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.TFMAlertAddress",@"TFMAlertAddress")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "EmailAddress", XPath = @"/*[local-name()='TFMAlertAddress' and namespace-uri()='http://MFM.Lbg.Schemas.TFMAlertAddress']/*[local-name()='EmailAddress' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "HelpdeskRef", XPath = @"/*[local-name()='TFMAlertAddress' and namespace-uri()='http://MFM.Lbg.Schemas.TFMAlertAddress']/*[local-name()='HelpdeskRef' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TFMAlertAddress"})]
    public sealed class TFMAlertAddress : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.TFMAlertAddress"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.TFMAlertAddress"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TFMAlertAddress"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""TFMAlertAddress"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TFMAlertAddress' and namespace-uri()='http://MFM.Lbg.Schemas.TFMAlertAddress']/*[local-name()='EmailAddress' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TFMAlertAddress' and namespace-uri()='http://MFM.Lbg.Schemas.TFMAlertAddress']/*[local-name()='HelpdeskRef' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""EmailAddress"" type=""xs:string"" />
        <xs:element name=""HelpdeskRef"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TFMAlertAddress() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TFMAlertAddress";
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
