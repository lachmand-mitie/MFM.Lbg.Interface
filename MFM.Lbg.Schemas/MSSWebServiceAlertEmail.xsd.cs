namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.WebServiceAlertEmail",@"MSSWebServiceAlertEmail")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SmtpServer", XPath = @"/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='SmtpServer' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Subject", XPath = @"/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='Subject' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "To", XPath = @"/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='To' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Bcc", XPath = @"/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='Bcc' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BodyText", XPath = @"/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='BodyText' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BodyTextPayload", XPath = @"/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='BodyTextPayload' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MSSWebServiceAlertEmail"})]
    public sealed class MSSWebServiceAlertEmail : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.WebServiceAlertEmail"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.WebServiceAlertEmail"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MSSWebServiceAlertEmail"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='SmtpServer' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='Subject' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='To' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='Bcc' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='BodyText' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MSSWebServiceAlertEmail' and namespace-uri()='http://MFM.Lbg.Schemas.WebServiceAlertEmail']/*[local-name()='BodyTextPayload' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" default=""mailrelay.mitie.com"" name=""SmtpServer"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Subject"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""To"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Bcc"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""BodyText"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BodyTextPayload"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MSSWebServiceAlertEmail() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MSSWebServiceAlertEmail";
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
