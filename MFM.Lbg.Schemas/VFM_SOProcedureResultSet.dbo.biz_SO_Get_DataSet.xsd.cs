namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StoredProcedureResultSet0", @"ArrayOfStoredProcedureResultSet0"})]
    public sealed class VFM_SOProcedureResultSet_dbo_biz_SO_Get_DataSet : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">ProcedureResultSet.dbo.biz_SO_Get_DataSet</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:complexType name=""StoredProcedureResultSet0_a49dc3"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SOREF"" nillable=""true"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POSEX"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MENGE"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MATNR_EXTERNAL"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WBS_POSID"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CONDITION_TYPE"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PRICE"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""E1EDP19_QUALF_002"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""KTEXT"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TDID"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ITEM_TXT_1"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ITEM_TXT_2"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ITEM_TXT_3"" nillable=""true"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""E1EDPT2_TDLINE"" nillable=""true"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:StoredProcedureResultSet0_a49dc3"" />
  <xs:complexType name=""ArrayOfStoredProcedureResultSet0_a49dc3"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""StoredProcedureResultSet0"" type=""ns3:StoredProcedureResultSet0_a49dc3"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""ArrayOfStoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0_a49dc3"" />
</xs:schema>";
        
        public VFM_SOProcedureResultSet_dbo_biz_SO_Get_DataSet() {
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet",@"StoredProcedureResultSet0")]
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet",@"ArrayOfStoredProcedureResultSet0")]
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
