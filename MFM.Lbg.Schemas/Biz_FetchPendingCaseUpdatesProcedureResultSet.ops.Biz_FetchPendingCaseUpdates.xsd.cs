namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "id", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='id' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "case_referenceid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_referenceid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_primarycompanyid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_primarycompanyid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_providercompanyid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_providercompanyid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_providerdivisionid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_providerdivisionid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_locationid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_locationid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "case_foreignsysid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_foreignsysid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StoredProcedureResultSet0", @"ArrayOfStoredProcedureResultSet0"})]
    public sealed class Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">ProcedureResultSet.ops.Biz_FetchPendingCaseUpdates</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""StoredProcedureResultSet0"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""id"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""processed"" nillable=""true"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""processts"" nillable=""true"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""caseid"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_referenceid"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_foreignsysid"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_calltype"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_primarycompanyid"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_providercompanyid"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_providerdivisionid"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_locationid"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Case_SLASeverity"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_cp_attend"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_cp_complete"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_buildingclass1"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""case_buildingclass2"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:StoredProcedureResultSet0"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='id' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_referenceid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_primarycompanyid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_providercompanyid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_providerdivisionid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_locationid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_foreignsysid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""ArrayOfStoredProcedureResultSet0"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""StoredProcedureResultSet0"" type=""ns3:StoredProcedureResultSet0"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfStoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0"" />
</xs:schema>";
        
        public Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "StoredProcedureResultSet0";
                _RootElements[1] = "ArrayOfStoredProcedureResultSet0";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates",@"StoredProcedureResultSet0")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "id", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='id' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "case_referenceid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_referenceid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_primarycompanyid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_primarycompanyid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_providercompanyid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_providercompanyid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_providerdivisionid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_providerdivisionid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "case_locationid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_locationid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"int")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "case_foreignsysid", XPath = @"/*[local-name()='StoredProcedureResultSet0' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']/*[local-name()='case_foreignsysid' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StoredProcedureResultSet0"})]
        public sealed class StoredProcedureResultSet0 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StoredProcedureResultSet0() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StoredProcedureResultSet0";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates",@"ArrayOfStoredProcedureResultSet0")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ArrayOfStoredProcedureResultSet0"})]
        public sealed class ArrayOfStoredProcedureResultSet0 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ArrayOfStoredProcedureResultSet0() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ArrayOfStoredProcedureResultSet0";
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
