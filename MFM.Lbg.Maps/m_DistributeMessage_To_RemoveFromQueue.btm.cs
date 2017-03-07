namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.DistibutedWorkItems", typeof(global::MFM.Lbg.Schemas.DistibutedWorkItems))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Remove_Case_From_Queue", typeof(global::MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo.biz_Global_Remove_Case_From_Queue))]
    public sealed class DistributeMessage_To_RemoveFromQueue : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s6 s0 s7 s10 s2 s1 s4 s11 s9 s5 s12 s3 s8 userCSharp"" version=""1.0"" xmlns:s6=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveySet"" xmlns:ns5=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Reset_Case_Extract"" xmlns:s8=""http://MFMSharedResources/Types/Helpdesk/v1/Address"" xmlns:s0=""http://MFMSharedResources/Types/Helpdesk/v1/IssuedWork"" xmlns:s7=""http://MFMSharedResources/Types/Helpdesk/v1/MSurveyQuestion"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Fetch_Case_DataSet"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/biz_Global_Remove_Case_From_Queue"" xmlns:s2=""http://MFMSharedResources/Types/Helpdesk/v1/Vendor"" xmlns:s1=""http://MFM.Lbg.Schemas.DistibutedWorkItems"" xmlns:s11=""http://MFMSharedResources/Types/Helpdesk/v1/MSurvey"" xmlns:s9=""http://MFMSharedResources/Types/Helpdesk/v1/Workitem"" xmlns:s10=""http://MFMSharedResources/Types/Helpdesk/v1/Customer"" xmlns:s5=""http://MFMSharedResources/Types/Helpdesk/v1/Location"" xmlns:s12=""http://MFMSharedResources/Types/Helpdesk/v1/Service"" xmlns:s3=""http://MFMSharedResources/Types/Helpdesk/v1/MRouting"" xmlns:s4=""http://MFMSharedResources/Types/Helpdesk/v1/Person"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:DistributedWorkItems"" />
  </xsl:template>
  <xsl:template match=""/s1:DistributedWorkItems"">
    <xsl:variable name=""var:v1"" select=""userCSharp:LogicalExistence(boolean(s0:IssuedWork/s9:Workitem/s9:HelpdeskId))"" />
    <xsl:variable name=""var:v3"" select=""boolean(s0:IssuedWork/s9:Workitem/s9:HelpdeskId)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalExistence($var:v3)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalNot(string($var:v4))"" />
    <ns0:biz_Global_Remove_Case_From_Queue>
      <xsl:if test=""string($var:v1)='true'"">
        <xsl:variable name=""var:v2"" select=""s0:IssuedWork/s9:Workitem/s9:HelpdeskId/text()"" />
        <ns0:ref>
          <xsl:value-of select=""$var:v2"" />
        </ns0:ref>
      </xsl:if>
      <xsl:if test=""string($var:v4)='true'"">
        <xsl:variable name=""var:v5"" select=""userCSharp:MathInt(&quot;1&quot;)"" />
        <ns0:code>
          <xsl:value-of select=""$var:v5"" />
        </ns0:code>
      </xsl:if>
      <xsl:if test=""string($var:v6)='true'"">
        <xsl:variable name=""var:v7"" select=""userCSharp:MathInt(&quot;-1&quot;)"" />
        <ns0:code>
          <xsl:value-of select=""$var:v7"" />
        </ns0:code>
      </xsl:if>
    </ns0:biz_Global_Remove_Case_From_Queue>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalExistence(bool val)
{
	return val;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string MathInt(string val)
{
	string retval = """";
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		try
		{
			int i = Convert.ToInt32(d, System.Globalization.CultureInfo.InvariantCulture);
			if (i > d)
			{
				i = i-1;
			}
			retval = i.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
		catch (Exception)
		{
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
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Remove_Case_From_Queue";
        
        private const global::MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo.biz_Global_Remove_Case_From_Queue _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.VFM_Extract_TypedProcedure_dbo+biz_Global_Remove_Case_From_Queue";
                return _TrgSchemas;
            }
        }
    }
}
