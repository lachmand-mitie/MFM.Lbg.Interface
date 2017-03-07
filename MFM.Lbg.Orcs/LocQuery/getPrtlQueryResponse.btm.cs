namespace MFM.Lbg.Orcs.LocQuery {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryResponse", typeof(global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryResponse))]
    public sealed class getPrtlQueryResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Orcs.PortalLocationQuery"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:QueryMXVISIONLOCQUERYResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:QueryMXVISIONLOCQUERYResponse"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;See results&quot;)"" />
    <ns0:PortalLocQueryResponse>
      <xsl:for-each select=""s0:MXVISIONLOCQUERYSet/s0:LOCATIONS"">
        <Location>
          <xsl:if test=""s0:DESCRIPTION"">
            <Name>
              <xsl:value-of select=""s0:DESCRIPTION/text()"" />
            </Name>
          </xsl:if>
          <xsl:if test=""s0:MTFMBLDGCLASS1"">
            <BuildingCode>
              <xsl:value-of select=""s0:MTFMBLDGCLASS1/text()"" />
            </BuildingCode>
          </xsl:if>
          <xsl:value-of select=""./text()"" />
        </Location>
      </xsl:for-each>
      <Result>
        <xsl:if test=""@rsTotal"">
          <Code>
            <xsl:value-of select=""@rsTotal"" />
          </Code>
        </xsl:if>
        <Message>
          <xsl:value-of select=""$var:v1"" />
        </Message>
      </Result>
      <xsl:value-of select=""s0:MXVISIONLOCQUERYSet/text()"" />
    </ns0:PortalLocQueryResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERYResponse";
        
        private const global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERYResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryResponse";
        
        private const global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryResponse _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryResponse";
                return _TrgSchemas;
            }
        }
    }
}
