namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.PollingTypedPolling_biz_Global_Export_Helpdesk_Cases+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.PollingTypedPolling_biz_Global_Export_Helpdesk_Cases.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Fetch_Case_DataSet", typeof(global::MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo.biz_Global_Fetch_Case_DataSet))]
    public sealed class ExtractedCaseId_To_GetCaseDetails : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet"" xmlns:ns5=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Reset_Case_Extract"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Remove_Case_From_Queue"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_Global_Export_Helpdesk_Cases"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPollingResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPollingResultSet0"">
    <ns0:biz_Global_Fetch_Case_DataSet>
      <xsl:if test=""s0:CASEID"">
        <xsl:variable name=""var:v1"" select=""string(s0:CASEID/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:id>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:id>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:id>
            <xsl:value-of select=""s0:CASEID/text()"" />
          </ns0:id>
        </xsl:if>
      </xsl:if>
    </ns0:biz_Global_Fetch_Case_DataSet>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.PollingTypedPolling_biz_Global_Export_Helpdesk_Cases+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.PollingTypedPolling_biz_Global_Export_Helpdesk_Cases.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Fetch_Case_DataSet";
        
        private const global::MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo.biz_Global_Fetch_Case_DataSet _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.PollingTypedPolling_biz_Global_Export_Helpdesk_Cases+TypedPollingResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Fetch_Case_DataSet";
                return _TrgSchemas;
            }
        }
    }
}
