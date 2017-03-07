namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER", typeof(global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocRequest", typeof(global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocRequest))]
    public sealed class Map_Loc_Query : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishRRMIAMIWORKORDER"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishRRMIAMIWORKORDER"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SERVICE&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;OPERATING&quot;)"" />
    <ns0:MiamiWsQueryLocRequest>
      <xsl:if test=""s0:RRMIAMIWORKORDERSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS1"">
        <BuildingClass1>
          <xsl:value-of select=""s0:RRMIAMIWORKORDERSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS1/text()"" />
        </BuildingClass1>
      </xsl:if>
      <xsl:if test=""s0:RRMIAMIWORKORDERSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS2"">
        <BuildingClass2>
          <xsl:value-of select=""s0:RRMIAMIWORKORDERSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS2/text()"" />
        </BuildingClass2>
      </xsl:if>
      <Type>
        <xsl:value-of select=""$var:v1"" />
      </Type>
      <Status>
        <xsl:value-of select=""$var:v2"" />
      </Status>
      <UniqueRecordsOnly>
        <xsl:text>false</xsl:text>
      </UniqueRecordsOnly>
      <MaxRows>
        <xsl:text>1</xsl:text>
      </MaxRows>
    </ns0:MiamiWsQueryLocRequest>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
        
        private const global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocRequest";
        
        private const global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocRequest";
                return _TrgSchemas;
            }
        }
    }
}
