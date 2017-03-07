namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER", typeof(global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiAMIWOQueryResponse", typeof(global::MFM.Lbg.Schemas.MiAMIWOQueryResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class x_to_1team_wl_ref_exists : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;The 1TEAM Workorder &quot; , string(InputMessagePart_1/MiAMIWOQueryResponseV1/WONUM/text()) , &quot; exists in MIAMI on reference &quot; , string(InputMessagePart_1/MiAMIWOQueryResponseV1/MTFMCLIENTREF/text()))"" />
    <ns0:UpdateRRMIAMIWOUPDATE>
      <ns0:RRMIAMIWOUPDATESet>
        <ns0:WORKORDER>
          <xsl:attribute name=""action"">
            <xsl:text>Change</xsl:text>
          </xsl:attribute>
          <xsl:for-each select=""InputMessagePart_0/ns0:PublishRRMIAMIWORKORDER/ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""InputMessagePart_0/ns0:PublishRRMIAMIWORKORDER/ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:WORKLOG>
            <ns0:CLASS>
              <xsl:text>WORKORDER</xsl:text>
            </ns0:CLASS>
            <ns0:CREATEBY>
              <xsl:variable name=""var:v1"" select=""ScriptNS0:RrAdminUser()"" />
              <xsl:value-of select=""$var:v1"" />
            </ns0:CREATEBY>
            <ns0:CREATEDATE>
              <xsl:value-of select=""$var:v2"" />
            </ns0:CREATEDATE>
            <ns0:DESCRIPTION>
              <xsl:text>Job already exists in MiAMI</xsl:text>
            </ns0:DESCRIPTION>
            <ns0:DESCRIPTION_LONGDESCRIPTION>
              <xsl:value-of select=""$var:v3"" />
            </ns0:DESCRIPTION_LONGDESCRIPTION>
            <ns0:LOGTYPE>
              <xsl:text>CLIENTNOTE</xsl:text>
            </ns0:LOGTYPE>
            <ns0:MODIFYBY>
              <xsl:variable name=""var:v4"" select=""ScriptNS0:RrAdminUser()"" />
              <xsl:value-of select=""$var:v4"" />
            </ns0:MODIFYBY>
            <ns0:MODIFYDATE>
              <xsl:value-of select=""$var:v2"" />
            </ns0:MODIFYDATE>
            <xsl:for-each select=""InputMessagePart_0/ns0:PublishRRMIAMIWORKORDER/ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
              <xsl:for-each select=""ns0:WONUM"">
                <ns0:RECORDKEY>
                  <xsl:value-of select=""./text()"" />
                </ns0:RECORDKEY>
              </xsl:for-each>
            </xsl:for-each>
          </ns0:WORKLOG>
        </ns0:WORKORDER>
      </ns0:RRMIAMIWOUPDATESet>
    </ns0:UpdateRRMIAMIWOUPDATE>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
        
        private const global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Schemas.MiAMIWOQueryResponse";
        
        private const global::MFM.Lbg.Schemas.MiAMIWOQueryResponse _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
                _SrcSchemas[1] = @"MFM.Lbg.Schemas.MiAMIWOQueryResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
                return _TrgSchemas;
            }
        }
    }
}
