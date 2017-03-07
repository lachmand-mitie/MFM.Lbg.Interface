namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "StoredProcedureResultSet0.StoredProcedureResultSet0.Case_ReferenceId", XPath = @"/*[local-name()='biz_Global_Fetch_Case_DataSetResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']/*[local-name()='Case_ReferenceId' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "StoredProcedureResultSet0.StoredProcedureResultSet0.case_foreignsysname", XPath = @"/*[local-name()='biz_Global_Fetch_Case_DataSetResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']/*[local-name()='case_foreignsysname' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"biz_Global_Fetch_Case_DataSet", @"biz_Global_Fetch_Case_DataSetResponse", @"biz_Global_Remove_Case_From_Queue", @"biz_Global_Remove_Case_From_QueueResponse", @"biz_Global_Reset_Case_Extract", @"biz_Global_Reset_Case_ExtractResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Fetch_Case_DataSet", typeof(global::MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Fetch_Case_DataSet))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Remove_Case_From_Queue", typeof(global::MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Remove_Case_From_Queue))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Reset_Case_Extract", typeof(global::MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Reset_Case_Extract))]
    public sealed class VFM_Extract_TypedProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Remove_Case_From_Queue"" xmlns:ns5=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Reset_Case_Extract"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Fetch_Case_DataSet"" namespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet"" />
  <xs:import schemaLocation=""MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Remove_Case_From_Queue"" namespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Remove_Case_From_Queue"" />
  <xs:import schemaLocation=""MFM.Lbg.Schemas.VFM_Extract_ProcedureResultSet_dbo_biz_Global_Reset_Case_Extract"" namespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Reset_Case_Extract"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedProcedure.dbo</fileNameHint>
      <b:references>
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Remove_Case_From_Queue"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Reset_Case_Extract"" />
        <b:reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""biz_Global_Fetch_Case_DataSet"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/biz_Global_Fetch_Case_DataSet</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""id"" nillable=""true"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""biz_Global_Fetch_Case_DataSetResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/biz_Global_Fetch_Case_DataSet/response</doc:action>
      </xs:documentation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='biz_Global_Fetch_Case_DataSetResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']/*[local-name()='Case_ReferenceId' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='biz_Global_Fetch_Case_DataSetResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']/*[local-name()='case_foreignsysname' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""biz_Global_Remove_Case_From_Queue"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/biz_Global_Remove_Case_From_Queue</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ref"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""128"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""code"" nillable=""true"" type=""xs:short"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""biz_Global_Remove_Case_From_QueueResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/biz_Global_Remove_Case_From_Queue/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns4:ArrayOfStoredProcedureResultSet0"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""biz_Global_Reset_Case_Extract"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/biz_Global_Reset_Case_Extract</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ref"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""128"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""biz_Global_Reset_Case_ExtractResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/biz_Global_Reset_Case_Extract/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns5:ArrayOfStoredProcedureResultSet0"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet1"" nillable=""true"" type=""ns5:ArrayOfStoredProcedureResultSet1"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public VFM_Extract_TypedProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [6];
                _RootElements[0] = "biz_Global_Fetch_Case_DataSet";
                _RootElements[1] = "biz_Global_Fetch_Case_DataSetResponse";
                _RootElements[2] = "biz_Global_Remove_Case_From_Queue";
                _RootElements[3] = "biz_Global_Remove_Case_From_QueueResponse";
                _RootElements[4] = "biz_Global_Reset_Case_Extract";
                _RootElements[5] = "biz_Global_Reset_Case_ExtractResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"biz_Global_Fetch_Case_DataSet")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"biz_Global_Fetch_Case_DataSet"})]
        public sealed class biz_Global_Fetch_Case_DataSet : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public biz_Global_Fetch_Case_DataSet() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "biz_Global_Fetch_Case_DataSet";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"biz_Global_Fetch_Case_DataSetResponse")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "StoredProcedureResultSet0.StoredProcedureResultSet0.Case_ReferenceId", XPath = @"/*[local-name()='biz_Global_Fetch_Case_DataSetResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']/*[local-name()='Case_ReferenceId' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "StoredProcedureResultSet0.StoredProcedureResultSet0.case_foreignsysname", XPath = @"/*[local-name()='biz_Global_Fetch_Case_DataSetResponse' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']/*[local-name()='case_foreignsysname' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"biz_Global_Fetch_Case_DataSetResponse"})]
        public sealed class biz_Global_Fetch_Case_DataSetResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public biz_Global_Fetch_Case_DataSetResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "biz_Global_Fetch_Case_DataSetResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"biz_Global_Remove_Case_From_Queue")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"biz_Global_Remove_Case_From_Queue"})]
        public sealed class biz_Global_Remove_Case_From_Queue : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public biz_Global_Remove_Case_From_Queue() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "biz_Global_Remove_Case_From_Queue";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"biz_Global_Remove_Case_From_QueueResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"biz_Global_Remove_Case_From_QueueResponse"})]
        public sealed class biz_Global_Remove_Case_From_QueueResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public biz_Global_Remove_Case_From_QueueResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "biz_Global_Remove_Case_From_QueueResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"biz_Global_Reset_Case_Extract")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"biz_Global_Reset_Case_Extract"})]
        public sealed class biz_Global_Reset_Case_Extract : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public biz_Global_Reset_Case_Extract() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "biz_Global_Reset_Case_Extract";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"biz_Global_Reset_Case_ExtractResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"biz_Global_Reset_Case_ExtractResponse"})]
        public sealed class biz_Global_Reset_Case_ExtractResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public biz_Global_Reset_Case_ExtractResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "biz_Global_Reset_Case_ExtractResponse";
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
