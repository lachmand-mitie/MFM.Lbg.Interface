namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFE_Update_Message", typeof(global::MFM.Lbg.Schemas.SAFE_Update_Message))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    public sealed class m_SAFE_To_WI_Update : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:s0=""http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:SafeUpdate"" />
  </xsl:template>
  <xsl:template match=""/s0:SafeUpdate"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Business/text()) , &quot;SAFE&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalEq(string(WorkType/text()) , &quot;Callout&quot;)"" />
    <xsl:variable name=""var:v5"" select=""string(Business/text())"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq($var:v5 , &quot;MPC&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalEq($var:v5 , &quot;MLA&quot;)"" />
    <ns0:MFMWorkItemUpdate>
      <SourceSystem>
        <xsl:value-of select=""$var:v1"" />
      </SourceSystem>
      <SourceSystemMessageId>
        <xsl:value-of select=""OutboundUpdId/text()"" />
      </SourceSystemMessageId>
      <SourceSystemMessageTs>
        <xsl:value-of select=""OutboundUpdTs/text()"" />
      </SourceSystemMessageTs>
      <BizTalkMessageId>
        <xsl:text>1</xsl:text>
      </BizTalkMessageId>
      <BizTalkMessageTs>
        <xsl:value-of select=""$var:v2"" />
      </BizTalkMessageTs>
      <xsl:if test=""string($var:v3)='true'"">
        <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;RW&quot;)"" />
        <WI_WorkType>
          <xsl:value-of select=""$var:v4"" />
        </WI_WorkType>
      </xsl:if>
      <WI_UpdateTs>
        <xsl:value-of select=""LastModifiedTs/text()"" />
      </WI_UpdateTs>
      <WI_SourceRef>
        <xsl:value-of select=""VisitId/text()"" />
      </WI_SourceRef>
      <WI_DestinationRef>
        <xsl:value-of select=""CustomerReference/text()"" />
      </WI_DestinationRef>
      <WI_ServiceLevel1>
        <xsl:value-of select=""ServiceType/text()"" />
      </WI_ServiceLevel1>
      <WI_Status>
        <xsl:value-of select=""VisitStatus/text()"" />
      </WI_Status>
      <WI_StatusChangeTS>
        <xsl:value-of select=""LastModifiedTs/text()"" />
      </WI_StatusChangeTS>
      <WI_StatusNote>
        <xsl:value-of select=""Note/text()"" />
      </WI_StatusNote>
      <WI_KpiAttendTs>
        <xsl:value-of select=""DateConfirmed/text()"" />
      </WI_KpiAttendTs>
      <WI_KpiCompleteTs>
        <xsl:value-of select=""DateConfirmed/text()"" />
      </WI_KpiCompleteTs>
      <WI_ActualAttendTs>
        <xsl:value-of select=""DateServiceStart/text()"" />
      </WI_ActualAttendTs>
      <WI_ActualCompleteTs>
        <xsl:value-of select=""DateServiceEnd/text()"" />
      </WI_ActualCompleteTs>
      <Meta_RF02>
        <xsl:value-of select=""Cardnumber/text()"" />
      </Meta_RF02>
      <Meta_RF03>
        <xsl:value-of select=""Customer/text()"" />
      </Meta_RF03>
      <Meta_RF09>
        <xsl:text>4793</xsl:text>
      </Meta_RF09>
      <xsl:if test=""string($var:v6)='true'"">
        <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;19010&quot;)"" />
        <Meta_RF10>
          <xsl:value-of select=""$var:v7"" />
        </Meta_RF10>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;19008&quot;)"" />
        <Meta_RF10>
          <xsl:value-of select=""$var:v9"" />
        </Meta_RF10>
      </xsl:if>
    </ns0:MFMWorkItemUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.SAFE_Update_Message";
        
        private const global::MFM.Lbg.Schemas.SAFE_Update_Message _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
        
        private const global::MFM.Lbg.Schemas.MFMWorkItemUpdate _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.SAFE_Update_Message";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MFM.Lbg.Schemas.MFMWorkItemUpdate";
                return _TrgSchemas;
            }
        }
    }
}
