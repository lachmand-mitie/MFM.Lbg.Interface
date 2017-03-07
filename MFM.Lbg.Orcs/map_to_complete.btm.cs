namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFEUPDCLIENTTypedProcedure_dbo+biz_Visit_Outbound_Completed", typeof(global::MFM.Lbg.Schemas.SAFEUPDCLIENTTypedProcedure_dbo.biz_Visit_Outbound_Completed))]
    public sealed class map_to_complete : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_Poll_Visit_Updates_MPC"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Visit_Outbound_Completed"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPollingResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPollingResultSet0"">
    <ns0:biz_Visit_Outbound_Completed>
      <xsl:if test=""s0:OutboundId"">
        <xsl:variable name=""var:v1"" select=""string(s0:OutboundId/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:ref>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:ref>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:ref>
            <xsl:value-of select=""s0:OutboundId/text()"" />
          </ns0:ref>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:VisitId"">
        <xsl:variable name=""var:v2"" select=""string(s0:VisitId/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v2)='true'"">
          <ns0:visit>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:visit>
        </xsl:if>
        <xsl:if test=""string($var:v2)='false'"">
          <ns0:visit>
            <xsl:value-of select=""s0:VisitId/text()"" />
          </ns0:visit>
        </xsl:if>
      </xsl:if>
    </ns0:biz_Visit_Outbound_Completed>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.SAFEUPDCLIENTTypedProcedure_dbo+biz_Visit_Outbound_Completed";
        
        private const global::MFM.Lbg.Schemas.SAFEUPDCLIENTTypedProcedure_dbo.biz_Visit_Outbound_Completed _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.SAFEUPDCLIENTTypedProcedure_dbo+biz_Visit_Outbound_Completed";
                return _TrgSchemas;
            }
        }
    }
}
