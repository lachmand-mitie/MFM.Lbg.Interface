namespace MFM.Lbg.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://MFM.Lbg.Schemas.MFMWorkItemUpdate",@"MFMWorkItemUpdate")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "WI_Status", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_Status' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SourceSystem", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='SourceSystem' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "WI_WorkType", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_WorkType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "WI_AssetRef", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_AssetRef' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SourceSystemMessageId", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='SourceSystemMessageId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Meta_RF01", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='Meta_RF01' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "WI_LocationLevel3", XPath = @"/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_LocationLevel3' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MFMWorkItemUpdate"})]
    public sealed class MFMWorkItemUpdate : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MFMWorkItemUpdate"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_Status' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='SourceSystem' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_WorkType' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_AssetRef' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='SourceSystemMessageId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='Meta_RF01' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MFMWorkItemUpdate' and namespace-uri()='http://MFM.Lbg.Schemas.MFMWorkItemUpdate']/*[local-name()='WI_LocationLevel3' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:all minOccurs=""1"" maxOccurs=""1"">
        <xs:element maxOccurs=""1"" name=""SourceSystem"" nillable=""true"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""SourceSystemMessageId"" nillable=""true"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""SourceSystemMessageTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element maxOccurs=""1"" name=""BizTalkMessageId"" nillable=""true"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""BizTalkMessageTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element maxOccurs=""1"" name=""WI_WorkType"" nillable=""true"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""WI_UpdateTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element maxOccurs=""1"" name=""WI_SourceRef"" nillable=""true"" type=""xs:string"" />
        <xs:element maxOccurs=""1"" name=""WI_DestinationRef"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ServiceLevel1"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ServiceLevel2"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ServiceLevel3"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_AssetRef"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_LocationLevel1"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_LocationLevel2"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_LocationLevel3"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_LocationLevel4"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_Status"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_StatusChangeTS"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_StatusNote"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_Priority"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_KpiStartTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_KpiAttendTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_KpiCompleteTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_KpiConfirmTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ActualStartTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ActualAttendTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ActualCompleteTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ActualConfirmTs"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF01"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF02"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF03"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF04"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF05"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF06"" nillable=""true"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF07"" nillable=""true"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF08"" nillable=""true"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF09"" nillable=""true"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF10"" nillable=""true"" type=""xs:int"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF11"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF12"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF13"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF14"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Meta_RF15"" nillable=""true"" type=""xs:dateTime"" />
        <xs:element maxOccurs=""1"" name=""Meta_RF21"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ServiceNotes"" nillable=""true"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""WI_Note"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_Noteid"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_NoteText"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""WI_CreatedBy"" nillable=""true"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_NoteTS"" type=""xs:dateTime"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ClientViewable"" type=""xs:int"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ActionRequired"" type=""xs:int"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_Ignore"" type=""xs:int"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_MitigationNotes"" nillable=""true"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""WI_MitEvnt"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_Noteid"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_NoteText"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""WI_CreatedBy"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_NoteTS"" type=""xs:dateTime"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ClientViewable"" type=""xs:int"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_ActionRequired"" type=""xs:int"" />
                    <xs:element minOccurs=""0"" maxOccurs=""1"" name=""WI_Mitigation"" type=""xs:int"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:all>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public MFMWorkItemUpdate() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MFMWorkItemUpdate";
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
