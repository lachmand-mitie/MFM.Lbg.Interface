namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.biz_SO_Get_PollingTypedPolling_biz_SO_Get_Polling+TypedPolling", typeof(global::MFM.Lbg.Schemas.biz_SO_Get_PollingTypedPolling_biz_SO_Get_Polling.TypedPolling))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.biz_Order_get_PendingTypedProcedure_dbo+biz_SO_Get_Pending", typeof(global::MFM.Lbg.Schemas.biz_Order_get_PendingTypedProcedure_dbo.biz_SO_Get_Pending))]
    public sealed class map_to_SO_Extract : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_PO_Get_Pending"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_Pending"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_SO_Get_Polling"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPolling"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPolling"">
    <ns0:biz_SO_Get_Pending>
      <xsl:value-of select=""./text()"" />
    </ns0:biz_SO_Get_Pending>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.biz_SO_Get_PollingTypedPolling_biz_SO_Get_Polling+TypedPolling";
        
        private const global::MFM.Lbg.Schemas.biz_SO_Get_PollingTypedPolling_biz_SO_Get_Polling.TypedPolling _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.biz_Order_get_PendingTypedProcedure_dbo+biz_SO_Get_Pending";
        
        private const global::MFM.Lbg.Schemas.biz_Order_get_PendingTypedProcedure_dbo.biz_SO_Get_Pending _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.biz_SO_Get_PollingTypedPolling_biz_SO_Get_Polling+TypedPolling";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.biz_Order_get_PendingTypedProcedure_dbo+biz_SO_Get_Pending";
                return _TrgSchemas;
            }
        }
    }
}
