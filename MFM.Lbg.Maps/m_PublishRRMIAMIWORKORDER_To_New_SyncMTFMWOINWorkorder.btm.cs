namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER", typeof(global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN", typeof(global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN))]
    public sealed class m_PublishRRMIAMIWORKORDER_To_New_SyncMTFMWOINWorkorder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:PublishRRMIAMIWORKORDER"" />
  </xsl:template>
  <xsl:template match=""/ns0:PublishRRMIAMIWORKORDER"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;Add&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;RR&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;ONETEAM&quot;)"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(&quot;MTFM&quot;)"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringConcat(&quot;RR-BizTalk&quot;)"" />
    <xsl:variable name=""var:v21"" select=""userCSharp:StringConcat(&quot;NSCT&quot;)"" />
    <xsl:variable name=""var:v44"" select=""userCSharp:StringConcat(&quot;WORKORDER&quot;)"" />
    <ns0:SyncMTFMWOIN>
      <ns0:MTFMWOINSet>
        <ns0:WORKORDER>
          <xsl:attribute name=""action"">
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:CLIENTREF>
                <xsl:value-of select=""./text()"" />
              </ns0:CLIENTREF>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:COMMODITY>
            <xsl:value-of select=""$var:v2"" />
          </ns0:COMMODITY>
          <ns0:COMMODITYGROUP>
            <xsl:value-of select=""$var:v3"" />
          </ns0:COMMODITYGROUP>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WONUM"">
              <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(string(./text()) , &quot;: &quot; , string(../ns0:DESCRIPTION/text()))"" />
              <xsl:variable name=""var:v5"" select=""userCSharp:StringLeft(string($var:v4) , &quot;100&quot;)"" />
              <ns0:DESCRIPTION>
                <xsl:value-of select=""$var:v5"" />
              </ns0:DESCRIPTION>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:LOCATIONS"">
              <xsl:for-each select=""ns0:LOCATION"">
                <xsl:variable name=""var:v6"" select=""string(./text())"" />
                <xsl:variable name=""var:v7"" select=""string(../ns0:DESCRIPTION/text())"" />
                <ns0:DESCRIPTION_LONGDESCRIPTION>
                  <xsl:variable name=""var:v8"" select=""ScriptNS0:rrLongDescription($var:v6 , $var:v7 , string(../../ns0:WORKTYPE/text()) , string(../../ns0:DESCRIPTION_LONGDESCRIPTION/text()) , string(../../ns0:ASSETNUM/text()) , string(../../ns0:PERSON/ns0:PRIMARYEMAIL/text()))"" />
                  <xsl:variable name=""var:v9"" select=""userCSharp:StringLeft(string($var:v8) , &quot;3988&quot;)"" />
                  <xsl:value-of select=""$var:v9"" />
                </ns0:DESCRIPTION_LONGDESCRIPTION>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:ISTASK>
            <xsl:value-of select=""$var:v10"" />
          </ns0:ISTASK>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WORKTYPE"">
              <xsl:variable name=""var:v11"" select=""string(./text())"" />
              <ns0:JPNUM>
                <xsl:variable name=""var:v12"" select=""ScriptNS0:translateRrWorkType($var:v11)"" />
                <xsl:variable name=""var:v13"" select=""userCSharp:LogicalEq(string($var:v12) , &quot;PM&quot;)"" />
                <xsl:if test=""string($var:v13)='true'"">
                  <xsl:variable name=""var:v14"" select=""../ns0:JPNUM/text()"" />
                  <xsl:value-of select=""$var:v14"" />
                </xsl:if>
              </ns0:JPNUM>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:LOCATIONS"">
              <xsl:for-each select=""ns0:MTFMBLDGCLASS1"">
                <xsl:variable name=""var:v15"" select=""string(./text())"" />
                <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat($var:v15 , &quot;-&quot; , string(../ns0:MTFMBLDGCLASS2/text()))"" />
                <ns0:LOCATION>
                  <xsl:value-of select=""$var:v16"" />
                </ns0:LOCATION>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:LOCATIONS"">
              <xsl:for-each select=""ns0:MTFMBLDGCLASS1"">
                <ns0:MTFMBLDGCLASS1>
                  <xsl:value-of select=""./text()"" />
                </ns0:MTFMBLDGCLASS1>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:LOCATIONS"">
              <xsl:for-each select=""ns0:MTFMBLDGCLASS2"">
                <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
                <ns0:MTFMBLDGCLASS2>
                  <xsl:value-of select=""./text()"" />
                  <xsl:value-of select=""$var:v17"" />
                </ns0:MTFMBLDGCLASS2>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:MTFMCLIENTREF>
                <xsl:value-of select=""./text()"" />
              </ns0:MTFMCLIENTREF>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:ONBEHALFOF"">
              <ns0:ONBEHALFOF>
                <xsl:value-of select=""./text()"" />
              </ns0:ONBEHALFOF>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:ORGID>
            <xsl:value-of select=""$var:v18"" />
          </ns0:ORGID>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:PHONE"">
              <ns0:PHONE>
                <xsl:value-of select=""./text()"" />
              </ns0:PHONE>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:REPORTDATE>
            <xsl:value-of select=""$var:v19"" />
          </ns0:REPORTDATE>
          <ns0:REPORTEDBY>
            <xsl:value-of select=""$var:v20"" />
          </ns0:REPORTEDBY>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:RESPONDBY"">
              <ns0:RESPONDBY>
                <xsl:value-of select=""./text()"" />
              </ns0:RESPONDBY>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:SITEID>
            <xsl:value-of select=""$var:v21"" />
          </ns0:SITEID>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WORKTYPE"">
              <xsl:variable name=""var:v22"" select=""string(./text())"" />
              <ns0:STATUS>
                <xsl:variable name=""var:v23"" select=""ScriptNS0:translateRrWorkType($var:v22)"" />
                <xsl:variable name=""var:v24"" select=""userCSharp:LogicalEq(string($var:v23) , &quot;RW&quot;)"" />
                <xsl:if test=""string($var:v24)='true'"">
                  <xsl:variable name=""var:v25"" select=""&quot;WAPPR&quot;"" />
                  <xsl:value-of select=""$var:v25"" />
                </xsl:if>
                <xsl:variable name=""var:v26"" select=""userCSharp:LogicalEq(string($var:v23) , &quot;PM&quot;)"" />
                <xsl:if test=""string($var:v26)='true'"">
                  <xsl:variable name=""var:v27"" select=""&quot;WSCH&quot;"" />
                  <xsl:value-of select=""$var:v27"" />
                </xsl:if>
                <xsl:variable name=""var:v28"" select=""userCSharp:LogicalEq(string($var:v23) , &quot;QW&quot;)"" />
                <xsl:if test=""string($var:v28)='true'"">
                  <xsl:variable name=""var:v29"" select=""&quot;WAPPR&quot;"" />
                  <xsl:value-of select=""$var:v29"" />
                </xsl:if>
                <xsl:variable name=""var:v30"" select=""userCSharp:LogicalEq(string($var:v23) , &quot;PCM/RW&quot;)"" />
                <xsl:if test=""string($var:v30)='true'"">
                  <xsl:variable name=""var:v31"" select=""&quot;WAPPR&quot;"" />
                  <xsl:value-of select=""$var:v31"" />
                </xsl:if>
              </ns0:STATUS>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WORKTYPE"">
              <xsl:variable name=""var:v32"" select=""string(./text())"" />
              <ns0:TARGCOMPDATE>
                <xsl:variable name=""var:v33"" select=""ScriptNS0:translateRrWorkType($var:v32)"" />
                <xsl:variable name=""var:v34"" select=""userCSharp:LogicalEq(string($var:v33) , &quot;PM&quot;)"" />
                <xsl:if test=""string($var:v34)='true'"">
                  <xsl:variable name=""var:v35"" select=""../ns0:TARGCOMPDATE/text()"" />
                  <xsl:value-of select=""$var:v35"" />
                </xsl:if>
                <xsl:variable name=""var:v36"" select=""userCSharp:LogicalNe(string($var:v33) , &quot;PM&quot;)"" />
                <xsl:if test=""string($var:v36)='true'"">
                  <xsl:variable name=""var:v37"" select=""../ns0:TARGCOMPDATE/text()"" />
                  <xsl:value-of select=""$var:v37"" />
                </xsl:if>
              </ns0:TARGCOMPDATE>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WORKTYPE"">
              <xsl:variable name=""var:v38"" select=""string(./text())"" />
              <ns0:TARGSTARTDATE>
                <xsl:variable name=""var:v39"" select=""ScriptNS0:translateRrWorkType($var:v38)"" />
                <xsl:variable name=""var:v40"" select=""userCSharp:LogicalEq(string($var:v39) , &quot;PM&quot;)"" />
                <xsl:if test=""string($var:v40)='true'"">
                  <xsl:variable name=""var:v41"" select=""../ns0:TARGSTARTDATE/text()"" />
                  <xsl:value-of select=""$var:v41"" />
                </xsl:if>
                <xsl:variable name=""var:v42"" select=""userCSharp:LogicalNe(string($var:v39) , &quot;PM&quot;)"" />
                <xsl:if test=""string($var:v42)='true'"">
                  <xsl:variable name=""var:v43"" select=""../ns0:RESPONDBY/text()"" />
                  <xsl:value-of select=""$var:v43"" />
                </xsl:if>
              </ns0:TARGSTARTDATE>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:WOCLASS>
            <xsl:value-of select=""$var:v44"" />
          </ns0:WOCLASS>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:SOURCESYSID"">
              <ns0:WOLO2>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO2>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:WOLO3>
                <xsl:value-of select=""./text()"" />
              </ns0:WOLO3>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WOPRIORITY"">
              <ns0:WOPRIORITY>
                <xsl:value-of select=""./text()"" />
              </ns0:WOPRIORITY>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:for-each select=""ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
            <xsl:for-each select=""ns0:WORKTYPE"">
              <xsl:variable name=""var:v45"" select=""string(./text())"" />
              <ns0:WORKTYPE>
                <xsl:variable name=""var:v46"" select=""ScriptNS0:translateRrWorkType($var:v45)"" />
                <xsl:value-of select=""$var:v46"" />
              </ns0:WORKTYPE>
            </xsl:for-each>
          </xsl:for-each>
        </ns0:WORKORDER>
      </ns0:MTFMWOINSet>
    </ns0:SyncMTFMWOIN>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
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


public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


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


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
        
        private const global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
        
        private const global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN";
                return _TrgSchemas;
            }
        }
    }
}
