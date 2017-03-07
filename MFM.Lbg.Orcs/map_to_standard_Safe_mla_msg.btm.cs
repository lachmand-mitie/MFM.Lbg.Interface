namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0", typeof(global::MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.SAFE_Update_Message", typeof(global::MFM.Lbg.Schemas.SAFE_Update_Message))]
    public sealed class map_to_standard_Safe_mla_msg : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:ns0=""http://MFM.Lbg.Schemas.SAFE_Update_Message/1/0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/biz_Poll_Visit_Updates_MPC"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TypedPollingResultSet0"" />
  </xsl:template>
  <xsl:template match=""/s0:TypedPollingResultSet0"">
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalEq(string(s0:Callout/text()) , &quot;1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;Callout&quot;)"" />
    <ns0:SafeUpdate>
      <xsl:if test=""s0:VisitId"">
        <VisitId>
          <xsl:value-of select=""s0:VisitId/text()"" />
        </VisitId>
      </xsl:if>
      <xsl:if test=""s0:CustomerReference"">
        <CustomerReference>
          <xsl:value-of select=""s0:CustomerReference/text()"" />
        </CustomerReference>
      </xsl:if>
      <xsl:if test=""s0:ServiceTypeRef"">
        <ServiceType>
          <xsl:value-of select=""s0:ServiceTypeRef/text()"" />
        </ServiceType>
      </xsl:if>
      <VisitStatus>
        <xsl:value-of select=""s0:VisitTypeDesc/text()"" />
      </VisitStatus>
      <xsl:if test=""s0:Deleted"">
        <Deleted>
          <xsl:value-of select=""s0:Deleted/text()"" />
        </Deleted>
      </xsl:if>
      <xsl:if test=""s0:DateServiceStart"">
        <DateServiceStart>
          <xsl:value-of select=""s0:DateServiceStart/text()"" />
        </DateServiceStart>
      </xsl:if>
      <xsl:if test=""s0:DateServiceEnd"">
        <DateServiceEnd>
          <xsl:value-of select=""s0:DateServiceEnd/text()"" />
        </DateServiceEnd>
      </xsl:if>
      <xsl:variable name=""var:v1"" select=""ScriptNS0:SafeMessageNoteClassA(string(s0:VisitId/text()) , string(s0:Address1/text()) , string(s0:Address2/text()) , string(s0:Address3/text()) , string(s0:Postcode/text()) , string(s0:VisitTypeRef/text()) , string(s0:VisitTypeDesc/text()) , string(s0:CustomerReference/text()) , string(s0:CallOutDetails/text()) , string(s0:PostCallOutDetails/text()) , string(s0:Urgent/text()) , string(s0:Deleted/text()))"" />
      <Note>
        <xsl:value-of select=""$var:v1"" />
      </Note>
      <ClientViewable>
        <xsl:text>0</xsl:text>
      </ClientViewable>
      <Customer>
        <xsl:text>LBG</xsl:text>
      </Customer>
      <Business>
        <xsl:text>MLA</xsl:text>
      </Business>
      <xsl:if test=""string($var:v2)='true'"">
        <xsl:variable name=""var:v4"" select=""string($var:v3)"" />
        <WorkType>
          <xsl:value-of select=""$var:v4"" />
        </WorkType>
      </xsl:if>
      <xsl:if test=""s0:OutboundId"">
        <OutboundUpdId>
          <xsl:value-of select=""s0:OutboundId/text()"" />
        </OutboundUpdId>
      </xsl:if>
      <xsl:if test=""s0:OutboundTs"">
        <OutboundUpdTs>
          <xsl:value-of select=""s0:OutboundTs/text()"" />
        </OutboundUpdTs>
      </xsl:if>
      <xsl:if test=""s0:DateLastModified"">
        <LastModifiedTs>
          <xsl:value-of select=""s0:DateLastModified/text()"" />
        </LastModifiedTs>
      </xsl:if>
      <xsl:if test=""s0:DateCalledIn"">
        <DateCalledIn>
          <xsl:value-of select=""s0:DateCalledIn/text()"" />
        </DateCalledIn>
      </xsl:if>
      <xsl:if test=""s0:DateConfirmed"">
        <DateConfirmed>
          <xsl:value-of select=""s0:DateConfirmed/text()"" />
        </DateConfirmed>
      </xsl:if>
    </ns0:SafeUpdate>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0";
        
        private const global::MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.SAFEUPDPOLLTypedPolling_biz_Poll_Visit_Updates_MPC+TypedPollingResultSet0";
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
