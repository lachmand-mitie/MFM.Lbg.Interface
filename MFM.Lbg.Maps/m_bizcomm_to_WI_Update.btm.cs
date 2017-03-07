namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.BizTalk_Comm", typeof(global::MFM.Lbg.Schemas.BizTalk_Comm))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    public sealed class m_bizcomm_to_WI_Update : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:s0=""http://MFM.Lbg.Schemas.BizTalk_Comm"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Biz_comm"" />
  </xsl:template>
  <xsl:template match=""/s0:Biz_comm"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;-1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;RW&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringLeft(string(L4/text()) , &quot;49&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringLeft(string(L6/text()) , &quot;49&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringLeft(string(L7/text()) , &quot;49&quot;)"" />
    <ns0:MFMWorkItemUpdate>
      <xsl:if test=""L1"">
        <SourceSystem>
          <xsl:value-of select=""L1/text()"" />
        </SourceSystem>
      </xsl:if>
      <SourceSystemMessageId>
        <xsl:value-of select=""$var:v1"" />
      </SourceSystemMessageId>
      <SourceSystemMessageTs>
        <xsl:value-of select=""$var:v2"" />
      </SourceSystemMessageTs>
      <BizTalkMessageId>
        <xsl:value-of select=""$var:v3"" />
      </BizTalkMessageId>
      <BizTalkMessageTs>
        <xsl:value-of select=""$var:v2"" />
      </BizTalkMessageTs>
      <WI_WorkType>
        <xsl:value-of select=""$var:v4"" />
      </WI_WorkType>
      <xsl:if test=""L5"">
        <WI_UpdateTs>
          <xsl:value-of select=""L5/text()"" />
        </WI_UpdateTs>
      </xsl:if>
      <WI_SourceRef>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_SourceRef>
      <xsl:if test=""L3"">
        <WI_DestinationRef>
          <xsl:value-of select=""L3/text()"" />
        </WI_DestinationRef>
      </xsl:if>
      <xsl:if test=""L10"">
        <WI_ServiceLevel1>
          <xsl:value-of select=""L10/text()"" />
        </WI_ServiceLevel1>
      </xsl:if>
      <WI_ServiceLevel2>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_ServiceLevel2>
      <WI_ServiceLevel3>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_ServiceLevel3>
      <WI_AssetRef>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_AssetRef>
      <WI_LocationLevel1>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_LocationLevel1>
      <WI_LocationLevel2>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_LocationLevel2>
      <WI_LocationLevel3>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_LocationLevel3>
      <WI_LocationLevel4>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_LocationLevel4>
      <xsl:if test=""L2"">
        <WI_Status>
          <xsl:value-of select=""L2/text()"" />
        </WI_Status>
      </xsl:if>
      <xsl:if test=""L5"">
        <WI_StatusChangeTS>
          <xsl:value-of select=""L5/text()"" />
        </WI_StatusChangeTS>
      </xsl:if>
      <xsl:if test=""L11"">
        <WI_StatusNote>
          <xsl:value-of select=""L11/text()"" />
        </WI_StatusNote>
      </xsl:if>
      <WI_Priority>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_Priority>
      <WI_KpiStartTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_KpiStartTs>
      <WI_KpiAttendTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_KpiAttendTs>
      <WI_KpiCompleteTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_KpiCompleteTs>
      <WI_KpiConfirmTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_KpiConfirmTs>
      <WI_ActualStartTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_ActualStartTs>
      <WI_ActualAttendTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_ActualAttendTs>
      <WI_ActualCompleteTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_ActualCompleteTs>
      <WI_ActualConfirmTs>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </WI_ActualConfirmTs>
      <Meta_RF01>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF01>
      <Meta_RF02>
        <xsl:value-of select=""$var:v5"" />
      </Meta_RF02>
      <xsl:if test=""L12"">
        <Meta_RF03>
          <xsl:value-of select=""L12/text()"" />
        </Meta_RF03>
      </xsl:if>
      <Meta_RF04>
        <xsl:value-of select=""$var:v6"" />
      </Meta_RF04>
      <Meta_RF05>
        <xsl:value-of select=""$var:v7"" />
      </Meta_RF05>
      <Meta_RF06>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF06>
      <Meta_RF07>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF07>
      <Meta_RF08>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF08>
      <Meta_RF09>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF09>
      <Meta_RF10>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF10>
      <Meta_RF11>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF11>
      <Meta_RF12>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF12>
      <Meta_RF13>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF13>
      <Meta_RF14>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF14>
      <Meta_RF15>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF15>
      <Meta_RF21>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </Meta_RF21>
    </ns0:MFMWorkItemUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.BizTalk_Comm";
        
        private const global::MFM.Lbg.Schemas.BizTalk_Comm _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.BizTalk_Comm";
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
