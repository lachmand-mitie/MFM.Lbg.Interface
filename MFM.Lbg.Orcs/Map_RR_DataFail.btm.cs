namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER", typeof(global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class Map_RR_DataFail : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var ScriptNS0 userCSharp"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PublishRRMIAMIWORKORDER"" />
  </xsl:template>
  <xsl:template match=""/ns0:PublishRRMIAMIWORKORDER"">
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;MiAMI building class must exist on the 1TEAM Maximo location before it can be sent to MiAMI.&quot;)"" />
    <ns0:UpdateRRMIAMIWOUPDATE>
      <ns0:RRMIAMIWOUPDATESet>
        <ns0:WORKORDER>
          <xsl:attribute name=""action"">
            <xsl:text>Change</xsl:text>
          </xsl:attribute>
          <ns0:NP_STATUSMEMO>
            <xsl:text>Location building class missing</xsl:text>
          </ns0:NP_STATUSMEMO>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
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
              <xsl:text>Building Class Error</xsl:text>
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
            <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
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


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
        
        private const global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
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
