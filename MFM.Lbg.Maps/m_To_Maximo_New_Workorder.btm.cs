namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOINService+MTFMWOIN", typeof(global::MFM.Lbg.Schemas.MTFMWOINService.MTFMWOIN))]
    public sealed class m_To_Maximo_New_Workorder : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8 userCSharp userVB"" version=""1.0"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:userVB=""http://schemas.microsoft.com/BizTalk/2003/userVB"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;GENERAL&quot;)"" />
    <xsl:variable name=""var:v3"" select=""string(s0:IssuedWork/s9:Workitem/s9:ProblemNote/@xsi:nil) = 'true'"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNot(string($var:v3))"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(string(s0:IssuedWork/s9:Workitem/s9:ContactFirstname/text()) , &quot; &quot; , string(s0:IssuedWork/s9:Workitem/s9:ContactSurname/text()))"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;MTFM&quot;)"" />
    <xsl:variable name=""var:v11"" select=""string(s0:IssuedWork/s9:Workitem/s9:ContactPhone/@xsi:nil) = 'true'"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:LogicalNot(string($var:v11))"" />
    <xsl:variable name=""var:v15"" select=""userCSharp:StringConcat(&quot;VISIONIT&quot;)"" />
    <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(&quot;NMS&quot;)"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat(&quot;WAPPR&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(&quot;WORKORDER&quot;)"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringConcat(&quot;CW&quot;)"" />
    <ns0:MTFMWOIN>
      <ns0:WORKORDER>
        <ns0:ASSETNUM>
          <xsl:value-of select=""$var:v1"" />
        </ns0:ASSETNUM>
        <ns0:CLIENTREF>
          <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:HelpdeskReference/text()"" />
        </ns0:CLIENTREF>
        <ns0:COMMODITY>
          <xsl:value-of select=""$var:v1"" />
        </ns0:COMMODITY>
        <ns0:COMMODITYGROUP>
          <xsl:value-of select=""$var:v2"" />
        </ns0:COMMODITYGROUP>
        <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s9:Service"">
          <ns0:DESCRIPTION>
            <xsl:if test=""s12:ServiceDetail/Detailname"">
              <xsl:value-of select=""s12:ServiceDetail/Detailname/text()"" />
            </xsl:if>
          </ns0:DESCRIPTION>
        </xsl:for-each>
        <ns0:DESCRIPTION_LONGDESCRIPTION>
          <xsl:if test=""string($var:v3)='true'"">
            <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;No notes&quot;)"" />
            <xsl:value-of select=""$var:v4"" />
          </xsl:if>
          <xsl:if test=""string($var:v5)='true'"">
            <xsl:variable name=""var:v6"" select=""s0:IssuedWork/s9:Workitem/s9:ProblemNote/text()"" />
            <xsl:value-of select=""$var:v6"" />
          </xsl:if>
        </ns0:DESCRIPTION_LONGDESCRIPTION>
        <ns0:ISTASK>
          <xsl:value-of select=""$var:v7"" />
        </ns0:ISTASK>
        <xsl:for-each select=""s0:IssuedWork/s9:Workitem/s5:Location"">
          <xsl:for-each select=""s8:Address"">
            <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(string(siteSiteID/text()) , &quot;-&quot; , string(../linkpropertyid/text()))"" />
            <ns0:LOCATION>
              <xsl:value-of select=""$var:v8"" />
            </ns0:LOCATION>
          </xsl:for-each>
        </xsl:for-each>
        <ns0:ONBEHALFOF>
          <xsl:value-of select=""$var:v9"" />
        </ns0:ONBEHALFOF>
        <ns0:ORGID>
          <xsl:value-of select=""$var:v10"" />
        </ns0:ORGID>
        <ns0:PHONE>
          <xsl:if test=""string($var:v11)='true'"">
            <xsl:variable name=""var:v12"" select=""s0:IssuedWork/s9:Workitem/s9:ContactPhone/text()"" />
            <xsl:value-of select=""$var:v12"" />
          </xsl:if>
          <xsl:if test=""string($var:v13)='true'"">
            <xsl:variable name=""var:v14"" select=""s0:IssuedWork/s9:Workitem/s9:ContactMobile/text()"" />
            <xsl:value-of select=""$var:v14"" />
          </xsl:if>
        </ns0:PHONE>
        <ns0:REPORTDATE>
          <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:CreatedDate"">
            <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:CreatedDate/text()"" />
          </xsl:if>
        </ns0:REPORTDATE>
        <ns0:REPORTEDBY>
          <xsl:value-of select=""$var:v15"" />
        </ns0:REPORTEDBY>
        <ns0:SITEID>
          <xsl:value-of select=""$var:v16"" />
        </ns0:SITEID>
        <ns0:STATUS>
          <xsl:value-of select=""$var:v17"" />
        </ns0:STATUS>
        <ns0:TARGCOMPDATE>
          <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:VendorCompleteBy"">
            <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:VendorCompleteBy/text()"" />
          </xsl:if>
        </ns0:TARGCOMPDATE>
        <ns0:TARGSTARTDATE>
          <xsl:if test=""s0:IssuedWork/s9:Workitem/s9:VendorAttendBy"">
            <xsl:value-of select=""s0:IssuedWork/s9:Workitem/s9:VendorAttendBy/text()"" />
          </xsl:if>
        </ns0:TARGSTARTDATE>
        <ns0:WOCLASS>
          <xsl:value-of select=""$var:v18"" />
        </ns0:WOCLASS>
        <ns0:WOPRIORITY>
          <xsl:variable name=""var:v19"" select=""userVB:DumbDownPriority(string(s0:IssuedWork/s9:Workitem/s9:SLA/text()))"" />
          <xsl:value-of select=""$var:v19"" />
        </ns0:WOPRIORITY>
        <ns0:WORKTYPE>
          <xsl:value-of select=""$var:v20"" />
        </ns0:WORKTYPE>
      </ns0:WORKORDER>
    </ns0:MTFMWOIN>
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


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOINService+MTFMWOIN";
        
        private const global::MFM.Lbg.Schemas.MTFMWOINService.MTFMWOIN _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOINService+MTFMWOIN";
                return _TrgSchemas;
            }
        }
    }
}
