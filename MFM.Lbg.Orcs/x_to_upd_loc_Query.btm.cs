namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0", typeof(global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates.StoredProcedureResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY))]
    public sealed class x_to_upd_loc_Query : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates"" xmlns:ns0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:StoredProcedureResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:StoredProcedureResultSet0"">
    <ns0:QueryMXVISIONLOCQUERY>
      <xsl:attribute name=""uniqueResult"">
        <xsl:text>1</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""maxItems"">
        <xsl:text>1</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""rsStart"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <ns0:MXVISIONLOCQUERYQuery>
        <xsl:attribute name=""operandMode"">
          <xsl:text>AND</xsl:text>
        </xsl:attribute>
        <ns0:LOCATIONS>
          <ns0:MTFMBLDGCLASS1>
            <xsl:attribute name=""operator"">
              <xsl:text>=</xsl:text>
            </xsl:attribute>
            <xsl:if test=""s0:case_buildingclass1"">
              <xsl:value-of select=""s0:case_buildingclass1/text()"" />
            </xsl:if>
          </ns0:MTFMBLDGCLASS1>
          <ns0:MTFMBLDGCLASS2>
            <xsl:attribute name=""operator"">
              <xsl:text>=</xsl:text>
            </xsl:attribute>
            <xsl:if test=""s0:case_buildingclass2"">
              <xsl:value-of select=""s0:case_buildingclass2/text()"" />
            </xsl:if>
          </ns0:MTFMBLDGCLASS2>
          <ns0:TYPE>
            <xsl:text>SERVICE</xsl:text>
          </ns0:TYPE>
        </ns0:LOCATIONS>
      </ns0:MXVISIONLOCQUERYQuery>
    </ns0:QueryMXVISIONLOCQUERY>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0";
        
        private const global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates.StoredProcedureResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY";
        
        private const global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY";
                return _TrgSchemas;
            }
        }
    }
}
