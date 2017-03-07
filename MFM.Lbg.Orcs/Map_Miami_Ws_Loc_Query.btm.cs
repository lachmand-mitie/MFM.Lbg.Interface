namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocRequest", typeof(global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY))]
    public sealed class Map_Miami_Ws_Loc_Query : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:ns0=""http://www.ibm.com/maximo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MiamiWsQueryLocRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:MiamiWsQueryLocRequest"">
    <ns0:QueryMXVISIONLOCQUERY>
      <xsl:if test=""UniqueRecordsOnly"">
        <xsl:attribute name=""uniqueResult"">
          <xsl:value-of select=""UniqueRecordsOnly/text()"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:if test=""MaxRows"">
        <xsl:attribute name=""maxItems"">
          <xsl:value-of select=""MaxRows/text()"" />
        </xsl:attribute>
      </xsl:if>
      <xsl:attribute name=""rsStart"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <ns0:MXVISIONLOCQUERYQuery>
        <xsl:attribute name=""operandMode"">
          <xsl:text>AND</xsl:text>
        </xsl:attribute>
        <ns0:LOCATIONS>
          <ns0:MTFMBLDGCLASS1>
            <xsl:value-of select=""BuildingClass1/text()"" />
          </ns0:MTFMBLDGCLASS1>
          <ns0:MTFMBLDGCLASS2>
            <xsl:value-of select=""BuildingClass2/text()"" />
          </ns0:MTFMBLDGCLASS2>
          <ns0:STATUS>
            <xsl:value-of select=""Status/text()"" />
          </ns0:STATUS>
          <ns0:TYPE>
            <xsl:value-of select=""Type/text()"" />
          </ns0:TYPE>
        </ns0:LOCATIONS>
        <xsl:value-of select=""./text()"" />
      </ns0:MXVISIONLOCQUERYQuery>
    </ns0:QueryMXVISIONLOCQUERY>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocRequest";
        
        private const global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocRequest _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocRequest";
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
