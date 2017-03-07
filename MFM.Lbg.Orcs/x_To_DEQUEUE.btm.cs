namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo+biz_PO_Set_Exported", typeof(global::MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo.biz_PO_Set_Exported))]
    public sealed class x_To_DEQUEUE : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/dbo.biz_PO_Get_Pending"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_PO_Get_DataSet"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPollingResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPollingResultSet0"">
    <ns0:biz_PO_Set_Exported>
      <xsl:if test=""s0:POREF"">
        <xsl:variable name=""var:v1"" select=""string(s0:POREF/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:POREF>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:POREF>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:POREF>
            <xsl:value-of select=""s0:POREF/text()"" />
          </ns0:POREF>
        </xsl:if>
      </xsl:if>
      <ns0:STAGE>
        <xsl:text>2</xsl:text>
      </ns0:STAGE>
    </ns0:biz_PO_Set_Exported>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo+biz_PO_Set_Exported";
        
        private const global::MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo.biz_PO_Set_Exported _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending+TypedPollingResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_POTypedProcedure_dbo+biz_PO_Set_Exported";
                return _TrgSchemas;
            }
        }
    }
}
