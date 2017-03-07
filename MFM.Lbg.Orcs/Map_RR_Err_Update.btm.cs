namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse", typeof(global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER", typeof(global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE", typeof(global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE))]
    public sealed class Map_RR_Err_Update : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://www.ibm.com/maximo"" xmlns:s0=""http://MFM.Lbg.Schemas.MiamiWsQueryLoc"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns0:UpdateRRMIAMIWOUPDATE>
      <ns0:RRMIAMIWOUPDATESet>
        <xsl:for-each select=""InputMessagePart_1/ns0:PublishRRMIAMIWORKORDER/ns0:RRMIAMIWORKORDERSet/ns0:WORKORDER"">
          <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
          <ns0:WORKORDER>
            <xsl:attribute name=""action"">
              <xsl:text>Change</xsl:text>
            </xsl:attribute>
            <xsl:for-each select=""ns0:SITEID"">
              <ns0:SITEID>
                <xsl:value-of select=""./text()"" />
              </ns0:SITEID>
            </xsl:for-each>
            <xsl:for-each select=""ns0:WONUM"">
              <ns0:WONUM>
                <xsl:value-of select=""./text()"" />
              </ns0:WONUM>
            </xsl:for-each>
            <ns0:WORKLOG>
              <ns0:CLASS>
                <xsl:text>WORKORDER</xsl:text>
              </ns0:CLASS>
              <ns0:CREATEBY>
                <xsl:variable name=""var:v1"" select=""ScriptNS0:RrAdminUser()"" />
                <xsl:value-of select=""$var:v1"" />
              </ns0:CREATEBY>
              <ns0:CREATEDATE>
                <xsl:value-of select=""$var:v2"" />
              </ns0:CREATEDATE>
              <ns0:DESCRIPTION>
                <xsl:text>Location Rejected</xsl:text>
              </ns0:DESCRIPTION>
              <xsl:for-each select=""ns0:LOCATIONS"">
                <ns0:DESCRIPTION_LONGDESCRIPTION>
                  <xsl:for-each select=""ns0:LOCATION"">
                    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalExistence(boolean(../ns0:MTFMBLDGCLASS1))"" />
                    <xsl:if test=""string($var:v3)='true'"">
                      <xsl:variable name=""var:v4"" select=""../ns0:MTFMBLDGCLASS1/text()"" />
                      <xsl:variable name=""var:v5"" select=""userCSharp:LogicalExistence(boolean(../ns0:MTFMBLDGCLASS2))"" />
                      <xsl:if test=""string($var:v5)='true'"">
                        <xsl:variable name=""var:v6"" select=""../ns0:MTFMBLDGCLASS2/text()"" />
                        <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(string(./text()) , &quot; ERROR: The MTFM Building classes have been rejected by MIAMI. &quot; , &quot;MTFMBLDGCLASS1: &quot; , string($var:v4) , &quot;. MTFMBLDGCLASS2: &quot; , string($var:v6) , &quot;. (ERROR - &quot; , string(../../../../../../InputMessagePart_0/s0:MiamiWsQueryLocResponse/Fault/FaultString/text()) , &quot;)&quot;)"" />
                        <xsl:value-of select=""$var:v7"" />
                      </xsl:if>
                    </xsl:if>
                  </xsl:for-each>
                </ns0:DESCRIPTION_LONGDESCRIPTION>
              </xsl:for-each>
              <ns0:LOGTYPE>
                <xsl:text>CLIENTNOTE</xsl:text>
              </ns0:LOGTYPE>
              <ns0:MODIFYBY>
                <xsl:variable name=""var:v8"" select=""ScriptNS0:RrAdminUser()"" />
                <xsl:value-of select=""$var:v8"" />
              </ns0:MODIFYBY>
              <ns0:MODIFYDATE>
                <xsl:value-of select=""$var:v2"" />
              </ns0:MODIFYDATE>
              <xsl:for-each select=""ns0:WONUM"">
                <ns0:RECORDKEY>
                  <xsl:value-of select=""./text()"" />
                </ns0:RECORDKEY>
              </xsl:for-each>
            </ns0:WORKLOG>
            <xsl:value-of select=""./text()"" />
          </ns0:WORKORDER>
        </xsl:for-each>
      </ns0:RRMIAMIWOUPDATESet>
    </ns0:UpdateRRMIAMIWOUPDATE>
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


public string StringConcat(string param0, string param1, string param2, string param3, string param4, string param5, string param6, string param7, string param8)
{
   return param0 + param1 + param2 + param3 + param4 + param5 + param6 + param7 + param8;
}


public bool LogicalExistence(bool val)
{
	return val;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""MFM.Lbg.Helper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=b52a4a519c43e251"" ClassName=""MFM.Lbg.Helper.Misc"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse";
        
        private const global::MFM.Lbg.Schemas.MiamiWsQueryLoc.MiamiWsQueryLocResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
        
        private const global::MTFM.Maximo.RR.RRMIAMIWORKORDERService.PublishRRMIAMIWORKORDER _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
        
        private const global::MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo.UpdateRRMIAMIWOUPDATE _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MiamiWsQueryLoc+MiamiWsQueryLocResponse";
                _SrcSchemas[1] = @"MTFM.Maximo.RR.RRMIAMIWORKORDERService+PublishRRMIAMIWORKORDER";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MTFM.Maximo.RR.RRMIAMI_RRMIAMIWOUPDATEIFACE_www_ibm_com_maximo+UpdateRRMIAMIWOUPDATE";
                return _TrgSchemas;
            }
        }
    }
}
