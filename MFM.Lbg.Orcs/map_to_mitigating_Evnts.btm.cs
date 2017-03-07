namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo+Biz_Import_Case_UpdateResponse", typeof(global::MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo.Biz_Import_Case_UpdateResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Load_many_notes+Request", typeof(global::MFM.Lbg.Schemas.Load_many_notes.Request))]
    public sealed class map_to_mitigating_Evnts : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 ScriptNS0"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Biz_Import_Case_Update"" xmlns:ns1=""http://MFM.Lbg.Schemas.Load_many_notes"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns2=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/Biz_Import_Case_Note"" xmlns:s0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns1:Request>
      <xsl:for-each select=""InputMessagePart_0/s0:MFMWorkItemUpdate/WI_MitigationNotes"">
        <xsl:for-each select=""WI_MitEvnt"">
          <ns0:Biz_Import_Case_Note>
            <xsl:if test=""../../../../InputMessagePart_1/ns0:Biz_Import_Case_UpdateResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:MessageId"">
              <xsl:variable name=""var:v1"" select=""string(../../../../InputMessagePart_1/ns0:Biz_Import_Case_UpdateResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:MessageId/@xsi:nil) = 'true'"" />
              <xsl:if test=""string($var:v1)='true'"">
                <ns0:Messageid>
                  <xsl:attribute name=""xsi:nil"">
                    <xsl:value-of select=""'true'"" />
                  </xsl:attribute>
                </ns0:Messageid>
              </xsl:if>
              <xsl:if test=""string($var:v1)='false'"">
                <ns0:Messageid>
                  <xsl:value-of select=""../../../../InputMessagePart_1/ns0:Biz_Import_Case_UpdateResponse/ns0:StoredProcedureResultSet0/ns3:StoredProcedureResultSet0/ns3:MessageId/text()"" />
                </ns0:Messageid>
              </xsl:if>
            </xsl:if>
            <xsl:if test=""WI_Noteid"">
              <ns0:SourceSystemNoteRef>
                <xsl:value-of select=""WI_Noteid/text()"" />
              </ns0:SourceSystemNoteRef>
            </xsl:if>
            <xsl:if test=""WI_NoteTS"">
              <ns0:NoteTs>
                <xsl:value-of select=""WI_NoteTS/text()"" />
              </ns0:NoteTs>
            </xsl:if>
            <xsl:variable name=""var:v2"" select=""ScriptNS0:StripFormatting(string(WI_NoteText/text()))"" />
            <ns0:NoteText>
              <xsl:value-of select=""$var:v2"" />
            </ns0:NoteText>
            <xsl:if test=""WI_CreatedBy"">
              <ns0:NoteBy>
                <xsl:value-of select=""WI_CreatedBy/text()"" />
              </ns0:NoteBy>
            </xsl:if>
          </ns0:Biz_Import_Case_Note>
        </xsl:for-each>
      </xsl:for-each>
    </ns1:Request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo+Biz_Import_Case_UpdateResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo.Biz_Import_Case_UpdateResponse _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.Load_many_notes+Request";
        
        private const global::MFM.Lbg.Schemas.Load_many_notes.Request _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
                _SrcSchemas[1] = @"MFM.Lbg.Schemas.VFM_UPDTypedProcedure_dbo+Biz_Import_Case_UpdateResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.Load_many_notes+Request";
                return _TrgSchemas;
            }
        }
    }
}
