namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0", typeof(global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates.StoredProcedureResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.TempMiamiWoUpd", typeof(global::MFM.Lbg.Schemas.TempMiamiWoUpd))]
    public sealed class x_to_upd_attributes : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s0 s1 ScriptNS0"" version=""1.0"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/ops/Biz_FetchPendingCaseUpdates"" xmlns:s1=""http://www.ibm.com/maximo"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""InputMessagePart_0/s1:QueryMXVISIONLOCQUERYResponse/s1:MXVISIONLOCQUERYSet/s1:LOCATIONS/s1:SITEID[1]/text()"" />
    <TempMiamiWoUpd>
      <xsl:if test=""InputMessagePart_1/s0:StoredProcedureResultSet0/s0:case_foreignsysid"">
        <attribute01>
          <xsl:value-of select=""InputMessagePart_1/s0:StoredProcedureResultSet0/s0:case_foreignsysid/text()"" />
        </attribute01>
      </xsl:if>
      <attribute02>
        <xsl:value-of select=""$var:v1"" />
      </attribute02>
      <xsl:variable name=""var:v2"" select=""ScriptNS0:GetMiamiFriendlyDateTimeString(string(InputMessagePart_1/s0:StoredProcedureResultSet0/s0:case_cp_attend/text()))"" />
      <attribute03>
        <xsl:value-of select=""$var:v2"" />
      </attribute03>
      <xsl:variable name=""var:v3"" select=""ScriptNS0:GetMiamiFriendlyDateTimeString(string(InputMessagePart_1/s0:StoredProcedureResultSet0/s0:case_cp_complete/text()))"" />
      <attribute04>
        <xsl:value-of select=""$var:v3"" />
      </attribute04>
    </TempMiamiWoUpd>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.MaximoHelper"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
        
        private const global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0";
        
        private const global::MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates.StoredProcedureResultSet0 _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.TempMiamiWoUpd";
        
        private const global::MFM.Lbg.Schemas.TempMiamiWoUpd _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
                _SrcSchemas[1] = @"MFM.Lbg.Schemas.Biz_FetchPendingCaseUpdatesProcedureResultSet_ops_Biz_FetchPendingCaseUpdates+StoredProcedureResultSet0";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.TempMiamiWoUpd";
                return _TrgSchemas;
            }
        }
    }
}
