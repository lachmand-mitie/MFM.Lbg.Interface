namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.biz_Order_get_PendingProcedureResultSet_dbo_biz_PO_Get_Pending+StoredProcedureResultSet0", typeof(global::MFM.Lbg.Schemas.biz_Order_get_PendingProcedureResultSet_dbo_biz_PO_Get_Pending.StoredProcedureResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending.TypedPollingResultSet0))]
    public sealed class map_To_Legacy_POIN : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/dbo.biz_PO_Get_Pending"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_PO_Get_Pending"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:StoredProcedureResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:StoredProcedureResultSet0"">
    <ns0:TypedPollingResultSet0>
      <xsl:if test=""s0:IDOCTYPE"">
        <xsl:variable name=""var:v1"" select=""string(s0:IDOCTYPE/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:IDOCTYPE>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:IDOCTYPE>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:IDOCTYPE>
            <xsl:value-of select=""s0:IDOCTYPE/text()"" />
          </ns0:IDOCTYPE>
        </xsl:if>
      </xsl:if>
      <xsl:if test=""s0:POREF"">
        <xsl:variable name=""var:v2"" select=""string(s0:POREF/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v2)='true'"">
          <ns0:POREF>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:POREF>
        </xsl:if>
        <xsl:if test=""string($var:v2)='false'"">
          <ns0:POREF>
            <xsl:value-of select=""s0:POREF/text()"" />
          </ns0:POREF>
        </xsl:if>
      </xsl:if>
    </ns0:TypedPollingResultSet0>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.biz_Order_get_PendingProcedureResultSet_dbo_biz_PO_Get_Pending+StoredProcedureResultSet0";
        
        private const global::MFM.Lbg.Schemas.biz_Order_get_PendingProcedureResultSet_dbo_biz_PO_Get_Pending.StoredProcedureResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending.TypedPollingResultSet0 _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.biz_Order_get_PendingProcedureResultSet_dbo_biz_PO_Get_Pending+StoredProcedureResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.PollingTypedPolling_dbo_biz_PO_Get_Pending+TypedPollingResultSet0";
                return _TrgSchemas;
            }
        }
    }
}
