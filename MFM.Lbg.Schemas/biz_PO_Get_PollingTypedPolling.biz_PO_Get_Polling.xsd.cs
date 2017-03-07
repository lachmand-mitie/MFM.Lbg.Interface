namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MFM.Lbg.Schemas.POAvailable), XPath = @"/*[local-name()='TypedPolling' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='TypedPollingResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='TypedPollingResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='Result' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TypedPollingResultSet0", @"ArrayOfTypedPollingResultSet0", @"TypedPolling"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.schPropertyPolling1001", typeof(global::MFM.Lbg.Schemas.schPropertyPolling1001))]
    public sealed class biz_PO_Get_PollingTypedPolling_biz_PO_Get_Polling : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling"" xmlns:ns0=""https://MFM.Lbg.Schemas.schPropertyPolling1001"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedPolling.biz_PO_Get_Polling</fileNameHint>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://MFM.Lbg.Schemas.schPropertyPolling1001"" location=""MFM.Lbg.Schemas.schPropertyPolling1001"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""TypedPollingResultSet0"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Result"" nillable=""true"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""TypedPollingResultSet0"" nillable=""true"" type=""tns:TypedPollingResultSet0"" />
  <xs:complexType name=""ArrayOfTypedPollingResultSet0"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TypedPollingResultSet0"" type=""tns:TypedPollingResultSet0"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfTypedPollingResultSet0"" nillable=""true"" type=""tns:ArrayOfTypedPollingResultSet0"" />
  <xs:element name=""TypedPolling"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedPolling</doc:action>
        <doc:description xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">exec dbo.biz_PO_Get_Polling</doc:description>
      </xs:documentation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:POAvailable"" xpath=""/*[local-name()='TypedPolling' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='TypedPollingResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='TypedPollingResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='Result' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TypedPollingResultSet0"" nillable=""true"" type=""tns:ArrayOfTypedPollingResultSet0"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public biz_PO_Get_PollingTypedPolling_biz_PO_Get_Polling() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "TypedPollingResultSet0";
                _RootElements[1] = "ArrayOfTypedPollingResultSet0";
                _RootElements[2] = "TypedPolling";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling",@"TypedPollingResultSet0")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TypedPollingResultSet0"})]
        public sealed class TypedPollingResultSet0 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TypedPollingResultSet0() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TypedPollingResultSet0";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling",@"ArrayOfTypedPollingResultSet0")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfTypedPollingResultSet0"})]
        public sealed class ArrayOfTypedPollingResultSet0 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfTypedPollingResultSet0() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfTypedPollingResultSet0";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling",@"TypedPolling")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::MFM.Lbg.Schemas.POAvailable), XPath = @"/*[local-name()='TypedPolling' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='TypedPollingResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='TypedPollingResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']/*[local-name()='Result' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_PO_Get_Polling']", XsdType = @"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TypedPolling"})]
        public sealed class TypedPolling : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TypedPolling() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TypedPolling";
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
