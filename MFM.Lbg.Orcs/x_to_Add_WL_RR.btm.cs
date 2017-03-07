namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOLOGSService+PublishMTFMWOLOGS", typeof(global::MFM.Lbg.Schemas.MTFMWOLOGSService.PublishMTFMWOLOGS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class x_to_Add_WL_RR : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var ScriptNS0 userCSharp"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PublishMTFMWOLOGS"" />
  </xsl:template>
  <xsl:template match=""/ns0:PublishMTFMWOLOGS"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <xsl:if test=""@messageID"">
        <xsl:attribute name=""messageID"">
          <xsl:value-of select=""@messageID"" />
        </xsl:attribute>
      </xsl:if>
      <ns0:RRMIAMIWOUPDATESet>
        <ns0:WORKORDER>
          <xsl:attribute name=""action"">
            <xsl:text>Change</xsl:text>
          </xsl:attribute>
          <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
            <xsl:for-each select=""ns0:WORKORDER"">
              <xsl:for-each select=""ns0:WOLO3"">
                <ns0:SITEID>
                  <xsl:value-of select=""./text()"" />
                </ns0:SITEID>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
            <xsl:for-each select=""ns0:WORKORDER"">
              <xsl:for-each select=""ns0:MTFMCLIENTREF"">
                <ns0:WONUM>
                  <xsl:value-of select=""./text()"" />
                </ns0:WONUM>
              </xsl:for-each>
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
            <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
              <xsl:for-each select=""ns0:CREATEDATE"">
                <ns0:CREATEDATE>
                  <xsl:value-of select=""./text()"" />
                </ns0:CREATEDATE>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
              <xsl:for-each select=""ns0:DESCRIPTION"">
                <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(string(./text()))"" />
                <xsl:variable name=""var:v3"" select=""userCSharp:StringLeft(string($var:v2) , &quot;100&quot;)"" />
                <ns0:DESCRIPTION>
                  <xsl:value-of select=""$var:v3"" />
                </ns0:DESCRIPTION>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
              <xsl:for-each select=""ns0:DESCRIPTION_LONGDESCRIPTION"">
                <xsl:variable name=""var:v4"" select=""string(./text())"" />
                <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat($var:v4 , string(../ns0:CREATEBY/text()) , &quot;[ Created By: &quot; , &quot;, Modified By: &quot; , string(../ns0:MODIFYBY/text()) , &quot; ]&quot; , &quot;MIAMI WORKLOG: &quot; , string(../ns0:WORKLOGID/text()))"" />
                <ns0:DESCRIPTION_LONGDESCRIPTION>
                  <xsl:variable name=""var:v6"" select=""ScriptNS0:StripFormatting(string($var:v5))"" />
                  <xsl:value-of select=""$var:v6"" />
                </ns0:DESCRIPTION_LONGDESCRIPTION>
              </xsl:for-each>
            </xsl:for-each>
            <ns0:LOGTYPE>
              <xsl:text>CLIENTNOTE</xsl:text>
            </ns0:LOGTYPE>
            <ns0:MODIFYBY>
              <xsl:variable name=""var:v7"" select=""ScriptNS0:RrAdminUser()"" />
              <xsl:value-of select=""$var:v7"" />
            </ns0:MODIFYBY>
            <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
              <xsl:for-each select=""ns0:MODIFYDATE"">
                <ns0:MODIFYDATE>
                  <xsl:value-of select=""./text()"" />
                </ns0:MODIFYDATE>
              </xsl:for-each>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMWOLOGSSet/ns0:WORKLOG"">
              <xsl:for-each select=""ns0:WORKORDER"">
                <xsl:for-each select=""ns0:MTFMCLIENTREF"">
                  <ns0:RECORDKEY>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RECORDKEY>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
          </ns0:WORKLOG>
        </ns0:WORKORDER>
      </ns0:RRMIAMIWOUPDATESet>
      <xsl:value-of select=""./text()"" />
    </ns0:UpdateRRMIAMIWOUPDATE>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7;
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOLOGSService+PublishMTFMWOLOGS";
        
        private const global::MFM.Lbg.Schemas.MTFMWOLOGSService.PublishMTFMWOLOGS _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOLOGSService+PublishMTFMWOLOGS";
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
