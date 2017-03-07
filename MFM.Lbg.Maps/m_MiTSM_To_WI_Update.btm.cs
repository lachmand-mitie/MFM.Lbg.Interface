namespace MFM.Lbg.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiTsmAlert", typeof(global::MFM.Lbg.Schemas.MiTsmAlert))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    public sealed class m_MiTSM_To_WI_Update : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:s0=""http://MFM.Lbg.Schemas.MiTsmAlert"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MiTsmAlert"" />
  </xsl:template>
  <xsl:template match=""/s0:MiTsmAlert"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;MiTSM&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;-1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;RW&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;Completed&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;LBG&quot;)"" />
    <ns0:MFMWorkItemUpdate>
      <SourceSystem>
        <xsl:value-of select=""$var:v1"" />
      </SourceSystem>
      <SourceSystemMessageId>
        <xsl:value-of select=""$var:v2"" />
      </SourceSystemMessageId>
      <SourceSystemMessageTs>
        <xsl:value-of select=""$var:v3"" />
      </SourceSystemMessageTs>
      <BizTalkMessageId>
        <xsl:value-of select=""$var:v4"" />
      </BizTalkMessageId>
      <BizTalkMessageTs>
        <xsl:value-of select=""$var:v3"" />
      </BizTalkMessageTs>
      <WI_WorkType>
        <xsl:value-of select=""$var:v5"" />
      </WI_WorkType>
      <WI_UpdateTs>
        <xsl:value-of select=""MiTsmAlert_Child20/cts/text()"" />
      </WI_UpdateTs>
      <WI_SourceRef>
        <xsl:value-of select=""MiTsmAlert_Child5/in/text()"" />
      </WI_SourceRef>
      <WI_LocationLevel1>
        <xsl:value-of select=""MiTsmAlert_Child2/sc/text()"" />
      </WI_LocationLevel1>
      <WI_LocationLevel2>
        <xsl:value-of select=""MiTsmAlert_Child3/sn/text()"" />
      </WI_LocationLevel2>
      <WI_LocationLevel3>
        <xsl:value-of select=""MiTsmAlert_Child4/csr/text()"" />
      </WI_LocationLevel3>
      <WI_Status>
        <xsl:value-of select=""$var:v6"" />
      </WI_Status>
      <WI_StatusChangeTS>
        <xsl:value-of select=""MiTsmAlert_Child20/cts/text()"" />
      </WI_StatusChangeTS>
      <WI_StatusNote>
        <xsl:value-of select=""MiTsmAlert_Child12/idesc/text()"" />
      </WI_StatusNote>
      <WI_Priority>
        <xsl:text>P1</xsl:text>
      </WI_Priority>
      <WI_KpiAttendTs>
        <xsl:value-of select=""MiTsmAlert_Child8/rts/text()"" />
      </WI_KpiAttendTs>
      <WI_KpiCompleteTs>
        <xsl:value-of select=""MiTsmAlert_Child20/cts/text()"" />
      </WI_KpiCompleteTs>
      <WI_ActualAttendTs>
        <xsl:value-of select=""MiTsmAlert_Child8/rts/text()"" />
      </WI_ActualAttendTs>
      <WI_ActualCompleteTs>
        <xsl:value-of select=""MiTsmAlert_Child20/cts/text()"" />
      </WI_ActualCompleteTs>
      <Meta_RF03>
        <xsl:value-of select=""$var:v7"" />
      </Meta_RF03>
      <Meta_RF09>
        <xsl:text>4793</xsl:text>
      </Meta_RF09>
      <Meta_RF10>
        <xsl:text>19012</xsl:text>
      </Meta_RF10>
      <WI_ServiceNotes>
        <xsl:for-each select=""MiTsmAlert_Child14/Description"">
          <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;-1&quot;)"" />
          <WI_Note>
            <WI_Noteid>
              <xsl:value-of select=""$var:v8"" />
            </WI_Noteid>
            <WI_NoteText>
              <xsl:value-of select=""./text()"" />
            </WI_NoteText>
            <WI_CreatedBy>
              <xsl:value-of select=""../../MiTsmAlert_Child9/rby/text()"" />
            </WI_CreatedBy>
            <WI_NoteTS>
              <xsl:value-of select=""../../MiTsmAlert_Child20/cts/text()"" />
            </WI_NoteTS>
            <WI_ClientViewable>
              <xsl:text>0</xsl:text>
            </WI_ClientViewable>
          </WI_Note>
        </xsl:for-each>
      </WI_ServiceNotes>
    </ns0:MFMWorkItemUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MiTsmAlert";
        
        private const global::MFM.Lbg.Schemas.MiTsmAlert _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MiTsmAlert";
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
