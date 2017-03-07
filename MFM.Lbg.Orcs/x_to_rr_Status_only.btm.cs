namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class x_to_rr_Status_only : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:UpdateRRMIAMIWOUPDATE"" />
  </xsl:template>
  <xsl:template match=""/ns0:UpdateRRMIAMIWOUPDATE"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <xsl:if test=""@messageID"">
        <xsl:attribute name=""messageID"">
          <xsl:value-of select=""@messageID"" />
        </xsl:attribute>
      </xsl:if>
      <ns0:RRMIAMIWOUPDATESet>
        <xsl:for-each select=""ns0:RRMIAMIWOUPDATESet/ns0:WORKORDER"">
          <ns0:WORKORDER>
            <xsl:if test=""@transLanguage"">
              <xsl:attribute name=""transLanguage"">
                <xsl:value-of select=""@transLanguage"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@action"">
              <xsl:attribute name=""action"">
                <xsl:value-of select=""@action"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@relationship"">
              <xsl:attribute name=""relationship"">
                <xsl:value-of select=""@relationship"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""@deleteForInsert"">
              <xsl:attribute name=""deleteForInsert"">
                <xsl:value-of select=""@deleteForInsert"" />
              </xsl:attribute>
            </xsl:if>
            <xsl:if test=""ns0:MAXINTERRORMSG"">
              <ns0:MAXINTERRORMSG>
                <xsl:value-of select=""ns0:MAXINTERRORMSG/text()"" />
              </ns0:MAXINTERRORMSG>
            </xsl:if>
            <xsl:for-each select=""ns0:STATUS"">
              <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(./text()) , &quot;INPRG&quot;)"" />
              <xsl:variable name=""var:v2"" select=""string(./text())"" />
              <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq($var:v2 , &quot;COMP&quot;)"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:LogicalEq($var:v2 , &quot;CAN&quot;)"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq($var:v2 , &quot;REJECT&quot;)"" />
              <xsl:variable name=""var:v6"" select=""userCSharp:LogicalOr(string($var:v1) , string($var:v3) , string($var:v4) , string($var:v5))"" />
              <ns0:ACTFINISH>
                <xsl:if test=""string($var:v6)='true'"">
                  <xsl:variable name=""var:v7"" select=""../ns0:ACTFINISH/text()"" />
                  <xsl:value-of select=""$var:v7"" />
                </xsl:if>
              </ns0:ACTFINISH>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUS"">
              <xsl:variable name=""var:v8"" select=""string(./text())"" />
              <xsl:variable name=""var:v9"" select=""userCSharp:LogicalEq($var:v8 , &quot;INPRG&quot;)"" />
              <xsl:variable name=""var:v10"" select=""userCSharp:LogicalEq($var:v8 , &quot;COMP&quot;)"" />
              <xsl:variable name=""var:v11"" select=""userCSharp:LogicalEq($var:v8 , &quot;CAN&quot;)"" />
              <xsl:variable name=""var:v12"" select=""userCSharp:LogicalEq($var:v8 , &quot;REJECT&quot;)"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:LogicalOr(string($var:v9) , string($var:v10) , string($var:v11) , string($var:v12))"" />
              <ns0:ACTSTART>
                <xsl:if test=""../ns0:ACTSTART/@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""../ns0:ACTSTART/@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""string($var:v13)='true'"">
                  <xsl:variable name=""var:v14"" select=""../ns0:ACTSTART/text()"" />
                  <xsl:value-of select=""$var:v14"" />
                </xsl:if>
              </ns0:ACTSTART>
            </xsl:for-each>
            <xsl:for-each select=""ns0:MTFMWONUM"">
              <ns0:MTFMWONUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMWONUM>
            </xsl:for-each>
            <xsl:for-each select=""ns0:NP_STATUSMEMO"">
              <ns0:NP_STATUSMEMO>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:NP_STATUSMEMO>
            </xsl:for-each>
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:STATUS"">
              <ns0:STATUS>
                <xsl:if test=""@maxvalue"">
                  <xsl:attribute name=""maxvalue"">
                    <xsl:value-of select=""@maxvalue"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:STATUS>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:if test=""@changed"">
                  <xsl:attribute name=""changed"">
                    <xsl:value-of select=""@changed"" />
                  </xsl:attribute>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
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


public bool LogicalOr(string param0, string param1, string param2, string param3)
{
	return ValToBool(param0) || ValToBool(param1) || ValToBool(param2) || ValToBool(param3);
	return false;
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
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
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
