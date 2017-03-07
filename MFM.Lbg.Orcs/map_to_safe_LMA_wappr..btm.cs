namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_create_safe_visitResponse", typeof(global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_create_safe_visitResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_MatchResponse", typeof(global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_Beacon_Fetch_Property_MatchResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFE_Update_Message", typeof(global::MFM.Lbg.Schemas.SAFE_Update_Message))]
    public sealed class map_to_safe_LMA_wappr : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s8 s16 s3 s4 s5 s1 s6 s7 s2 s0 s10 s11 s12 s13 s14 s15 s9 userCSharp"" version=""1.0"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:s16=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s6=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Beacon_Fetch_Property_Match"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:ns0=""http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:s13=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_create_safe_visit"" xmlns:s14=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s15=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringLeft(string(InputMessagePart_2/s0:DistributedWorkItems/s3:IssuedWork/s11:Workitem/s11:TargetSystem/text()) , &quot;3&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;The visit id:&quot; , string(InputMessagePart_0/s1:biz_create_safe_visitResponse/s1:StoredProcedureResultSet0/s13:StoredProcedureResultSet0/s13:VisitId/text()) , &quot; has been created in SAFE (&quot; , string($var:v1) , &quot;)&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:SafeUpdate>
      <xsl:if test=""InputMessagePart_0/s1:biz_create_safe_visitResponse/s1:StoredProcedureResultSet0/s13:StoredProcedureResultSet0/s13:VisitId"">
        <VisitId>
          <xsl:value-of select=""InputMessagePart_0/s1:biz_create_safe_visitResponse/s1:StoredProcedureResultSet0/s13:StoredProcedureResultSet0/s13:VisitId/text()"" />
        </VisitId>
      </xsl:if>
      <CustomerReference>
        <xsl:value-of select=""InputMessagePart_2/s0:DistributedWorkItems/s3:IssuedWork/s11:Workitem/s11:HelpdeskReference/text()"" />
      </CustomerReference>
      <xsl:if test=""InputMessagePart_2/s0:DistributedWorkItems/s3:IssuedWork/s11:Workitem/s11:Service/s14:ServiceDetail/statutory"">
        <ServiceType>
          <xsl:value-of select=""InputMessagePart_2/s0:DistributedWorkItems/s3:IssuedWork/s11:Workitem/s11:Service/s14:ServiceDetail/statutory/text()"" />
        </ServiceType>
      </xsl:if>
      <VisitStatus>
        <xsl:text>SENT</xsl:text>
      </VisitStatus>
      <Deleted>
        <xsl:text>0</xsl:text>
      </Deleted>
      <Note>
        <xsl:value-of select=""$var:v2"" />
      </Note>
      <ClientViewable>
        <xsl:text>0</xsl:text>
      </ClientViewable>
      <xsl:if test=""InputMessagePart_1/s1:biz_Beacon_Fetch_Property_MatchResponse/s1:StoredProcedureResultSet0/s6:StoredProcedureResultSet0/s6:cardnumber"">
        <Cardnumber>
          <xsl:value-of select=""InputMessagePart_1/s1:biz_Beacon_Fetch_Property_MatchResponse/s1:StoredProcedureResultSet0/s6:StoredProcedureResultSet0/s6:cardnumber/text()"" />
        </Cardnumber>
      </xsl:if>
      <Customer>
        <xsl:text>LBG</xsl:text>
      </Customer>
      <Business>
        <xsl:text>MLA</xsl:text>
      </Business>
      <WorkType>
        <xsl:text>Callout</xsl:text>
      </WorkType>
      <OutboundUpdId>
        <xsl:text>-1</xsl:text>
      </OutboundUpdId>
      <OutboundUpdTs>
        <xsl:value-of select=""$var:v3"" />
      </OutboundUpdTs>
      <LastModifiedTs>
        <xsl:value-of select=""$var:v3"" />
      </LastModifiedTs>
      <xsl:if test=""InputMessagePart_2/s0:DistributedWorkItems/s3:IssuedWork/s11:Workitem/s11:VendorAttendBy"">
        <DateConfirmed>
          <xsl:value-of select=""InputMessagePart_2/s0:DistributedWorkItems/s3:IssuedWork/s11:Workitem/s11:VendorAttendBy/text()"" />
        </DateConfirmed>
      </xsl:if>
    </ns0:SafeUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2, string param3, string param4)
{
   return param0 + param1 + param2 + param3 + param4;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
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
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_create_safe_visitResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_create_safe_visitResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_MatchResponse";
        
        private const global::MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo.biz_Beacon_Fetch_Property_MatchResponse _srcSchemaTypeReference1 = null;
        
        private const string _strSrcSchemasList2 = @"MFM.Lbg.Schemas.DistibutedWorkItems";
        
        private const global::MFM.Lbg.Schemas.DistibutedWorkItems _srcSchemaTypeReference2 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.SAFE_Update_Message";
        
        private const global::MFM.Lbg.Schemas.SAFE_Update_Message _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [3];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_create_safe_visitResponse";
                _SrcSchemas[1] = @"MFM.Lbg.Schemas.VFM_MPCITypedProcedure_dbo+biz_Beacon_Fetch_Property_MatchResponse";
                _SrcSchemas[2] = @"MFM.Lbg.Schemas.DistibutedWorkItems";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.SAFE_Update_Message";
                return _TrgSchemas;
            }
        }
    }
}
