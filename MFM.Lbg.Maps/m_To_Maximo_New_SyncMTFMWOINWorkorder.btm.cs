namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOINService+SyncMTFMWOIN", typeof(global::MFM.Lbg.Schemas.MTFMWOINService.SyncMTFMWOIN))]
    public sealed class m_To_Maximo_New_SyncMTFMWOINWorkorder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8 userCSharp ScriptNS0 userVB"" version=""1.0"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;VISIONFM&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringSubstring(string(s0:IssuedWork/s9:Workitem/s9:ProblemNote/text()) , &quot;1&quot; , &quot;99&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:ConvertChr(&quot;13&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:ConvertChr(&quot;10&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(string($var:v5) , string($var:v6))"" />
    <xsl:variable name=""var:v8"" select=""string(s0:IssuedWork/s9:Workitem/s9:ProblemNote/text())"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(string($var:v7) , &quot;&quot; , $var:v8 , string($var:v7) , string($var:v7) , &quot;Contact: &quot; , string(s0:IssuedWork/s9:Workitem/s9:ContactFirstname/text()) , &quot; &quot; , string(s0:IssuedWork/s9:Workitem/s9:ContactPhone/text()) , &quot; &quot; , string(s0:IssuedWork/s9:Workitem/s9:ContactMobile/text()) , string($var:v7) , &quot;Building Class 1:  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteSiteID/text()) , &quot; / Building Class 2:  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/linkpropertyid/text()) , string($var:v7) , &quot;Address:&quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteAddress1/text()) , &quot; &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteAddress2/text()) , &quot;  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteAddress3/text()) , &quot;  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteAddress4/text()) , &quot;  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteAddress5/text()) , &quot;  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/siteCity/text()) , &quot;  &quot; , string(s0:IssuedWork/s9:Workitem/s5:Location/s8:Address/sitePostCode/text()) , string($var:v7) , &quot;Service: &quot; , string(s0:IssuedWork/s9:Workitem/s9:Service/s12:ServiceStream/Streamname/text()) , &quot; -  &quot; , string(s0:IssuedWork/s9:Workitem/s9:Service/s12:ServiceType/Typename/text()) , &quot; -  &quot; , string(s0:IssuedWork/s9:Workitem/s9:Service/s12:ServiceDetail/Detailname/text()) , &quot; &quot; , string(s0:IssuedWork/s9:Workitem/s9:CustomerQuestions/text()))"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
    <xsl:variable name=""var:v16"" select=""string(s0:IssuedWork/s9:Workitem/s9:ContactFirstname/text())"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat($var:v16 , &quot; &quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringLeft(string($var:v17) , &quot;30&quot;)"" />
    <xsl:variable name=""var:v19"" select=""string(s0:IssuedWork/s9:Workitem/s9:ContactPhone/text())"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringLeft($var:v19 , &quot;35&quot;)"" />
    <xsl:variable name=""var:v21"" select=""userCSharp:StringConcat(&quot;VISIONIT&quot;)"" />
    <xsl:variable name=""var:v22"" select=""userCSharp:StringConcat(&quot;WAPPR&quot;)"" />
    <xsl:variable name=""var:v25"" select=""userCSharp:StringConcat(&quot;WORKORDER&quot;)"" />
    <ns0:SyncMTFMWOIN>
      <ns0:MTFMWOINSet>
        <ns0:WORKORDER>
          <ns0:ASSETNUM>
            <xsl:value-of select=""$var:v1"" />
          </ns0:ASSETNUM>
          <ns0:CLIENTREF>
            <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:HelpdeskReference/text()"" />
          </ns0:CLIENTREF>
          <ns0:COMMODITY>
            <xsl:variable name=""var:v2"" select=""ScriptNS0:getMiAMICommodity(string(s0:IssuedWork/s9:Workitem/s9:CompanyId/text()) , string(s0:IssuedWork/s9:Workitem/s9:Service/s12:ServiceStream/@StreamId) , string(s0:IssuedWork/s9:Workitem/s9:Service/s12:ServiceDetail/@DetailId))"" />
            <xsl:value-of select=""$var:v2"" />
          </ns0:COMMODITY>
          <ns0:COMMODITYGROUP>
            <xsl:value-of select=""$var:v3"" />
          </ns0:COMMODITYGROUP>
          <ns0:DESCRIPTION>
            <xsl:value-of select=""$var:v4"" />
          </ns0:DESCRIPTION>
          <ns0:DESCRIPTION_LONGDESCRIPTION>
            <xsl:variable name=""var:v10"" select=""ScriptNS0:StripFormatting(string($var:v9))"" />
            <xsl:variable name=""var:v11"" select=""userCSharp:StringLeft(string($var:v10) , &quot;3988&quot;)"" />
            <xsl:value-of select=""$var:v11"" />
          </ns0:DESCRIPTION_LONGDESCRIPTION>
          <ns0:ISTASK>
            <xsl:value-of select=""$var:v12"" />
          </ns0:ISTASK>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
            <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(string(linkMitiePropertyCode/text()) , &quot;-&quot; , string(../s12:MService/VendorServiceLine/text()))"" />
            <ns0:LOCATION>
              <xsl:value-of select=""$var:v13"" />
            </ns0:LOCATION>
          </xsl:for-each>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
            <ns0:MTFMBLDGCLASS1>
              <xsl:if test=""linkMitiePropertyCode"">
                <xsl:value-of select=""linkMitiePropertyCode/text()"" />
              </xsl:if>
            </ns0:MTFMBLDGCLASS1>
          </xsl:for-each>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s12:MService"">
            <ns0:MTFMBLDGCLASS2>
              <xsl:if test=""VendorServiceLine"">
                <xsl:value-of select=""VendorServiceLine/text()"" />
              </xsl:if>
            </ns0:MTFMBLDGCLASS2>
          </xsl:for-each>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s12:BundleItem"">
            <xsl:variable name=""var:v14"" select=""userCSharp:LogicalEq(string(BundleType/text()) , &quot;CostCentreCode&quot;)"" />
            <ns0:MTFMCLIENTPO>
              <xsl:if test=""string($var:v14)='true'"">
                <xsl:variable name=""var:v15"" select=""BundleDescription/text()"" />
                <xsl:value-of select=""$var:v15"" />
              </xsl:if>
            </ns0:MTFMCLIENTPO>
          </xsl:for-each>
          <ns0:MTFMCLIENTREF>
            <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:HelpdeskReference/text()"" />
          </ns0:MTFMCLIENTREF>
          <ns0:MTFMCONTACTEMAIL>
            <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:ContactEmail"">
              <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:ContactEmail/text()"" />
            </xsl:if>
          </ns0:MTFMCONTACTEMAIL>
          <ns0:MTFMCUSTFAULTREF>
            <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:CustomerRef"">
              <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:CustomerRef/text()"" />
            </xsl:if>
          </ns0:MTFMCUSTFAULTREF>
          <ns0:ONBEHALFOF>
            <xsl:value-of select=""$var:v18"" />
          </ns0:ONBEHALFOF>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
            <xsl:for-each select=""s8:Address"">
              <ns0:ORGID>
                <xsl:if test=""siteLongitude"">
                  <xsl:value-of select=""siteLongitude/text()"" />
                </xsl:if>
              </ns0:ORGID>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:PHONE>
            <xsl:value-of select=""$var:v20"" />
          </ns0:PHONE>
          <ns0:REPORTDATE>
            <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:CreatedDate"">
              <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:CreatedDate/text()"" />
            </xsl:if>
          </ns0:REPORTDATE>
          <ns0:REPORTEDBY>
            <xsl:value-of select=""$var:v21"" />
          </ns0:REPORTEDBY>
          <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
            <xsl:for-each select=""s8:Address"">
              <ns0:SITEID>
                <xsl:if test=""siteSiteName"">
                  <xsl:value-of select=""siteSiteName/text()"" />
                </xsl:if>
              </ns0:SITEID>
            </xsl:for-each>
          </xsl:for-each>
          <ns0:STATUS>
            <xsl:value-of select=""$var:v22"" />
          </ns0:STATUS>
          <ns0:TARGCOMPDATE>
            <xsl:variable name=""var:v23"" select=""ScriptNS0:AdjustForBst(string(s0:IssuedWork/s9:Workitem/s9:VendorCompleteBy/text()))"" />
            <xsl:value-of select=""$var:v23"" />
          </ns0:TARGCOMPDATE>
          <ns0:TARGSTARTDATE>
            <xsl:variable name=""var:v24"" select=""ScriptNS0:AdjustForBst(string(s0:IssuedWork/s9:Workitem/s9:VendorAttendBy/text()))"" />
            <xsl:value-of select=""$var:v24"" />
          </ns0:TARGSTARTDATE>
          <ns0:WOCLASS>
            <xsl:value-of select=""$var:v25"" />
          </ns0:WOCLASS>
          <ns0:WOLO2>
            <xsl:value-of select=""$var:v3"" />
          </ns0:WOLO2>
          <ns0:WOPRIORITY>
            <xsl:variable name=""var:v26"" select=""userVB:DumbDownPriority(string(s0:IssuedWork/s9:Workitem/s9:SLA/text()))"" />
            <xsl:value-of select=""$var:v26"" />
          </ns0:WOPRIORITY>
          <ns0:WORKTYPE>
            <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:WorkType"">
              <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:WorkType/text()"" />
            </xsl:if>
          </ns0:WORKTYPE>
          <ns0:WPSERVICE>
            <ns0:DESCRIPTION>
              <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:ProblemNote"">
                <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:ProblemNote/text()"" />
              </xsl:if>
            </ns0:DESCRIPTION>
            <ns0:LINECOST>
              <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:BudgetValue"">
                <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:BudgetValue/text()"" />
              </xsl:if>
            </ns0:LINECOST>
          </ns0:WPSERVICE>
        </ns0:WORKORDER>
      </ns0:MTFMWOINSet>
    </ns0:SyncMTFMWOIN>
  </xsl:template>
  <msxsl:script language=""VB"" implements-prefix=""userVB""><![CDATA[
Public Function DumbDownPriority(ByVal param1 As String) As String
	Return param1.Remove(0,1)
End Function



]]></msxsl:script>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string StringSubstring(string str, string left, string right)
{
	string retval = """";
	double dleft = 0;
	double dright = 0;
	if (str != null && IsNumeric(left, ref dleft) && IsNumeric(right, ref dright))
	{
		int lt = (int)dleft;
		int rt = (int)dright;
		lt--; rt--;
		if (lt >= 0 && rt >= lt && lt < str.Length)
		{
			if (rt < str.Length)
			{
				retval = str.Substring(lt, rt-lt+1);
			}
			else
			{
				retval = str.Substring(lt, str.Length-lt);
			}
		}
	}
	return retval;
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


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8, string param9, string param10, string param11, string param12, string param13, string param14, string param15, string param16, string param17, string param18, string param19, string param20, string param21, string param22, string param23, string param24, string param25, string param26, string param27, string param28, string param29, string param30, string param31, string param32, string param33, string param34, string param35, string param36, string param37, string param38, string param39)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8 + param9 + param10 + param11 + param12 + param13 + param14 + param15 + param16 + param17 + param18 + param19 + param20 + param21 + param22 + param23 + param24 + param25 + param26 + param27 + param28 + param29 + param30 + param31 + param32 + param33 + param34 + param35 + param36 + param37 + param38 + param39;
}


public string ConvertChr(string val)
{
	string retval = """";
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		int v = (int) d;
		if (v >= 1 && v <= 127)
		{
			char c = (char)v;
			retval = c.ToString(System.Globalization.CultureInfo.InvariantCulture);
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.DistibutedWorkItems";
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
