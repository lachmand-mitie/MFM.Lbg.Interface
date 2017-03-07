namespace MFM.Lbg.Orcs {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MFM.Lbg.Schemas.MSSWebServiceAlertEmail", typeof(global::MFM.Lbg.Schemas.MSSWebServiceAlertEmail))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"MSS.Notification.Service.MSSNotifyEmail", typeof(global::MSS.Notification.Service.MSSNotifyEmail))]
    public sealed class LegacyWsEmail_To_NotifyEMaiHtml : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp ScriptNS0"" version=""1.0"" xmlns:s0=""http://MFM.Lbg.Schemas.WebServiceAlertEmail"" xmlns:ns0=""http://MSS.Notification.Service.NotifyEmail/v1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MSSWebServiceAlertEmail"" />
  </xsl:template>
  <xsl:template match=""/s0:MSSWebServiceAlertEmail"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;DISTSENT&quot;)"" />
    <ns0:MSSNotifyEmail>
      <ApplicationName>
        <xsl:text>MFM.Helpdesk.Distributor</xsl:text>
      </ApplicationName>
      <CreatedTs>
        <xsl:value-of select=""$var:v1"" />
      </CreatedTs>
      <SmtpHost>
        <xsl:text>mailrelay.mitie.com</xsl:text>
      </SmtpHost>
      <SmtpPort>
        <xsl:text>25</xsl:text>
      </SmtpPort>
      <Retry>
        <xsl:text>20</xsl:text>
      </Retry>
      <EmailMetaData>
        <To>
          <xsl:value-of select=""To/text()"" />
        </To>
        <From>
          <xsl:text>no.reply@mitie.com</xsl:text>
        </From>
        <Subject>
          <xsl:value-of select=""Subject/text()"" />
        </Subject>
        <HighImportance>
          <xsl:text>false</xsl:text>
        </HighImportance>
      </EmailMetaData>
      <EmailContentData>
        <BodyType>
          <xsl:text>html</xsl:text>
        </BodyType>
        <Transform>
          <xsl:text>true</xsl:text>
        </Transform>
        <xsl:variable name=""var:v3"" select=""ScriptNS0:XslPath(string($var:v2))"" />
        <PathToTransform>
          <xsl:value-of select=""$var:v3"" />
        </PathToTransform>
        <BodyEncoding>
          <xsl:text>UTF8</xsl:text>
        </BodyEncoding>
        <BodyNonRecurring>
          <P1>
            <xsl:value-of select=""BodyText/text()"" />
          </P1>
          <xsl:if test=""BodyTextPayload"">
            <P2>
              <xsl:value-of select=""BodyTextPayload/text()"" />
            </P2>
          </xsl:if>
        </BodyNonRecurring>
      </EmailContentData>
      <ErrorHandle>
        <SuspendTs>
          <xsl:value-of select=""$var:v1"" />
        </SuspendTs>
        <EmailDidError>
          <xsl:text>0</xsl:text>
        </EmailDidError>
      </ErrorHandle>
    </ns0:MSSNotifyEmail>
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
        
        private const string _strSrcSchemasList0 = @"MFM.Lbg.Schemas.MSSWebServiceAlertEmail";
        
        private const global::MFM.Lbg.Schemas.MSSWebServiceAlertEmail _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"MSS.Notification.Service.MSSNotifyEmail";
        
        private const global::MSS.Notification.Service.MSSNotifyEmail _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"MFM.Lbg.Schemas.MSSWebServiceAlertEmail";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"MSS.Notification.Service.MSSNotifyEmail";
                return _TrgSchemas;
            }
        }
    }
}
