namespace MFM.Lbg.Orcs.LocQuery {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryRequest", typeof(global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryResponse", typeof(global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryResponse))]
    public sealed class InvalidProviderResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Orcs.PortalLocationQuery"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PortalLocQueryRequest"" />
  </xsl:template>
  <xsl:template match=""/ns0:PortalLocQueryRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;-1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;'&quot; , string(Provider/text()) , &quot;' verb is not recognised as a valid destination&quot;)"" />
    <ns0:PortalLocQueryResponse>
      <Result>
        <Code>
          <xsl:value-of select=""$var:v1"" />
        </Code>
        <Message>
          <xsl:value-of select=""$var:v2"" />
        </Message>
      </Result>
      <xsl:value-of select=""./text()"" />
    </ns0:PortalLocQueryResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryRequest";
        
        private const global::MFM.Lbg.Orcs.LocQuery.PortalLocationQuery.PortalLocQueryRequest _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Orcs.LocQuery.PortalLocationQuery+PortalLocQueryRequest";
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
