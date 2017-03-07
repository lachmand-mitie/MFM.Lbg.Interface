namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"TempMiamiWoUpd")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "attribute01", XPath = @"/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute01' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "attribute02", XPath = @"/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute02' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "attribute03", XPath = @"/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute03' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "attribute04", XPath = @"/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute04' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "attribute05", XPath = @"/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute05' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TempMiamiWoUpd"})]
    public sealed class TempMiamiWoUpd : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TempMiamiWoUpd"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""TempMiamiWoUpd"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute01' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute02' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute03' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute04' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TempMiamiWoUpd' and namespace-uri()='']/*[local-name()='attribute05' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""attribute01"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""wonum"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""attribute02"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""sitied"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""attribute03"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""targstart"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""attribute04"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""targcomp"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""attribute05"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo notes=""wopriority"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""attribute06"" type=""xs:string"" />
        <xs:element name=""attribute07"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TempMiamiWoUpd() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TempMiamiWoUpd";
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
