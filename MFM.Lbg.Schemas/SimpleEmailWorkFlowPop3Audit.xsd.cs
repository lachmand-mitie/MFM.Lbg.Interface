namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"SimpleEmailWorkFlowPop3Audit")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Body.RawBodyContent", XPath = @"/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Body' and namespace-uri()='']/*[local-name()='RawBodyContent' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Header.From", XPath = @"/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='From' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Header.RawHeaders", XPath = @"/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='RawHeaders' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.DateTime), "Header.SentDt", XPath = @"/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='SentDt' and namespace-uri()='']", XsdType = @"dateTime")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Header.Subject", XPath = @"/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='Subject' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SimpleEmailWorkFlowPop3Audit"})]
    public sealed class SimpleEmailWorkFlowPop3Audit : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SimpleEmailWorkFlowPop3Audit"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Body' and namespace-uri()='']/*[local-name()='RawBodyContent' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='From' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='RawHeaders' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='SentDt' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SimpleEmailWorkFlowPop3Audit' and namespace-uri()='']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='Subject' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence minOccurs=""1"" maxOccurs=""1"">
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence maxOccurs=""1"">
              <xs:element maxOccurs=""1"" name=""From"" type=""xs:string"" />
              <xs:element maxOccurs=""1"" name=""To"" type=""xs:string"" />
              <xs:element maxOccurs=""1"" name=""RawHeaders"" type=""xs:string"" />
              <xs:element maxOccurs=""1"" name=""SentDt"" type=""xs:dateTime"" />
              <xs:element maxOccurs=""1"" name=""Subject"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Body"">
          <xs:complexType>
            <xs:sequence maxOccurs=""1"">
              <xs:element maxOccurs=""1"" name=""RawBodyContent"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""VisionData"">
          <xs:complexType>
            <xs:sequence maxOccurs=""1"">
              <xs:element maxOccurs=""1"" default=""false"" name=""ValidSubject"" type=""xs:string"" />
              <xs:element default=""None"" name=""Action"" type=""xs:string"" />
              <xs:element default=""None"" name=""Ref"" type=""xs:string"" />
              <xs:element default=""None"" name=""Workflow"" type=""xs:string"" />
              <xs:element name=""Id"" type=""xs:string"" />
              <xs:element name=""Guid"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SimpleEmailWorkFlowPop3Audit() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SimpleEmailWorkFlowPop3Audit";
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
