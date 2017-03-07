namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.TypedPollingTypedPolling_biz_SO_Get_Pending+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.TypedPollingTypedPolling_biz_SO_Get_Pending.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSet", typeof(global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_DataSet))]
    public sealed class map_to_get_so_items : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_SO_Get_Pending"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_DataSet"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_SO_Get_Header"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPollingResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPollingResultSet0"">
    <ns0:biz_SO_Get_DataSet>
      <xsl:if test=""s0:SOREF"">
        <xsl:variable name=""var:v1"" select=""string(s0:SOREF/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:SOREF>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:SOREF>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:SOREF>
            <xsl:value-of select=""s0:SOREF/text()"" />
          </ns0:SOREF>
        </xsl:if>
      </xsl:if>
    </ns0:biz_SO_Get_DataSet>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.TypedPollingTypedPolling_biz_SO_Get_Pending+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.TypedPollingTypedPolling_biz_SO_Get_Pending.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSet";
        
        private const global::MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo.biz_SO_Get_DataSet _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.TypedPollingTypedPolling_biz_SO_Get_Pending+TypedPollingResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_SOTypedProcedure_dbo+biz_SO_Get_DataSet";
                return _TrgSchemas;
            }
        }
    }
}
