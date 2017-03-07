namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiSoapError", typeof(global::MFM.Lbg.Schemas.MiamiSoapError))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse", typeof(global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocResponse))]
    public sealed class Loc_Err_Response : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""MFM.Lbg.Schemas/Soap/Erros/Miami/1_1"" xmlns:ns0=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MiamiSoapErorr_1_1"" />
  </xsl:template>
  <xsl:template match=""/s0:MiamiSoapErorr_1_1"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:MiamiWsQueryLocResponse>
      <Location>
        <xsl:value-of select=""$var:v1"" />
      </Location>
      <SiteId>
        <xsl:value-of select=""$var:v1"" />
      </SiteId>
      <OrgId>
        <xsl:value-of select=""$var:v1"" />
      </OrgId>
      <Fault>
        <FaultString>
          <xsl:value-of select=""faultString/text()"" />
        </FaultString>
      </Fault>
      <xsl:value-of select=""./text()"" />
    </ns0:MiamiWsQueryLocResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MiamiSoapError";
        
        private const global::MFM.Lbg.Schemas.MiamiSoapError _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MiamiSoapError";
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
