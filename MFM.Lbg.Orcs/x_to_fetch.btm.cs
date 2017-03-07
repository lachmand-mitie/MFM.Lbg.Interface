namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Biz_GetCaseUpdatesPollingTypedPolling_Biz_GetCaseUpdatesPolling+TypedPolling", typeof(global::MFM.Lbg.Schemas.Biz_GetCaseUpdatesPollingTypedPolling_Biz_GetCaseUpdatesPolling.TypedPolling))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesTypedProcedure_ops+Biz_FetchPendingCaseUpdates", typeof(global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesTypedProcedure_ops.Biz_FetchPendingCaseUpdates))]
    public sealed class x_to_fetch : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/ops"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/Biz_GetCaseUpdatesPolling"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPolling"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPolling"">
    <ns0:Biz_FetchPendingCaseUpdates>
      <xsl:value-of select=""./text()"" />
    </ns0:Biz_FetchPendingCaseUpdates>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.Biz_GetCaseUpdatesPollingTypedPolling_Biz_GetCaseUpdatesPolling+TypedPolling";
        
        private const global::MFM.Lbg.Schemas.Biz_GetCaseUpdatesPollingTypedPolling_Biz_GetCaseUpdatesPolling.TypedPolling _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesTypedProcedure_ops+Biz_FetchPendingCaseUpdates";
        
        private const global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesTypedProcedure_ops.Biz_FetchPendingCaseUpdates _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.Biz_GetCaseUpdatesPollingTypedPolling_Biz_GetCaseUpdatesPolling+TypedPolling";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesTypedProcedure_ops+Biz_FetchPendingCaseUpdates";
                return _TrgSchemas;
            }
        }
    }
}
