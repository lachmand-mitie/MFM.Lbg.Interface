namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0", typeof(global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates.StoredProcedureResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Biz_ClosePendingCaseUpdateTypedProcedure_ops+Biz_ClosePendingCaseUpdate", typeof(global::MFM.Lbg.Schemas.Biz_ClosePendingCaseUpdateTypedProcedure_ops.Biz_ClosePendingCaseUpdate))]
    public sealed class x_to_closePendingUpd : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/ops"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:StoredProcedureResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:StoredProcedureResultSet0"">
    <ns0:Biz_ClosePendingCaseUpdate>
      <xsl:if test=""s0:id"">
        <xsl:variable name=""var:v1"" select=""string(s0:id/@xsi:nil) = 'true'"" />
        <xsl:if test=""string($var:v1)='true'"">
          <ns0:id>
            <xsl:attribute name=""xsi:nil"">
              <xsl:value-of select=""'true'"" />
            </xsl:attribute>
          </ns0:id>
        </xsl:if>
        <xsl:if test=""string($var:v1)='false'"">
          <ns0:id>
            <xsl:value-of select=""s0:id/text()"" />
          </ns0:id>
        </xsl:if>
      </xsl:if>
      <ns0:status>
        <xsl:text>2</xsl:text>
      </ns0:status>
    </ns0:Biz_ClosePendingCaseUpdate>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0";
        
        private const global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates.StoredProcedureResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.Biz_ClosePendingCaseUpdateTypedProcedure_ops+Biz_ClosePendingCaseUpdate";
        
        private const global::MFM.Lbg.Schemas.Biz_ClosePendingCaseUpdateTypedProcedure_ops.Biz_ClosePendingCaseUpdate _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.Biz_ClosePendingCaseUpdateTypedProcedure_ops+Biz_ClosePendingCaseUpdate";
                return _TrgSchemas;
            }
        }
    }
}
