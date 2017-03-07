namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MTFMWOLOGSService+PublishMTFMWOLOGS", typeof(global::MFM.Lbg.Schemas.MTFMWOLOGSService.PublishMTFMWOLOGS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MFMWorkItemUpdate", typeof(global::MFM.Lbg.Schemas.MFMWorkItemUpdate))]
    public sealed class x_WL_to_WIUpd : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.MFMWorkItemUpdate"" xmlns:s0=""http://www.ibm.com/maximo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PublishMTFMWOLOGS"" />
  </xsl:template>
  <xsl:template match=""/s0:PublishMTFMWOLOGS"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v4"" select=""string(s0:MTFMWOLOGSSet/s0:WORKLOG/s0:DESCRIPTION_LONGDESCRIPTION/text())"" />
    <ns0:MFMWorkItemUpdate>
      <SourceSystem>
        <xsl:text>TFMMXO75</xsl:text>
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
        <xsl:text>1</xsl:text>
      </BizTalkMessageId>
      <BizTalkMessageTs>
        <xsl:value-of select=""$var:v1"" />
      </BizTalkMessageTs>
      <WI_WorkType>
        <xsl:value-of select=""$var:v2"" />
      </WI_WorkType>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:MODIFYDATE"">
        <WI_UpdateTs>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:MODIFYDATE/text()"" />
        </WI_UpdateTs>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKORDER/s0:WONUM"">
        <WI_SourceRef>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKORDER/s0:WONUM/text()"" />
        </WI_SourceRef>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKORDER/s0:MTFMCLIENTREF"">
        <WI_DestinationRef>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKORDER/s0:MTFMCLIENTREF/text()"" />
        </WI_DestinationRef>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:LOGTYPE"">
        <WI_LocationLevel4>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:LOGTYPE/text()"" />
        </WI_LocationLevel4>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:MODIFYDATE"">
        <WI_StatusChangeTS>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:MODIFYDATE/text()"" />
        </WI_StatusChangeTS>
      </xsl:if>
      <xsl:variable name=""var:v3"" select=""ScriptNS0:StripFormatting(string(s0:MTFMWOLOGSSet/s0:WORKLOG/s0:DESCRIPTION_LONGDESCRIPTION/text()))"" />
      <WI_StatusNote>
        <xsl:value-of select=""$var:v3"" />
      </WI_StatusNote>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:DESCRIPTION"">
        <Meta_RF01>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:DESCRIPTION/text()"" />
        </Meta_RF01>
      </xsl:if>
      <xsl:variable name=""var:v5"" select=""ScriptNS0:StripFormatting($var:v4)"" />
      <Meta_RF02>
        <xsl:value-of select=""$var:v5"" />
      </Meta_RF02>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:CREATEBY"">
        <Meta_RF03>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:CREATEBY/text()"" />
        </Meta_RF03>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:CLIENTVIEWABLE"">
        <Meta_RF04>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:CLIENTVIEWABLE/text()"" />
        </Meta_RF04>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKORDER/s0:STATUS"">
        <Meta_RF05>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKORDER/s0:STATUS/text()"" />
        </Meta_RF05>
      </xsl:if>
      <xsl:if test=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKLOGID"">
        <Meta_RF06>
          <xsl:value-of select=""s0:MTFMWOLOGSSet/s0:WORKLOG/s0:WORKLOGID/text()"" />
        </Meta_RF06>
      </xsl:if>
      <xsl:value-of select=""./text()"" />
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



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MTFMWOLOGSService+PublishMTFMWOLOGS";
        
        private const global::MFM.Lbg.Schemas.MTFMWOLOGSService.PublishMTFMWOLOGS _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MTFMWOLOGSService+PublishMTFMWOLOGS";
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
