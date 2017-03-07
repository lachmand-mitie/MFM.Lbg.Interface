namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class Map_Miami_RR_Upd : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PublishMTFMWODETAIL"" />
  </xsl:template>
  <xsl:template match=""/ns0:PublishMTFMWODETAIL"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <xsl:if test=""@messageID"">
        <xsl:attribute name=""messageID"">
          <xsl:value-of select=""@messageID"" />
        </xsl:attribute>
      </xsl:if>
      <ns0:RRMIAMIWOUPDATESet>
        <xsl:for-each select=""ns0:MTFMWODETAILSet/ns0:WORKORDER"">
          <ns0:WORKORDER>
            <xsl:attribute name=""action"">
              <xsl:text>Change</xsl:text>
            </xsl:attribute>
            <xsl:for-each select=""ns0:STATUS"">
              <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(./text()) , &quot;COMP&quot;)"" />
              <ns0:ACTFINISH>
                <xsl:if test=""string($var:v1)='true'"">
                  <xsl:variable name=""var:v2"" select=""../ns0:ACTFINISH/text()"" />
                  <xsl:value-of select=""$var:v2"" />
                </xsl:if>
              </ns0:ACTFINISH>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUS"">
              <xsl:variable name=""var:v3"" select=""string(./text())"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v3 , &quot;INPRG&quot;)"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v3 , &quot;COMP&quot;)"" />
              <ns0:ACTSTART>
                <xsl:if test=""string($var:v4)='true'"">
                  <xsl:variable name=""var:v5"" select=""../ns0:ACTSTART/text()"" />
                  <xsl:value-of select=""$var:v5"" />
                </xsl:if>
                <xsl:if test=""string($var:v6)='true'"">
                  <xsl:variable name=""var:v7"" select=""../ns0:ACTSTART/text()"" />
                  <xsl:value-of select=""$var:v7"" />
                </xsl:if>
              </ns0:ACTSTART>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:MTFMWONUM>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMWONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUS"">
              <xsl:variable name=""var:v8"" select=""string(./text())"" />
              <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;MiAMI Status: &quot; , $var:v8)"" />
              <ns0:NP_STATUSMEMO>
                <xsl:value-of select=""$var:v9"" />
              </ns0:NP_STATUSMEMO>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WOLO3"">
              <ns0:SITEID>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUS"">
              <xsl:variable name=""var:v10"" select=""string(./text())"" />
              <xsl:variable name=""var:v11"" select=""userCSharp:LogicalEq($var:v10 , &quot;INPRG&quot;)"" />
              <xsl:variable name=""var:v12"" select=""userCSharp:LogicalEq($var:v10 , &quot;COMP&quot;)"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:LogicalOr(string($var:v11) , string($var:v12))"" />
              <xsl:if test=""$var:v13"">
                <ns0:STATUS>
                  <xsl:if test=""string($var:v13)='true'"">
                    <xsl:variable name=""var:v14"" select=""./text()"" />
                    <xsl:variable name=""var:v15"" select=""userCSharp:LogicalEq(string($var:v14) , &quot;REJECT&quot;)"" />
                    <xsl:if test=""string($var:v15)='true'"">
                      <xsl:variable name=""var:v16"" select=""&quot;CAN&quot;"" />
                      <xsl:value-of select=""$var:v16"" />
                    </xsl:if>
                  </xsl:if>
                  <xsl:if test=""string($var:v13)='true'"">
                    <xsl:variable name=""var:v17"" select=""./text()"" />
                    <xsl:variable name=""var:v18"" select=""userCSharp:LogicalNe(string($var:v17) , &quot;REJECT&quot;)"" />
                    <xsl:if test=""string($var:v13)='true'"">
                      <xsl:if test=""string($var:v18)='true'"">
                        <xsl:variable name=""var:v19"" select=""string($var:v17)"" />
                        <xsl:value-of select=""$var:v19"" />
                      </xsl:if>
                    </xsl:if>
                  </xsl:if>
                </ns0:STATUS>
              </xsl:if>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMCLIENTREF"">
              <ns0:WONUM>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WORKLOG"">
              <xsl:variable name=""var:v20"" select=""position()"" />
              <xsl:variable name=""var:v22"" select=""userCSharp:StringConcat(string(ns0:DESCRIPTION_LONGDESCRIPTION/text()) , &quot;[ Created By: &quot; , string(ns0:CREATEBY/text()) , &quot;, Modified By: &quot; , string(ns0:MODIFYBY/text()) , &quot; ]&quot; , &quot;MIAMI WORKLOG: &quot; , string(ns0:WORKLOGID/text()))"" />
              <ns0:WORKLOG>
                <ns0:CLASS>
                  <xsl:text>WORKORDER</xsl:text>
                </ns0:CLASS>
                <ns0:CREATEBY>
                  <xsl:variable name=""var:v21"" select=""ScriptNS0:RrAdminUser()"" />
                  <xsl:value-of select=""$var:v21"" />
                </ns0:CREATEBY>
                <xsl:for-each select=""ns0:CREATEDATE"">
                  <ns0:CREATEDATE>
                    <xsl:value-of select=""./text()"" />
                  </ns0:CREATEDATE>
                </xsl:for-each>
                <xsl:for-each select=""ns0:DESCRIPTION"">
                  <ns0:DESCRIPTION>
                    <xsl:value-of select=""./text()"" />
                  </ns0:DESCRIPTION>
                </xsl:for-each>
                <ns0:DESCRIPTION_LONGDESCRIPTION>
                  <xsl:variable name=""var:v23"" select=""ScriptNS0:StripFormatting(string($var:v22))"" />
                  <xsl:value-of select=""$var:v23"" />
                </ns0:DESCRIPTION_LONGDESCRIPTION>
                <ns0:LOGTYPE>
                  <xsl:text>CLIENTNOTE</xsl:text>
                </ns0:LOGTYPE>
                <ns0:MODIFYBY>
                  <xsl:variable name=""var:v24"" select=""ScriptNS0:RrAdminUser()"" />
                  <xsl:value-of select=""$var:v24"" />
                </ns0:MODIFYBY>
                <ns0:MODIFYDATE>
                  <xsl:variable name=""var:v25"" select=""ScriptNS0:rrSecondsShifter(string($var:v20) , string(ns0:MODIFYDATE/text()))"" />
                  <xsl:value-of select=""$var:v25"" />
                </ns0:MODIFYDATE>
                <xsl:for-each select=""../ns0:MTFMCLIENTREF"">
                  <ns0:RECORDKEY>
                    <xsl:value-of select=""./text()"" />
                  </ns0:RECORDKEY>
                </xsl:for-each>
                <xsl:value-of select=""./text()"" />
              </ns0:WORKLOG>
            </xsl:for-each>
            <xsl:value-of select=""./text()"" />
          </ns0:WORKORDER>
        </xsl:for-each>
      </ns0:RRMIAMIWOUPDATESet>
    </ns0:UpdateRRMIAMIWOUPDATE>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public bool LogicalOr(string param0, string param1)
{
	return ValToBool(param0) || ValToBool(param1);
	return false;
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
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

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
        
        private const global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
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
