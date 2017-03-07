namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL", typeof(global::MFM.Lbg.Schemas.MTFMWODETAILService.PublishMTFMWODETAIL))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    public sealed class m_MXO75_to_WI_Update : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishMTFMWODETAIL"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishMTFMWODETAIL"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;TFMMXO75&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalNe(string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:CLIENTREF/text()) , &quot;&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalEq(string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:WORKTYPE/text()) , &quot;PM&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:LogicalExistence(boolean(s0:MTFMWODETAILSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS1))"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:LogicalExistence(boolean(s0:MTFMWODETAILSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS2))"" />
    <xsl:variable name=""var:v13"" select=""string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/text())"" />
    <xsl:variable name=""var:v14"" select=""string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:WORKTYPE/text())"" />
    <xsl:variable name=""var:v16"" select=""string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTSTART/@xsi:nil) = 'true'"" />
    <xsl:variable name=""var:v17"" select=""userCSharp:LogicalNot(string($var:v16))"" />
    <xsl:variable name=""var:v19"" select=""string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTFINISH/@xsi:nil) = 'true'"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:LogicalNot(string($var:v19))"" />
    <xsl:variable name=""var:v22"" select=""userCSharp:LogicalEq($var:v14 , &quot;PM&quot;)"" />
    <xsl:variable name=""var:v23"" select=""userCSharp:LogicalExistence(boolean(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ASSET))"" />
    <xsl:variable name=""var:v24"" select=""userCSharp:LogicalAnd(string($var:v22) , string($var:v23))"" />
    <xsl:variable name=""var:v26"" select=""userCSharp:LogicalNe($var:v14 , &quot;PM&quot;)"" />
    <xsl:variable name=""var:v28"" select=""boolean(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ASSET)"" />
    <xsl:variable name=""var:v29"" select=""userCSharp:LogicalExistence($var:v28)"" />
    <xsl:variable name=""var:v30"" select=""userCSharp:LogicalAnd(string($var:v22) , string($var:v29))"" />
    <xsl:variable name=""var:v32"" select=""userCSharp:StringConcat(string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:PLUSCFREQUENCY/text()) , &quot;-&quot; , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:PLUSCFREQUNIT/text()))"" />
    <ns0:MFMWorkItemUpdate>
      <SourceSystem>
        <xsl:value-of select=""$var:v1"" />
      </SourceSystem>
      <xsl:if test=""@messageID"">
        <SourceSystemMessageId>
          <xsl:value-of select=""@messageID"" />
        </SourceSystemMessageId>
      </xsl:if>
      <xsl:if test=""@creationDateTime"">
        <SourceSystemMessageTs>
          <xsl:value-of select=""@creationDateTime"" />
        </SourceSystemMessageTs>
      </xsl:if>
      <BizTalkMessageId>
        <xsl:value-of select=""$var:v2"" />
      </BizTalkMessageId>
      <BizTalkMessageTs>
        <xsl:value-of select=""$var:v3"" />
      </BizTalkMessageTs>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WORKTYPE"">
        <WI_WorkType>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WORKTYPE/text()"" />
        </WI_WorkType>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:CHANGEDATE"">
        <WI_UpdateTs>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:CHANGEDATE/text()"" />
        </WI_UpdateTs>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM"">
        <WI_SourceRef>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM/text()"" />
        </WI_SourceRef>
      </xsl:if>
      <xsl:if test=""string($var:v4)='true'"">
        <xsl:variable name=""var:v5"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:CLIENTREF/text()"" />
        <WI_DestinationRef>
          <xsl:value-of select=""$var:v5"" />
        </WI_DestinationRef>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:JPNUM"">
        <WI_ServiceLevel1>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:JPNUM/text()"" />
        </WI_ServiceLevel1>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PMNUM"">
        <WI_ServiceLevel2>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PMNUM/text()"" />
        </WI_ServiceLevel2>
      </xsl:if>
      <xsl:if test=""string($var:v6)='true'"">
        <xsl:variable name=""var:v7"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PM/s0:WOSTATUS/text()"" />
        <WI_ServiceLevel3>
          <xsl:value-of select=""$var:v7"" />
        </WI_ServiceLevel3>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:ASSETNUM"">
        <WI_AssetRef>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:ASSETNUM/text()"" />
        </WI_AssetRef>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:LOCATION"">
        <WI_LocationLevel1>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:LOCATION/text()"" />
        </WI_LocationLevel1>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:SITEID"">
        <WI_LocationLevel2>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:SITEID/text()"" />
        </WI_LocationLevel2>
      </xsl:if>
      <xsl:if test=""string($var:v8)='true'"">
        <xsl:variable name=""var:v9"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS1/text()"" />
        <WI_LocationLevel3>
          <xsl:value-of select=""$var:v9"" />
        </WI_LocationLevel3>
      </xsl:if>
      <xsl:if test=""string($var:v10)='true'"">
        <xsl:variable name=""var:v11"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:LOCATIONS/s0:MTFMBLDGCLASS2/text()"" />
        <WI_LocationLevel4>
          <xsl:value-of select=""$var:v11"" />
        </WI_LocationLevel4>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS"">
        <WI_Status>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/text()"" />
        </WI_Status>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE"">
        <WI_StatusChangeTS>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE/text()"" />
        </WI_StatusChangeTS>
      </xsl:if>
      <xsl:variable name=""var:v12"" select=""ScriptNS0:QualifyReasonCode(string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUS/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFM_REASON/text()))"" />
      <xsl:variable name=""var:v15"" select=""ScriptNS0:MaximoStatusNote($var:v13 , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:STATUSDATE/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:WONUM/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFMCLIENTREF/text()) , $var:v14 , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:SCHEDSTART/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:SCHEDFINISH/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTSTART/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTFINISH/text()) , string(s0:MTFMWODETAILSet/s0:WORKORDER/s0:NP_STATUSMEMO/text()) , string($var:v12))"" />
      <WI_StatusNote>
        <xsl:value-of select=""$var:v15"" />
      </WI_StatusNote>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WOPRIORITY"">
        <WI_Priority>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:WOPRIORITY/text()"" />
        </WI_Priority>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:TARGSTARTDATE"">
        <WI_KpiAttendTs>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:TARGSTARTDATE/text()"" />
        </WI_KpiAttendTs>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:TARGCOMPDATE"">
        <WI_KpiCompleteTs>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:TARGCOMPDATE/text()"" />
        </WI_KpiCompleteTs>
      </xsl:if>
      <xsl:if test=""string($var:v17)='true'"">
        <xsl:variable name=""var:v18"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTSTART/text()"" />
        <WI_ActualAttendTs>
          <xsl:value-of select=""$var:v18"" />
        </WI_ActualAttendTs>
      </xsl:if>
      <xsl:if test=""string($var:v20)='true'"">
        <xsl:variable name=""var:v21"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:ACTFINISH/text()"" />
        <WI_ActualCompleteTs>
          <xsl:value-of select=""$var:v21"" />
        </WI_ActualCompleteTs>
      </xsl:if>
      <xsl:if test=""string($var:v24)='true'"">
        <xsl:variable name=""var:v25"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:ASSET/s0:TEMPLATEID/text()"" />
        <Meta_RF01>
          <xsl:value-of select=""$var:v25"" />
        </Meta_RF01>
      </xsl:if>
      <xsl:if test=""string($var:v26)='true'"">
        <xsl:variable name=""var:v27"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:MTFM_REASON/text()"" />
        <Meta_RF01>
          <xsl:value-of select=""$var:v27"" />
        </Meta_RF01>
      </xsl:if>
      <xsl:if test=""string($var:v30)='true'"">
        <xsl:variable name=""var:v31"" select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:ASSET/s0:DESCRIPTION/text()"" />
        <Meta_RF02>
          <xsl:value-of select=""$var:v31"" />
        </Meta_RF02>
      </xsl:if>
      <Meta_RF03>
        <xsl:value-of select=""$var:v32"" />
      </Meta_RF03>
      <Meta_RF09>
        <xsl:text>4793</xsl:text>
      </Meta_RF09>
      <Meta_RF10>
        <xsl:text>19009</xsl:text>
      </Meta_RF10>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PMDUEDATE"">
        <Meta_RF11>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PMDUEDATE/text()"" />
        </Meta_RF11>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PMNEXTDUEDATE"">
        <Meta_RF12>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:PMNEXTDUEDATE/text()"" />
        </Meta_RF12>
      </xsl:if>
      <xsl:if test=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:DESCRIPTION"">
        <Meta_RF21>
          <xsl:value-of select=""s0:MTFMWODETAILSet/s0:WORKORDER/s0:DESCRIPTION/text()"" />
        </Meta_RF21>
      </xsl:if>
      <WI_ServiceNotes>
        <xsl:for-each select=""s0:MTFMWODETAILSet/s0:WORKORDER"">
          <xsl:for-each select=""s0:WORKLOG"">
            <WI_Note>
              <xsl:if test=""s0:WORKLOGID"">
                <WI_Noteid>
                  <xsl:value-of select=""s0:WORKLOGID/text()"" />
                </WI_Noteid>
              </xsl:if>
              <xsl:variable name=""var:v33"" select=""userCSharp:CleanNilString(string(s0:DESCRIPTION_LONGDESCRIPTION/text()))"" />
              <xsl:variable name=""var:v34"" select=""ScriptNS0:MaximoWorkLogNote(string(s0:DESCRIPTION/text()) , string($var:v33) , string(s0:LOGTYPE/text()) , string(s0:MODIFYBY/text()) , string(s0:MODIFYDATE/text()) , string(s0:WORKLOGID/text()))"" />
              <WI_NoteText>
                <xsl:value-of select=""$var:v34"" />
              </WI_NoteText>
              <xsl:if test=""s0:CREATEBY"">
                <WI_CreatedBy>
                  <xsl:value-of select=""s0:CREATEBY/text()"" />
                </WI_CreatedBy>
              </xsl:if>
              <xsl:if test=""s0:CREATEDATE"">
                <WI_NoteTS>
                  <xsl:value-of select=""s0:CREATEDATE/text()"" />
                </WI_NoteTS>
              </xsl:if>
              <xsl:if test=""s0:CLIENTVIEWABLE"">
                <WI_ClientViewable>
                  <xsl:value-of select=""s0:CLIENTVIEWABLE/text()"" />
                </WI_ClientViewable>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </WI_Note>
          </xsl:for-each>
        </xsl:for-each>
      </WI_ServiceNotes>
      <WI_MitigationNotes>
        <xsl:for-each select=""s0:MTFMWODETAILSet/s0:WORKORDER"">
          <xsl:for-each select=""s0:MTFM_WOMITEVS"">
            <xsl:variable name=""var:v35"" select=""userCSharp:StringConcat(string(s0:MITEVT/text()) , &quot;, &quot; , string(s0:NOTES/text()) , &quot;, &quot; , string(s0:NOTES_LONGDESCRIPTION/text()))"" />
            <xsl:variable name=""var:v36"" select=""userCSharp:LogicalExistence(boolean(.))"" />
            <xsl:variable name=""var:v38"" select=""boolean(.)"" />
            <xsl:variable name=""var:v39"" select=""userCSharp:LogicalExistence($var:v38)"" />
            <WI_MitEvnt>
              <xsl:if test=""s0:MTFM_WOMITEVSID"">
                <WI_Noteid>
                  <xsl:value-of select=""s0:MTFM_WOMITEVSID/text()"" />
                </WI_Noteid>
              </xsl:if>
              <WI_NoteText>
                <xsl:value-of select=""$var:v35"" />
              </WI_NoteText>
              <xsl:if test=""string($var:v36)='true'"">
                <xsl:variable name=""var:v37"" select=""userCSharp:StringConcat(&quot;MITIGATE&quot;)"" />
                <WI_CreatedBy>
                  <xsl:value-of select=""$var:v37"" />
                </WI_CreatedBy>
              </xsl:if>
              <xsl:if test=""s0:EVTDATE"">
                <WI_NoteTS>
                  <xsl:value-of select=""s0:EVTDATE/text()"" />
                </WI_NoteTS>
              </xsl:if>
              <xsl:if test=""string($var:v39)='true'"">
                <xsl:variable name=""var:v40"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
                <WI_Mitigation>
                  <xsl:value-of select=""$var:v40"" />
                </WI_Mitigation>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </WI_MitEvnt>
          </xsl:for-each>
        </xsl:for-each>
      </WI_MitigationNotes>
    </ns0:MFMWorkItemUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0)
{
   return param0;
}


public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public string StringConcat(string param0, string param1, string param2, string param3, string param4)
{
   return param0 + param1 + param2 + param3 + param4;
}


public bool LogicalExistence(bool val)
{
	return val;
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


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
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


public bool LogicalAnd(string param0, string param1)
{
	return ValToBool(param0) && ValToBool(param1);
	return false;
}


        public string CleanNilString(string note)
        {
            if (String.IsNullOrEmpty(note))
            {
                return """";
            }
            else
            {
                return note;
            }
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWODETAILService+PublishMTFMWODETAIL";
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
