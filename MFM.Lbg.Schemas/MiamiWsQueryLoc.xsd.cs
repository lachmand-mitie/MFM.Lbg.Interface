namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BuildingClass1", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='BuildingClass1' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BuildingClass2", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='BuildingClass2' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Type", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='Type' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MiamiWsQueryLocRequest", @"MiamiWsQueryLocResponse"})]
    public sealed class MiamiWsQueryLoc : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MiamiWsQueryLocRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='BuildingClass1' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='BuildingClass2' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='Type' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='Status' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""BuildingClass1"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""BuildingClass2"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Type"" type=""xs:string"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Status"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UniqueRecordsOnly"" type=""xs:boolean"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MaxRows"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""MiamiWsQueryLocResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Location"" type=""xs:string"" />
        <xs:element name=""SiteId"" type=""xs:string"" />
        <xs:element name=""OrgId"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""Fault"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FaultString"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MiamiWsQueryLoc() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "MiamiWsQueryLocRequest";
                _RootElements[1] = "MiamiWsQueryLocResponse";
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
        
        [Schema(@"http://MFM.Lbg.Schemas.MiamiWsQueryLoc",@"MiamiWsQueryLocRequest")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BuildingClass1", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='BuildingClass1' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BuildingClass2", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='BuildingClass2' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Type", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='Type' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status", XPath = @"/*[local-name()='MiamiWsQueryLocRequest' and namespace-uri()='http://MFM.Lbg.Schemas.MiamiWsQueryLoc']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MiamiWsQueryLocRequest"})]
        public sealed class MiamiWsQueryLocRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MiamiWsQueryLocRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MiamiWsQueryLocRequest";
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
        
        [Schema(@"http://MFM.Lbg.Schemas.MiamiWsQueryLoc",@"MiamiWsQueryLocResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MiamiWsQueryLocResponse"})]
        public sealed class MiamiWsQueryLocResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MiamiWsQueryLocResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MiamiWsQueryLocResponse";
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
}
