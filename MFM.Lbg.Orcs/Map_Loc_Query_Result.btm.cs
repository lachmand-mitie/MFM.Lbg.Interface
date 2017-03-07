namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse", typeof(global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocResponse))]
    public sealed class Map_Loc_Query_Result : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:s0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryMXVISIONLOCQUERYResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryMXVISIONLOCQUERYResponse"">
    <ns0:MiamiWsQueryLocResponse>
      <xsl:if test=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:LOCATION"">
        <Location>
          <xsl:value-of select=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:LOCATION/text()"" />
        </Location>
      </xsl:if>
      <xsl:if test=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:SITEID"">
        <SiteId>
          <xsl:value-of select=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:SITEID/text()"" />
        </SiteId>
      </xsl:if>
      <xsl:if test=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:ORGID"">
        <OrgId>
          <xsl:value-of select=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS/s0:ORGID/text()"" />
        </OrgId>
      </xsl:if>
    </ns0:MiamiWsQueryLocResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
        
        private const global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse";
        
        private const global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse";
                return _TrgSchemas;
            }
        }
    }
}
