namespace MFM.Lbg.Orcs.LocQuery {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryRequest", typeof(global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo+QueryMXVISIONLOCQUERY", typeof(global::MFM.Lbg.Orcs.GenItems.MTFMVISIONFM_MTFMVISIONLOCQUERY_www_ibm_com_maximo.QueryMXVISIONLOCQUERY))]
    public sealed class CreatePrtlLocQuery : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Orcs.PortalLocationQuery"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PortalLocQueryRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:PortalLocQueryRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringUpperCase(string(Contract/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;TYPE = 'BUILDING' AND STATUS != 'DECOMMISSIONED' AND DISABLED=0 AND DESCRIPTION LIKE '%&quot; , string($var:v1) , &quot;%'&quot;)"" />
    <ns0:QueryMXVISIONLOCQUERY>
      <xsl:attribute name=""uniqueResult"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""maxItems"">
        <xsl:text>50</xsl:text>
      </xsl:attribute>
      <xsl:attribute name=""rsStart"">
        <xsl:text>0</xsl:text>
      </xsl:attribute>
      <ns0:MXVISIONLOCQUERYQuery>
        <xsl:attribute name=""operandMode"">
          <xsl:text>AND</xsl:text>
        </xsl:attribute>
        <ns0:WHERE>
          <xsl:value-of select=""$var:v2"" />
        </ns0:WHERE>
        <xsl:value-of select=""./text()"" />
      </ns0:MXVISIONLOCQUERYQuery>
    </ns0:QueryMXVISIONLOCQUERY>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryRequest";
        
        private const global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryRequest _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryRequest";
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
